using System;

class Power
{
	public void CalculatePower()
	{
		int b = int.Parse(Console.ReadLine());
		int e = int.Parse(Console.ReadLine());
		int result = 1;
		for (int i = 1; i <= e; i++)
		{
			result *= b;
		}
		Console.WriteLine(result);
	}
}