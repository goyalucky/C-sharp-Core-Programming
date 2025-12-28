/* Write a program to generate a six-digit OTP number using Math.Random() method.
Validate the numbers are unique by generating the OTP number 10 times and ensuring all
the 10 OTPs are not the same
Hint =>
a. Write a method to Generate a 6-digit OTP number using Math.Random()
b.Create an array to save the OTP numbers generated 10 times
c. Write a method to ensure that the OTP numbers generated are unique. If unique
return true else return false*/


using System;

class OTPUtility
{
	// Static Random object
	private static Random random = new Random();

	// a. Method to generate a 6-digit OTP
	public static int GenerateOTP()
	{
		// Generates number between 100000 and 999999
		return random.Next(100000, 1000000);
	}

	// c. Method to check whether OTPs are unique
	public static bool AreOTPsUnique(int[] otps)
	{
		for (int i = 0; i < otps.Length; i++)
		{
			for (int j = i + 1; j < otps.Length; j++)
			{
				if (otps[i] == otps[j])
					return false;
			}
		}
		return true;
	}
}