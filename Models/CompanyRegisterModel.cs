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

        [Required(ErrorMessage = "Please insert Company Name")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please insert Company Email")]
        [EmailAddress]
        [Display(Name = "Company Email")]
        public string CompanyEmail { get; set; }

        [Required(ErrorMessage = "Please insert Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string CompanyPassword { get; set; }

        [Required(ErrorMessage = "Please confirm password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("CompanyPassword", ErrorMessage = "Passwords do not match.")]
        public string CompanyConfirmPassword { get; set; }

    }
}