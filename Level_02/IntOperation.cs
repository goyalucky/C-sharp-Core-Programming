using System;

class IntOperation
{
	public void Arithmetic()
	{
		Console.Write("Enter first number: ");
		int a = int.Parse(Console.ReadLine());

		Console.Write("Enter second number: ");
		int b = int.Parse(Console.ReadLine());

		Console.Write("Enter second number: ");
		int c = int.Parse(Console.ReadLine());

		int a1 = a+ b*c;
		int a2 = a*b +c;
		int a3 = c+a /b;
		int a4 = a%b + c;

		Console.WriteLine(
			$"The results of int Operation are {a1}, {a2},{a3} and {a4}"
		);
	}
}
