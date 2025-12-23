using System;

class Program
{
	static void Main(string[] args)
	{
		CountSubstringOccurInString c = new CountSubstringOccurInString();
		c.CountSubstring();

		ToggleCase tg = new ToggleCase();
		tg.ShowToggleCase();

		LongestWord lw = new LongestWord();
		lw.ShowLongestWord();

		RemoveDuplicates r = new RemoveDuplicates();
		r.ShowRemoveDuplicates();

		PalindromeString ps = new PalindromeString();
		ps.ShowPalindromeString();

		CountVowelsAndConsonants cvc = new CountVowelsAndConsonants();
		cvc.ShowCountVowelsAndConsonants();

		ReverseString rs = new ReverseString();
		rs.ShowReverseString();
	}
}