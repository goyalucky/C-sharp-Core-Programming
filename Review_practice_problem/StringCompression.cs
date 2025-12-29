//Program to compress a string by replacing consecutive identical characters with the character followed by the count of its occurrences.


using System;

class StringCompression
{
	public void CompressString()
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