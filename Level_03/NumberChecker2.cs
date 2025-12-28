/*Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods

a.Method to find the count of digits in the number and a Method to Store the digits of
the number in a digits array

b. Method to reverse the digits array

c. Method to compare two arrays and check if they are equal

d. Method to check if a number is a palindrome using the Digits. A palindrome number
is a number that remains the same when its digits are reversed.

e. Method to Check if a number is a duck number using the digits array.A duck number
is a number that has a non-zero digit present in it*/


using System;

class NumberChecker2
{
	// a1. Method to count digits
	public static int CountDigits(int number)
	{
		number = Math.Abs(number);
		return number.ToString().Length;
	}

	// a2. Method to store digits in array
	public static int[] StoreDigits(int number)
	{
		number = Math.Abs(number);
		string str = number.ToString();
		int[] digits = new int[str.Length];

		for (int i = 0; i < str.Length; i++)
		{
			digits[i] = str[i] - '0';
		}
		return digits;
	}

	// b. Method to reverse digits array
	public static int[] ReverseArray(int[] arr)
	{
		int[] rev = new int[arr.Length];
		for (int i = 0; i < arr.Length; i++)
		{
			rev[i] = arr[arr.Length - 1 - i];
		}
		return rev;
	}

	// c. Method to compare two arrays
	public static bool CompareArrays(int[] a, int[] b)
	{
		if (a.Length != b.Length)
			return false;

		for (int i = 0; i < a.Length; i++)
		{
			if (a[i] != b[i])
				return false;
		}
		return true;
	}

	// d. Method to check palindrome
	public static bool IsPalindrome(int number)
	{
		int[] original = StoreDigits(number);
		int[] reversed = ReverseArray(original);
		return CompareArrays(original, reversed);
	}

	// e. Method to check duck number (as per given hint)
	// Duck Number: A number that has a NON-ZERO digit present in it
	public static bool IsDuckNumber(int[] digits)
	{
		foreach (int d in digits)
		{
			if (d != 0)
				return true;
		}
		return false;
	}
}