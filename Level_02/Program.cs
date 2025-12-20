using System;

class Program 
{
    static void Main(string[] args)
    {
		int number = Convert.ToInt32(Console.ReadLine());
		MultiplesFinder finder = new MultiplesFinder();
		finder.FindMultiples(number);

		Factors f = new Factors();
		f.PrintFactors();

		Power p = new Power();
		p.CalculatePower();

		GreatestFactor gf = new GreatestFactor();
		gf.FindGreatestFactor();

		FriendsComparison obj = new FriendsComparison();
		obj.FindYoungestAndTallest();

		FindingBmi fbm = new FindingBmi();
        fbm.CalculateBmi();

		FizzBuzzWhile fbw = new FizzBuzzWhile();
        fbw.PrintFizzBuzz();

		FizzBuzz fb = new FizzBuzz();
        fb.PrintFizzBuzz();

		PrimeNo pm = new PrimeNo();
        pm.CheckPrime();

		GradeCalculator gc = new GradeCalculator();
        gc.CalculateGrade();

		LeapYear ly = new LeapYear();
        ly.CheckLeapYear();
	}
}