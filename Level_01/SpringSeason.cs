/*Write a program SpringSeason that takes two int values month and day from the
command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season”.*/


using System;

class SpringSeason
{
	public static bool ShowSpringSeason(int month,int day)
	{
		if ((month == 3 && day >= 20) ||
		   (month == 4) ||
		   (month == 5) ||
		   (month == 6 && day <= 20))
		{
			return true;
		}
		return false;
	}
}