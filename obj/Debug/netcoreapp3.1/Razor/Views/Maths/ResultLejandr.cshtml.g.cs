#pragma checksum "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7616b4a8b6bcf29d6de3a8a83f4a1159f0c5fddd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maths_ResultLejandr), @"mvc.1.0.view", @"/Views/Maths/ResultLejandr.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7616b4a8b6bcf29d6de3a8a83f4a1159f0c5fddd", @"/Views/Maths/ResultLejandr.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a59dd0c8444c78aab5623d934b9675ff773f97", @"/Views/_ViewImports.cshtml")]
    public class Views_Maths_ResultLejandr : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CountLejandr>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <p>Вы ввели число=:");
#nullable restore
#line 3 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
                  Write(Model.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Степени=:");
#nullable restore
#line 4 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
           Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Модуля:=");
#nullable restore
#line 5 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
          Write(Model.Module);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Символ Лежандра:=");
#nullable restore
#line 6 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
                   Write(Model.Res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h2>Итог</h2>\r\n");
            WriteLiteral("        <h3>");
#nullable restore
#line 9 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
       Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 10 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
         if (ViewBag.Message == "Сравнение разрешимо")
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
             foreach (var key in Model.ResultLejandr)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Ответы:");
#nullable restore
#line 15 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
                     Write(key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
#nullable restore
#line 23 "D:\UIB\UIB\UIB\Views\Maths\ResultLejandr.cshtml"
Write(Html.Partial("Footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CountLejandr> Html { get; private set; }
    }
}
#pragma warning restore 1591
