#pragma checksum "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\Checkout\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a60da5ce879267ebb81a8ecaab1b929afce84339"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Checkout), @"mvc.1.0.view", @"/Views/Checkout/Checkout.cshtml")]
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
#line 1 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\_ViewImports.cshtml"
using Csharp_Seat_Booking_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\_ViewImports.cshtml"
using Csharp_Seat_Booking_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a60da5ce879267ebb81a8ecaab1b929afce84339", @"/Views/Checkout/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3549b3b905540b4768067e0371bbc018e613e919", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\Checkout\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center>\r\n<div>\r\n    <div>\r\n        <h2>Checkout</h2>\r\n        <hr>\r\n\r\n    <h4 class=\"text-center\">");
#nullable restore
#line 11 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\Checkout\Checkout.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n  \r\n        <br>\r\n\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a60da5ce879267ebb81a8ecaab1b929afce843394167", async() => {
                WriteLiteral(@"
        <div class=""row checkout-body"" style=""font:14px 'Open Sans', sans-serif; text-align:center; width: 100vh; border:1px solid #ebeff2;"">
            <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12"">
                <div class=""tile"" style="" background:#fff; border-radius:5px; margin: 1px 1px 3px 3px; height: 50vh; width: 90vh;"">
                    <div class=""wrapper"">
                        <div class=""header text-center"" style=""width: 90vh; border-bottom:1px solid #ebeff2; padding:19px 0; text-align:center; color:#59687f; font-weight:600; font-size:19px;	"">
                            ");
#nullable restore
#line 21 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\Checkout\Checkout.cshtml"
                       Write(ViewData["EventName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                        <div class=""dates"" style=""width: 90vh; padding:19px 0 30px 0; margin:10px 20px 10px 20px; border:1px solid #ebeff2; font-size:16px; color:#59687f; font-weight:600; overflow:auto;"">
                            <div class=""BookingDate"" style=""float:left; width:50%; text-align:center; position:relative;"">
                                <strong style=""display:block; color:#adb8c2; font-size:14px; font-weight:700;"">
                                    DATE: 
                                </strong>
                                     ");
#nullable restore
#line 28 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\Checkout\Checkout.cshtml"
                                Write(ViewData["BookingDate"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <span style=""width:20px; height:40px; position:absolute; right:0; top:0;""></span>
                            </div>
                            <div class=""BookingTime"" style=""float:left; width:50%; text-align:center; position:relative;"">
                                <strong style=""display:block; color:#adb8c2; font-size:14px; font-weight:700;"">
                                    TIME: 
                                </strong> 
                                    ");
#nullable restore
#line 35 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\Checkout\Checkout.cshtml"
                               Write(ViewData["BookingTime"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""seats"" style=""float: left; width: 90vh; overflow:auto;"">
                            <div class=""goldSeat"" style=""width: 30vh; float:left; text-align:center; padding:15px 0 30px 0; border-right:1px solid #ebeff2;"">
                                <strong style=""color: gold; font-size:14px;"">
                                    GOLD
                                </strong> 
                                    ");
#nullable restore
#line 43 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\Checkout\Checkout.cshtml"
                               Write(ViewData["SeatCategoryGoldPrice"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <div class=""orangeSeat"" style=""width: 30vh; float:left; text-align:center; padding:15px 0 30px 0; border-right:1px solid #ebeff2;"">
                                <strong style=""color: orange; font-size:14px;"">
                                    ORANGE
                                </strong> 
                                    ");
#nullable restore
#line 49 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\Checkout\Checkout.cshtml"
                               Write(ViewData["SeatCategoryOrangePrice"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <div class=""blueSeat"" style=""width: 30vh; float:left; text-align:center; padding:15px 0 30px 0; border-right: none;"">
                                <strong style=""color: aqua; font-size:14px;"">
                                    BLUE
                                </strong> 
                                    ");
#nullable restore
#line 55 "C:\Users\bbdnet2061\Bootcamp\C#\Project\Csharp-Seat-Booking-System\Views\Checkout\Checkout.cshtml"
                               Write(ViewData["SeatCategoryBluePrice"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>

                        </div>
                        <div class=""seatNumber"" style=""float:left; width: 91vh;"">

                            <div class=""goldSeat"" style=""border-right:1px solid #ebeff2; margin-left: 0; width: 30vh; float:left; text-align:center; padding:15px 0 30px 0; background:#f7f8fa; overflow:auto; font-size:16px; color:#59687f; font-weight:600; "">
                                <strong>Number of Seats</strong> 5
                            </div>

                            <div class=""orangeSeat"" style=""border-right:1px solid #ebeff2;  margin-left: 0; width: 30vh; float:left; text-align:center; padding:15px 0 30px 0; background:#f7f8fa; overflow:auto; font-size:16px; color:#59687f; font-weight:600;"">
                                <strong>Number of Seats</strong> 3
                            </div>

                            <div class=""blueSeat"" style=""border-right: none;  margin-left: 0; width: 30vh; float:left; text-align:cente");
                WriteLiteral(@"r; padding:15px 0 30px 0; background:#f7f8fa; overflow:auto; font-size:16px; color:#59687f; font-weight:600;"">
                                <strong>Number of Seats</strong> 13
                            </div>

                        </div>
                    </div>
                </div>
                <div class=""checkout-footer"" style="" margin: 1px 0px 1px 0px; padding: 0px 0px 20px 0px; text-align:center;"">
                    <input class=""checkout-button"" type=""button"" style=""width: 120px; height: 30px; font-weight: 700; "" onclick=""window.location.href = 'https://localhost:5001/Checkout/ViewCart';"" value=""Checkout"" />
                </div>
           </div>
       ");
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n</center>");
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
