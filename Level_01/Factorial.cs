using System;

class Factorial
{
	public void CalculateFactorial()
	{
		Console.Write("Enter a positive integer: ");
		int number = int.Parse(Console.ReadLine());
		long factorial = 1;
		while (number > 1)
		{
			factorial *= number;
			number--;
		}
		Console.WriteLine($"The factorial is {factorial}");
	}
}