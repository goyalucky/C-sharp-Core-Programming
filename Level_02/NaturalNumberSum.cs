/*Write a program to find the sum of n natural numbers using recursive method and
compare the result with the formulae n*(n+1)/2 and show the result from both
computations is correct.*/


using System;

class NaturalNumberSum
{
	// Recursive method
	public static int RecursiveSum(int n)
	{
		if (n == 1)
			return 1;
		return n + RecursiveSum(n - 1);
	}

	// Formula method
	public static int FormulaSum(int n)
	{
		return n * (n + 1) / 2;
	}
}