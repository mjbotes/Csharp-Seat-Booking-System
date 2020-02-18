using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Csharp_Seat_Booking_System.Models;
using Csharp_Seat_Booking_System.Data;
using Microsoft.EntityFrameworkCore.Storage;

namespace Csharp_Seat_Booking_System.Controllers
{
    public class LoginController : Controller
    {

        private readonly CsharpSeatBookingSystemContext _businessUser;  
  
        public LoginController(CsharpSeatBookingSystemContext businessUser)
        {
            _businessUser = businessUser;
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

        [HttpGet]
        public IActionResult CompanyRegister(){
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]  
        public IActionResult CompanyRegister(CompanyRegisterModel model)  
        {
            if(ModelState.IsValid)
            {
            _businessUser.Add(model);
            _businessUser.SaveChanges();
            ViewBag.message = "The User " + model.CompanyName + " Is Saved Successfully";
             return RedirectToAction("ViewEvents", "Events");
            }
            return View();

        }

        public IActionResult CompanyProfile(){
            return View();
        }
        
    }
}