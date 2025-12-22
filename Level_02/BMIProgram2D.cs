/*Rewrite the above program using multi-dimensional array to store height, weight, and BMI in
2D array for all the persons*/


using System;

class BMIProgram2D
{
	public void CalculateBMI()
	{
		Console.Write("Enter the number of persons: ");
		int n = Convert.ToInt32(Console.ReadLine());
		if (n <= 0) return;

		double[][] pd = new double[n][];
		string[] ws = new string[n];

		for (int i = 0; i < n; i++)
		{
			pd[i] = new double[3];
			while (true)
			{
				Console.Write($"Person {i + 1} - Enter height in meters: ");
				pd[i][0] = Convert.ToDouble(Console.ReadLine());
				if (pd[i][0] > 0) break;
			}

			while (true)
			{
				Console.Write($"Person {i + 1} - Enter weight in kg: ");
				pd[i][1] = Convert.ToDouble(Console.ReadLine());
				if (pd[i][1] > 0) break;
			}

			pd[i][2] = pd[i][1] / (pd[i][0] * pd[i][0]);

			if (pd[i][2] < 18.5) ws[i] = "Underweight";
			else if (pd[i][2] < 25) ws[i] = "Normal";
			else if (pd[i][2] < 30) ws[i] = "Overweight";
			else ws[i] = "Obese";
		}
		Console.WriteLine("\nHeight(m)\tWeight(kg)\tBMI\t\tStatus");
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine($"{pd[i][0]},{pd[i][1]},{pd[i][2]},{ws[i]}");
		}
	}
}
