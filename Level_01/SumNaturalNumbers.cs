using System;

public class SumNaturalNumbers
{
	public void SumNatNum()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		if (n <= 0)
		{
			Console.WriteLine("Input is not a natural number.");
			return;
		}
		int sumLoop = 0;
		int i = 1;
		while (i <= n)
		{
			sumLoop += i;
			i++;
		}
		int sumFormula = n * (n + 1) / 2;
		if (sumLoop == sumFormula)
		{
			Console.WriteLine("Both results are correct and equal.");
		}
		else
		{
			Console.WriteLine("There is a mismatch in results.");
		}
	}
}
