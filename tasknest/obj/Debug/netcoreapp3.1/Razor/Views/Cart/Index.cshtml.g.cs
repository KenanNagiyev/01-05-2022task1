#pragma checksum "C:\Users\hp\Desktop\tasknest\tasknest\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02641e375dbfda57deb10da31c55f3f7068cc85b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\tasknest\tasknest\Views\_ViewImports.cshtml"
using tasknest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\tasknest\tasknest\Views\_ViewImports.cshtml"
using tasknest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\tasknest\tasknest\Views\_ViewImports.cshtml"
using tasknest.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02641e375dbfda57deb10da31c55f3f7068cc85b", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da816af36dd0a5b01af878e2597c329f1eb8b7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("field_form shipping_calculator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hp\Desktop\tasknest\tasknest\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main"">
    <div class=""page-header breadcrumb-wrap"">
        <div class=""container"">
            <div class=""breadcrumb"">
                <a href=""index.html"" rel=""nofollow""><i class=""fi-rs-home mr-5""></i>Home</a>
                <span></span> Shop
                <span></span> Cart
            </div>
        </div>
    </div>
    <div class=""container mb-80 mt-50"">
        <div class=""row"">
            <div class=""col-lg-8 mb-40"">
                <h1 class=""heading-2 mb-10"">Your Cart</h1>
                <div class=""d-flex justify-content-between"">
                    <h6 class=""text-body"">There are <span class=""text-brand"">3</span> products in your cart</h6>
                    <h6 class=""text-body""><a href=""#"" class=""text-muted""><i class=""fi-rs-trash mr-5""></i>Clear Cart</a></h6>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""table-responsive shopping-summery"">
          ");
            WriteLiteral(@"          <table class=""table table-wishlist"">
                        <thead>
                            <tr class=""main-heading"">
                                <th class=""custome-checkbox start pl-30"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""checkbox"" id=""exampleCheckbox11""");
            BeginWriteAttribute("value", " value=\"", 1400, "\"", 1408, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <label class=""form-check-label"" for=""exampleCheckbox11""></label>
                                </th>
                                <th scope=""col"" colspan=""2"">Product</th>
                                <th scope=""col"">Unit Price</th>
                                <th scope=""col"">Quantity</th>
                                <th scope=""col"">Subtotal</th>
                                <th scope=""col"" class=""end"">Remove</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr class=""pt-30"">
                                <td class=""custome-checkbox pl-30"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""checkbox"" id=""exampleCheckbox1""");
            BeginWriteAttribute("value", " value=\"", 2231, "\"", 2239, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <label class=""form-check-label"" for=""exampleCheckbox1""></label>
                                </td>
                                <td class=""image product-thumbnail pt-40""><img src=""assets/imgs/shop/product-1-1.jpg"" alt=""#""></td>
                                <td class=""product-des product-name"">
                                    <h6 class=""mb-5""><a class=""product-name mb-10 text-heading"" href=""shop-product-right.html"">Field Roast Chao Cheese Creamy Original</a></h6>
                                    <div class=""product-rate-cover"">
                                        <div class=""product-rate d-inline-block"">
                                            <div class=""product-rating"" style=""width:90%"">
                                            </div>
                                        </div>
                                        <span class=""font-small ml-5 text-muted""> (4.0)</span>
                                    </div>
               ");
            WriteLiteral(@"                 </td>
                                <td class=""price"" data-title=""Price"">
                                    <h4 class=""text-body"">$2.51 </h4>
                                </td>
                                <td class=""text-center detail-info"" data-title=""Stock"">
                                    <div class=""detail-extralink mr-15"">
                                        <div class=""detail-qty border radius"">
                                            <a href=""#"" class=""qty-down""><i class=""fi-rs-angle-small-down""></i></a>
                                            <span class=""qty-val"">1</span>
                                            <a href=""#"" class=""qty-up""><i class=""fi-rs-angle-small-up""></i></a>
                                        </div>
                                    </div>
                                </td>
                                <td class=""price"" data-title=""Price"">
                                    <h4 class=""text-brand"">$2.51 </h");
            WriteLiteral(@"4>
                                </td>
                                <td class=""action text-center"" data-title=""Remove""><a href=""#"" class=""text-body""><i class=""fi-rs-trash""></i></a></td>
                            </tr>


                        </tbody>
                    </table>
                </div>
                <div class=""divider-2 mb-30""></div>
                <div class=""cart-action d-flex justify-content-between"">
                    <a class=""btn ""><i class=""fi-rs-arrow-left mr-10""></i>Continue Shopping</a>
                    <a class=""btn  mr-10 mb-sm-15""><i class=""fi-rs-refresh mr-10""></i>Update Cart</a>
                </div>
                <div class=""row mt-50"">
                    <div class=""col-lg-7"">
                        <div class=""calculate-shiping p-40 border-radius-15 border"">
                            <h4 class=""mb-10"">Calculate Shipping</h4>
                            <p class=""mb-30""><span class=""font-lg text-muted"">Flat rate:</span><strong class=""");
            WriteLiteral("text-brand\">5%</strong></p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02641e375dbfda57deb10da31c55f3f7068cc85b10162", async() => {
                WriteLiteral(@"
                                <div class=""form-row"">
                                    <div class=""form-group col-lg-12"">
                                        <div class=""custom_select"">
                                            <select class=""form-control select-active w-100"">
                                            </select>
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-row row"">
                                    <div class=""form-group col-lg-6"">
                                        <input required=""required"" placeholder=""State / Country"" name=""name"" type=""text"">
                                    </div>
                                    <div class=""form-group col-lg-6"">
                                        <input required=""required"" placeholder=""PostCode / ZIP"" name=""name"" type=""text"">
                                    </div>
        ");
                WriteLiteral("                        </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-lg-5"">
                        <div class=""p-40"">
                            <h4 class=""mb-10"">Apply Coupon</h4>
                            <p class=""mb-30""><span class=""font-lg text-muted"">Using A Promo Code?</p>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02641e375dbfda57deb10da31c55f3f7068cc85b12978", async() => {
                WriteLiteral(@"
                                <div class=""d-flex justify-content-between"">
                                    <input class=""font-medium mr-15 coupon"" name=""Coupon"" placeholder=""Enter Your Coupon"">
                                    <button class=""btn""><i class=""fi-rs-label mr-10""></i>Apply</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""border p-md-4 cart-totals ml-30"">
                    <div class=""table-responsive"">
                        <table class=""table no-border"">
                            <tbody>
                                <tr>
                                    <td class=""cart_total_label"">
                                        <h6 class=""text-muted"">Subtotal</h6>
                                    </td>
                                    <td class=""cart_total_amount"">
                                        <h4 class=""text-brand text-end"">$12.31</h4>
                                    </td>
                                </tr>
                                <tr>
                                    <td scope=""col"" colspan=""2"">
                                        <div class=""divider-2 mt-10 mb-10""></div>
                         ");
            WriteLiteral(@"           </td>
                                </tr>

                                <tr>
                                    <td class=""cart_total_label"">
                                        <h6 class=""text-muted"">Total</h6>
                                    </td>
                                    <td class=""cart_total_amount"">
                                        <h4 class=""text-brand text-end"">$12.31</h4>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                    <a href=""#"" class=""btn mb-20 w-100"">Proceed To CheckOut<i class=""fi-rs-sign-out ml-15""></i></a>
                </div>
            </div>
        </div>
    </div>
</main>

");
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
