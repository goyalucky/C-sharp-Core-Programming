/*Write a program that displays the current time in different time zones:
? GMT(Greenwich Mean Time)
? IST(Indian Standard Time)
? PST(Pacific Standard Time)
Hint: Use DateTimeOffset and TimeZoneInfo to work with different time zones.*/


using System;

public class TimeZoneService
{
	public void DisplayTimeZones()
	{
		DateTimeOffset utcTime = DateTimeOffset.UtcNow;
		TimeZoneInfo GMT = TimeZoneInfo.Utc;
		TimeZoneInfo IST = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
		TimeZoneInfo PST = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
		Console.WriteLine("GMT : " + TimeZoneInfo.ConvertTime(utcTime, GMT));
		Console.WriteLine("IST : " + TimeZoneInfo.ConvertTime(utcTime, IST));
		Console.WriteLine("PST : " + TimeZoneInfo.ConvertTime(utcTime, PST));
	}
}
