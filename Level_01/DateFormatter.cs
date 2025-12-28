/*Write a program that:
? Displays the current date in three different formats:
o dd/MM/yyyy
o yyyy-MM-dd
o EEE, MMM dd, yyyy
Hint: Use DateTime.ToString() with custom date format strings.*/



using System;

public class DateFormatter
{
	public void ShowFormats()
	{
		DateTime today = DateTime.Now;

		Console.WriteLine("dd/MM/yyyy     : " + today.ToString("dd/MM/yyyy"));
		Console.WriteLine("yyyy-MM-dd     : " + today.ToString("yyyy-MM-dd"));
		Console.WriteLine("EEE, MMM dd, yyyy : " + today.ToString("ddd, MMM dd, yyyy"));
	}
}
