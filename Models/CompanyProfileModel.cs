using System.ComponentModel.DataAnnotations;

namespace Csharp_Seat_Booking_System.Models
{
    public class CompanyProfileModel{

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Events")]
        public string CompanyEvents {get; set; }

        [Display(Name = "Venues and Seats")]
        public string CompanyVenuesAndSeats { get; set; }
    }
}