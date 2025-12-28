/*Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods

a.Method to find the count of digits in the number and a Method to Store the digits of
the number in a digits array

b. Method to find the sum of the digits of a number using the digits array

c.Method to find the sum of the squares of the digits of a number using the digits array.
Use Math.Pow() method

d.Method to Check if a number is a Harshad number using a digits array.A number is
called a Harshad number if it is divisible by the sum of its digits. For e.g. 21

e. Method to find the frequency of each digit in the number. Create a 2D array to store
the frequency with digit in the first column and frequency in the second column.*/


using System;

public static class NumberChecker1
{
	// a. Count digits
	public static int CountDigits(int number)
	{
		int count = 0;
		while (number > 0)
		{
			count++;
			number /= 10;
		}
		return count;
	}

	// a. Store digits in array
	public static int[] StoreDigits(int number)
	{
		int count = CountDigits(number);
		int[] digits = new int[count];

		for (int i = count - 1; i >= 0; i--)
		{
			digits[i] = number % 10;
			number /= 10;
		}
		return digits;
	}

	// b. Sum of digits
	public static int SumOfDigits(int[] digits)
	{
		int sum = 0;
		foreach (int d in digits)
		{
			sum += d;
		}
		return sum;
	}

	// c. Sum of squares of digits
	public static int SumOfSquares(int[] digits)
	{
		int sum = 0;
		foreach (int d in digits)
		{
			sum += (int)Math.Pow(d, 2);
		}
		return sum;
	}

	// d. Harshad number check
	public static bool IsHarshadNumber(int number, int[] digits)
	{
		int sum = SumOfDigits(digits);
		return number % sum == 0;
	}

	// e. Digit frequency using 2D array
	public static void PrintDigitFrequency(int[] digits)
	{
		int[,] freq = new int[10, 2];

		for (int i = 0; i < 10; i++)
		{
			freq[i, 0] = i;     // digit
			freq[i, 1] = 0;     // frequency
		}

		foreach (int d in digits)
		{
			freq[d, 1]++;
		}

		Console.WriteLine("\nDigit Frequency:");
		for (int i = 0; i < 10; i++)
		{
			if (freq[i, 1] > 0)
			{
				Console.WriteLine("Digit " + freq[i, 0] + " -> " + freq[i, 1]);
			}
		}
	}
}
