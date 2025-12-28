using System;

class Program
{
	static void Main(string[] args)
	{

		NumberGuessGame game = new NumberGuessGame();
		game.Start();

		BasicCalculator calc = new BasicCalculator();
		calc.Calculate();


		int d = Convert.ToInt32(Console.ReadLine());
		int e = Convert.ToInt32(Console.ReadLine());
		GCDandLCMCalculator calcu = new GCDandLCMCalculator();
		int hcf = calcu.CalculateGCD(d, e);
		int lcm = calcu.CalculateLCM(d, e, hcf);
		Console.WriteLine($"HCF: {hcf}");
		Console.WriteLine($"LCM: {lcm}");


		Temperature temp = new Temperature();
		Console.Write("Enter temperature in Celsius: ");
		double celsius = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Fahrenheit: {temp.CelsiusToFahrenheit(celsius)}");

		Console.Write("Enter temperature in Fahrenheit: ");
		double fahr = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Celsius: {temp.FahrenheitToCelsius(fahr)}");


		Console.Write("Enter number for factorial: ");
		int m = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Factorial: {FactorialRecursion.CalcFactorial(m)}");

		PalindromeString p = new PalindromeString();
		p.palindrome();

		Console.Write("Enter number of Fibonacci terms: ");
		int n = Convert.ToInt32(Console.ReadLine());
		FibonacciSequence fib = new FibonacciSequence();
		fib.GenerateFibonacci(n);

		Console.Write("Enter three numbers: ");
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int c = Convert.ToInt32(Console.ReadLine());

		int max = MaximumOfThree.FindMaximum(a, b, c);
		Console.WriteLine($"Maximum: {max}");
	}
}
