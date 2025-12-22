//Create a program to store the digits of the number in an array and find the largest and
//second largest element of the array.


using System;

class StoreDigitinArray
{
	public void StoreDigits()
	{
		int n = Convert.ToInt32(Console.ReadLine());

		int temp = n;
		int digitCount = 0;

		while (temp > 0)
		{
			digitCount++;
			temp /= 10;
		}

		int[] digits = new int[digitCount];

		for (int i = digitCount - 1; i >= 0; i--)
		{
			digits[i] = n % 10;
			n /= 10;
		}

		Console.WriteLine("\nDigits in the number are:");
		for (int i = 0; i < digitCount; i++)
		{
			Console.Write(digits[i] + " ");
		}
		int l = digits[0];
		int sl = int.MinValue;

		for (int i = 1; i < digitCount; i++)
		{
			if (digits[i] > l)
			{
				sl = l;
				l = digits[i];
			}
			else if (digits[i] > sl && digits[i] != l)
			{
				sl = digits[i];
			}
		}
		Console.WriteLine("\n\nLargest digit: " + l);
		Console.WriteLine("Second largest digit: " + sl);
	}
}
