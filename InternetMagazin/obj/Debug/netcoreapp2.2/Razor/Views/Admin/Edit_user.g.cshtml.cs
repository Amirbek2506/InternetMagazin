#pragma checksum "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b8ba334984882ea12ef6c2683de286ad170bae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Edit_user), @"mvc.1.0.view", @"/Views/Admin/Edit_user.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Edit_user.cshtml", typeof(AspNetCore.Views_Admin_Edit_user))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b8ba334984882ea12ef6c2683de286ad170bae4", @"/Views/Admin/Edit_user.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81965d1722757b6f921423dc5039fe93d373221c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Edit_user : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
  
    Layout = null;
    List<RollViewModel> roles = ViewBag.Roles;
    UserViewModel user = Model;

#line default
#line hidden
            BeginContext(110, 272, true);
            WriteLiteral(@"<div class=""modal-header"">
    <h5 class=""modal-title"">Редактирование пользователья</h5>
    <button type=""button"" class=""close"" data-dismiss=""modal""><span aria-hidden=""true"">&times;</span></button>
</div>
<div class=""modal-body"">
    <div class=""box-body"">
        ");
            EndContext();
            BeginContext(382, 4103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b8ba334984882ea12ef6c2683de286ad170bae44075", async() => {
                BeginContext(388, 375, true);
                WriteLiteral(@"
            <div id=""error-edit_pole"" class=""alert alert-danger d-none"" role=""alert"">
            </div>
            <div class=""row mbn-20"">

                <!--Single Select-->
                <div class=""col-12 mb-20"">
                    <h5 class=""sub-title"">Рол *</h5>
                    <select id=""role_edit"" class=""form-control form-control-sm bSelect"">
");
                EndContext();
#line 22 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                         if (roles.Count() > 0)
                        {
                            foreach (var role in roles)
                            {
                                if (user.RollesId == role.Id)
                                {

#line default
#line hidden
                BeginContext(1025, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1061, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b8ba334984882ea12ef6c2683de286ad170bae45374", async() => {
                    BeginContext(1096, 10, false);
#line 28 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                                                                 Write(role.Title);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#line 28 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                                                WriteLiteral(role.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1115, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 29 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(1225, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1261, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b8ba334984882ea12ef6c2683de286ad170bae48129", async() => {
                    BeginContext(1287, 10, false);
#line 32 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                                                        Write(role.Title);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 32 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                                       WriteLiteral(role.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1306, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 33 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                                }
                            }
                        }

#line default
#line hidden
                BeginContext(1401, 321, true);
                WriteLiteral(@"                    </select>
                </div>
                <!--Single Select-->

                <div class=""col-12 mb-20"">
                    <label for=""formLayoutUsername3"">Фамилия *</label>
                    <input type=""text"" id=""last_name_edit"" class=""form-control form-control-sm"" placeholder=""""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1722, "\"", 1744, 1);
#line 42 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
WriteAttributeValue("", 1730, user.LastName, 1730, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1745, 249, true);
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"col-12 mb-20\">\r\n                    <label for=\"formLayoutEmail3\">Имя *</label>\r\n                    <input type=\"text\" id=\"first_name_edit\" class=\"form-control form-control-sm\" placeholder=\"\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1994, "\"", 2017, 1);
#line 47 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
WriteAttributeValue("", 2002, user.FirstName, 2002, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2018, 253, true);
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"col-12 mb-20\">\r\n                    <label for=\"formLayoutEmail3\">Отчество</label>\r\n                    <input type=\"text\" id=\"middle_name_edit\" class=\"form-control form-control-sm\" placeholder=\"\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2271, "\"", 2295, 1);
#line 52 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
WriteAttributeValue("", 2279, user.MiddleName, 2279, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2296, 251, true);
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"col-12 mb-20\">\r\n                    <label for=\"formLayoutPassword3\">Телефон *</label>\r\n                    <input type=\"text\" id=\"phone_edit\" class=\"form-control form-control-sm\" placeholder=\"\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2547, "\"", 2566, 1);
#line 57 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
WriteAttributeValue("", 2555, user.Phone, 2555, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2567, 246, true);
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-12 mb-20\">\r\n                    <label for=\"formLayoutPassword3\">Е-mail</label>\r\n                    <input type=\"text\" id=\"email_edit\" class=\"form-control form-control-sm\" placeholder=\"\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2813, "\"", 2832, 1);
#line 61 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
WriteAttributeValue("", 2821, user.Email, 2821, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2833, 548, true);
                WriteLiteral(@">
                </div>
                <div class=""col-12 mb-20"">
                    <label for=""formLayoutPassword3"">Парол *</label>
                    <input type=""text"" id=""password_edit"" class=""form-control form-control-sm"" placeholder=""Оставьте поле пустым, если не хотите менять"" value="""">
                </div>

                <div class=""col-12 mb-20"">
                    <label for=""formLayoutPassword3"">Город</label>
                    <input type=""text"" id=""city_edit"" class=""form-control form-control-sm"" placeholder=""""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3381, "\"", 3399, 1);
#line 70 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
WriteAttributeValue("", 3389, user.City, 3389, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3400, 249, true);
                WriteLiteral(">\r\n                </div>\r\n\r\n                <div class=\"col-12 mb-20\">\r\n                    <label for=\"formLayoutPassword3\">Адрес</label>\r\n                    <input type=\"text\" id=\"address_edit\" class=\"form-control form-control-sm\" placeholder=\"\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3649, "\"", 3669, 1);
#line 75 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
WriteAttributeValue("", 3657, user.Addres, 3657, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3670, 325, true);
                WriteLiteral(@">
                </div>
                <div class=""col-12 mb-20"">
                    <label for=""formLayoutFile1"">Фото (не обязательно)</label>
                    <div class=""d-flex"">
                        <input type=""file"" id=""image_edit"" class="""">
                        <div class=""image-user float-right"">
");
                EndContext();
#line 82 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                             if (user.Image != null)
                            {

#line default
#line hidden
                BeginContext(4080, 36, true);
                WriteLiteral("                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4116, "\"", 4157, 4);
                WriteAttributeValue("", 4122, "/uploads/users/", 4122, 15, true);
#line 84 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
WriteAttributeValue("", 4137, user.Id, 4137, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 4145, "/", 4145, 1, true);
#line 84 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
WriteAttributeValue("", 4146, user.Image, 4146, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4158, 18, true);
                WriteLiteral(" alt=\"Нет фото\">\r\n");
                EndContext();
#line 85 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                            }
                            else
                            {

#line default
#line hidden
                BeginContext(4272, 57, true);
                WriteLiteral("                                <label>Нет фото</label>\r\n");
                EndContext();
#line 89 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                            }

#line default
#line hidden
                BeginContext(4360, 118, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n            ");
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
            BeginContext(4485, 87, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"modal-footer\">\r\n        <button data-id=\"");
            EndContext();
            BeginContext(4573, 7, false);
#line 99 "D:\projects\InternetMagazin\InternetMagazin\Views\Admin\Edit_user.cshtml"
                    Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4580, 94, true);
            WriteLiteral("\" id=\"save_edit_user\" class=\"button button-primary button-my\">Сохранить</button>\r\n    </div>\r\n");
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
