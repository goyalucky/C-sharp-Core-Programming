
//Create a program to take a number as input and reverse the number. To do this, store the
//digits of the number in an array and display the array in reverse order

using System;

class ReverseNumberDigitArray
{
	public void ReverseDigits()
	{
		Console.Write("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		int temp = number;
		int digitCount = 0;
		while (temp > 0)
		{
			digitCount++;
			temp /= 10;
		}
		int[] digits = new int[digitCount];
		for (int i = 0; i < digitCount; i++)
		{
			digits[i] = number % 10;
			number /= 10;
		}
		Console.WriteLine("\nDigits in reverse order:");
		for (int i = 0; i < digitCount; i++)
		{
			Console.Write(digits[i] + " ");
		}
	}
}