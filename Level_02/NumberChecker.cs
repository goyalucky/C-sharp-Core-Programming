/*Write a program to take user input for 5 numbers and check whether a number is
positive or negative. Further for positive numbers check if the number is even or odd. Finally
compare the first and last elements of the array and display if they are equal, greater, or less*/


using System;

class NumberChecker
{
	// Check if the number is positive
	public bool IsPositive(int number)
	{
		return number >= 0;
	}

	// Check if the number is even
	public bool IsEven(int number)
	{
		return number % 2 == 0;
	}

	// Compare two numbers
	// Returns: 1 if num1 > num2, 0 if equal, -1 if num1 < num2
	public int Compare(int num1, int num2)
	{
		if (num1 > num2) return 1;
		else if (num1 == num2) return 0;
		else return -1;
	}
}
