using System;

class Largest
{
	public void CheckLargest(int num1, int num2, int num3)
	{
		bool firstLargest = (num1 > num2 && num1 > num3);
		bool secondLargest = (num2 > num1 && num2 > num3);
		bool thirdLargest = (num3 > num1 && num3 > num2);

		Console.WriteLine("Is the first number the largest? " + firstLargest);
		Console.WriteLine("Is the second number the largest? " + secondLargest);
		Console.WriteLine("Is the third number the largest? " + thirdLargest);
	}
}
