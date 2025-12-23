using System;

class IndexOutOfRangeDemo
{
	public void ShowIndexOutOfRange()
	{
		try
		{
			string s = Console.ReadLine();
			Console.WriteLine(s[s.Length]); 
		}
		catch (IndexOutOfRangeException ex)
		{
			Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
		}
	}
}