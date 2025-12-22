using System;

class Voting
{
	public void CheckEligibilty()
	{
		for(int i = 1; i <= 10; i++)
		{
		int age = Convert.ToInt32(Console.ReadLine());
			if (age >= 18)
			{
				Console.WriteLine(" Student " + i + " Eligible to vote ");
			}
			else
			{
				Console.WriteLine(" Student " + i + " Not Eligible to vote ");
			}
		}
	}
}