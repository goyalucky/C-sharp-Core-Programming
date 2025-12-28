/* Write a program that:
? Takes two date inputs and compares them to check if the first date is
before, after, or the same as the second date.
Hint: Use DateTime.Compare(), DateTime.CompareTo(), or direct comparison using DateTime methods.*/


using System;

public class DateComparer
{
	public void CompareDates(string d1, string d2)
	{
		DateTime date1 = DateTime.ParseExact(d1, "dd-MM-yyyy", null);
		DateTime date2 = DateTime.ParseExact(d2, "dd-MM-yyyy", null);

		int result = DateTime.Compare(date1, date2);

		if (result < 0)
			Console.WriteLine("First date is BEFORE second date");
		else if (result > 0)
			Console.WriteLine("First date is AFTER second date");
		else
			Console.WriteLine("Both dates are SAME");
	}
}
