using System;

class FindingBmi
{
	public void CalculateBmi()
	{
		int weight = int.Parse(Console.ReadLine());
		int height = int.Parse(Console.ReadLine());
		double bmi = weight / (height * height);
		if (bmi <= 18.4)
		{
			Console.WriteLine("Underweight");
		}
		else if (bmi >= 18.5 && bmi <= 24.9)
		{
			Console.WriteLine("Normal");
		}
		else if (bmi >= 25 && bmi <= 39.9)
		{
			Console.WriteLine("Overweight");
		}
		else
		{
			Console.WriteLine("Obese");
		}
	}
}