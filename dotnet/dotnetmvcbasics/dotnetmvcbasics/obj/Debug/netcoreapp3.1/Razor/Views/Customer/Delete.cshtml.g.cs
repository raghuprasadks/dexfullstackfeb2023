#pragma checksum "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61b8307d01d73dfcd68517d897e0657ee6e6a1f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Delete), @"mvc.1.0.view", @"/Views/Customer/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b8307d01d73dfcd68517d897e0657ee6e6a1f0", @"/Views/Customer/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f92d4c9efb7c120e9bfe5b1ad7eb5663098551", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dotnetmvcbasics.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.DisplayFor(model => model.location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n");
#nullable restore
#line 46 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
#nullable restore
#line 52 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 54 "D:\kaushalya\consultancy\ilinkdigital\2023\DEX\dotnet\dotnetmvcbasics\dotnetmvcbasics\Views\Customer\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dotnetmvcbasics.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
