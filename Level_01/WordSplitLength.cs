using System;

class WordSplitLength
{
	public string[] SplitWords(string s)
	{
		return s.Split(' ');
	}

	public int GetLength(string w)
	{
		return w.Length;
	}

	public void DisplayWordsAndLengths()
	{
		string s = Console.ReadLine();
		string[] a = SplitWords(s);

		for (int i = 0; i < a.Length; i++)
		{
			if (a[i] != "")
				Console.WriteLine(a[i] + " : " + GetLength(a[i]));
		}
	}
}
