/*Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods -

a.Method to Find the count of digits in the number

b. Method to Store the digits of the number in a digits array

c. Method to Check if a number is a duck number using the digits array.A duck number
is a number that has a non-zero digit present in it

d. Method to check if the number is an armstrong number using the digits array.
Armstrong number is a number that is equal to the sum of its own digits raised to the power
of the number of digits. Eg: 153 = 1 ^ 3 + 5 ^ 3 + 3 ^ 3

e.Method to find the largest and second largest elements in the digits array. Use
Int32.MinValue to initialize the variable.

f. Method to find the smallest and second smallest elements in the digits array. Use
Int32.MaxValue to initialize the variable.*/



using System;

public static class NumberChecker
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

	// b. Store digits in array
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

	// c. Duck number check (contains non-zero digit)
	public static bool IsDuckNumber(int[] digits)
	{
		foreach (int d in digits)
		{
			if (d != 0)
				return true;
		}
		return false;
	}

	// d. Armstrong number check
	public static bool IsArmstrong(int number, int[] digits)
	{
		int sum = 0;
		int power = digits.Length;

		foreach (int d in digits)
		{
			sum += (int)Math.Pow(d, power);
		}

		return sum == number;
	}

	// e. Largest & second largest
	public static void FindLargestAndSecondLargest(int[] digits)
	{
		int largest = Int32.MinValue;
		int secondLargest = Int32.MinValue;

		foreach (int d in digits)
		{
			if (d > largest)
			{
				secondLargest = largest;
				largest = d;
			}
			else if (d > secondLargest && d != largest)
			{
				secondLargest = d;
			}
		}

		Console.WriteLine("Largest Digit: " + largest);
		Console.WriteLine("Second Largest Digit: " + secondLargest);
	}

	// f. Smallest & second smallest
	public static void FindSmallestAndSecondSmallest(int[] digits)
	{
		int smallest = Int32.MaxValue;
		int secondSmallest = Int32.MaxValue;

		foreach (int d in digits)
		{
			if (d < smallest)
			{
				secondSmallest = smallest;
				smallest = d;
			}
			else if (d < secondSmallest && d != smallest)
			{
				secondSmallest = d;
			}
		}
		Console.WriteLine("Smallest Digit: " + smallest);
		Console.WriteLine("Second Smallest Digit: " + secondSmallest);
	}
}
