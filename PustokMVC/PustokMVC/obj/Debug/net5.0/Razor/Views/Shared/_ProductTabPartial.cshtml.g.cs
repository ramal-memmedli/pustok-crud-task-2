#pragma checksum "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b59f20523d501c91bc8c8edfdf9357998d094e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductTabPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductTabPartial.cshtml")]
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
#line 1 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\_ViewImports.cshtml"
using Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\_ViewImports.cshtml"
using PustokMVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b59f20523d501c91bc8c8edfdf9357998d094e4", @"/Views/Shared/_ProductTabPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539765384a2ba8d65cf2493303afe4e0ac462934", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ProductTabPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/image/products/product-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""product-slider multiple-row  slider-border-multiple-row  sb-slick-slider""
                         data-slick-setting='{
                            ""autoplay"": true,
                            ""autoplaySpeed"": 8000,
                            ""slidesToShow"": 5,
                            ""rows"":1,
                            ""dots"":true
                        }' data-slick-responsive='[
                            {""breakpoint"":1200, ""settings"": {""slidesToShow"": 3} },
                            {""breakpoint"":768, ""settings"": {""slidesToShow"": 2} },
                            {""breakpoint"":480, ""settings"": {""slidesToShow"": 1} },
                            {""breakpoint"":320, ""settings"": {""slidesToShow"": 1} }
                        ]'>
");
#nullable restore
#line 16 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                         foreach (Product product in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""single-slide"">
                                    <div class=""product-card"">
                                        <div class=""product-header"">
                                            <a href=""#"" class=""author"">
                                                ");
#nullable restore
#line 22 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                                           Write(product.Author.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </a>\r\n                                            <h3><a href=\"product-details.html\">");
#nullable restore
#line 24 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                                                                          Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                        </div>\r\n                                        <div class=\"product-card--body\">\r\n                                            <div class=\"card-image\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b59f20523d501c91bc8c8edfdf9357998d094e46321", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                <div class=\"hover-contents\">\r\n                                                    <a href=\"product-details.html\" class=\"hover-image\">\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b59f20523d501c91bc8c8edfdf9357998d094e47684", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                    </a>
                                                    <div class=""hover-btns"">
                                                        <a href=""cart.html"" class=""single-btn"">
                                                            <i class=""fas fa-shopping-basket""></i>
                                                        </a>
                                                        <a href=""wishlist.html"" class=""single-btn"">
                                                            <i class=""fas fa-heart""></i>
                                                        </a>
                                                        <a href=""compare.html"" class=""single-btn"">
                                                            <i class=""fas fa-random""></i>
                                                        </a>
                                                        <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
      ");
            WriteLiteral(@"                                                      class=""single-btn"">
                                                            <i class=""fas fa-eye""></i>
                                                        </a>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""price-block"">
");
#nullable restore
#line 51 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                                                 if(product.DiscountPrice > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"price\">£");
#nullable restore
#line 52 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                                                                     Write(product.SalePrice - product.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    <del class=\"price-old\">£");
#nullable restore
#line 53 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                                                                       Write(product.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                                                    <span class=\"price-discount\">%");
#nullable restore
#line 54 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                                                                             Write(Math.Round((product.DiscountPrice * 100) / product.SalePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 55 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                                                }   
                                                else 
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"price\">£");
#nullable restore
#line 58 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                                                                    Write(product.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 64 "C:\Users\Ramal\Desktop\Desktop\PustokMVC\PustokMVC\Views\Shared\_ProductTabPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591