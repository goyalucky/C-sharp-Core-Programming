//Write a program that calculates the factorial of a number using a recursive function.


using System;

class FactorialRecursion
{
	//method to calculate factorial using recursively
	public static int CalcFactorial(int m)
	{
		if(m == 0 || m == 1)
		{
			return 1;
		}
		int f1 = CalcFactorial(m - 1);
		int f2 = m * CalcFactorial(m - 1);
		return f2;
	}
}