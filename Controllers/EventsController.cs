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
        EventList.Add(new Event("https://lh3.googleusercontent.com/proxy/3CdejYgpHivKQgMH8mICvlDUEwluwy5fDbNnpFilOqcTIX72Yhc8CPm-iABdRzGS-80T091jqV3frPP9W8tRikb0nEJHkIDPxq1_", "Jexi", "Its in IMAX"));
        EventList.Add(new Event("default", "Terminator", "Its in IMAX"));
        ViewData["Events"] = EventList.ToArray();
        return View();
        }

        public IActionResult AddEvent(){
            return View();
        }

        public IActionResult SeatSelection(){
        //must be get to get the movie being booked
           Venue CurrentVenue = new Venue("Test", "SeatTest.txt");
            List<Seat> TestList = CurrentVenue.GetLayout();
            foreach (Seat Test in TestList)
            {
                Console.Out.WriteLine(Test);
            }
            ViewData["arr"] = TestList;
            return View();
        }

        [HttpPost]
        public IActionResult AddSeatsToCart(string SeatListJson)
        {
            Console.WriteLine("im HERTR");
            if (SeatListJson == null)
            {
                return BadRequest();
            }

            Console.Out.WriteLine(SeatListJson);
            return View();
        }
    }
}