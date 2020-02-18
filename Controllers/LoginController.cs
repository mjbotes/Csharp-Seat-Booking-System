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
using System.Data.Common;

namespace Csharp_Seat_Booking_System.Controllers
{
    public class LoginController : Controller
    {

        private readonly CsharpSeatBookingSystemContext Database;  
        private readonly SignInManager<IdentityUser> SignInManager;
  
        public LoginController(CsharpSeatBookingSystemContext Database, SignInManager<IdentityUser> SignInManager)
        {
            this.Database = Database;
            this.SignInManager = SignInManager;
        }

        // [HttpGet]
        public IActionResult Login(){
            return View();
        }

        [HttpGet]
        public IActionResult UserLogin(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserLogin(UserLoginModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await SignInManager.PasswordSignInAsync(model.UserEmail, model.UserPassword, false, false);

                if(result.Succeeded)
                {
                    return RedirectToAction("ViewEvents", "Events");
                }

                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                

            }
            return View(model);

            

        }

        public IActionResult Register(){
            return View();
        }

        [HttpGet]
        public IActionResult UserRegister(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UserRegister(UserRegisterModel model){
            try{
                if(ModelState.IsValid)
                {
                    this.Database.Add(model);
                    this.Database.SaveChanges();
                    return RedirectToAction("ViewEvents", "Events");
                }
            }
            catch(Exception error){
                ViewBag.message = error.Message;
                return View();
            }

            return View();
        }

        [HttpGet]
        public IActionResult CompanyRegister(){
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]  
        public IActionResult CompanyRegister(CompanyRegisterModel model)  
        {
            try
            {

                if(ModelState.IsValid)
                {
                    this.Database.Add(model);
                    this.Database.SaveChanges();
                    return RedirectToAction("ViewEvents", "Events");
                }
            }
            catch(Exception error)
            {
                ViewBag.message = error.Message;
                return View();
            }
            return View();

        }

        public IActionResult CompanyProfile(){
            return View();
        }
        
    }
}