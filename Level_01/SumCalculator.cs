using System;

class SumCalculator
{
	public void CalculateSum()
	{
		double total = 0.0;
		double number;
		number = Convert.ToDouble(Console.ReadLine());
		while (number != 0)
		{
			total += number;
			Console.WriteLine("Enter another number (0 to stop):");
			number = Convert.ToDouble(Console.ReadLine());
		}
		Console.WriteLine("The total sum is: " + total);
	}
}