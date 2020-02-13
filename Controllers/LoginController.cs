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
    public class LoginController : Controller
    {
        public LoginController(){

        }

        public IActionResult Login(){
            return View();
        }

        public IActionResult Register(){
            return View();
        }

        public IActionResult UserRegister(){
            return View();
        }

        public IActionResult CompanyRegister(){
            return View();
        }
    }
}