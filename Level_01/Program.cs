using System;

class Program
{
	static void Main(string[] args)
	{
		int number = int.Parse(Console.ReadLine());
		DivisibleByFive dbf = new DivisibleByFive();
		dbf.Divisibility(number);

		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		int n3 = int.Parse(Console.ReadLine());
		Smallest sm = new Smallest();
		sm.CheckSmallest(number1, number2, number3);

		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int num3 = int.Parse(Console.ReadLine());
		Largest lg = new Largest();
		lg.CheckLargest(num1, num2, num3);

		NaturalNumber nn = new NaturalNumber();
		nn.SumNaturalNumbers();

		Voting vote = new Voting();
		vote.CheckEligibility();

		Number nm = new Number();
		nm.CheckNumber();

		int month = int.Parse(Console.ReadLine());
		int day = int.Parse(Console.ReadLine());
		SpringSeason season = new SpringSeason();
		season.CheckSeason(month, day);

		int counter = int.Parse(Console.ReadLine());
		Countdown rocket = new Countdown();
		rocket.Launch(counter);

		int c1 = int.Parse(Console.ReadLine());
		CountdownusingFor rocket = new CountdownusingFor();
		rocket.Launch(c1);

		SumCalculator sc = new SumCalculator();
		sc.CalculateSum();

		SumCalculatorBreak scb = new SumCalculatorBreak();
		scb.CalSum();

		SumNaturalNumbers sn = new SumNaturalNumbers();
		sn.SumNatNum();

		Factorial f = new Factorial();
		f.CalculateFactorial();

		FactorialFor ff = new FactorialFor();
		ff.CalculateFactorial();

		OddEven oe = new OddEven();
		oe.CalculateOddEven();

		double salary;
		int yearsOfService;
		salary = Convert.ToDouble(Console.ReadLine());
		yearsOfService = Convert.ToInt32(Console.ReadLine());
		EmployeeBonus emp = new EmployeeBonus();
		double bonus = emp.CalculateBonus(salary, yearsOfService);
		Console.WriteLine("Bonus Amount: " + bonus);

		int number = Convert.ToInt32(Console.ReadLine());
		MultiplicationTable m = new MultiplicationTable();
		m.PrintTable();

	}
}
