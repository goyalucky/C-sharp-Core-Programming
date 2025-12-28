//Create a program that calculates the Greatest Common Divisor (GCD) and Least Common Multiple (LCM) of two numbers using functions.


using System;


class GCDandLCMCalculator
{
	// Method to calculate GCD using Euclidean algorithm
	public int CalculateGCD(int d, int e)
	{
		while (e != 0)
		{
			int temp = e;
			e = d % e;
			d = temp;
		}
		return d;
	}
	// Method to calculate LCM
	public int CalculateLCM(int d, int e,int hcf)
	{
		return (d * e) / hcf;
	}
}