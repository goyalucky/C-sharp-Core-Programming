/*Create a program that:
? Takes a date input and adds 7 days, 1 month, and 2 years to it.
? Then subtracts 3 weeks from the result.
Hint: Use DateTime.AddDays(), DateTime.AddMonths(), DateTime.AddYears(), and DateTime.AddWeeks() methods.*/


using System;

public class DateCalculator
{
	public void CalculateDate(string input)
	{
		DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", null);
		DateTime result = date
			.AddDays(7)
			.AddMonths(1)
			.AddYears(2)
			.AddDays(-21);   
		Console.WriteLine("Final Date: " + result.ToString("dd-MM-yyyy"));
	}
}
