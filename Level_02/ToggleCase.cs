using System;

class ToggleCase
{
	public void ShowToggleCase()
	{
		string s = Console.ReadLine();
		for(int i=0;i< s.Length; i++)
		{
			if(Char.IsUpper(s[i]))
			{
				Console.Write(Char.ToLower(s[i]));
			}
			else if(Char.IsLower(s[i]))
			{
				Console.Write(Char.ToUpper(s[i]));
			}
			else
			{
				Console.Write(s[i]);
			}
		}
	}
}