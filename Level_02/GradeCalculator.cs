using System;

class GradeCalculator
{
	public void CalculateGrade()
	{
		int Physics = int.Parse(Console.ReadLine());
		int Chemistry = int.Parse(Console.ReadLine());
		int Math = int.Parse(Console.ReadLine());
		int total = Physics + Chemistry + Math;
		double percentage = total / 3.0;
		char grade;

		if (percentage >= 80)
			grade = 'A';
		else if (percentage >= 70)
			grade = 'B';
		else if (percentage >= 60)
			grade = 'C';
		else if (percentage >= 50)
			grade = 'D';
		else if (percentage >= 40)
			grade = 'E';
		else
			grade = 'R';
		Console.WriteLine("Total Marks: " + total);
		Console.WriteLine("Percentage: " + percentage + "%");
		Console.WriteLine("Grade: " + grade);
	}
}