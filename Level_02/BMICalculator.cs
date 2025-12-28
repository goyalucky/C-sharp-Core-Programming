/* An organization took up the exercise to find the Body Mass Index (BMI) of all the
persons in the team of 10 members. For this create a program to find the BMI and display
the height, weight, BMI and status of each individual*/


using System;

class BMICalculator
{
	// Calculate BMI for all persons and populate the 3rd column of the array
	public void CalculateBMI(double[,] data)
	{
		for (int i = 0; i < data.GetLength(0); i++)
		{
			double weight = data[i, 0]; // in kg
			double heightCm = data[i, 1]; // in cm
			double heightM = heightCm / 100; // convert to meters

			data[i, 2] = weight / (heightM * heightM); // BMI
		}
	}

	// Determine BMI status based on BMI value
	public string[] DetermineBMIStatus(double[,] data)
	{
		string[] status = new string[data.GetLength(0)];

		for (int i = 0; i < data.GetLength(0); i++)
		{
			double bmi = data[i, 2];

			if (bmi < 18.5)
				status[i] = "Underweight";
			else if (bmi < 24.9)
				status[i] = "Normal weight";
			else if (bmi < 29.9)
				status[i] = "Overweight";
			else
				status[i] = "Obese";
		}

		return status;
	}
}
