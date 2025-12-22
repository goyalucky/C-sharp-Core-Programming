//Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on
//their ages and the tallest among the friends based on their heights

using System;

class FriendsComparison
{
	public void CompareFriends()
	{
		string[] names = ["Amar", "Akbar", "Anthony"];
		int[] age = new int[3];
		double[] height = new double[3];

		for(int i = 1; i < 3; i++)
		{
			Console.WriteLine(names[i]);
			age[i] = Convert.ToInt32(Console.ReadLine());
			height[i] = Convert.ToDouble(Console.ReadLine());
		}
		int youngidx = 0;
		int talleidx = 0;
		for(int i = 1; i < 3; i++)
		{
			if(age[i] < age[youngidx])
			{
				youngidx = i;
			}
			if(height[i] > height[talleidx])
			{
				talleidx = i;
			}
		}
		Console.WriteLine("Youngest Friend: " + names[youngidx]);
		Console.WriteLine("Tallest Friend: " + names[talleidx]);
	}
}