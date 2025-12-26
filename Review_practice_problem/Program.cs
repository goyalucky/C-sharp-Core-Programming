using System;

class Program
{
	static void Main(string[] args)
	{
		string s = "aaaabbbccd";
		int count = 1;
		System.Text.StringBuilder result = new System.Text.StringBuilder();
		for (int i = 1; i <= s.Length; i++)
		{
			if (i < s.Length && s[i] == s[i - 1])
			{
				count++;
			}
			else
			{
				result.Append(s[i - 1]).Append(count);
				count = 1;
			}
		}
		Console.WriteLine(result.ToString());
	}
}