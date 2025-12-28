/*Write a program that checks if a given string is a palindrome (a word, phrase, or sequence that reads the same backward as forward).*/


using System;

class PalindromeString
{
	//method to check the the string is palindrome or not
	public void palindrome()
	{
		string s = Console.ReadLine();
		int left = 0;
		int right = s.Length - 1;
		while (left < right)
		{
			if (s[left] != s[right])
			{
				Console.WriteLine("The string is not a palindrome.");
				return;
			}
			left++;
			right--;
		}
		Console.WriteLine("The string is a palindrome.");
	}
}