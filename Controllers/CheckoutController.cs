using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Csharp_Seat_Booking_System.Models;

namespace Csharp_Seat_Booking_System.Controllers
{
    public class CheckoutController : Controller
    {

        public string EventName = "Queen and Slim";
        public string Venue = "Cresta Sterkenikor";
        public int SeatCategoryGold = 5;
        public int SeatCategoryOrange = 5;
        public int SeatCategoryBlue = 5;
        public int SeatCategoryGoldPrice = 200;
        public int SeatCategoryOrangePrice = 150;
        public int SeatCategoryBluePrice = 100;
        
        public int NumberOfTickets;
        public int PriceOfTickets;


        [DataType(DataType.Date)]
        public DateTime BookingDate = DateTime.Now;
       
        [DataType(DataType.Time)]
        public DateTime BookingTime = DateTime.Now;
        public IActionResult Checkout()
        {
        
            ViewData["EventName"] = EventName;
            ViewData["BookingDate"] = BookingDate.ToString("dddd, dd MMMM yyyy");
            ViewData["BookingTime"] = BookingTime.ToString("HH:mm");
            ViewData["SeatCategoryGold"] = SeatCategoryGold;
            ViewData["SeatCategoryOrange"] = SeatCategoryOrange;
            ViewData["SeatCategoryBlue"] = SeatCategoryBlue;
            ViewData["SeatCategoryGoldPrice"] = SeatCategoryGoldPrice;
            ViewData["SeatCategoryOrangePrice"] = SeatCategoryOrangePrice;
            ViewData["SeatCategoryBluePrice"] = SeatCategoryBluePrice;

            return View();
        }
        public IActionResult ViewCart()
        {
        
            ViewData["EventName"] = EventName;
            ViewData["Venue"] = Venue;
            ViewData["BookingDate"] = BookingDate.ToString("dddd, dd MMMM yyyy");
            ViewData["BookingTime"] = BookingTime.ToString("HH:mm");
            ViewData["NumberOfTickets"] = SeatCategoryGold + SeatCategoryOrange + SeatCategoryBlue;
            ViewData["PriceOfTickets"] = (SeatCategoryGold*SeatCategoryGoldPrice) + (SeatCategoryOrange*SeatCategoryOrangePrice) + (SeatCategoryBlue*SeatCategoryBluePrice);

            return View();
        }

        public IActionResult PaymentSuccess()
        {
            
            return View();
        }

        public IActionResult PaymentFailed()
        {
            return View();
        }
    }
}