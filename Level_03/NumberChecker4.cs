/* Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods

a.Method to find factors of a number and return them as an array. Note there are 2 for
loops one for the count and another for finding the factor and storing in the array

b. Method to find the greatest factor of a Number using the factors array

c.Method to find the sum of the factors using factors array and return the sum

d. Method to find the product of the factors using factors array and return the product

e. Method to find product of cube of the factors using the factors array.Use Math.Pow()

f.Method to Check if a number is a perfect number. Perfect numbers are positive
integers that are equal to the sum of their proper divisors

g. Method to find the number is an abundant number. A number is called an abundant
number if the sum of its proper divisors is greater than the number itself

h. Method to find the number is a deficient number. A number is called a deficient
number if the sum of its proper divisors is less than the number itself

i. Method to Check if a number is a strong number. A number is called a strong number
if the sum of the factorial of its digits is equal to the number itself */


using System;

class NumberChecker4
{
	// a. Method to find factors of a number and return as array
	public static int[] GetFactors(int number)
	{
		int count = 0;
		// First loop: count factors
		for (int i = 1; i <= number; i++)
		{
			if (number % i == 0)
				count++;
		}

		int[] factors = new int[count];
		int index = 0;

		// Second loop: store factors
		for (int i = 1; i <= number; i++)
		{
			if (number % i == 0)
				factors[index++] = i;
		}

		return factors;
	}

	// b. Greatest factor using factors array
	public static int GreatestFactor(int[] factors)
	{
		return factors[factors.Length - 1];
	}

	// c. Sum of factors
	public static int SumOfFactors(int[] factors)
	{
		int sum = 0;
		foreach (int f in factors)
			sum += f;
		return sum;
	}

	// d. Product of factors
	public static long ProductOfFactors(int[] factors)
	{
		long product = 1;
		foreach (int f in factors)
			product *= f;
		return product;
	}

	// e. Product of cube of factors
	public static double ProductOfCubeOfFactors(int[] factors)
	{
		double product = 1;
		foreach (int f in factors)
			product *= Math.Pow(f, 3);
		return product;
	}

	// f. Check Perfect Number
	public static bool IsPerfect(int number)
	{
		int sum = 0;

		for (int i = 1; i < number; i++)
		{
			if (number % i == 0)
				sum += i;
		}

		return sum == number;
	}

	// g. Check Abundant Number
	public static bool IsAbundant(int number)
	{
		int sum = 0;

		for (int i = 1; i < number; i++)
		{
			if (number % i == 0)
				sum += i;
		}

		return sum > number;
	}

	// h. Check Deficient Number
	public static bool IsDeficient(int number)
	{
		int sum = 0;

		for (int i = 1; i < number; i++)
		{
			if (number % i == 0)
				sum += i;
		}

		return sum < number;
	}

	// i. Check Strong Number
	public static bool IsStrong(int number)
	{
		int temp = number;
		int sum = 0;

		while (temp > 0)
		{
			int digit = temp % 10;
			sum += Factorial(digit);
			temp /= 10;
		}

		return sum == number;
	}

	// Helper method for factorial
	private static int Factorial(int n)
	{
		int fact = 1;
		for (int i = 1; i <= n; i++)
			fact *= i;
		return fact;
	}
}