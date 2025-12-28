/* Create a program to find the factors of a number taken as user input, store the factors in
an array and display the factors. Also find the sum, sum of square of factors and product of
the factors and display the results*/


using System;

class FactorsOfNumber
{
	public void ShowFactors(int number)
	{
		int[] factors = new int[number]; // max possible size
		int count = 0;
		int sum = 0;
		int sumOfSquares = 0;
		long product = 1;

		// Find factors
		for (int i = 1; i <= number; i++)
		{
			if (number % i == 0)
			{
				factors[count++] = i;
				sum += i;
				sumOfSquares += i * i;
				product *= i;
			}
		}

		// Display factors
		Console.Write("Factors: ");
		for (int i = 0; i < count; i++)
		{
			Console.Write(factors[i] + " ");
		}

		Console.WriteLine("\nSum of factors: " + sum);
		Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
		Console.WriteLine("Product of factors: " + product);
	}
}
