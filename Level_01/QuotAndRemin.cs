// Write a program to take 2 numbers and print their quotient and reminder


using System;

public class  QuotAndRemin
{
    public void ShowQuotAndRemin()
    {
        int d1 = Convert.ToInt32(Console.ReadLine());
        int d2 = Convert.ToInt32(Console.ReadLine());
        int q = d1 / d2;
        int r = d1 % d2;
        Console.WriteLine("Quotient: " + q);
        Console.WriteLine("Remainder: " + r);
	}
}