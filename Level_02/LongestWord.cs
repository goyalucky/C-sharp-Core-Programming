using System;

class LongestWord
{
	public void ShowLongestWord()
	{
		string s = Console.ReadLine();
		string[] words = s.Split(' ');
		string longest = "";
		for(int i = 0; i < words.Length; i++)
		{
			if(words[i].Length > longest.Length)
			{
				longest = words[i];
			}
		}
		Console.WriteLine("Longest word is: " + longest);
	}
}