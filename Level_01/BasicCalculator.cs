//Write a program that performs basic mathematical operations (addition, subtraction, multiplication, division) based on user input.


using System;

class BasicCalculator
{
	public void Calculate()
	{
		double a, b;
		string s;
		a = Convert.ToDouble(Console.ReadLine());
		b = Convert.ToDouble(Console.ReadLine());
		s = Console.ReadLine();
		switch (s)
		{
			case "+":
				Console.WriteLine("Result = " + (a + b));
				break;

			case "-":
				Console.WriteLine("Result = " + (a - b));
				break;

			case "*":
				Console.WriteLine("Result = " + (a * b));
				break;

			case "/":
				if (b != 0)
					Console.WriteLine("Result = " + (a / b));
				else
					Console.WriteLine("Division by zero is not allowed");
				break;

			default:
				Console.WriteLine("Invalid Operator");
				break;
		}
	}
}
