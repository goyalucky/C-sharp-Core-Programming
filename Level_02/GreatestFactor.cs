using System;

class GreatestFactor
{
	public void FindGreatestFactor()
	{
		int n = int.Parse(Console.ReadLine());
		int greatestFactor = 1;
		for (int i = n - 1; i >= 1; i--)
		{
			if (n % i == 0)
			{
				greatestFactor = i;
				break;
			}
		}
		Console.WriteLine("Greatest factor (besides itself): " + greatestFactor);
	}
}
