using System;

class FizzBuzzProgram
{
	public void RunFizzBuzz()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		string[] results = new string[n + 1];
		for (int i = 1; i <= n; i++)
		{
			if (i % 3 == 0 && i % 5 == 0)
			{
				results[i] = "FizzBuzz";
			}
			else if (i % 3 == 0)
			{
				results[i] = "Fizz";
			}
			else if (i % 5 == 0)
			{
				results[i] == "Buzz";
			}
			else
			{
				results[i].ToString();
			}
		}
		for(int i = 1; i <= n; i++)
		{
			Console.WriteLine("Position" + i + " = " + results[i]);
		}
	}
}