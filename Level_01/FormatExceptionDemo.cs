using System;

class FormatExceptionDemo
{
	public void ShowFormatException()
	{
		try
		{
			string s = Console.ReadLine();
			int number = int.Parse(s); 
			Console.WriteLine("Parsed number: " + number);
		}
		catch (FormatException ex)
		{
			Console.WriteLine("FormatException caught: " + ex.Message);
		}
	}
}