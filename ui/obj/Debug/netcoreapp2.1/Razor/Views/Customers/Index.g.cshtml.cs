#pragma checksum "F:\customers\ui\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e008570085f91d1474f3ae46437eb3b62cbc756f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Index.cshtml", typeof(AspNetCore.Views_Customers_Index))]
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
#line 1 "F:\customers\ui\Views\_ViewImports.cshtml"
using ui;

#line default
#line hidden
#line 2 "F:\customers\ui\Views\_ViewImports.cshtml"
using ui.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e008570085f91d1474f3ae46437eb3b62cbc756f", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b248bf9220e494c74c49641808d2ad6c0d20b33", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ui.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\customers\ui\Views\Customers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(81, 110, true);
            WriteLiteral("\r\n        <div class=\"customers\">\r\n            <h1>Customers List</h1>\r\n            <ul id=\"customers-list\">\r\n");
            EndContext();
#line 9 "F:\customers\ui\Views\Customers\Index.cshtml"
                 foreach(var customer in Model) {

#line default
#line hidden
            BeginContext(242, 78, true);
            WriteLiteral("                    <li>\r\n                        <span class=\"customer-name\">");
            EndContext();
            BeginContext(321, 13, false);
#line 11 "F:\customers\ui\Views\Customers\Index.cshtml"
                                               Write(customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(334, 70, true);
            WriteLiteral("</span>\r\n                        <span class=\"customer-detail\">Email: ");
            EndContext();
            BeginContext(405, 14, false);
#line 12 "F:\customers\ui\Views\Customers\Index.cshtml"
                                                        Write(customer.Email);

#line default
#line hidden
            EndContext();
            BeginContext(419, 71, true);
            WriteLiteral("</span>\r\n                        <span class=\"customer-detail\">Mobile: ");
            EndContext();
            BeginContext(491, 15, false);
#line 13 "F:\customers\ui\Views\Customers\Index.cshtml"
                                                         Write(customer.Mobile);

#line default
#line hidden
            EndContext();
            BeginContext(506, 72, true);
            WriteLiteral("</span>\r\n                        <span class=\"customer-detail\">Address: ");
            EndContext();
            BeginContext(579, 16, false);
#line 14 "F:\customers\ui\Views\Customers\Index.cshtml"
                                                          Write(customer.Address);

#line default
#line hidden
            EndContext();
            BeginContext(595, 87, true);
            WriteLiteral("</span>\r\n                        <span class=\"customer-detail customer-status\">Status: ");
            EndContext();
            BeginContext(683, 15, false);
#line 15 "F:\customers\ui\Views\Customers\Index.cshtml"
                                                                         Write(customer.Status);

#line default
#line hidden
            EndContext();
            BeginContext(698, 36, true);
            WriteLiteral("</span>\r\n                    </li>\r\n");
            EndContext();
#line 17 "F:\customers\ui\Views\Customers\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(753, 35, true);
            WriteLiteral("            </ul>\r\n\r\n        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ui.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591