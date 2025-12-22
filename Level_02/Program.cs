using System;

class Program
{
	static void Main(string[] args)
	{
		DigitFrequency df = new DigitFrequency();
		df.FindFrequency();

		StudentGrades2D obj = new StudentGrades2D();
		obj.CalculateGrades();

		StudentGrades sg = new StudentGrades();
		sg.CalculateGrades();

		BMIProgram2D bmi = new BMIProgram2D();
		bmi.CalculateBMI();

		BMIProgram bp = new BMIProgram();
		bp.CalculateBMI();

		ReverseNumberDigitArray r = new ReverseNumberDigitArray();
		r.ReverseDigits();

		StoreDigit s = new StoreDigit();
		s.StoreDigits();

		FriendsComparison f = new FriendsComparison();
		f.CompareFriends();

		EmployeeBonus e = new EmployeeBonus();
		e.CalculateBonus();

		StoreDigitinArray sd = new StoreDigitinArray();
		sd.StoreDigits();
	}
}