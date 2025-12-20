using System;

class FriendsComparison
{
	public void FindYoungestAndTallest()
	{
		int amarAge = int.Parse(Console.ReadLine());
		int akbarAge = int.Parse(Console.ReadLine());
		int anthonyAge = int.Parse(Console.ReadLine());
		int amarHeight = int.Parse(Console.ReadLine());
		int akbarHeight = int.Parse(Console.ReadLine());
		int anthonyHeight = int.Parse(Console.ReadLine());

		string youngest;
		int minAge = amarAge;

		youngest = "Amar";

		if (akbarAge < minAge)
		{
			minAge = akbarAge;
			youngest = "Akbar";
		}
		if (anthonyAge < minAge)
		{
			minAge = anthonyAge;
			youngest = "Anthony";
		}

		string tallest;
		int maxHeight = amarHeight;

		tallest = "Amar";

		if (akbarHeight > maxHeight)
		{
			maxHeight = akbarHeight;
			tallest = "Akbar";
		}
		if (anthonyHeight > maxHeight)
		{
			maxHeight = anthonyHeight;
			tallest = "Anthony";
		}

		Console.WriteLine("\nYoungest Friend: " + youngest);
		Console.WriteLine("Tallest Friend: " + tallest);
	}
}