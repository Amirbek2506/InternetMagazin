#pragma checksum "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da8d529920c51d2876727cb844fa74a310376c45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index_product), @"mvc.1.0.view", @"/Views/Home/Index_product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index_product.cshtml", typeof(AspNetCore.Views_Home_Index_product))]
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
#line 1 "D:\projects\InternetMagazin\InternetMagazin\Views\_ViewImports.cshtml"
using InternetMagazin;

#line default
#line hidden
#line 2 "D:\projects\InternetMagazin\InternetMagazin\Views\_ViewImports.cshtml"
using InternetMagazin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8d529920c51d2876727cb844fa74a310376c45", @"/Views/Home/Index_product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81965d1722757b6f921423dc5039fe93d373221c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index_product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/products/default.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
  
    Layout = null;
    CategoryViewModel category = ViewBag.Category;

#line default
#line hidden
            BeginContext(81, 336, true);
            WriteLiteral(@"        <!-- Page Headings Start -->
        <div class=""row"">
            <div class=""row justify-content-between align-items-center mb-10"">
                <!-- Page Heading Start -->
                <div class=""col-12 col-lg-auto mb-20"">
                    <div class=""page-heading"">
                        <h3 class=""title"">");
            EndContext();
            BeginContext(418, 14, false);
#line 12 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                     Write(category.Title);

#line default
#line hidden
            EndContext();
            BeginContext(432, 1194, true);
            WriteLiteral(@"</h3>
                    </div>
                </div>
            </div><!-- Page Heading End -->
            <div class=""col-12 mb-30"">
            </div>
            <!-- Page Headings End -->
            <!--Default Data Table Start-->
            <div class=""col-12 mb-30"">
                <div class=""box"">
                    <div class=""box-body"" style=""padding: 0;"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th width=""15%"" class=""text-center"" style=""vertical-align: middle"">#</th>
                                    <th width=""20%"" class=""text-center"" style=""vertical-align: middle"">Заголовок</th>
                                    <th class=""text-center"" style=""vertical-align: middle"">Артикул</th>
                                    <th class=""text-center"" style=""vertical-align: middle"">Цена</th>
                                    <th width=""170"" class=""text-center"" style");
            WriteLiteral("=\"vertical-align: middle\">Действие</th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody id=\"table_adm\">\r\n");
            EndContext();
#line 34 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                  List<ProductViewModel> Products = Model;
                                    List<ProductViewModel> products = Products.Where(p => p.CategoryId == category.Id).ToList();
                                

#line default
#line hidden
            BeginContext(1867, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 37 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                 if (products.Count > 0)
                                {
                                    

#line default
#line hidden
#line 39 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                     foreach (ProductViewModel product in products)
                                    {

#line default
#line hidden
            BeginContext(2084, 94, true);
            WriteLiteral("                                        <tr class=\"text-center\" style=\"vertical-align: middle\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2178, "\"", 2209, 2);
            WriteAttributeValue("", 2183, "table_item_cus_", 2183, 15, true);
#line 41 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
WriteAttributeValue("", 2198, product.Id, 2198, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2210, 96, true);
            WriteLiteral(">\r\n                                            <th width=\"15%\" style=\"vertical-align: middle\">\r\n");
            EndContext();
#line 43 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                  
                                                    List<Product_GaleryViewModel> product_Galeries = ViewBag.GetImagesProducts;
                                                    int count = product_Galeries.Where(p => p.ProductsId == product.Id).Count();
                                                

#line default
#line hidden
            BeginContext(2668, 48, true);
            WriteLiteral("                                                ");
            EndContext();
#line 47 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                 if (count > 0)
                                                {
                                                    string image = product_Galeries.Where(p => p.ProductsId == product.Id).First().Image;

#line default
#line hidden
            BeginContext(2923, 137, true);
            WriteLiteral("                                                    <div class=\"image-cat\">\r\n                                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3060, "\"", 3102, 4);
            WriteAttributeValue("", 3066, "/uploads/products/", 3066, 18, true);
#line 51 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
WriteAttributeValue("", 3084, product.Id, 3084, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 3095, "/", 3095, 1, true);
#line 51 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
WriteAttributeValue("", 3096, image, 3096, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3103, 70, true);
            WriteLiteral(" alt=\"\">\r\n                                                    </div>\r\n");
            EndContext();
#line 53 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(3329, 133, true);
            WriteLiteral("                                                    <div class=\"image-cat\">\r\n                                                        ");
            EndContext();
            BeginContext(3462, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "da8d529920c51d2876727cb844fa74a310376c4510499", async() => {
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
            EndContext();
            BeginContext(3511, 62, true);
            WriteLiteral("\r\n                                                    </div>\r\n");
            EndContext();
#line 59 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3624, 171, true);
            WriteLiteral("                                            </th>\r\n                                            <td width=\"20%\" class=\"text-center\" style=\"vertical-align: middle\"> <strong>");
            EndContext();
            BeginContext(3796, 13, false);
#line 61 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                                                                                   Write(product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3809, 115, true);
            WriteLiteral("</strong></td>\r\n                                            <td class=\"text-center\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(3925, 15, false);
#line 62 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                                                              Write(product.Articul);

#line default
#line hidden
            EndContext();
            BeginContext(3940, 110, true);
            WriteLiteral("</td>\r\n\r\n                                            <td class=\"text-center\" style=\"vertical-align: middle\">\r\n");
            EndContext();
#line 65 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                 if (product.Is_sale == 1)
                                                {

#line default
#line hidden
            BeginContext(4177, 57, true);
            WriteLiteral("                                                    <del>");
            EndContext();
            BeginContext(4235, 13, false);
#line 67 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                    Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4248, 85, true);
            WriteLiteral("   </del>\r\n                                                    <span class=\"price\">  ");
            EndContext();
            BeginContext(4334, 22, false);
#line 68 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                                     Write(product.Price_Discount);

#line default
#line hidden
            EndContext();
            BeginContext(4356, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 69 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                }
                                                else
                                                {
                                                    

#line default
#line hidden
            BeginContext(4574, 13, false);
#line 72 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                               Write(product.Price);

#line default
#line hidden
            EndContext();
#line 72 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                                  
                                                }

#line default
#line hidden
            BeginContext(4640, 233, true);
            WriteLiteral("                                            </td>\r\n\r\n                                            <td width=\"170\" class=\"text-center act\" style=\"vertical-align: middle\">\r\n                                                <span data-id=\"");
            EndContext();
            BeginContext(4874, 10, false);
#line 77 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                          Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4884, 115, true);
            WriteLiteral("\" id=\"log__in\" class=\"ti-shopping-cart\">   </span>\r\n                                                <span data-id=\"");
            EndContext();
            BeginContext(5000, 10, false);
#line 78 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                                          Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5010, 143, true);
            WriteLiteral("\" id=\"log__in\" class=\"ti-heart\">    </span>\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 81 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                    }

#line default
#line hidden
#line 81 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                     
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(5300, 179, true);
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"text-center\" colspan=\"7\">Нет продукт</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 88 "D:\projects\InternetMagazin\InternetMagazin\Views\Home\Index_product.cshtml"
                                }

#line default
#line hidden
            BeginContext(5514, 199, true);
            WriteLiteral("                            </tbody>\r\n\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!--Default Data Table End-->");
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
