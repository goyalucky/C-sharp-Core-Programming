using System;

class Program
{
	static void Main(string[] args)
	{
		FormatExceptionDemo f  = new FormatExceptionDemo();
		f.ShowFormatException();

		IndexOutOfRangeDemo i = new IndexOutOfRangeDemo();
		i.ShowIndexOutOfRange();

		WordSplitLength ws = new WordSplitLength();
		ws.DisplayWordsAndLengths();
		Console.ReadKey();

		LowerCase lc = new LowerCase();
		lc.ConvertToLowerCase();

		UpperCase uc = new UpperCase();
		uc.ConvertToUpperCase();

		StringCharacters s = new StringCharacters();
		s.ShowCharacters();

		SubstringCharAt sb = new SubstringCharAt();
		sb.ExtractSubstringAndCharAt();

		StringComparison sc = new StringComparison();
		sc.CompareStrings();
	}
}