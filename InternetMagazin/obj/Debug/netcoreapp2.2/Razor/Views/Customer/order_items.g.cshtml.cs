#pragma checksum "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8d7a62a294ce52f1a3a61d6fad928b5c09b4c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_order_items), @"mvc.1.0.view", @"/Views/Customer/order_items.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/order_items.cshtml", typeof(AspNetCore.Views_Customer_order_items))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d7a62a294ce52f1a3a61d6fad928b5c09b4c7f", @"/Views/Customer/order_items.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81965d1722757b6f921423dc5039fe93d373221c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_order_items : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/products/default.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image-description"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
  
    Layout = null;
    List<Order_ItemViewModel> order_items = Model;
    List<ProductViewModel> products=  ViewBag.GetProducts;
    List<Product_GaleryViewModel> galeries = ViewBag.GetImagesProducts;
    UserViewModel user = ViewBag.GetUser;

#line default
#line hidden
            BeginContext(255, 157, true);
            WriteLiteral("    <!--Default Data Table Start-->\r\n                <h1 class=\"font-weight-medium font-size-7 ml-lg-1 mb-lg-8 pb-xl-1\">\r\n                    <span data-id=\"");
            EndContext();
            BeginContext(413, 7, false);
#line 10 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                              Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(420, 1262, true);
            WriteLiteral(@""" id=""I_orders"" class=""cursor-pointer""><i class=""ti-arrow-left""></i> Назад</span>
                </h1>
                <table class=""table"">
                    <thead>
                        <tr class=""border"">
                            <th scope=""col""
                                class=""py-3 border-bottom-0 font-weight-medium pl-3 pl-lg-5 text-center"">
                                #
                            </th>
                            <th scope=""col"" class=""py-3 border-bottom-0 font-weight-medium text-center"">
                                Продукт
                            </th>
                            <th scope=""col"" class=""py-3 border-bottom-0 font-weight-medium text-center"">
                                Количество
                            </th>
                            <th scope=""col"" class=""py-3 border-bottom-0 font-weight-medium text-center"">
                                Цена за 1
                            </th>
                            <th ");
            WriteLiteral("scope=\"col\" class=\"py-3 border-bottom-0 font-weight-medium text-center\">\r\n                                Итого\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 34 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                         if (order_items.Count() > 0)
                        {
                            foreach (var item in order_items)
                            {
                                 ProductViewModel product = products.Where(p => p.Id == item.ProductId).Single();
                                

#line default
#line hidden
            BeginContext(2007, 302, true);
            WriteLiteral(@"                                <tr class=""border"">
                                    <th class=""pl-3 pl-md-5 font-weight-normal align-middle py-6 text-center"">
                                        <div class=""d-flex align-items-center"">
                                            <a data-id=""");
            EndContext();
            BeginContext(2310, 7, false);
#line 43 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                                                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2317, 32, true);
            WriteLiteral("\" class=\"d-block p-img-thumb\">\r\n");
            EndContext();
#line 44 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                                                 if (galeries.Where(p => p.ProductsId == item.ProductId).ToList().Count() > 0)
                                                {

#line default
#line hidden
            BeginContext(2528, 56, true);
            WriteLiteral("                                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2584, "\"", 2686, 4);
            WriteAttributeValue("", 2590, "/uploads/products/", 2590, 18, true);
#line 46 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
WriteAttributeValue("", 2608, item.ProductId, 2608, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2623, "/", 2623, 1, true);
#line 46 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
WriteAttributeValue("", 2624, galeries.Where(p=>p.ProductsId==item.ProductId).First().Image, 2624, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2687, 45, true);
            WriteLiteral(" class=\"img-fluid\" alt=\"image-description\">\r\n");
            EndContext();
#line 47 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(2888, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
            BeginContext(2940, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8d7a62a294ce52f1a3a61d6fad928b5c09b4c7f9493", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
            BeginContext(3024, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 51 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3077, 552, true);
            WriteLiteral(@"                                            </a>
                                        </div>
                                    </th>
                                    <th class=""pl-3 pl-md-5 font-weight-normal align-middle py-6"">
                                        <div class=""d-flex align-items-center"">
                                            <div class=""ml-xl-4"">
                                                <div class=""font-weight-normal"">
                                                    <a href="""" class=""text-dark"">");
            EndContext();
            BeginContext(3630, 13, false);
#line 59 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                                                                            Write(product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3643, 207, true);
            WriteLiteral("</a>\r\n                                                </div>\r\n                                            </div>\r\n                                        </div>\r\n                                    </th>\r\n\r\n");
            EndContext();
#line 65 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                                       decimal Price = product.Is_sale == 1 ? product.Price_Discount : product.Price;

#line default
#line hidden
            BeginContext(3970, 78, true);
            WriteLiteral("                                    <td class=\"align-middle py-5 text-center\">");
            EndContext();
            BeginContext(4049, 13, false);
#line 66 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                                                                         Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(4062, 97, true);
            WriteLiteral("</td>\r\n                                    <td class=\"align-middle py-5 text-center\" width=\"15%\">");
            EndContext();
            BeginContext(4160, 5, false);
#line 67 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                                                                                     Write(Price);

#line default
#line hidden
            EndContext();
            BeginContext(4165, 170, true);
            WriteLiteral(" TJS</td>\r\n                                    <td class=\"align-middle py-5 text-center\" width=\"15%\">\r\n                                        <span class=\"text-primary\">");
            EndContext();
            BeginContext(4336, 10, false);
#line 69 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                                                              Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4346, 96, true);
            WriteLiteral("</span>  TJS\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 72 "D:\projects\InternetMagazin\InternetMagazin\Views\Customer\order_items.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(4500, 62, true);
            WriteLiteral("\r\n                    </tbody>\r\n                    </table>\r\n");
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
