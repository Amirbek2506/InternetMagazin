#pragma checksum "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e13a00ec24e2225362e6a24aad81f3ac9abaa1c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index_categories), @"mvc.1.0.view", @"/Views/Admin/Index_categories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index_categories.cshtml", typeof(AspNetCore.Views_Admin_Index_categories))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e13a00ec24e2225362e6a24aad81f3ac9abaa1c6", @"/Views/Admin/Index_categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81965d1722757b6f921423dc5039fe93d373221c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index_categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
  
    Layout = null;

#line default
#line hidden
#line 5 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
  List<CategoryViewModel> Categories = Model;

#line default
#line hidden
            BeginContext(77, 100, true);
            WriteLiteral("\r\n<!-- Page Headings Start -->\r\n<div class=\"row justify-content-between align-items-center mb-10\">\r\n");
            EndContext();
#line 9 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
      CategoryViewModel Cat = ViewBag.CategoryName; 

#line default
#line hidden
            BeginContext(232, 143, true);
            WriteLiteral("    <!-- Page Heading Start -->\r\n    <div class=\"col-12 col-lg-auto mb-20\">\r\n        <div class=\"page-heading\">\r\n            <h3 class=\"title\">");
            EndContext();
            BeginContext(376, 9, false);
#line 13 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
                         Write(Cat.Title);

#line default
#line hidden
            EndContext();
            BeginContext(385, 520, true);
            WriteLiteral(@"</h3>
        </div>
    </div><!-- Page Heading End -->

</div><!-- Page Headings End -->

<div class=""row"">
    <div class=""col-12 mb-30"">
        <button id=""ad_cat_btn"" class=""button button-my float-right""><span><i class=""ti-plus""></i>Добавить</span></button>
    </div>
    <!--Default Data Table Start-->
    <div class=""col-12 mb-30"">
        <div class=""box"">
            <div class=""box-body"" style=""padding: 0;"">
                <table class=""table"">
                    <tbody id=""table-adm"">
");
            EndContext();
#line 29 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
                         if (Categories.Count() > 0)
                        {
                            int i = 0;
                            foreach(CategoryViewModel category in Categories)
                            {


#line default
#line hidden
            BeginContext(1138, 35, true);
            WriteLiteral("                                <tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1173, "\"", 1205, 2);
            WriteAttributeValue("", 1178, "table_item_adm_", 1178, 15, true);
#line 35 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
WriteAttributeValue("", 1193, category.Id, 1193, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1206, 94, true);
            WriteLiteral(">\r\n                                    <td class=\"text-center\" style=\"vertical-align: middle\">");
            EndContext();
#line 36 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
                                                                                             i++;

#line default
#line hidden
            BeginContext(1308, 1, false);
#line 36 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
                                                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1309, 98, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\" style=\"vertical-align: middle\">");
            EndContext();
            BeginContext(1408, 14, false);
#line 37 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
                                                                                      Write(category.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1422, 171, true);
            WriteLiteral("</td>\r\n                                    <td width=\"170\" class=\"text-center act\" style=\"vertical-align: middle\">\r\n                                        <span data-id=\"");
            EndContext();
            BeginContext(1594, 11, false);
#line 39 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
                                                  Write(category.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1605, 143, true);
            WriteLiteral("\" id=\"delete_category\" class=\"ti-trash delete-item\"></span>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 42 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(1806, 743, true);
            WriteLiteral(@"                    </tbody>
                    </table>
                </div>
            </div>
        </div>


        <!--Default Data Table End-->
        <!-- Modal -->
        <div class=""modal fade"" id=""add_category_modal"">
            <div class=""modal-dialog modal-lg"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"">Добавление категории</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal""><span aria-hidden=""true"">&times;</span></button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""box-body"">
                            ");
            EndContext();
            BeginContext(2549, 617, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e13a00ec24e2225362e6a24aad81f3ac9abaa1c69163", async() => {
                BeginContext(2555, 604, true);
                WriteLiteral(@"
                                <div id=""error_pole"" class=""alert alert-danger d-none"" role=""alert"">
                                </div>
                                <div class=""row mbn-20"">

                                    <div class=""col-12 mb-20"">
                                        <label for=""formLayoutUsername3"">Заголовок *</label>
                                        <input type=""text"" id=""title_new"" class=""form-control form-control-sm"" placeholder="""">
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
            BeginContext(3166, 151, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"modal-footer\">\r\n                        <button data-id=\"");
            EndContext();
            BeginContext(3318, 6, false);
#line 77 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Index_categories.cshtml"
                                    Write(Cat.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3324, 270, true);
            WriteLiteral(@""" id=""save_category"" class=""button button-primary button-my"">Сохранить</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src=""/public/assets/js/plugins/summernote/summernote.active.js""></script>
");
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
