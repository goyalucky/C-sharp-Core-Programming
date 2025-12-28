/*Create a program to find the youngest friends among 3 Amar, Akbar and Anthony
based on their ages and tallest among the friends based on their heights and display it*/


using System;

class Friends
{
	// Method to find the youngest friend
	public string FindYoungest(string[] names, int[] ages)
	{
		int minAge = ages[0];
		int index = 0;

		for (int i = 1; i < ages.Length; i++)
		{
			if (ages[i] < minAge)
			{
				minAge = ages[i];
				index = i;
			}
		}
		return names[index];
	}

	// Method to find the tallest friend
	public string FindTallest(string[] names, double[] heights)
	{
		double maxHeight = heights[0];
		int index = 0;

		for (int i = 1; i < heights.Length; i++)
		{
			if (heights[i] > maxHeight)
			{
				maxHeight = heights[i];
				index = i;
			}
		}
		return names[index];
	}
}
