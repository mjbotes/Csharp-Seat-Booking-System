#pragma checksum "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f75f1a35c3a486fde9bbccc6360e1546656dc5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_SeatSelection), @"mvc.1.0.view", @"/Views/Events/SeatSelection.cshtml")]
namespace AspNetCore
{
    #line hidden
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\_ViewImports.cshtml"
using Csharp_Seat_Booking_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
using Csharp_Seat_Booking_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f75f1a35c3a486fde9bbccc6360e1546656dc5a", @"/Views/Events/SeatSelection.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694bf7a6a29d5b942a6a5243e7bee4ed444b7dd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_SeatSelection : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 9 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
  
    ViewData["Title"] = "Seat Selection";
    List<Seat> SeatArr = (List<Seat>)ViewData["arr"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Book your seats.</h2>\r\n\r\n<div style=\"position: relative\">\r\n");
#nullable restore
#line 18 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
     foreach(Seat SeatInArr in SeatArr)
    {
        string Scolor = "grey";
        switch(SeatInArr.GetCatergory())
        {
        case 1:
            Scolor = "blue";
            break;
        case 2:
            Scolor = "orange";
            break;
        case 3:
        default:
            Scolor = "gold";
            break;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button");
            BeginWriteAttribute("style", " style=\"", 797, "\"", 950, 13);
            WriteAttributeValue("", 805, "position:", 805, 9, true);
            WriteAttributeValue(" ", 814, "absolute;", 815, 10, true);
            WriteAttributeValue(" ", 824, "left:", 825, 6, true);
#nullable restore
#line 34 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
WriteAttributeValue(" ", 830, SeatInArr.GetXCordinate() * 30, 831, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 864, "px;", 864, 3, true);
            WriteAttributeValue(" ", 867, "top:", 868, 5, true);
#nullable restore
#line 34 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
WriteAttributeValue(" ", 872, SeatInArr.GetYCordinate() * 40, 873, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 906, "px;", 906, 3, true);
            WriteAttributeValue(" ", 909, "width:30px;", 910, 12, true);
            WriteAttributeValue(" ", 921, "height:", 922, 8, true);
            WriteAttributeValue(" ", 929, "30px;", 930, 6, true);
            WriteAttributeValue(" ", 935, "color:", 936, 7, true);
#nullable restore
#line 34 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
WriteAttributeValue(" ", 942, Scolor, 943, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-chair\"></i></button>\r\n");
#nullable restore
#line 35 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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