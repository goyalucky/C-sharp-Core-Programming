using System;

class SumCalculatorBreak
{
	public void CalSum()
	{
		double total = 0.0;
		double number;
		while(true)
		{
			number = Convert.ToDouble(Console.ReadLine());
			if (number <= 0)
			{
				break;
			}
			total += number;
			Console.WriteLine("Enter another number (0 or negative to stop):");
		}
		Console.WriteLine("The total sum is: " + total);
	}
}