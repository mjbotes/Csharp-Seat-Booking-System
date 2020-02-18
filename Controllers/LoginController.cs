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
        private const bool IsPersistent = false;  
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

  
        public LoginController( UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {

            this.userManager = userManager;
            this.signInManager = signInManager;

        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("ViewEvents", "Events");

        }
        
        public IActionResult Login(){

            return View();
        }

        [HttpGet]
        public IActionResult CompanyLogin(){

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
                var result = await signInManager.PasswordSignInAsync(model.UserEmail, model.UserPassword, IsPersistent, false);

                if(result.Succeeded)
                {

                    return RedirectToAction("ViewEvents", "Events");

                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                

            }

            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompanyLogin(UserLoginModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserEmail, model.UserPassword, IsPersistent, false);

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

                var user = new IdentityUser{UserName = model.UserEmail};
                var createdUser = await userManager.CreateAsync(user, model.UserPassword);

                if(createdUser.Succeeded)
                {

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
        public async Task<IActionResult> CompanyRegister(UserRegisterModel model){

            if(ModelState.IsValid)
            {

                var user = new IdentityUser{UserName = model.UserEmail};
                var createdUser = await userManager.CreateAsync(user, model.UserPassword);

                if(createdUser.Succeeded)
                {

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
    }
}