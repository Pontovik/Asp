#pragma checksum "D:\UIB\UIB\UIB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "703182dd7a781f8653f04007ce684de3f91e2342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\UIB\UIB\UIB\Views\_ViewImports.cshtml"
using UIB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UIB\UIB\UIB\Views\_ViewImports.cshtml"
using UIB.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\UIB\UIB\UIB\Views\_ViewImports.cshtml"
using UIB.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\UIB\UIB\UIB\Views\_ViewImports.cshtml"
using UIB.Models.Counts;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"703182dd7a781f8653f04007ce684de3f91e2342", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a59dd0c8444c78aab5623d934b9675ff773f97", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Subject>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>Предмет</th>\r\n            <th>Препод</th>\r\n            <th>Начало</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 11 "D:\UIB\UIB\UIB\Views\Home\Index.cshtml"
         foreach (var sub in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td class=\"text-center\">");
#nullable restore
#line 16 "D:\UIB\UIB\UIB\Views\Home\Index.cshtml"
                                   Write(sub.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 17 "D:\UIB\UIB\UIB\Views\Home\Index.cshtml"
                                   Write(sub.Teacher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">");
#nullable restore
#line 18 "D:\UIB\UIB\UIB\Views\Home\Index.cshtml"
                                   Write(sub.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 20 "D:\UIB\UIB\UIB\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Subject>> Html { get; private set; }
    }
}
#pragma warning restore 1591