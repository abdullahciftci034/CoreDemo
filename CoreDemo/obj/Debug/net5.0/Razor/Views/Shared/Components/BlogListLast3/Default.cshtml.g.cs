#pragma checksum "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListLast3\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba27da42fff9bd4937df4858e99d283e1a8cc64a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListLast3_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListLast3/Default.cshtml")]
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
#line 1 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListLast3\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba27da42fff9bd4937df4858e99d283e1a8cc64a", @"/Views/Shared/Components/BlogListLast3/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListLast3_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListLast3\Default.cshtml"
  
	ViewData["Title"] = "RecentlyPost";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"tech-btm\">\r\n\t<h3>Latest Posts</h3>\r\n");
#nullable restore
#line 8 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListLast3\Default.cshtml"
     foreach (var val in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div class=\"blog-grids row mb-3\">\r\n\t\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 260, "\"", 296, 2);
            WriteAttributeValue("", 267, "/Blog/BlogDetails/", 267, 18, true);
#nullable restore
#line 12 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListLast3\Default.cshtml"
WriteAttributeValue("", 285, val.BlogId, 285, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 309, "\"", 338, 1);
#nullable restore
#line 13 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListLast3\Default.cshtml"
WriteAttributeValue("", 315, val.BlogThumbnailImage, 315, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 370, "\"", 376, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t</a>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t\t<h5>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 463, "\"", 499, 2);
            WriteAttributeValue("", 470, "/Blog/BlogDetails/", 470, 18, true);
#nullable restore
#line 19 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListLast3\Default.cshtml"
WriteAttributeValue("", 488, val.BlogId, 488, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListLast3\Default.cshtml"
                                                       Write(val.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t</h5>\r\n\t\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"far fa-clock\"></i>");
#nullable restore
#line 23 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListLast3\Default.cshtml"
                                               Write(val.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</span>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 28 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListLast3\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
