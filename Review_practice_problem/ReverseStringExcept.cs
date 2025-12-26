using System;

class ReverseStringExcept
{
    public void ReverseString()
    {
        string t = "abc#efgh";
        string res = "";
		for (int i = t.Length - 1; i >= 0; i--)
        {
            res+=t[i];
			if (t[i] == '#')
            {
                res+='#';
			}
        }
            Console.Write(res);
    }
}