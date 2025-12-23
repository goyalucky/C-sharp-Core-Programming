//NullReferenceDe

using System;

class StringComparison
{
	public void CompareStrings()
	{
		string s = Console.ReadLine();
		string t = Console.ReadLine();
		 bool result = string.Equals(s, t);
		Console.WriteLine(result);
	}
}