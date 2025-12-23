using System;

class NullReferenceDemo
{
	public void ShowNullReference()
	{
		string s = null;
		try
		{
			Console.WriteLine("Length of the string: " + s.Length);
		}
		catch (NullReferenceException e)
		{
			Console.WriteLine("Caught a NullReferenceException: " + e.Message);
		}
	}
}