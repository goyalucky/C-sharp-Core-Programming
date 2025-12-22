using System;

class FactorFinder
{
	public void FindAndDisplayFactors()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		if (n <= 0)
		{
			return;
		}
		int maxFactor = 10;
		int[] factors = new int[maxFactor];
		int index = 0;
		for (int i = 1; i <= n; i++)
		{
			if (n % i == 0)
			{
				if (index == maxFactor)
				{
					maxFactor = maxFactor * 2;
					int[] temp = new int[maxFactor];
					for (int j = 0; j < factors.Length; j++)
					{
						temp[j] = factors[j];
					}
					factors = temp;
				}
				factors[index] = i;
				index++;
			}
		}
		Console.WriteLine("\nFactors of " + n + " are:");
		for (int i = 0; i < index; i++)
		{
			Console.Write(factors[i] + " ");
		}
	}
}
