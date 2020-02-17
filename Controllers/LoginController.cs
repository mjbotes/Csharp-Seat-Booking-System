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

namespace Csharp_Seat_Booking_System.Controllers
{
    public class LoginController : Controller
    {

        private readonly UserManager<IdentityUser> userManager;  
        private readonly SignInManager<IdentityUser> signInManager;  
  
        public LoginController(UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager){
            this.userManager =userManager;  
            this.signInManager = signInManager;
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

        [HttpPost]  
        public async Task<IActionResult> CompanyRegister(CompanyRegisterModel model)  
        {  
            if (ModelState.IsValid)  
            {  
                var user = new IdentityUser   
                {   
                    UserName=model.CompanyName,  
                    Email=model.CompanyEmail  
                };  
                var result = await userManager.CreateAsync(user, model.CompanyPassword);  
  
                if (result.Succeeded)  
                {  
                    await signInManager.SignInAsync(user, isPersistent: false);  
                    return RedirectToAction("Index", "Home");  
                }  
                foreach (var error in result.Errors)  
                {  
                    ModelState.AddModelError("",error.Description);  
                }  
            }  
            return View();  
        }

        public IActionResult CompanyProfile(){
            return View();
        }
        
    }
}