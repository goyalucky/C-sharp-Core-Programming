using System;

class CountDigit
{
	public void CountDigits()
	{
		int n = int.Parse(Console.ReadLine());
		int count = 0;
		if (n == 0)
		{
			count = 1;
		} else
		{
			while (n > 0)
			{
				n /= 10;
				count++;
			}
		}
		Console.WriteLine("Number of digits: " + count);
	}
}