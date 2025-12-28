/* Write a program that takes three integer inputs from the user and finds the maximum of the three numbers. */


using System;

class MaximumOfThree
{
	// Method to find the maximum of three numbers
	public static int FindMaximum(int a, int b, int c)
	{
		return Math.Max(a, Math.Max(b, c));
	}
}