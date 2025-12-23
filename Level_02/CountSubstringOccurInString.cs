using System;

class CountSubstringOccurInString
{
	public void CountSubstring()
	{
		string text = Console.ReadLine();
		string sub = Console.ReadLine();

		int count = 0;

		for (int i = 0; i <= text.Length - sub.Length; i++)
		{
			if (text.Substring(i, sub.Length) == sub)
			{
				count++;
			}
		}

		Console.WriteLine("Substring occurs " + count + " times");
	}
}