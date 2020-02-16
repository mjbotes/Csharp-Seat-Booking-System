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
    public class CheckoutController : Controller
    {
        public string FullName = "Dee Ram";
        public IActionResult Checkout()
        {
            ViewData["FullName"] = "Hello " + FullName;
            return View();
        }
        public IActionResult ViewCart()
        {
            ViewData["FullName"] = "Hello " + FullName;
            return View();
        }

        public IActionResult PaymentSuccess()
        {
            return View();
        }

        public IActionResult PaymentFailed()
        {
            ViewData["Payment Failed"] = "Payment Failed";
            return View();
        }
    }
}