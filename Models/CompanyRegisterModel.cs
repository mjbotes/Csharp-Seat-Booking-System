using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Csharp_Seat_Booking_System.Models
{
    public class CompanyRegisterModel {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please Enter Company Email")]
        [EmailAddress]
        [Display(Name = "Company Email")]
        public string CompanyEmail { get; set; }


        [DataType(DataType.Password, ErrorMessage = "Password Format is incorrect")]
        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        public string CompanyPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please confirm password")]
        [Display(Name = "Confirm Password")]
        [Compare("CompanyPassword", ErrorMessage = "Passwords do not match.")]
        public string CompanyConfirmPassword { get; set; }

    }
}