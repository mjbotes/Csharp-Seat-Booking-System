using Microsoft.EntityFrameworkCore;
using Csharp_Seat_Booking_System.Models;

namespace Csharp_Seat_Booking_System.Data
{
    public class CsharpSeatBookingSystemContext : DbContext
    {
        public CsharpSeatBookingSystemContext (DbContextOptions<CsharpSeatBookingSystemContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyRegisterModel> User { get; set; }
    }
}

