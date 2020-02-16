using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Csharp_Seat_Booking_System.Models;

public class Venue
{
	private List<Seat> VenueLayout;

	public Venue(string Name, string FileName)
    {
		string[] FileArr = { "" };
		try
		{
			FileArr = System.IO.File.ReadAllLines(FileName);
		} catch(System.IO.FileNotFoundException)
        {
			Console.Out.WriteLine("But it does exist -_-");
        }
		int LineIndex = 0;
		int CharIndex = 0;
		VenueLayout = new List<Seat>();

		foreach (string LineInFile in FileArr)
        {
			char[] CharArr = LineInFile.ToCharArray();
			CharIndex = 0;
			foreach (char CharInLine in CharArr)
            {
				if (CharInLine != '0')
				{
					VenueLayout.Add(new Seat(CharInLine - '0', CharIndex, LineIndex));
				}
				CharIndex++;
            }
			LineIndex++;
        }
    }

	public List<Seat> GetLayout()
    {
		return VenueLayout;
    }
}
