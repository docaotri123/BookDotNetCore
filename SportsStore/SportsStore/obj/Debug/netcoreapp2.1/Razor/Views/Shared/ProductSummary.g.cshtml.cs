#pragma checksum "H:\Tri\DotNet\BookDotNetCore\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1816399fe324369d1b2e0312113978aa2445437"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ProductSummary.cshtml", typeof(AspNetCore.Views_Shared_ProductSummary))]
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
#line 1 "H:\Tri\DotNet\BookDotNetCore\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#line 2 "H:\Tri\DotNet\BookDotNetCore\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1816399fe324369d1b2e0312113978aa2445437", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d00d49aade00e308a73ca2368f87808ce589652f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 107, true);
            WriteLiteral("<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-1\">\r\n        <h4>\r\n            ");
            EndContext();
            BeginContext(124, 10, false);
#line 5 "H:\Tri\DotNet\BookDotNetCore\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(134, 104, true);
            WriteLiteral("\r\n            <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n                <small>");
            EndContext();
            BeginContext(239, 25, false);
#line 7 "H:\Tri\DotNet\BookDotNetCore\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml"
                  Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(264, 89, true);
            WriteLiteral("</small>\r\n            </span>\r\n        </h4>\r\n    </div>\r\n    <div class=\"card-text p-1\">");
            EndContext();
            BeginContext(354, 17, false);
#line 11 "H:\Tri\DotNet\BookDotNetCore\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml"
                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(371, 14, true);
            WriteLiteral("</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591