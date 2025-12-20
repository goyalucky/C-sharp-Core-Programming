using System;

class NaturalNumber
{
	public void SumNaturalNumbers()
	{
		int n = int.Parse(Console.ReadLine());
		int sum = n*(n+1)/2;
		if(n > 0)
		{
			console.WriteLine($"The sum of {n} natural numbers is {sum}");
		}
		else
		{
			console.WriteLine($"The number {n}is not a natural number");
		}
	}
}