using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Csharp_Seat_Booking_System.Models;
using Csharp_Seat_Booking_System.Services;

namespace Csharp_Seat_Booking_System.Controllers
{
    public class EventsController : Controller
    {
        public JsonFileProductService ProductService { get; }
        public EventsController(JsonFileProductService  productService)
        {
            this.ProductService = productService;
        }

        public IActionResult ViewEvents(){
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