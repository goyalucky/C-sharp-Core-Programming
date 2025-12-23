//Return All Characters Without Using ToCharArray()

using System;

class StringCharacters
{
	public void ShowCharacters()
	{
		string s = Console.ReadLine();

		char[] a = new char[s.Length];
		for (int i = 0; i < s.Length; i++)
		{
			a[i] = s[i];
		}

		char[] b = s.ToCharArray();

		for (int i = 0; i < a.Length; i++)
		{
			Console.Write(a[i] + " ");
		}
		Console.WriteLine();

		for (int i = 0; i < b.Length; i++)
		{
			Console.Write(b[i] + " ");
		}
	}
}
