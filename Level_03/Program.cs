using System;

class  Program
{
    static void Main(string[] args)
    {
		Calculator c = new Calculator();
		c.Calculate();

		int m = int.Parse(args[0]);
		int d = int.Parse(args[1]);
		int y = int.Parse(args[2]);
		DayOfWeekCalculator obj = new DayOfWeekCalculator();
		obj.FindDay(m, d, y);

		AbundantNumber ab = new AbundantNumber();
        ab.CheckAbundant();

		HarshadNumber hs = new HarshadNumber();
        hs.CheckHarshad();

		CountDigit cd = new CountDigit();
        cd.CountDigits();

		ArmstrongCheck ac = new ArmstrongCheck();
        ac.CheckArmstrong();
	}
}