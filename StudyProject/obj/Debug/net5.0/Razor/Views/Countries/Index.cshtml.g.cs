#pragma checksum "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f384f9d2704a6e72b59f2edca136f2b5ca6935a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Countries_Index), @"mvc.1.0.view", @"/Views/Countries/Index.cshtml")]
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
#line 1 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\_ViewImports.cshtml"
using StudyProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\_ViewImports.cshtml"
using StudyProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f384f9d2704a6e72b59f2edca136f2b5ca6935a", @"/Views/Countries/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa184d6ed6bb0009db66eeb76daa6590fa4a6459", @"/Views/_ViewImports.cshtml")]
    public class Views_Countries_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<StudyProject.Models.Country>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"
  
    ViewData["Title"] = "Страны";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div id=\"features-wrapper\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"
             foreach (var country in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-4 col-12-medium\">\r\n\r\n                    <!-- Box -->\r\n                    <section class=\"box feature\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 403, "\"", 442, 2);
            WriteAttributeValue("", 410, "Countries/Get/", 410, 14, true);
#nullable restore
#line 19 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"
WriteAttributeValue("", 424, country.CountryId, 424, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"image featured\"><img");
            BeginWriteAttribute("src", " src=\"", 471, "\"", 499, 1);
#nullable restore
#line 19 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"
WriteAttributeValue("", 477, country.CardPhotoLink, 477, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 500, "\"", 506, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                        <div class=\"inner\">\r\n                            <header>\r\n                                <h2>");
#nullable restore
#line 22 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"
                               Write(country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <p>");
#nullable restore
#line 23 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"
                              Write(country.CardDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </header>\r\n");
#nullable restore
#line 25 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"
                             if (@country.CardTagline.Length > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>");
#nullable restore
#line 27 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"
                              Write(country.CardTagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 28 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>Phasellus quam turpis, feugiat sit amet in, hendrerit in lectus. Praesent sed semper amet bibendum tristique fringilla.</p>\r\n");
#nullable restore
#line 32 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </section>\r\n\r\n\r\n                </div>\r\n");
#nullable restore
#line 38 "C:\Users\Hepret\source\repos\StudyProject\StudyProject\Views\Countries\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<StudyProject.Models.Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591
