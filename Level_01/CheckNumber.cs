// Write a program to check whether a number is positive, negative, or zero.


using System;

class CheckNumber
{
	// This method checks whether a number is negative, positive, or zero
	// Returns:
	// -1 ? Negative number
	//  1 ? Positive number
	//  0 ? Zero
	public int NumberCheck(int n)
	{
		if (n < 0)        // Check if number is negative
			return -1;
		else if (n > 0)   // Check if number is positive
			return 1;
		else              // Number is zero
			return 0;
	}
}
