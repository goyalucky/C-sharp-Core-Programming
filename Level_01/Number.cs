using System;

class Number
{
	public void CheckNumber()
	{
		int n = int.Parse(Console.ReadLine());
        if(n>0)
        {
            console.WriteLine("Positive");
        } else if (n < 0)
        {
            console.WriteLine("Negative");
		}
        else
        {
            console.WriteLine("Zero");
		}
	}
}