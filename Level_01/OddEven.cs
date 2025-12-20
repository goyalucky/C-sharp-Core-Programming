using System;

class OddEven
{
	public void CalculateOddEven(int number)
	{
		for (int i = 0; i <= number; i++) {
			bool isEven = (number % 2 == 0);
			if (isEven)
			{
				Console.WriteLine("The number " + number + " is even.");
			}
			else
			{
				Console.WriteLine("The number " + number + " is odd.");
			}
		}
	}
}