/* Write a program that generates the Fibonacci sequence up to a specified number of terms entered by the user.*/


using System;

class FibonacciSequence
{
	// Method to generate Fibonacci sequence up to n terms
	public void GenerateFibonacci(int n)
	{
		int a = 0;
		int b = 1;
		Console.Write(a + " " + b + " ");
		for(int i=2; i < n; i++)
		{
			int c = a + b;
			Console.Write(c + " ");
			a = b;
			b = c;
		}
	}
}