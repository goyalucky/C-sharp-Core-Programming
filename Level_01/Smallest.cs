using System;

class Smallest
{
	public void CheckSmallest(int number1, int number2, int number3)
	{
		bool result = (number1 < number2 && number1 < number3);
		Console.WriteLine("Is the first number the smallest? " + result);
	}
}
