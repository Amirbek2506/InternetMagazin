#pragma checksum "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38af363900713000e7bad72eedd32bdb52ec9fda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_index), @"mvc.1.0.view", @"/Views/Customer/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/index.cshtml", typeof(AspNetCore.Views_Customer_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38af363900713000e7bad72eedd32bdb52ec9fda", @"/Views/Customer/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81965d1722757b6f921423dc5039fe93d373221c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
  
    Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
            BeginContext(60, 6150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38af363900713000e7bad72eedd32bdb52ec9fda4117", async() => {
                BeginContext(66, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
     foreach (CategoryViewModel category in ViewBag.GetCategories)
    {
        if (category.ParentId != 0)
        {

#line default
#line hidden
                BeginContext(191, 364, true);
                WriteLiteral(@"            <!-- Page Headings Start -->
            <div class=""row"">
                <div class=""row justify-content-between align-items-center mb-10"">
                    <!-- Page Heading Start -->
                    <div class=""col-12 col-lg-auto mb-20"">
                        <div class=""page-heading"">
                            <h3 class=""title"">");
                EndContext();
                BeginContext(556, 14, false);
#line 15 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                         Write(category.Title);

#line default
#line hidden
                EndContext();
                BeginContext(570, 1278, true);
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
         ");
                WriteLiteral("                               <th width=\"170\" class=\"text-center\" style=\"vertical-align: middle\">Действие</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody id=\"table_adm\">\r\n");
                EndContext();
#line 37 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                      List<ProductViewModel> Products = Model;
                                        List<ProductViewModel> products = Products.Where(p => p.CategoryId == category.Id).ToList();
                                    

#line default
#line hidden
                BeginContext(2101, 36, true);
                WriteLiteral("                                    ");
                EndContext();
#line 40 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                     if (products.Count > 0)
                                    {
                                        

#line default
#line hidden
#line 42 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                         foreach (ProductViewModel product in products)
                                        {

#line default
#line hidden
                BeginContext(2334, 98, true);
                WriteLiteral("                                            <tr class=\"text-center\" style=\"vertical-align: middle\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2432, "\"", 2463, 2);
                WriteAttributeValue("", 2437, "table_item_cus_", 2437, 15, true);
#line 44 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
WriteAttributeValue("", 2452, product.Id, 2452, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2464, 100, true);
                WriteLiteral(">\r\n                                                <th width=\"15%\" style=\"vertical-align: middle\">\r\n");
                EndContext();
#line 46 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                      
                                                        List<Product_GaleryViewModel> product_Galeries = ViewBag.GetImagesProducts;
                                                        int count = product_Galeries.Where(p => p.ProductsId == product.Id).Count();
                                                    

#line default
#line hidden
                BeginContext(2942, 52, true);
                WriteLiteral("                                                    ");
                EndContext();
#line 50 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                     if (count > 0)
                                                    {
                                                        string image = product_Galeries.Where(p => p.ProductsId == product.Id).First().Image;

#line default
#line hidden
                BeginContext(3209, 145, true);
                WriteLiteral("                                                        <div class=\"image-cat\">\r\n                                                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3354, "\"", 3396, 4);
                WriteAttributeValue("", 3360, "/uploads/products/", 3360, 18, true);
#line 54 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
WriteAttributeValue("", 3378, product.Id, 3378, 11, false);

#line default
#line hidden
                WriteAttributeValue("", 3389, "/", 3389, 1, true);
#line 54 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
WriteAttributeValue("", 3390, image, 3390, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3397, 74, true);
                WriteLiteral(" alt=\"\">\r\n                                                        </div>\r\n");
                EndContext();
#line 56 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
                BeginContext(3639, 141, true);
                WriteLiteral("                                                        <div class=\"image-cat\">\r\n                                                            ");
                EndContext();
                BeginContext(3780, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "38af363900713000e7bad72eedd32bdb52ec9fda11439", async() => {
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
                BeginContext(3829, 66, true);
                WriteLiteral("\r\n                                                        </div>\r\n");
                EndContext();
#line 62 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                    }

#line default
#line hidden
                BeginContext(3950, 179, true);
                WriteLiteral("                                                </th>\r\n                                                <td width=\"20%\" class=\"text-center\" style=\"vertical-align: middle\"> <strong>");
                EndContext();
                BeginContext(4130, 13, false);
#line 64 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                                                                                       Write(product.Title);

#line default
#line hidden
                EndContext();
                BeginContext(4143, 119, true);
                WriteLiteral("</strong></td>\r\n                                                <td class=\"text-center\" style=\"vertical-align: middle\">");
                EndContext();
                BeginContext(4263, 15, false);
#line 65 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                                                                  Write(product.Articul);

#line default
#line hidden
                EndContext();
                BeginContext(4278, 114, true);
                WriteLiteral("</td>\r\n\r\n                                                <td class=\"text-center\" style=\"vertical-align: middle\">\r\n");
                EndContext();
#line 68 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                     if (product.Is_sale == 1)
                                                    {

#line default
#line hidden
                BeginContext(4527, 61, true);
                WriteLiteral("                                                        <del>");
                EndContext();
                BeginContext(4589, 13, false);
#line 70 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                        Write(product.Price);

#line default
#line hidden
                EndContext();
                BeginContext(4602, 89, true);
                WriteLiteral("   </del>\r\n                                                        <span class=\"price\">  ");
                EndContext();
                BeginContext(4692, 22, false);
#line 71 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                                         Write(product.Price_Discount);

#line default
#line hidden
                EndContext();
                BeginContext(4714, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 72 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                    }
                                                    else
                                                    {
                                                        

#line default
#line hidden
                BeginContext(4948, 13, false);
#line 75 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                   Write(product.Price);

#line default
#line hidden
                EndContext();
#line 75 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                                      
                                                    }

#line default
#line hidden
                BeginContext(5018, 245, true);
                WriteLiteral("                                                </td>\r\n\r\n                                                <td width=\"170\" class=\"text-center act\" style=\"vertical-align: middle\">\r\n                                                    <span data-id=\"");
                EndContext();
                BeginContext(5264, 10, false);
#line 80 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                              Write(product.Id);

#line default
#line hidden
                EndContext();
                BeginContext(5274, 123, true);
                WriteLiteral("\" id=\"add_to_cart\" class=\"ti-shopping-cart\">   </span>\r\n                                                    <span data-id=\"");
                EndContext();
                BeginContext(5398, 10, false);
#line 81 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                                              Write(product.Id);

#line default
#line hidden
                EndContext();
                BeginContext(5408, 155, true);
                WriteLiteral("\" id=\"add_to_wish\" class=\"ti-heart\">    </span>\r\n                                                </td>\r\n                                            </tr>\r\n");
                EndContext();
#line 84 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                        }

#line default
#line hidden
#line 84 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
                BeginContext(5726, 191, true);
                WriteLiteral("                                        <tr>\r\n                                            <td class=\"text-center\" colspan=\"7\">Нет продукт</td>\r\n                                        </tr>\r\n");
                EndContext();
#line 91 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
                                    }

#line default
#line hidden
                BeginContext(5956, 229, true);
                WriteLiteral("                                </tbody>\r\n\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!--Default Data Table End-->\r\n");
                EndContext();
#line 100 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\index.cshtml"
        }
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6210, 2, true);
            WriteLiteral("\r\n");
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
