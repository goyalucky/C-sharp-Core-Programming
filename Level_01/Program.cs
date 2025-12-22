using System;

class  Program
{
    static void Main(string[] args)
    {
		FizzBuzzProgram fb =  new FizzBuzzProgram();
		fb.RunFizzBuzz();

		MatrixToArray m  = new MatrixToArray();
		m.Copy2DTo1D();

		FactorFinder ff = new FactorFinder();
		ff.FindAndDisplayFactors();

		OddEvenArray oe = new OddEvenArray();
		oe.CheckOddEven();

		HeightCalculator hc = new HeightCalculator();
		hc.CalculateHeight();

		MultiplicationTableRange obj = new MultiplicationTableRange();
		obj.PrintTable();

		MultiplicationTable mt = new MultiplicationTable();
        mt.PrintTable();

		NumberCheck n = new NumberCheck();
        n.CheckNumber();

		Voting v = new Voting();
        v.CheckEligibilty();
	}
}