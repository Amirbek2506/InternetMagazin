#pragma checksum "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a14d9674e4aabe2689428fb91e4f8c0a2d52c6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index_product), @"mvc.1.0.view", @"/Views/Admin/Index_product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index_product.cshtml", typeof(AspNetCore.Views_Admin_Index_product))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a14d9674e4aabe2689428fb91e4f8c0a2d52c6d", @"/Views/Admin/Index_product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81965d1722757b6f921423dc5039fe93d373221c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index_product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-select.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrapSelect.active.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
            BeginContext(63, 121, true);
            WriteLiteral("<!-- Page Headings Start -->\r\n<div class=\"row\">\r\n    <div class=\"row justify-content-between align-items-center mb-10\">\r\n");
            EndContext();
#line 9 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
           CategoryViewModel category = ViewBag.Category;

#line default
#line hidden
            BeginContext(244, 159, true);
            WriteLiteral("        <!-- Page Heading Start -->\r\n        <div class=\"col-12 col-lg-auto mb-20\">\r\n            <div class=\"page-heading\">\r\n                <h3 class=\"title\">");
            EndContext();
            BeginContext(404, 14, false);
#line 13 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                             Write(category.Title);

#line default
#line hidden
            EndContext();
            BeginContext(418, 1383, true);
            WriteLiteral(@"</h3>
            </div>
        </div>
    </div><!-- Page Heading End -->
    <div class=""col-12 mb-30"">
        <button data-id=""0"" id=""ad_product_btn"" class=""button button-my float-right""><span><i class=""ti-plus""></i>Добавить</span></button>
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
                            <th class=""text-center"" style=""vertical-ali");
            WriteLiteral(@"gn: middle"">Цена со скидкой</th>
                            <th class=""text-center"" style=""vertical-align: middle"">Количество на складе</th>
                            <th width=""170"" class=""text-center"" style=""vertical-align: middle"">Действие</th>
                        </tr>
                    </thead>
                    <tbody id=""table-adm"">
");
            EndContext();
#line 39 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                          List<ProductViewModel> Products = ViewBag.GetProducts;

#line default
#line hidden
            BeginContext(1884, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 40 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                         if (Products.Count > 0)
                        {
                            

#line default
#line hidden
#line 42 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                             foreach (ProductViewModel product in Products)
                            {

#line default
#line hidden
            BeginContext(2069, 86, true);
            WriteLiteral("                                <tr class=\"text-center\" style=\"vertical-align: middle\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2155, "\"", 2186, 2);
            WriteAttributeValue("", 2160, "table_item_adm_", 2160, 15, true);
#line 44 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
WriteAttributeValue("", 2175, product.Id, 2175, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2187, 88, true);
            WriteLiteral(">\r\n                                    <th width=\"15%\" style=\"vertical-align: middle\">\r\n");
            EndContext();
#line 46 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
              
                List<Product_GaleryViewModel> product_Galeries = ViewBag.GetImagesProducts;
                int count = product_Galeries.Where(p => p.ProductsId == product.Id).Count();
            

#line default
#line hidden
            BeginContext(2493, 34, true);
            WriteLiteral("                                  ");
            EndContext();
#line 50 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                                   if (count>0)
                                  { 
                                         string image= product_Galeries.Where(p => p.ProductsId == product.Id).First().Image;

#line default
#line hidden
            BeginContext(2707, 121, true);
            WriteLiteral("                                            <div class=\"image-cat\">\r\n                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2828, "\"", 2870, 4);
            WriteAttributeValue("", 2834, "/uploads/products/", 2834, 18, true);
#line 54 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
WriteAttributeValue("", 2852, product.Id, 2852, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2863, "/", 2863, 1, true);
#line 54 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
WriteAttributeValue("", 2864, image, 2864, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2871, 62, true);
            WriteLiteral(" alt=\"\">\r\n                                            </div>\r\n");
            EndContext();
#line 56 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(3065, 65, true);
            WriteLiteral("                                            <div>Нет фото</div>\r\n");
            EndContext();
#line 60 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3173, 155, true);
            WriteLiteral("                                    </th>\r\n                                    <td width=\"20%\" class=\"text-center\" style=\"vertical-align: middle\"> <strong>");
            EndContext();
            BeginContext(3329, 13, false);
#line 62 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                                                                                                           Write(product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3342, 107, true);
            WriteLiteral("</strong></td>\r\n                                    <td class=\"text-center\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(3450, 15, false);
#line 63 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                                                                                      Write(product.Articul);

#line default
#line hidden
            EndContext();
            BeginContext(3465, 98, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(3564, 13, false);
#line 64 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                                                                                      Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3577, 98, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(3676, 22, false);
#line 65 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                                                                                      Write(product.Price_Discount);

#line default
#line hidden
            EndContext();
            BeginContext(3698, 98, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(3797, 16, false);
#line 66 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                                                                                      Write(product.Quontity);

#line default
#line hidden
            EndContext();
            BeginContext(3813, 171, true);
            WriteLiteral("</td>\r\n                                    <td width=\"170\" class=\"text-center act\" style=\"vertical-align: middle\">\r\n                                        <span data-id=\"");
            EndContext();
            BeginContext(3985, 10, false);
#line 68 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                                                  Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3995, 118, true);
            WriteLiteral("\" id=\"edit_product\" class=\"ti-pencil edit-item mr-10\"></span>\r\n                                        <span data-id=\"");
            EndContext();
            BeginContext(4114, 10, false);
#line 69 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                                                  Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4124, 142, true);
            WriteLiteral("\" id=\"delete_product\" class=\"ti-trash delete-item\"></span>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 72 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                            }

#line default
#line hidden
#line 72 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4381, 154, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\" colspan=\"7\">Нет данных</td>\r\n                            </tr>\r\n");
            EndContext();
#line 79 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                        }

#line default
#line hidden
            BeginContext(4562, 1213, true);
            WriteLiteral(@"                    </tbody>

                </table>
            </div>
        </div>
    </div>
</div>
<!--Default Data Table End-->
<!-- Modal -->
<div class=""modal fade"" id=""add_product_modal"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Добавление продукта</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal""><span aria-hidden=""true"">&times;</span></button>
            </div>
            <div class=""modal-body"">

                <div class=""box-body"">
                    <ul class=""nav nav-pills mb-15"">
                        <li class=""nav-item""><a class=""nav-link active"" data-toggle=""pill"" href=""#main"">Основные</a></li>
                        <li class=""nav-item""><a class=""nav-link"" data-toggle=""pill"" href=""#description"">Описание</a></li>
                        <li class=""nav-item""><a class=""nav-link"" data-toggle=""pill"" href=""#galery"">Галерея<");
            WriteLiteral("/a></li>\r\n                    </ul>\r\n                    <div class=\"tab-content\">\r\n\r\n                        <div class=\"tab-pane fade active show\" id=\"main\">\r\n                            ");
            EndContext();
            BeginContext(5775, 2573, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a14d9674e4aabe2689428fb91e4f8c0a2d52c6d16986", async() => {
                BeginContext(5781, 2560, true);
                WriteLiteral(@"
                                <div id=""error_add_product"" class=""alert alert-danger d-none"" role=""alert"">
                                </div>
                                <div class=""row mbn-20"">

                                    <div class=""col-12 mb-10"">
                                        <label for=""formLayoutUsername3"">Заголовок *</label>
                                        <input required type=""text"" id=""title_new"" class=""form-control form-control-sm"" placeholder="""">
                                    </div>

                                    <div class=""col-12 mb-10"">
                                        <label for=""formLayoutPassword3"">Артикул *</label>
                                        <input required type=""text"" id=""articul_new"" class=""form-control form-control-sm"" placeholder="""">
                                    </div>
                                    <div class=""col-12 mb-10"">
                                        <label for=""formLayoutPasswor");
                WriteLiteral(@"d3"">Цена</label>
                                        <input required type=""text"" id=""price_new"" class=""form-control form-control-sm"" placeholder="""">
                                    </div>
                                    <div class=""col-12 mb-10"">
                                        <label for=""formLayoutPassword3"">Цена со скидкой</label>
                                        <div class=""d-flex"">
                                            <input type=""text"" id=""price_discount_new"" class=""form-control form-control-sm"" placeholder="""">
                                            <label class=""adomx-checkbox d-flex align-items-center ml-30"" style=""width: 100%""><input id=""is_sale_new"" type=""checkbox""> <i class=""icon""></i> В скидку</label>
                                        </div>
                                    </div>
                                    <div class=""col-12 mb-10"">
                                        <label for=""formLayoutPassword3"">Количество на складе</lab");
                WriteLiteral(@"el>
                                        <input required type=""text"" id=""quontity_new"" class=""form-control form-control-sm"" placeholder="""">
                                    </div>
                                    <div class=""col-12 mb-10"">
                                        <label class=""adomx-checkbox""><input id=""is_new_new"" type=""checkbox""> <i class=""icon""></i>Новинка</label>
                                    </div>
                                </div>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8348, 136, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"tab-pane fade\" id=\"description\">\r\n                            ");
            EndContext();
            BeginContext(8484, 461, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a14d9674e4aabe2689428fb91e4f8c0a2d52c6d21306", async() => {
                BeginContext(8490, 448, true);
                WriteLiteral(@"
                                <div class=""row mbn-20"">
                                    <div class=""col-12 mb-20"">
                                        <label for=""formLayoutMessage1"">Описание (не обязательно)</label>
                                        <textarea id=""description_new"" class=""form-control""></textarea>
                                    </div>
                                </div>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8945, 129, true);
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"tab-pane fade\" id=\"galery\">\r\n                            ");
            EndContext();
            BeginContext(9074, 847, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a14d9674e4aabe2689428fb91e4f8c0a2d52c6d23352", async() => {
                BeginContext(9080, 834, true);
                WriteLiteral(@"
                                <div class=""col-12 mb-20"">
                                    <label for=""formLayoutMessage1"">Фото (не обязательно)</label>
                                    <span> (размер изображение должет быть  900х1352 пикс. )</span>
                                    <div class=""d-flex"">
                                        <input type=""file"" id=""image_to_temp"" name=""file"">
                                        <button id=""upload_temp_btn"" class=""button button-box-30 button-success""><i class=""ti-upload mr-0""></i></button>
                                    </div>
                                </div>
                                <div id=""images_product"" class=""row mbn-20"">
                                    
                                </div>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9921, 205, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"modal-footer\" style=\"border-top: none;\">\r\n                <button data-id=\"");
            EndContext();
            BeginContext(10127, 11, false);
#line 174 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_product.cshtml"
                            Write(category.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10138, 351, true);
            WriteLiteral(@""" id=""save_product"" class=""button button-primary button-my"">Сохранить</button>
            </div>
        </div>

    </div>
</div>
<!-- Modal -->
<div class=""modal fade"" id=""edit_product_modal"">
    <div class=""modal-dialog modal-lg"">
        <div id=""edit_product_modal_body"" class=""modal-content"">

        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(10489, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a14d9674e4aabe2689428fb91e4f8c0a2d52c6d26589", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10537, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(10539, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a14d9674e4aabe2689428fb91e4f8c0a2d52c6d27771", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
