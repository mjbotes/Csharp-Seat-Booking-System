using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Csharp_Seat_Booking_System.Models
{
    public class Seat
    {
        private int SeatCatergory;
        public int SeatXCordinate;
        public int SeatYCordinate;

        public Seat()
        {

        }

        public int GetXCordinate()
        {
            return SeatXCordinate;
        }

        public int GetYCordinate()
        {
            return SeatYCordinate;
        }

        public int GetCatergory()
        {
            return SeatCatergory;
        }

        public Seat(int SeatCatergory, int SeatXCordinate, int SeatYCordinate)
        {
            this.SeatCatergory = SeatCatergory;
            this.SeatXCordinate = SeatXCordinate;
            this.SeatYCordinate = SeatYCordinate;
        }
        
        public override string ToString()
        {
            return SeatCatergory + "\t" + SeatXCordinate + "\t" + SeatYCordinate;
        }
    }
}