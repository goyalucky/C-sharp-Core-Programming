using System;

class Calculator
{
	public void Calculate()
	{
		int a, b;
		string s;

		a = Convert.toDouble(Console.ReadLine());
		b = Convert.toDouble(Console.ReadLine());
		s = Console.ReadLine();

		switch (s)
		{
			case "+":
				Console.WriteLine("Result = ", a + b);

			case "-":
				Console.WriteLine("Result = ", a - b);

			case "*":
				Console.WriteLine("Result = ", a * b);
			
			case "/":
				if (second != 0)
					Console.WriteLine("Result = " + (first / second));
				else
					Console.WriteLine("Division by zero is not allowed");
				break;

			default:
				Console.WriteLine("Invalid Operator");
				break;
		}
	}
}