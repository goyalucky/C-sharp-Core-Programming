 // Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.


using System;

class SimpleInterest
{
	// Method to calculate simple interest
	public void CalculateSimpleInterest()
	{
		//take Principal as a input from the user
		int p = Convert.ToInt32(Console.ReadLine());
		// take Rate as a input from the user
		int r = Convert.ToInt32(Console.ReadLine());
		//take time as a input from the user
		int t = Convert.ToInt32(Console.ReadLine());
		// calculate simple interest
		double si = (p * r * t) / 100.0;
		Console.WriteLine("Simple Interest: " + si);
	}
}