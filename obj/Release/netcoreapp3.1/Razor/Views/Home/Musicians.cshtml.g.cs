#pragma checksum "/Users/thomasverbruggen/Projects/MusicianList/MusicianList/Views/Home/Musicians.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2eba3f077348666162e9bd4843a19b9051a86dfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Musicians), @"mvc.1.0.view", @"/Views/Home/Musicians.cshtml")]
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
#line 1 "/Users/thomasverbruggen/Projects/MusicianList/MusicianList/Views/_ViewImports.cshtml"
using MusicianList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/thomasverbruggen/Projects/MusicianList/MusicianList/Views/_ViewImports.cshtml"
using MusicianList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/thomasverbruggen/Projects/MusicianList/MusicianList/Views/Home/Musicians.cshtml"
using Contentful.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eba3f077348666162e9bd4843a19b9051a86dfa", @"/Views/Home/Musicians.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08980eeabc89847557a48d4d725d9dd843b3806b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Musicians : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContentfulCollection<MusiciansList>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n\n<div class=\"container row pt-3 align-between d-flex justify-content-between\">\n");
#nullable restore
#line 8 "/Users/thomasverbruggen/Projects/MusicianList/MusicianList/Views/Home/Musicians.cshtml"
     foreach (var musicians in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col-2 m-1 p-0 text-center\" style=\"width: 18rem;\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 290, "\"", 323, 1);
#nullable restore
#line 11 "/Users/thomasverbruggen/Projects/MusicianList/MusicianList/Views/Home/Musicians.cshtml"
WriteAttributeValue("", 296, musicians.Picture.File.Url, 296, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 345, "\"", 375, 1);
#nullable restore
#line 11 "/Users/thomasverbruggen/Projects/MusicianList/MusicianList/Views/Home/Musicians.cshtml"
WriteAttributeValue("", 351, musicians.Picture.Title, 351, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <div class=\"card-body\">\n                <h5 class=\"card-title\">");
#nullable restore
#line 13 "/Users/thomasverbruggen/Projects/MusicianList/MusicianList/Views/Home/Musicians.cshtml"
                                  Write(musicians.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            </div>\n            <ul class=\"list-group list-group-flush\">\n                <li class=\"list-group-item\">");
#nullable restore
#line 16 "/Users/thomasverbruggen/Projects/MusicianList/MusicianList/Views/Home/Musicians.cshtml"
                                       Write(musicians.Instrument);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            </ul>\n        </div>\n");
#nullable restore
#line 19 "/Users/thomasverbruggen/Projects/MusicianList/MusicianList/Views/Home/Musicians.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContentfulCollection<MusiciansList>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
