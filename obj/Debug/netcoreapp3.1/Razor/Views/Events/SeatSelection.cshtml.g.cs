#pragma checksum "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "912d8940d86f3a766d3677e6cf8fd1f941326445"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"912d8940d86f3a766d3677e6cf8fd1f941326445", @"/Views/Events/SeatSelection.cshtml")]
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
        string id =  SeatInArr.ToElementId();

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button");
            BeginWriteAttribute("id", " id=", 844, "", 851, 1);
#nullable restore
#line 35 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
WriteAttributeValue("", 848, id, 848, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 851, "\"", 1004, 13);
            WriteAttributeValue("", 859, "position:", 859, 9, true);
            WriteAttributeValue(" ", 868, "absolute;", 869, 10, true);
            WriteAttributeValue(" ", 878, "left:", 879, 6, true);
#nullable restore
#line 35 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
WriteAttributeValue(" ", 884, SeatInArr.GetXCordinate() * 30, 885, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 918, "px;", 918, 3, true);
            WriteAttributeValue(" ", 921, "top:", 922, 5, true);
#nullable restore
#line 35 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
WriteAttributeValue(" ", 926, SeatInArr.GetYCordinate() * 40, 927, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 960, "px;", 960, 3, true);
            WriteAttributeValue(" ", 963, "width:30px;", 964, 12, true);
            WriteAttributeValue(" ", 975, "height:", 976, 8, true);
            WriteAttributeValue(" ", 983, "30px;", 984, 6, true);
            WriteAttributeValue(" ", 989, "color:", 990, 7, true);
#nullable restore
#line 35 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
WriteAttributeValue(" ", 996, Scolor, 997, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=", 1005, "", 1026, 3);
            WriteAttributeValue("", 1014, "AddSeat(", 1014, 8, true);
#nullable restore
#line 35 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
WriteAttributeValue("", 1022, id, 1022, 3, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1025, ")", 1025, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-chair\"></i></button>\r\n");
#nullable restore
#line 36 "C:\Users\bbdnet2202\Documents\Bootcamp\C#\Csharp-Seat-Booking-System\Views\Events\SeatSelection.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <button onclick=AddToCart() style=""position:absolute; bottom:40px"">Add to Cart</button>
</div>

<script>
    var seats = [];
    function AddSeat(seatId) {
        if (seats.includes(seatId.id)) {
            seats.splice(seats.indexOf(seatId.id), 1);
            seatId.style.color = ""blue"";
        } else {
            seatId.style.color = ""green"";
            seats.push(seatId.id);
        }
        console.log(seats);
    }

    function AddToCart() {
        $.post(""http://localhost:5001/Events/AddSeatsToCart"", JSON.stringify(seats));

    }
</script>");
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
