#pragma checksum "C:\Users\Ibrahim\Source\Repos\FinalPro\LimakAz\Views\Payment\Page1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df56e81b8e0012db5498b1e2cb254043036c3b5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Page1), @"mvc.1.0.view", @"/Views/Payment/Page1.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ibrahim\Source\Repos\FinalPro\LimakAz\Views\_ViewImports.cshtml"
using LimakAz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ibrahim\Source\Repos\FinalPro\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ibrahim\Source\Repos\FinalPro\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ibrahim\Source\Repos\FinalPro\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.Models.Settings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df56e81b8e0012db5498b1e2cb254043036c3b5f", @"/Views/Payment/Page1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193bdce69418faf7fc4d341454722a3f16e70f8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Page1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formInputAmt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://js.stripe.com/v3/""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"">

<style>
    #donate_label {
        color: black;
    }

    .payment {
        padding: 10px 20px;
    }

    .terms {
        padding: 10px 0;
        background: #bfbfbf;
        text-align: center;
    }

    #inputAmt {
        border: 1px solid #1E90FF;
        border-radius: 5px;
        height: 35px;
        width: 70%;
        font-size: 16px !important;
    }

    .flex-container {
        display: flex;
        flex-wrap: wrap;
        justify-content: center;
    }

    ._topFlexDiv {
        width: 16%;
        margin: 10px;
        text-align: center;
        font-size: 16px;
    }

    .amt-btn {
        height: 35px;
        font-size: 16px !important;
    }

    #btn {
        height: 45px;
        width: 5");
            WriteLiteral(@"0%;
        align-items: center;
        font-size: 16px !important;
    }

    ._bottomFlexDiv1 {
        width: 100%;
        /*justify-content: flex-end !important;*/
        margin-top: 15px
    }

    ._bottomFlexDiv2 {
        width: 50%;
        margin-top: 10px
    }

    #_print_buttton {
        height: 50px;
        width: 15%;
        color: white !important;
        background-color: #bfbfbf;
        align-items: center;
        font-size: 18px;
        padding-top: 10px;
    }

    ");
            WriteLiteral("@media only screen and (max-width: 995px) {\r\n        #btn {\r\n            height: 60px !important;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@media only screen and (max-width: 676px) {
        ._topFlexDiv {
            width: 40%;
        }

        ._bottomFlexDiv1 {
            width: 100%;
            margin-top: 15px
        }

        ._bottomFlexDiv2 {
            width: 100%;
            margin-top: 10px
        }

        #_print_buttton {
            width: 40%;
        }

        #btn {
            height: 60px !important;
        }
    }

    ");
            WriteLiteral(@"@media only screen and (max-width: 480px) {
        ._topFlexDiv {
            width: 40%;
        }

        ._bottomFlexDiv1 {
            width: 100%;
            margin-top: 10px;
            justify-content: center !important;
        }

        ._bottomFlexDiv2 {
            width: 100%;
            margin-top: 10px;
            justify-content: center !important;
        }

        #_print_buttton {
            width: 40%;
        }

        #btn {
            height: 60px !important;
        }
    }
</style>
<div class=""payment"">
    <div class=""flex-container"">
        <div class=""_topFlexDiv"">
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""10"">$10</button>
        </div>
        <div class=""_topFlexDiv"">
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""20"">$20</button>
        </div>
        <div class=""_topFlexDiv"">
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""50"">$50</button>
        </di");
            WriteLiteral(@"v>
        <div class=""_topFlexDiv"">
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""100"">$100</button>
        </div>
        <div class=""_topFlexDiv"">
            <button class=""btn btn-primary btn-block amt-btn btn250"" data-val=""250"">$250</button>
        </div>
        <div class=""_topFlexDiv"">
            <button class=""btn btn-primary btn-block amt-btn btn500"" data-val=""500"">$500</button>
        </div>
        <div class=""_topFlexDiv"">
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""1000"">$1000</button>
        </div>
        <div class=""_topFlexDiv"">
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""2500"">$2500</button>
        </div>
        <div class=""_topFlexDiv"">
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""5000"">$5000</button>
        </div>
        <div class=""_topFlexDiv"">
            <button class=""btn btn-primary btn-block amt-btn"" data-val=""0"">Other</button>
        </div>
");
            WriteLiteral("    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df56e81b8e0012db5498b1e2cb254043036c3b5f8722", async() => {
                WriteLiteral(@"
        <div class=""form-group form-inline justify-content-center _bottomFlexDiv1"">
            <label for=""inputAmt"" id=""donate_label"" class=""mr-2"" style=""color:black"">$</label>
            <input type=""text"" class=""form-control border-primary text-center"" id=""inputAmt"" name=""inputAmt"" required>
        </div>
        <div class=""form-group form-inline justify-content-center _bottomFlexDiv2"">
            <button id=""btn"" class=""btn btn-primary btn-lg"">Tax Exempt Donation</button>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<script>
    const pkey = ""pk_live_3tcT7zDsmUMaZi4NUxGrHtnk"";
    const base_url = ""https://stripeserv.azurewebsites.net/create-checkout"";
    var payload = {
        val: 5000
    };
    $("".amt-btn"").on(""click"", function () {
        var value = this.dataset.val;
        //var value = parseFloat(this.dataset.val).toFixed(2);
        if (value) {
            $(""#inputAmt"").val(value);
        }
        else if (value == ""NaN"" || value == ""undefined"") {
            $(""#inputAmt"").val(0);
        }
        console.log(this.dataset.val);
    });
    $(document).ready(function () {
        $('#formInputAmt').submit(function (e) {
            e.preventDefault();
        })
    });
    var btn = document.getElementById(""btn"");
    btn.addEventListener(""click"", function (e) {
        e.preventDefault();
        var amt = $(""#inputAmt"").val();
        var amtInt = parseInt(amt);
        if (amtInt > 0) {
            var amtInCent = amtInt * 100;
            console.log(amtInCen");
            WriteLiteral("t);\r\n            localStorage.setItem(\'donationAmount\', amtInCent);\r\n        } else {\r\n            alert(\"Please select or input donation amount greater than zero\");\r\n        }\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
