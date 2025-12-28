//Write a program to find the smallest and the largest of the 3 numbers.


using System;

class SmallestLargest
{
	public static int[] FindSmallestAndLargest(int a, int b, int c)
	{
		int smallest = Math.Min(a, Math.Min(b, c));
		int largest = Math.Max(a, Math.Max(b, c));
		return new int[] { smallest, largest };
	}
}
