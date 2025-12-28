/* Create a program to find the shortest, tallest, and mean height of players present in a
football team.

a. The formula to calculate the mean is: mean = sum of all elements/number of
elements
b. Create an int array named heights of size 11 and get 3 digits random height in cms for
each player in the range 150 cms to 250 cms
c. Write the method to Find the sum of all the elements present in the array.
d. Write the method to find the mean height of the players on the football team
e. Write the method to find the shortest height of the players on the football team
f. Write the method to find the tallest height of the players on the football team
g. Finally display the results
*/


using System;

public class FootballTeam
{
	private int[] heights = new int[11];

	public void GenerateHeights()
	{
		Random random = new Random();
		for (int i = 0; i < heights.Length; i++)
		{
			heights[i] = random.Next(150, 251);
		}
	}

	public void DisplayHeights()
	{
		Console.WriteLine("Player Heights (cm):");
		foreach (int h in heights)
		{
			Console.Write(h + " ");
		}
		Console.WriteLine();
	}

	public int FindSum()
	{
		int sum = 0;
		foreach (int h in heights)
		{
			sum += h;
		}
		return sum;
	}

	public double FindMean()
	{
		return (double)FindSum() / heights.Length;
	}

	public int FindShortest()
	{
		int min = heights[0];
		foreach (int h in heights)
		{
			if (h < min)
				min = h;
		}
		return min;
	}

	public int FindTallest()
	{
		int max = heights[0];
		foreach (int h in heights)
		{
			if (h > max)
				max = h;
		}
		return max;
	}
}
