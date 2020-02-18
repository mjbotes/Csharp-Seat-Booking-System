using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Csharp_Seat_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Csharp_Seat_Booking_System.Data
{
    public class CsharpSeatBookingSystemContext : IdentityDbContext
    {
        public CsharpSeatBookingSystemContext (DbContextOptions<CsharpSeatBookingSystemContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyRegisterModel> BusinessUser { get; set; }

        public DbSet<UserRegisterModel> RegularUser { get; set; }

        
    }
}

