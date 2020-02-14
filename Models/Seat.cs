using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Csharp_Seat_Booking_System.Models
{
    public class Seat
    {
        public int SeatCatergory;
        public int SeatXCordinate;
        public int SeatYCordinate;

        public Seat()
        {

        }

        public Seat(int SeatCatergory, int SeatXCordinate, int SeatYCordinate)
        {
            this.SeatCatergory = SeatCatergory;
            this.SeatXCordinate = SeatXCordinate;
            this.SeatYCordinate = SeatYCordinate;
        }
    }
}