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

        public DbSet<UserRegisterModel> User { get; set; }

        
    }
}

