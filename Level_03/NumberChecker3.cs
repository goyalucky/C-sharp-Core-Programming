/*Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods

a.Method to Check if a number is a prime number. A prime number is a number greater
than 1 that has no positive divisors other than 1 and itself.

b. Method to Check if a number is a neon number. A neon number is a number where
the sum of digits of the square of the number is equal to the number itself

c. Method to Check if a number is a spy number. A number is called a spy number if the
sum of its digits is equal to the product of its digits

d. Method to Check if a number is an automorphic number. An automorphic number is a
number whose square ends with the number itself. E.g. 5 is an automorphic number

e. Method to Check if a number is a buzz number. A buzz number is a number that is
either divisible by 7 or ends with 7*/


using System;

class NumberChecker3
{
	// a. Check Prime Number
	public static bool IsPrime(int number)
	{
		if (number <= 1)
			return false;

		for (int i = 2; i <= Math.Sqrt(number); i++)
		{
			if (number % i == 0)
				return false;
		}
		return true;
	}

	// b. Check Neon Number
	// Neon number: sum of digits of (number^2) == number
	public static bool IsNeon(int number)
	{
		int square = number * number;
		int sum = 0;

		while (square > 0)
		{
			sum += square % 10;
			square /= 10;
		}
		return sum == number;
	}

	// c. Check Spy Number
	// Spy number: sum of digits == product of digits
	public static bool IsSpy(int number)
	{
		int sum = 0;
		int product = 1;

		while (number > 0)
		{
			int digit = number % 10;
			sum += digit;
			product *= digit;
			number /= 10;
		}
		return sum == product;
	}

	// d. Check Automorphic Number
	// Automorphic: square ends with the number itself
	public static bool IsAutomorphic(int number)
	{
		int square = number * number;
		return square.ToString().EndsWith(number.ToString());
	}

	// e. Check Buzz Number
	// Buzz number: divisible by 7 OR ends with 7
	public static bool IsBuzz(int number)
	{
		return (number % 7 == 0 || number % 10 == 7);
	}
}
