using System;
using System.ComponentModel.DataAnnotations;

namespace Checkout.Models
{
    public class CheckoutInformation
    {
        public string FullName {get; set;}
        public int NumberOfSeats {get; set;}
        public decimal Price {get; set;}
        public string BookingFor {get; set;}
        [DataType(DataType.Date)]
        public DateTime BookingDate {get; set;}
        [DataType(DataType.Time)]
        public DateTime BookingTime {get; set;}

    }
}