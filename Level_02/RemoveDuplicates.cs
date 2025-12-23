using System;

class RemoveDuplicates
{
	public void ShowRemoveDuplicates()
	{
		string s = Console.ReadLine();
		string res = "";
		for(int i = 0; i < s.Length; i++)
		{
			if(!res.Contains(s[i]))
			{
				res += s[i];
			}
		}
		Console.WriteLine(res);
	}
}