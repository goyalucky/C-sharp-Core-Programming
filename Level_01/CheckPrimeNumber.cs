//Create a program that checks whether a given number is a prime number.


using System;

class CheckPrimeNumber
{
	// Method to check if a number is prime
	public void IsPrime(int number)
	{
		if (number <= 1)
		{
			Console.WriteLine($"{number} is not a prime number.");
			return;
		}
		for (int i = 2; i <= Math.Sqrt(number); i++)
		{
			if (number % i == 0)
			{
				Console.WriteLine($"{number} is not a prime number.");
				return;
			}
		}
		Console.WriteLine($"{number} is a prime number.");
	}
}