#pragma checksum "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "816d2a108f0c5729e1f19786525f5e375e8c3767"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_SearchBySupplier), @"mvc.1.0.view", @"/Views/Product/SearchBySupplier.cshtml")]
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
#line 1 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\_ViewImports.cshtml"
using dotnetmvcbasics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\_ViewImports.cshtml"
using dotnetmvcbasics.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"816d2a108f0c5729e1f19786525f5e375e8c3767", @"/Views/Product/SearchBySupplier.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f92d4c9efb7c120e9bfe5b1ad7eb5663098551", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_SearchBySupplier : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<dotnetmvcbasics.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
  
    ViewData["Title"] = "SearchBySupplier";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>SearchBySupplier</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "816d2a108f0c5729e1f19786525f5e375e8c37673953", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.DisplayFor(modelItem => item.Supplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 54 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 55 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Product\SearchBySupplier.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<dotnetmvcbasics.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591