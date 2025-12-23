using System;

class CountVowelsAndConsonants
{
	public void ShowCountVowelsAndConsonants()
	{
		string s = Console.ReadLine();
		int vow = 0;
		int cons = 0;
		s = s.ToLower();
		for (int i=0;i< s.Length; i++)
		{
			if(s[i] == 'a' || s[i]== 'e'|| s[i] == 'i'|| s[i] == 'o' || s[i] == 'u')
			{
				vow++;
			}
			else
			{
				cons++;
			}
		}
		Console.WriteLine("Vowels are: " + vow);
		Console.WriteLine("Consonants are: " + cons);
	}
}