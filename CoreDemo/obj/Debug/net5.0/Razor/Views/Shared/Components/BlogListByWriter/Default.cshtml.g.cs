#pragma checksum "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListByWriter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ecd02b63a1c32a6ede5bb092f4c0ba1acc58bc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListByWriter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListByWriter/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ecd02b63a1c32a6ede5bb092f4c0ba1acc58bc6", @"/Views/Shared/Components/BlogListByWriter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListByWriter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n\t<h4>Top stories of the week</h4>\r\n");
#nullable restore
#line 4 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListByWriter\Default.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"blog-grids row mb-3\">\r\n\t\t<div class=\"col-md-5 blog-grid-left\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ecd02b63a1c32a6ede5bb092f4c0ba1acc58bc63805", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<img");
                BeginWriteAttribute("src", " src=\"", 275, "\"", 305, 1);
#nullable restore
#line 9 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListByWriter\Default.cshtml"
WriteAttributeValue("", 281, item.BlogThumbnailImage, 281, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\"");
                BeginWriteAttribute("alt", " alt=\"", 324, "\"", 330, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 231, "~/Blog/BlogDetails/", 231, 19, true);
#nullable restore
#line 8 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListByWriter\Default.cshtml"
AddHtmlAttributeValue("", 250, item.BlogId, 250, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div class=\"col-md-7 blog-grid-right\">\r\n\r\n\t\t\t<h5>\r\n\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ecd02b63a1c32a6ede5bb092f4c0ba1acc58bc66092", async() => {
#nullable restore
#line 15 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListByWriter\Default.cshtml"
                                                         Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 420, "~/Blog/BlogDetails/", 420, 19, true);
#nullable restore
#line 15 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListByWriter\Default.cshtml"
AddHtmlAttributeValue("", 439, item.BlogId, 439, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</h5>\r\n\t\t\t<div class=\"sub-meta\">\r\n\t\t\t\t<span>\r\n\t\t\t\t\t\t<i class=\"far fa-clock\"></i> ");
#nullable restore
#line 19 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListByWriter\Default.cshtml"
                                                Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</span>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 24 "D:\Documents\WorkFolder\C#_Work\NewWoorkFolder\Ders2\CoreDemo\CoreDemo\Views\Shared\Components\BlogListByWriter\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
