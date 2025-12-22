using System;

class DigitFrequency
{
	public void FindFrequency()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int temp = n;
		int count = 0;

		if (temp == 0)
			count = 1;
		else
		{
			while (temp > 0)
			{
				count++;
				temp /= 10;
			}
		}

		int[] digits = new int[count];
		temp = n;

		for (int i = count - 1; i >= 0; i--)
		{
			digits[i] = temp % 10;
			temp /= 10;
		}

		int[] frequency = new int[10];

		for (int i = 0; i < count; i++)
		{
			frequency[digits[i]]++;
		}

		Console.WriteLine("\nDigit Frequency:");
		for (int i = 0; i < 10; i++)
		{
			if (frequency[i] > 0)
				Console.WriteLine($"Digit {i} : {frequency[i]}");
		}
	}
}
