using System;

class ReverseString
{
	public void ShowReverseString()
	{
		string s = Console.ReadLine();
		string res = "";
		for(int i = s.Length - 1; i >= 0; i--)
		{
			res += s[i];
		}
		Console.WriteLine(res);
	}
}