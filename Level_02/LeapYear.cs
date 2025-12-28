// Write a program that takes a year as input and outputs the Year is a Leap Year or not


using System;

class LeapYear
{
	// Method to check leap year
	public static bool IsLeapYear(int year)
	{
		if (year < 1582)
			return false;

		return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
	}
}
