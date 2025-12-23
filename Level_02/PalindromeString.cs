using System;

class PalindromeString
{
	public bool ShowPalindromeString()
	{
		string s = Console.ReadLine();
		int left = 0;
		int right = s.Length - 1;
		while(left < right)
		{
			if (s[left] != s[right])
			{
				Console.WriteLine("Not a Palindrome");
				return false;
			}
			left++;
			right--;
		}
		Console.WriteLine("It is a Palindrome String");
		return true;
	}
}