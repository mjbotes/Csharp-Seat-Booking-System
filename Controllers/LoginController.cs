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

        // private readonly CsharpSeatBookingSystemContext Database;  
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

  
        public LoginController(/*CsharpSeatBookingSystemContext Database,*/ UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            // this.Database = Database;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        
        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("ViewEvents", "Events");
        }

        [HttpGet]
        public IActionResult UserLogin(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserLogin(UserLoginModel model)
        {
            if(ModelState.IsValid)
            {
                // signInManager.
                var result = await signInManager.PasswordSignInAsync(model.UserEmail, model.UserPassword, false, false);

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
        public async Task<IActionResult> UserRegister(UserRegisterModel model){

            if(ModelState.IsValid)
            {
                // this.Database.Add(model);
                // this.Database.SaveChanges();
                // return RedirectToAction("ViewEvents", "Events");
                var user = new IdentityUser{
                    UserName = model.UserName,
                    Email = model.UserEmail
                };
                var createdUser = await userManager.CreateAsync(user, model.UserPassword);

                if(createdUser.Succeeded){
                    await signInManager.SignInAsync(user, isPersistent :false);
                    return RedirectToAction("ViewEvents", "Events");
                }

                foreach(var error in createdUser.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
            
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
                    // this.Database.Add(model);
                    // this.Database.SaveChanges();
                    // return RedirectToAction("ViewEvents", "Events");
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