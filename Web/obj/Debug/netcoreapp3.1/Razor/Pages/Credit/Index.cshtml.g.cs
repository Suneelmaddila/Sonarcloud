#pragma checksum "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e425afc6771351b49725723cb9910b2a613cf91d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BankManagementSystem.Web.Views.Credit.Pages_Credit_Index), @"mvc.1.0.razor-page", @"/Pages/Credit/Index.cshtml")]
namespace BankManagementSystem.Web.Views.Credit
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
#line 1 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Services.DataServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Web.Pages.Deposit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Common.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Common.BindingModels.Deposit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\_ViewImports.cshtml"
using BankManagementSystem.Common.ViewModels.CreditCard;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e425afc6771351b49725723cb9910b2a613cf91d", @"/Pages/Credit/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1b8b3f4d2a9e0fb4f0098f64f5c926eaffd070", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Credit_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
  
    ViewData["Title"] = "Credits";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>");
#nullable restore
#line 9 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <hr class=\"hr-2\" />\r\n");
#nullable restore
#line 11 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
     if (Model.ViewModels.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-hover table-striped table-bordered"">
            <thead>
                <tr>
                    <th>Financial Resource Amount</th>
                    <th>Payment Period</th>
                    <th>Percent Interest</th>
                    <th>Total Debt</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                 foreach (var credit in Model.ViewModels)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                       Write(credit.FinancialResourceAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                       Write(credit.PaymentPeriod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                       Write(credit.PercentInterest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 30 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                        Write(credit.FinancialResourceAmount * (1 + credit.PercentInterest / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 36 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4><i>You do not have any active credits currently.</i></h4>\r\n");
#nullable restore
#line 40 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Pages\Credit\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankManagementSystem.Web.Pages.Credit.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BankManagementSystem.Web.Pages.Credit.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BankManagementSystem.Web.Pages.Credit.IndexModel>)PageContext?.ViewData;
        public BankManagementSystem.Web.Pages.Credit.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
