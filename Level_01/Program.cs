using System;

class Program
{
	static void Main(string[] args)
	{
		double angle = Convert.ToDouble(Console.ReadLine());
		TrigonometryCalculator obj = new TrigonometryCalculator();
		double[] res1 = obj.calculateTrigonometricFunctions(angle);
		Console.WriteLine("Sin = " + res1[0]);
		Console.WriteLine("Cos = " + res1[1]);
		Console.WriteLine("Tan = " + res1[2]);


		WindChillTemperature wct = new WindChillTemperature();
		wct.ShowWindChillTemperature();


		int chocolates = Convert.ToInt32(Console.ReadLine());
		int children = Convert.ToInt32(Console.ReadLine());
		int[] res = ChocolateDistribution.DistributeChocolates(chocolates, children);
		Console.WriteLine("Each child gets: " + res[0]);
		Console.WriteLine("Remaining chocolates: " + res[1]);


		QuotAndRemin qr = new QuotAndRemin();
		qr.ShowQuotAndRemin();

		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());
		int c = Convert.ToInt32(Console.ReadLine());
		int[] result = SmallestLargest.FindSmallestAndLargest(a, b, c);
		Console.WriteLine("Smallest: " + result[0]);
		Console.WriteLine("Largest: " + result[1]);


		SumOfNaturalNo sn = new SumOfNaturalNo();
		sn.ShowSumOfNaturalNo();

		int month = Convert.ToInt32(args[0]);
		int day = Convert.ToInt32(args[1]);
		if (SpringSeason.ShowSpringSeason(month, day))
			Console.WriteLine("Its a Spring Season");
		else
			Console.WriteLine("Not a Spring Season");


		int n = Convert.ToInt32(Console.ReadLine());
		CheckNumber cn = new CheckNumber();
		cn.NumberCheck(n);

		TriangularPark t = new TriangularPark();
		t.CalculateRound();

		HandshakeCalculator hc = new HandshakeCalculator();
		hc.CalculateHandshakes();

		MaximumHandshakes m = new MaximumHandshakes();
		m.ShowMaximumHandshakes();

		SimpleInterest  s  = new SimpleInterest();
		s.CalculateSimpleInterest();
	}
}