#pragma checksum "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\ViewEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77e310a10bbd6945bed616a939ace87f31eec00b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_ViewEvents), @"mvc.1.0.view", @"/Views/Events/ViewEvents.cshtml")]
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
#line 1 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\_ViewImports.cshtml"
using Csharp_Seat_Booking_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\ViewEvents.cshtml"
using Csharp_Seat_Booking_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e310a10bbd6945bed616a939ace87f31eec00b", @"/Views/Events/ViewEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694bf7a6a29d5b942a6a5243e7bee4ed444b7dd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_ViewEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\ViewEvents.cshtml"
  
    ViewData["Title"] = "Events";
    Event[] Events = (Event[])ViewData["Events"];
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\ViewEvents.cshtml"
 foreach (var EventHappening in Events)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>\r\n<div>\r\n<img");
            BeginWriteAttribute("src", " src=", 204, "", 231, 1);
#nullable restore
#line 12 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\ViewEvents.cshtml"
WriteAttributeValue("", 209, EventHappening.ImgSrc, 209, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<h3>");
#nullable restore
#line 13 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\ViewEvents.cshtml"
Write(EventHappening.EventName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>");
#nullable restore
#line 14 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\ViewEvents.cshtml"
Write(EventHappening.EventDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n</a>\r\n");
#nullable restore
#line 17 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\ViewEvents.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n}");
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
