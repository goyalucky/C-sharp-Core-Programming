using System;

class SubstringCharAt
{
	public void ExtractSubstringAndCharAt()
	{
		string s = Console.ReadLine();
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		string x = "";

		for (int i = a; i < b; i++)
		{
			x+= s[i];
		}
		string y = s.Substring(a, b - a);
		Console.WriteLine(x);
		Console.WriteLine(y);
	}
}