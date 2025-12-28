//Write a program to find the sum of n natural numbers using loop


using System;

class SumOfNaturalNo
{
	public void ShowSumOfNaturalNo()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int sum = 0;
		for (int i = 1; i <= n; i++)
		{
			sum += i;
		}
		Console.WriteLine("Sum of first " + n + " natural numbers is: " + sum);
	}
}