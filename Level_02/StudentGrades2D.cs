using System;

class StudentGrades2D
{
	public void CalculateGrades()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		if (n <= 0) return;

		double[,] m = new double[n, 3];
		double[] p = new double[n];
		string[] g = new string[n];
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine($"\nStudent {i + 1}:");
			for (int j = 0; j < 3; j++)
			{
				string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";
				while (true)
				{
					Console.Write($"Enter marks in {subject}: ");
					m[i, j] = Convert.ToDouble(Console.ReadLine());
					if (m[i, j] >= 0) break;
					Console.WriteLine("Marks must be positive. Try again.");
				}
			}
			p[i] = (m[i, 0] + m[i, 1] + m[i, 2]) / 3;
			if (p[i] >= 90) g[i] = "A";
			else if (p[i] >= 80) g[i] = "B";
			else if (p[i] >= 70) g[i] = "C";
			else if (p[i] >= 60) g[i] = "D";
			else g[i] = "F";
		}
		Console.WriteLine("\nPhysics\tChemistry\tMaths\tPercentage\tGrade");
		for (int i = 0; i < n; i++)
		{
			Console.Write($"{m[i, 0]}\t{m[i, 1]}\t\t{m[i, 2]}\t{p[i]:0.00}\t\t{g[i]}\n");
		}
	}
}