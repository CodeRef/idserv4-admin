#pragma checksum "C:\CodeRef\idserv-admin\IdServe\WebClient2\Views\Home\CallApi2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea04fb693835e29551a0f2c187c29ad0ae63ca9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CallApi2), @"mvc.1.0.view", @"/Views/Home/CallApi2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CallApi2.cshtml", typeof(AspNetCore.Views_Home_CallApi2))]
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
#line 1 "C:\CodeRef\idserv-admin\IdServe\WebClient2\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#line 2 "C:\CodeRef\idserv-admin\IdServe\WebClient2\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea04fb693835e29551a0f2c187c29ad0ae63ca9b", @"/Views/Home/CallApi2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CallApi2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\CodeRef\idserv-admin\IdServe\WebClient2\Views\Home\CallApi2.cshtml"
  
    ViewData["Title"] = "CallApi2";

#line default
#line hidden
            BeginContext(46, 7, true);
            WriteLiteral("\r\n<pre>");
            EndContext();
            BeginContext(54, 12, false);
#line 6 "C:\CodeRef\idserv-admin\IdServe\WebClient2\Views\Home\CallApi2.cshtml"
Write(ViewBag.Json);

#line default
#line hidden
            EndContext();
            BeginContext(66, 8, true);
            WriteLiteral("</pre>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
