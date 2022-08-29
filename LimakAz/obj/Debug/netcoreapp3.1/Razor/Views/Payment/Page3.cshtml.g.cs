#pragma checksum "C:\Users\Ibrahim\Source\Repos\FinalPro\LimakAz\Views\Payment\Page3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "984108f2712162c43b7dd07c997f0d612774de07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment_Page3), @"mvc.1.0.view", @"/Views/Payment/Page3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"984108f2712162c43b7dd07c997f0d612774de07", @"/Views/Payment/Page3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193bdce69418faf7fc4d341454722a3f16e70f8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment_Page3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<script src=""https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js""></script>
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css"">

<style>
    .payment {
        padding: 10px 20px;
    }

    .terms {
        padding: 10px 0;
        background: #bfbfbf;
        text-align: center;
    }

    .StripeElement {
        box-sizing: border-box;
        height: 40px;
        padding: 10px 12px;
        border: 1px solid transparent;
        border-radius: 4px;
        background-color: white;
        box-shadow: 0 1px 3px 0 #e6ebf1;
        -webkit-transition: box-shadow 150ms ease;
        transition: box-shadow 150ms ease;
    }

    .StripeElement--focus {
        box-shadow: 0 1px 3px 0 #cfd7df;
    }

    .StripeElement--invalid {
        border-color: #fa755a;
    }

    .StripeElement--webkit-autofill {
        background-color: #fefde5 !important;
    }

    .labels {");
            WriteLiteral("\n        color: black;\r\n    }\r\n</style>\r\n\r\n<div class=\"payment\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "984108f2712162c43b7dd07c997f0d612774de075410", async() => {
                WriteLiteral(@"
        <label class=""labels"" for=""card-element"">
            Credit or debit card
        </label>
        <div id=""card-element"">
        </div>
        <div id=""card-errors"" role=""alert""></div>
        <button id=""submit"" class=""btn btn-lg btn-primary pl-4 mt-4"">Donate Now</button>
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
    const token_url = ""https://stripe-checkout.azurewebsites.net/api/stripe/secret"";
    const contact_url = ""https://stripe-checkout.azurewebsites.net/api/activecampaign/create-contact"";
    var stripe = Stripe('pk_test_EOTgC6zr3IXvLP40qI04Vcen');
    var elements = stripe.elements();
    var style = {
        base: {
            color: '#32325d',
            fontFamily: '""Helvetica Neue"", Helvetica, sans-serif',
            fontSmoothing: 'antialiased',
            fontSize: '16px',
            '::placeholder': {
                color: '#aab7c4'
            }
        },
        invalid: {
            color: '#fa755a',
            iconColor: '#fa755a'
        }
    };
    var card = elements.create('card', { style: style });
    card.mount('#card-element');
    card.on('change', function (event) {
        var displayError = document.getElementById('card-errors');
        if (event.error) {
            displayError.textContent = event.error.message;
        } els");
            WriteLiteral(@"e {
            displayError.textContent = '';
        }
    });
    var form = document.getElementById('payment-form');
    var stripeCustomerId = """";
    form.addEventListener('submit', function (ev) {
        ev.preventDefault();
        var amount = localStorage.getItem('donationAmount');
        var email = localStorage.getItem('email');
        var fname = localStorage.getItem('fname');
        var lname = localStorage.getItem('lname');
        var countrySelect = localStorage.getItem('countrySelect');
        var addr1 = localStorage.getItem('addr1');
        var addr2 = localStorage.getItem('addr2');
        var city = localStorage.getItem('city');
        var postalcode = localStorage.getItem('postalcode');
        var phone = localStorage.getItem('phone');
        const data = {
            Amount: amount,
            Email: email,
            FirstName: fname,
            LastName: lname,
            Country: countrySelect,
            Address1: addr1,
            Address2:");
            WriteLiteral(@" addr2,
            City: city,
            PostalCode: postalcode,
            Phone: phone,
            Currency: ""USD""
        };
        console.log(data);

        axios.post(token_url, data)
            .then(responseJson => {
                console.log(responseJson);
                var clientSecret = responseJson.data.clientSecret;
                stripeCustomerId = responseJson.data.customerId;
                stripe.confirmCardPayment(clientSecret, {
                    payment_method: {
                        card: card,
                        billing_details: {
                            name: fname + ' ' + lname
                        }
                    }
                })
                .then(function (result) {
                    console.log(result);
                    if (result.error) {
                        // Show error to your customer (e.g., insufficient funds)
                        console.log(result.error.message);
                    } else {
");
            WriteLiteral(@"                        // The payment has been processed!
                        if (result.paymentIntent.status === 'succeeded') {
                            console.log(""Payment Success!"");
                            data.StripeCustomerId = stripeCustomerId;
                            data.StripePaymentIntent = result.paymentIntent.id;
                            handleClientDetails(data);
                            //redirect to success page!
                        }
                    }
            });
        })
        .catch(function (error) {
            console.log(error);
        })
        .then(function () {
            //localStorage.clear();
        });
    });
    function handleClientDetails(data) {
        console.log(data);
        axios.post(contact_url, data)
            .then(function (response) {
                console.log(response);
            })
            .catch(function (error) {
                console.log(error);
            })
    }
</script>");
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
