using System;

	class MultiplesFinder
	{
		public void FindMultiples(int number)
		{
			for (int i = 100; i >= 1; i--)
			{
				if (i % number == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}

