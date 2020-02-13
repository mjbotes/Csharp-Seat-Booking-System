using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Csharp_Seat_Booking_System.Models
{
    public class Event
    {
        public string ImgSrc {get; set; }
        public string EventName {get; set; }
        public string EventDescription {get; set; }

        public Event(string ImgSrc, string EventName, string EventDescription){
            this.ImgSrc = ImgSrc;
            this.EventName = EventName;
            this.EventDescription = EventDescription;
        }

        public Event(){
            
        }

    }
}