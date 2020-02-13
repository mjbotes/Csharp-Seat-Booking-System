using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Csharp_Seat_Booking_System.Models;

namespace Csharp_Seat_Booking_System.Controllers
{
    public class EventsController : Controller
    {
        public List<Event> EventList = new List<Event>();

        public IActionResult ViewEvents(){
        EventList.Add(new Event("https://www.gstatic.com/tv/thumb/v22vodart/3542039/p3542039_v_v8_ac.jpg", "Avatar", "Its in IMAX"));
        EventList.Add(new Event("default", "Jexi", "Its in IMAX"));
        EventList.Add(new Event("default", "Terminator", "Its in IMAX"));
        ViewData["Events"] = EventList.ToArray();
        return View();
        }

        public IActionResult AddEvent(){
            return View();
        }
    }
}