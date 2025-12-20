using System;

class ArmstrongCheck
{
	public void CheckArmstrong()
	{
		int number = int.Parse(Console.ReadLine());

		int origNumber = number;
		int sum = 0;
		int digits = number.ToString().Length;
		while (number > 0)
		{
			int digit = number % 10;
			sum += (int)Math.Pow(digit, digits);
			number /= 10;
		}
		if (sum == origNumber)
			Console.WriteLine($"{origNumber} is an Armstrong number.");
		else
			Console.WriteLine($"{origNumber} is not an Armstrong number.");
	}
}