#pragma checksum "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b95845929da6c14471efc61f7c93abd5426da5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_checkout_order), @"mvc.1.0.view", @"/Views/Customer/checkout_order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/checkout_order.cshtml", typeof(AspNetCore.Views_Customer_checkout_order))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b95845929da6c14471efc61f7c93abd5426da5f", @"/Views/Customer/checkout_order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81965d1722757b6f921423dc5039fe93d373221c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_checkout_order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout woocommerce-checkout row mt-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
   
    Layout = null;
    List<CartViewModel> Cart = Model;
    UserViewModel user = ViewBag.GetUser;
    List<ProductViewModel> Products=ViewBag.GetProducts;

#line default
#line hidden
            BeginContext(168, 543, true);
            WriteLiteral(@"
    <div id=""content"" class=""site-content bg-punch-light space-bottom-3"">
        <div class=""col-full container"">
            <div id=""primary"" class=""content-area"">
                <main id=""main"" class=""site-main"">
                    <article id=""post-6"" class=""post-6 page type-page status-publish hentry"">
                        <header class=""entry-header space-top-2 space-bottom-1 mb-2"">
                            <h4 class=""entry-title font-size-7 text-center"">Оформления заказа</h4>
                        </header>

");
            EndContext();
#line 17 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                         if (Cart.Count() > 0)
                        {

#line default
#line hidden
            BeginContext(786, 154, true);
            WriteLiteral("                            <div class=\"entry-content\">\r\n                                <div class=\"woocommerce\">\r\n\r\n                                    ");
            EndContext();
            BeginContext(940, 22047, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b95845929da6c14471efc61f7c93abd5426da5f5794", async() => {
                BeginContext(1039, 1118, true);
                WriteLiteral(@"
                                        <div class=""col2-set col-md-6 col-lg-7 col-xl-8 mb-6 mb-md-0"" id=""customer_details"">
                                            <div class=""px-4 pt-5 bg-white border"">
                                                <div class=""woocommerce-billing-fields"">
                                                    <h3 class=""mb-4 font-size-3"">Платежные реквизиты</h3>
                                                    <div class=""woocommerce-billing-fields__field-wrapper row"">

                                                        <p class=""col-lg-6 mb-4d75 form-row form-row-first validate-required woocommerce-invalid woocommerce-invalid-required-field"" id=""billing_first_name_field"" data-priority=""10"">
                                                            <label for=""billing_first_name"" class=""form-label"">Имя <abbr class=""required"" title=""обязательный"">*</abbr></label>
                                                            <input type=""text"" required cl");
                WriteLiteral("ass=\"input-text form-control\" name=\"billing_first_name\" id=\"billing_first_name\" placeholder=\"\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2157, "\"", 2180, 1);
#line 31 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
WriteAttributeValue("", 2165, user.FirstName, 2165, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2181, 588, true);
                WriteLiteral(@" autocomplete=""given-name"" autofocus=""autofocus"">
                                                        </p>
                                                        <p class=""col-lg-6 mb-4d75 form-row form-row-last validate-required"" id=""billing_last_name_field"" data-priority=""20"">
                                                            <label for=""billing_last_name"" class=""form-label"">Фамилия</label>
                                                            <input type=""text"" class=""input-text form-control"" name=""billing_last_name"" id=""billing_last_name"" placeholder=""""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2769, "\"", 2791, 1);
#line 35 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
WriteAttributeValue("", 2777, user.LastName, 2777, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2792, 640, true);
                WriteLiteral(@" autocomplete=""family-name"">
                                                        </p>
                                                        <p class=""col-lg-12 col-sm-12 mb-4d75 form-row form-row-last validate-required"" id=""billing_last_name_field"" data-priority=""20"">
                                                            <label for=""order_comments"" class=""form-label"">Адрес <abbr class=""required"" title=""обязательный"">*</abbr></label>
                                                            <textarea name=""order_comments"" required class=""input-text form-control"" id=""billing_address"" placeholder="""" rows=""5"" cols=""5"">");
                EndContext();
                BeginContext(3433, 11, false);
#line 39 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                                                                                                                                                                                      Write(user.Addres);

#line default
#line hidden
                EndContext();
                BeginContext(3444, 547, true);
                WriteLiteral(@"</textarea>
                                                        </p>
                                                        <p class=""col-lg-12 col-sm-12 mb-4d75 form-row form-row-last validate-required"" id=""billing_last_name_field"" data-priority=""20"">
                                                            <label for=""order_comments"" class=""form-label"">Город </label>
                                                            <input type=""text"" class=""input-text form-control"" name=""billing_city"" id=""billing_city"" placeholder=""""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3991, "\"", 4009, 1);
#line 43 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
WriteAttributeValue("", 3999, user.City, 3999, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4010, 633, true);
                WriteLiteral(@">
                                                        </p>

                                                        <p class=""col-lg-6 mb-4d75 form-row form-row-first validate-required woocommerce-invalid woocommerce-invalid-required-field"" id=""billing_first_name_field"" data-priority=""10"">
                                                            <label for=""billing_first_name"" class=""form-label"">Телефон <abbr class=""required"" title=""обязательный"">*</abbr></label>
                                                            <input type=""text"" required class=""input-text form-control"" id=""billing_phone"" placeholder=""""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4643, "\"", 4662, 1);
#line 48 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
WriteAttributeValue("", 4651, user.Phone, 4651, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4663, 583, true);
                WriteLiteral(@" autocomplete=""given-name"" autofocus=""autofocus"">
                                                        </p>
                                                        <p class=""col-lg-6 mb-4d75 form-row form-row-last validate-required"" id=""billing_last_name_field"" data-priority=""20"">
                                                            <label for=""billing_last_name"" class=""form-label"">E-mail</label>
                                                            <input type=""text"" class=""input-text form-control"" name=""billing_last_name"" id=""billing_email"" placeholder=""""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5246, "\"", 5265, 1);
#line 52 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
WriteAttributeValue("", 5254, user.Email, 5254, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5266, 3174, true);
                WriteLiteral(@" autocomplete=""family-name"">
                                                        </p>







                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div id=""order_review"" class=""col-md-6 col-lg-5 col-xl-4 woocommerce-checkout-review-order"">
                                            <div id=""checkoutAccordion"" class=""border border-gray-900 bg-white mb-5"">

                                                <div class=""p-4d875 border"">
                                                    <div id=""checkoutHeadingOnee"" class=""checkout-head"">
                                                        <a href=""#"" class=""text-dark d-flex align-items-center justify-content-between"" data-toggle=""collapse"" data-target=""#checkoutCollapseOnee"" aria-expanded=""true"" aria-controls=""checkoutCollapseOnee"">
        ");
                WriteLiteral(@"                                                    <h3 class=""checkout-title mb-0 font-weight-medium font-size-3"">Ваш заказ</h3>
                                                            <svg class=""mins"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""15px"" height=""2px"">
                                                                <path fill-rule=""evenodd"" fill=""rgb(22, 22, 25)"" d=""M0.000,-0.000 L15.000,-0.000 L15.000,2.000 L0.000,2.000 L0.000,-0.000 Z"" />
                                                            </svg>
                                                            <svg class=""plus"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""15px"" height=""15px"">
                                                                <path fill-rule=""evenodd"" fill=""rgb(22, 22, 25)"" d=""M15.000,8.000 L9.000,8.000 L9.000,15.000 L7.000,15.000 L7.000,8.000 L0.000,8.000 L0.000,6.000 L7.000,6.000 L7.000,-0.000 L9.000,-0.000 L9.000,6.000");
                WriteLiteral(@" L15.000,6.000 L15.000,8.000 Z"" />
                                                            </svg>
                                                        </a>
                                                    </div>
                                                    <div id=""checkoutCollapseOnee"" class=""mt-4 checkout-content collapse show"" aria-labelledby=""checkoutHeadingOnee"" data-parent=""#checkoutAccordion"">
                                                        <table class=""shop_table woocommerce-checkout-review-order-table"">
                                                            <thead class=""d-none"">
                                                                <tr>
                                                                    <th class=""product-name"">Продукт</th>
                                                                    <th class=""product-total"">Итог</th>
                                                                </tr>
                                     ");
                WriteLiteral("                       </thead>\r\n                                                            <tbody>\r\n");
                EndContext();
#line 89 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                                                                   decimal Sum = 0;

#line default
#line hidden
                BeginContext(8526, 64, true);
                WriteLiteral("                                                                ");
                EndContext();
#line 90 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                                                                 foreach (var item in Cart)
                                                                {
                                                                    {Sum += item.Price;}

#line default
#line hidden
                BeginContext(8776, 267, true);
                WriteLiteral(@"                                                                    <tr class=""cart_item"">
                                                                        <td class=""product-name"">
                                                                            ");
                EndContext();
                BeginContext(9044, 58, false);
#line 95 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                                                                       Write(Products.Where(p => p.Id == item.ProductId).Single().Title);

#line default
#line hidden
                EndContext();
                BeginContext(9102, 36, true);
                WriteLiteral(" <strong class=\"product-quantity\">× ");
                EndContext();
                BeginContext(9139, 13, false);
#line 95 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                                                                                                                                                                      Write(item.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(9152, 312, true);
                WriteLiteral(@"</strong>
                                                                        </td>
                                                                        <td class=""product-total"">
                                                                            <span class=""woocommerce-Price-amount amount"">");
                EndContext();
                BeginContext(9465, 10, false);
#line 98 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                                                                                                                     Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(9475, 225, true);
                WriteLiteral("<span class=\"woocommerce-Price-currencySymbol ml-2\">TJS</span></span>\r\n                                                                        </td>\r\n                                                                    </tr>\r\n");
                EndContext();
#line 101 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                                                                 }

#line default
#line hidden
                BeginContext(9768, 5928, true);
                WriteLiteral(@"                                                                </tbody>
                                                            </table>
                                                        </div>
                                                    </div>
                                                    <div class=""p-4d875 border"">
                                                        <div id=""checkoutHeadingTwo"" class=""checkout-head"">
                                                            <a href=""#"" class=""text-dark d-flex align-items-center justify-content-between"" data-toggle=""collapse"" data-target=""#checkoutCollapseTwo"" aria-expanded=""false"" aria-controls=""checkoutCollapseTwo"">
                                                                <h3 class=""checkout-title mb-0 font-weight-medium font-size-3"">Доставка</h3>
                                                                <svg class=""mins"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width");
                WriteLiteral(@"=""15px"" height=""2px"">
                                                                    <path fill-rule=""evenodd"" fill=""rgb(22, 22, 25)"" d=""M0.000,-0.000 L15.000,-0.000 L15.000,2.000 L0.000,2.000 L0.000,-0.000 Z"" />
                                                                </svg>
                                                                <svg class=""plus"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""15px"" height=""15px"">
                                                                    <path fill-rule=""evenodd"" fill=""rgb(22, 22, 25)"" d=""M15.000,8.000 L9.000,8.000 L9.000,15.000 L7.000,15.000 L7.000,8.000 L0.000,8.000 L0.000,6.000 L7.000,6.000 L7.000,-0.000 L9.000,-0.000 L9.000,6.000 L15.000,6.000 L15.000,8.000 Z"" />
                                                                </svg>
                                                            </a>
                                                        </div>
                                      ");
                WriteLiteral(@"                  <div id=""checkoutCollapseTwo"" class=""mt-4 checkout-content collapse show"" aria-labelledby=""checkoutHeadingTwo"" data-parent=""#checkoutAccordion"">

                                                            <ul id=""shipping_method"">
                                                                <li>
                                                                    <input type=""hidden"" id=""shipping_cost"" value=""0"" data-id=""Самовывоз"">
                                                                    <input type=""radio"" name=""shipping_method[0]"" checked data-index=""0"" data-id=""Самовывоз"" id=""shipping_method_0_flat_rate1"" value=""0"" class=""shipping_method"">
                                                                    <label for=""shipping_method_0_flat_rate1"">Самовывоз</label>
                                                                </li>
                                                                <li>
                                                                ");
                WriteLiteral(@"    <input type=""radio"" name=""shipping_method[0]"" data-index=""0"" data-id=""Внутри города"" id=""shipping_method_0_flat_rate2"" value=""11"" class=""shipping_method"">
                                                                    <label for=""shipping_method_0_flat_rate2"">
                                                                        Внутри города:
                                                                        <span class=""woocommerce-Price-amount amount"">
                                                                            11<span class=""woocommerce-Price-currencySymbol ml-2"">TJS</span>
                                                                        </span>
                                                                    </label>
                                                                </li>
                                                                <li>
                                                                    <input type=""radio"" name=""shipping");
                WriteLiteral(@"_method[0]"" data-index=""0"" data-id=""За городом"" id=""shipping_method_0_flat_rate3"" value=""50"" class=""shipping_method"">
                                                                    <label for=""shipping_method_0_flat_rate3"">
                                                                        За городом:
                                                                        <span class=""woocommerce-Price-amount amount"">
                                                                            50<span class=""woocommerce-Price-currencySymbol ml-2"">TJS</span>
                                                                        </span>
                                                                    </label>
                                                                </li>
                                                            </ul>
                                                        </div>
                                                    </div>
                         ");
                WriteLiteral(@"                           <div class=""p-4d875 border"">
                                                        <table class=""shop_table shop_table_responsive"">
                                                            <tbody>
                                                                <tr class=""order-total"">
                                                                    <th>Всего</th>
                                                                    <td data-title=""Total"">
                                                                        <strong>
                                                                            <span class=""woocommerce-Price-amount amount"">
                                                                                <span id=""total_order"">");
                EndContext();
                BeginContext(15697, 3, false);
#line 155 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                                                                                                  Write(Sum);

#line default
#line hidden
                EndContext();
                BeginContext(15700, 7280, true);
                WriteLiteral(@"</span><span class=""woocommerce-Price-currencySymbol ml-3"">TJS</span>
                                                                            </span>
                                                                        </strong>
                                                                    </td>
                                                                </tr>
                                                            </tbody>
                                                        </table>
                                                    </div>
                                                    <div class=""p-4d875 border"">
                                                        <div id=""checkoutHeadingThreee"" class=""checkout-head"">
                                                            <a href=""#"" class=""text-dark d-flex align-items-center justify-content-between"" data-toggle=""collapse"" data-target=""#checkoutCollapseThreee"" aria-expanded=""true"" aria-controls=""checkoutColl");
                WriteLiteral(@"apseThreee"">
                                                                <h3 class=""checkout-title mb-0 font-weight-medium font-size-3"">Оплата</h3>
                                                                <svg class=""mins"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""15px"" height=""2px"">
                                                                    <path fill-rule=""evenodd"" fill=""rgb(22, 22, 25)"" d=""M0.000,-0.000 L15.000,-0.000 L15.000,2.000 L0.000,2.000 L0.000,-0.000 Z"" />
                                                                </svg>
                                                                <svg class=""plus"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" width=""15px"" height=""15px"">
                                                                    <path fill-rule=""evenodd"" fill=""rgb(22, 22, 25)"" d=""M15.000,8.000 L9.000,8.000 L9.000,15.000 L7.000,15.000 L7.000,8.000 L0.000,8.000 L0.000,6.000 L7.000,6.0");
                WriteLiteral(@"00 L7.000,-0.000 L9.000,-0.000 L9.000,6.000 L15.000,6.000 L15.000,8.000 Z"" />
                                                                </svg>
                                                            </a>
                                                        </div>
                                                        <div id=""checkoutCollapseThreee"" class=""mt-4 checkout-content collapse show"" aria-labelledby=""checkoutHeadingThreee"" data-parent=""#checkoutAccordion"">
                                                            <div id=""payment"" class=""woocommerce-checkout-payment"">
                                                                <input type=""hidden"" id=""payment_method"" value=""1"">
                                                                <ul class=""wc_payment_methods payment_methods methods"">
                                                                    <li class=""wc_payment_method payment_method_bacs mb-0 d-table"">
                                               ");
                WriteLiteral(@"                         <input id=""payment_method_bacs"" type=""radio"" class=""input-radio payment-method"" checked name=""payment_method"" value=""1"" data-order_button_text="""">
                                                                        <label for=""payment_method_bacs"">Оплата при доставке </label>
                                                                        <div class=""payment_box payment_method_bacs"" style=""display: block;"">
                                                                            <p>
                                                                                Вы оплачиваете покупку при получении курьеру.
                                                                            </p>
                                                                        </div>
                                                                    </li>
                                                                    <li class=""wc_payment_method payment_method_cod mb-0 d-table");
                WriteLiteral(@""">
                                                                        <input id=""payment_method_alif"" type=""radio"" class=""input-radio payment-method"" name=""payment_method"" value=""2"" data-order_button_text="""">
                                                                        <label for=""payment_method_alif"">Alif mobi</label><br>
                                                                        <div class=""payment_box payment_method_cod"" style=""display: block;"">
                                                                            <p>В процессе.</p>
                                                                        </div>
                                                                    </li>
                                                                    <li class=""wc_payment_method payment_method_cheque mb-0 d-table"">
                                                                        <input id=""payment_method_cheque"" type=""radio"" class=""input-radio payment-method");
                WriteLiteral(@""" name=""payment_method"" value=""3"" data-order_button_text="""">
                                                                        <label for=""payment_method_cheque"">Корти милли</label>
                                                                        <div class=""payment_box payment_method_cheque"" style=""display: block;"">
                                                                            <p>В процессе.</p>
                                                                        </div>
                                                                    </li>

                                                                    <li class=""wc_payment_method payment_method_cod mb-0 d-table"">
                                                                        <input id=""payment_method_cod"" type=""radio"" class=""input-radio payment-method"" name=""payment_method"" value=""4"" data-order_button_text="""">
                                                                        <label for=""payment_m");
                WriteLiteral(@"ethod_cod"">VISA/Master карты</label>
                                                                        <div class=""payment_box payment_method_cod"" style=""display: block;"">
                                                                            <p>В процессе.</p>
                                                                        </div>
                                                                    </li>
                                                                </ul>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""form-row place-order"">
                                                    <span id=""make_order"" class=""button alt btn btn-dark btn-block rounded-0 py-4"">Оформить заказ</span>
                                    ");
                WriteLiteral("            </div>\r\n                                            </div>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(22987, 86, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 222 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(23157, 278, true);
            WriteLiteral(@"                        <div class=""col-12 mb-3"">
                            <div class=""alert alert-lg alert-danger"">
                                Не имея товаров в корзине, пытаетесь оформить заказ :)
                            </div>
                        </div>
");
            EndContext();
#line 230 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\checkout_order.cshtml"
                        }

#line default
#line hidden
            BeginContext(23462, 221, true);
            WriteLiteral("\r\n                    </article>\r\n\r\n                </main>\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n<script>\r\n        $(\'body\').addClass(\'right-sidebar woocommerce-checkout u-unfold-opened\');\r\n</script>\r\n");
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
