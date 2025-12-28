/*Create a program to divide N number of chocolates among M children. Print the number of chocolates each child will get and also the remaining 
Chocolates*/

using System;

class ChocolateDistribution
{
	public static int[] DistributeChocolates(int chocolates, int children)
	{
		int each = chocolates / children;
		int remaining = chocolates % children;
		return new int[] { each, remaining };
	}
}
