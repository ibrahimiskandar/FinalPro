﻿using DNTCaptcha.Core;
using LimakAz.Models;
using LimakAz.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LimakAz.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IDNTCaptchaValidatorService _validatorService;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext context, RoleManager<IdentityRole> roleManager, IDNTCaptchaValidatorService validatorService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _roleManager = roleManager;
            _validatorService = validatorService;
        }

        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        [HttpPost]

        [ValidateDNTCaptcha(

        ErrorMessage = "Please Enter Valid Captcha",
         CaptchaGeneratorLanguage = Language.English,
          CaptchaGeneratorDisplayMode = DisplayMode.SumOfTwoNumbers)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(MemberRegisterViewModel registerVM)
        {

            AppUser member = await _userManager.FindByNameAsync(registerVM.UserName);
            if (ModelState.IsValid)
            {
                if (!_validatorService.HasRequestValidCaptchaEntry(Language.English, DisplayMode.SumOfTwoNumbers))
                {
                    this.ModelState.AddModelError("DNTCaptchaInputText", "Please Enter Valid Captcha.");
                    return View();
                }
                if (member != null)
                {
                    ModelState.AddModelError("UserName", "İstifadəçi adı hal-hazırda sistemdə mövcuddur");
                    return View();
                }

                member = await _userManager.FindByEmailAsync(registerVM.Email);

                if (member != null)
                {
                    ModelState.AddModelError("Email", "Email hal-hazırda sistemdə mövcuddur");
                    return View();
                }

                member = new AppUser
                {
                    FullName = registerVM.FullName,
                    UserName = registerVM.UserName,
                    Email = registerVM.Email,
                    PhoneNumber = registerVM.PhoneNumber,
                };

                var result = await _userManager.CreateAsync(member, registerVM.Password);

                if (!result.Succeeded)
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                    return View();
                }

                //await _roleManager.CreateAsync(new IdentityRole("Member"));
                await _userManager.AddToRoleAsync(member, "Member");
                await _signInManager.SignInAsync(member, true);

                return RedirectToAction("index", "userpanel");
            }
            return View();

        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(MemberLoginViewModel memberLoginVM)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser member = _userManager.Users.FirstOrDefault(x => x.NormalizedEmail == memberLoginVM.Email.ToUpper() && !x.IsAdmin);
            
            if (member == null)
            {
                ModelState.AddModelError("", "Email və ya şifrə yalnışdır");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(member, memberLoginVM.Password, memberLoginVM.IsPersistent, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email və ya şifrə yalnışdır");
                return View();
            }
            /*
                        AppUser admin = null;

                        admin = _userManager.Users.FirstOrDefault(x => x.NormalizedEmail == memberLoginVM.Email.ToUpper() && x.IsAdmin);

                        if (admin != null)
                        {
                            return RedirectToAction("index", "dashboard", new { area = "AdminPanel" });
                        }
                        else
                        {
                            return RedirectToAction("index", "home");
                        }*/

            return RedirectToAction("index", "home");
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("index", "home");
        }

        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Profile()
        {
            AppUser member = await _userManager.FindByNameAsync(User.Identity.Name);

            if (member == null)
            {
                return RedirectToAction("index", "error");
            }

            ViewBag.WareHouses = _context.WareHouses.ToList();
            ProfileViewModel profileVM = new ProfileViewModel();
            if (member.WareHouseId != null)
            {
                profileVM = new ProfileViewModel
                {
                    FullName = member.FullName,
                    UserName = member.UserName,
                    Email = member.Email,
                    PhoneNumber = member.PhoneNumber,
                    BirthDay = member.BirthDay,
                    WareHouseId = (int)member.WareHouseId
                };
            }
            else
            {
                profileVM = new ProfileViewModel
                {
                    FullName = member.FullName,
                    UserName = member.UserName,
                    Email = member.Email,
                    PhoneNumber = member.PhoneNumber,
                    BirthDay = member.BirthDay,
                };
            }

            return View(profileVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Profile(ProfileViewModel profileVM)
        {
            ViewBag.WareHouses = _context.WareHouses.ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser member = await _userManager.FindByNameAsync(User.Identity.Name);
            if (member == null)
            {
                return RedirectToAction("index", "error");
            }
            if (!string.IsNullOrWhiteSpace(profileVM.ConfirmNewPassword) && !string.IsNullOrWhiteSpace(profileVM.NewPassword))
            {
                var passwordChangeResult = await _userManager.ChangePasswordAsync(member, profileVM.CurrentPassword, profileVM.NewPassword);

                if (!passwordChangeResult.Succeeded)
                {
                    foreach (var item in passwordChangeResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View();
                }

            }
            if (member.UserName != profileVM.UserName && _userManager.Users.Any(x => x.NormalizedUserName == profileVM.UserName.ToUpper()))
            {
                ModelState.AddModelError("UserName", "Bu istifadəçi adı hal-hazırda sistemdə mövcuddur.");
                return View();
            }

            member.FullName = profileVM.FullName;
            member.PhoneNumber = profileVM.PhoneNumber;
            member.BirthDay = profileVM.BirthDay;
            member.WareHouseId = profileVM.WareHouseId;
            member.UserName = profileVM.UserName;

            var result = await _userManager.UpdateAsync(member);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

                return View();
            }

            await _signInManager.SignInAsync(member, true);
            return RedirectToAction("profile", "account");

        }

        [Authorize(Roles = "Member")]
        public async Task<IActionResult> ChangePassword()
        {
            ViewBag.WareHouses = _context.WareHouses.ToList();

            AppUser member = await _userManager.FindByNameAsync(User.Identity.Name);
            ProfileViewModel profileViewModel = new ProfileViewModel();

            return View(profileViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> ChangePassword(ProfileViewModel profileVM)
        {
            ViewBag.WareHouses = _context.WareHouses.ToList();

            if (!ModelState.IsValid) return View();

            AppUser member = await _userManager.FindByNameAsync(User.Identity.Name);

            if (!string.IsNullOrWhiteSpace(profileVM.ConfirmNewPassword) && !string.IsNullOrWhiteSpace(profileVM.NewPassword))
            {
                var passwordChangeResult = await _userManager.ChangePasswordAsync(member, profileVM.CurrentPassword, profileVM.NewPassword);

                if (!passwordChangeResult.Succeeded)
                {
                    foreach (var item in passwordChangeResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View();
                }
            }
            return RedirectToAction("profile", "account");
        }

    }
}
