using System;

	class Factors
	{
		public void PrintFactors()
		{
			Console.Write("Enter a number: ");
			if (!int.TryParse(Console.ReadLine(), out int number))
			{
				Console.WriteLine("Invalid input");
				return;
			}
			for (int i = 1; i < number; i++)
			{
				if (number % i == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}

