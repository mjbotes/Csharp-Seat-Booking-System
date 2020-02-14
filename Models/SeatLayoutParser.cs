using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Csharp_Seat_Booking_System.Models;

public class CompanyController
{
	public SeatLayoutParser()
	{
	}

	public void ProcessSeatLayoutFile(string Name, string FileName)
    {
		string[] FileArr = System.IO.File.ReadAllLines(FileName);
		int LineIndex = 0;
		int CharIndex = 0;
		List Seats = new List<Seats>;

		foreach (string LineInFile in FileArr)
        {
			char[] CharArr = lineInFile.ToCharArray();
			CharIndex = 0;
			foreach (char CharInLine in CharArr)
            {
				Seats.Add(new Seat(CharInLine - '0', CharIndex, LineIndex));
				CharIndex++;
            }
			LineIndex++;
        }
    }
}
