#pragma checksum "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "867c8daee83c569849e8aa0383b14e377de0bbf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BankManagementSystem.Web.Views.Assets.Views_Assets_Index), @"mvc.1.0.view", @"/Views/Assets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Assets/Index.cshtml", typeof(BankManagementSystem.Web.Views.Assets.Views_Assets_Index))]
namespace BankManagementSystem.Web.Views.Assets
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Web;

#line default
#line hidden
#line 2 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Models;

#line default
#line hidden
#line 3 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Common.Constants;

#line default
#line hidden
#line 4 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Common.BindingModels.CreditCard;

#line default
#line hidden
#line 5 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Common.ViewModels.CreditCard;

#line default
#line hidden
#line 6 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\_ViewImports.cshtml"
using BankManagementSystem.Common.ViewModels.Asset;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"867c8daee83c569849e8aa0383b14e377de0bbf6", @"/Views/Assets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd6a4f4ce6c4c0dbfb80c717241e242af923fc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Assets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AssetViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Assets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
  
    ViewData["Title"] = "Assets For Sale";

#line default
#line hidden
            BeginContext(89, 35, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>");
            EndContext();
            BeginContext(125, 17, false);
#line 8 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(142, 32, true);
            WriteLiteral("</h1>\r\n    <hr class=\"hr-2\" />\r\n");
            EndContext();
#line 10 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
            BeginContext(210, 379, true);
            WriteLiteral(@"        <table class=""table table-hover table-striped table-bordered"">
            <thead>
                <tr>
                    <th>Created On</th>
                    <th>Name</th>
                    <th>Category</th>
                    <th>Monetary Value</th>
                    <th>Actions</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 23 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
                 foreach (var asset in Model)
                {

#line default
#line hidden
            BeginContext(655, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(710, 15, false);
#line 26 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
                       Write(asset.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(725, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(761, 10, false);
#line 27 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
                       Write(asset.Name);

#line default
#line hidden
            EndContext();
            BeginContext(771, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(807, 19, false);
#line 28 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
                       Write(asset.AssetCategory);

#line default
#line hidden
            EndContext();
            BeginContext(826, 36, true);
            WriteLiteral("</td>\r\n                        <td>$");
            EndContext();
            BeginContext(863, 19, false);
#line 29 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
                        Write(asset.MonetaryValue);

#line default
#line hidden
            EndContext();
            BeginContext(882, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(947, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "867c8daee83c569849e8aa0383b14e377de0bbf68428", async() => {
                BeginContext(1021, 113, true);
                WriteLiteral("\r\n                                <button class=\"btn btn-warning\">Purchase</button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
                                                       WriteLiteral(asset.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1138, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 36 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1217, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 39 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1281, 127, true);
            WriteLiteral("        <h4><i>There are no credit assets registered yet. Consider using administrator credentials to create assets.</i></h4>\r\n");
            EndContext();
#line 43 "C:\Users\panka\Downloads\BankManagementSystem-master\BankManagementSystem-master\src\Web\Views\Assets\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1415, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AssetViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
