using System;

class DivisibleByFive
{
	public void Divisibility(int number)
	{
		bool result = (number % 5 == 0);
		Console.WriteLine("Is the number " + number + " divisible by 5? " + result);
	}
}
