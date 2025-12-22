//An organization took up an exercise to find the Body Mass Index (BMI) of all the persons in
//the team. For this create a program to find the BMI and display the height, weight, BMI and
//status of each individual

using System;

class BMIProgram
{
	public void CalculateBMI()
	{
		int n = Convert.ToInt32(Console.ReadLine());

		double[] height = new double[n];
		double[] weight = new double[n];
		double[] bmi = new double[n];
		string[] status = new string[n];

		for(int i= 0; i < n; i++)
		{
			height[i] = Convert.ToDouble(Console.ReadLine());
			weight[i] = Convert.ToDouble(Console.ReadLine());
			bmi[i] = weight[i] / (height[i] * height[i]);

			if(bmi[i] < 18.5)
			{
				status[i] = "Underweight";
			}
			else if(bmi[i] >= 18.5 && bmi[i] < 24.9)
			{
				status[i] = "Normal weight";
			}
			else if(bmi[i] >= 25 && bmi[i] < 29.9)
			{
				status[i] = "Overweight";
			}
			else
			{
				status[i] = "Obesity";
			}
		}
		Console.WriteLine("\nHeight(m)\tWeight(kg)\tBMI\t\tStatus");
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine($"height is {height[i]}, Weight is {weight[i]}, BMI IS {bmi[i]}, Status is {status[i]}");
		}
	}
}