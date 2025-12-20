using System;

class MultiplicationTable
{
	public void PrintTable(int number)
	{
		for(int i = 6; i <= 9; i++)
		{
			console.Writeline(number + "*" + i + "=" + (number * i));
		}
	}
}