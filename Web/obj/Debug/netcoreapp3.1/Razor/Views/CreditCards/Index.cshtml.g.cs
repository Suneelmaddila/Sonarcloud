#pragma checksum "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d76913889e21cd9a96dcc3cabf9c6af189358b47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BankManagementSystem.Web.Views.CreditCards.Views_CreditCards_Index), @"mvc.1.0.view", @"/Views/CreditCards/Index.cshtml")]
namespace BankManagementSystem.Web.Views.CreditCards
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
#line 1 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Common.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Common.BindingModels.CreditCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Common.ViewModels.CreditCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Common.ViewModels.Asset;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d76913889e21cd9a96dcc3cabf9c6af189358b47", @"/Views/CreditCards/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd6a4f4ce6c4c0dbfb80c717241e242af923fc2", @"/Views/_ViewImports.cshtml")]
    public class Views_CreditCards_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CreditCardViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml"
  
    ViewData["Title"] = "Registered Cards";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <hr class=\"hr-2\" />\r\n");
#nullable restore
#line 10 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml"
     if (Model.Count() > 0) { 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-hover table-striped table-bordered"">
            <thead>
                <tr>
                    <th>Number</th>
                    <th>CVV</th>
                    <th>Expiration Date</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 20 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml"
                 foreach (var card in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml"
                       Write(card.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml"
                       Write(card.CVV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml"
                       Write(card.ExpirationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 30 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4><i>There are no credit cards registered yet. Consider registering one yourself.</i></h4>\r\n");
#nullable restore
#line 34 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\CreditCards\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CreditCardViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
