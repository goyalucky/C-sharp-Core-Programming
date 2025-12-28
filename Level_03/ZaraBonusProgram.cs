/* Create a program to find the bonus of 10 employees based on their years of service
as well as the total bonus amount the 10-year-old company Zara has to pay as a bonus,
along with the old and new salary.

a.Zara decides to give a bonus of 5% to employees whose year of service is more than 5
years or 2% if less than 5 years

b. Create a Method to determine the Salary and years of service and return the same.
Use the Math.Random() method to determine the 5-digit salary for each employee and also
use the random method to determine the years of service. Define 2D Array to save the
salary and years of service.

c. Write a Method to calculate the new salary and bonus based on the logic defined
above and return the new 2D Array of the latest salary and bonus amount

d. Write a Method to Calculate the sum of the Old Salary, the Sum of the New Salary,
and the Total Bonus Amount and display it in a Tabular Format */



using System;

class ZaraBonusProgram
{
	const int EMP_COUNT = 10;
	// Method to generate salary and years of service
	static int[,] GenerateEmployeeData()
	{
		int[,] data = new int[EMP_COUNT, 2];
		Random rand = new Random();
		for (int i = 0; i < EMP_COUNT; i++)
		{
			data[i, 0] = rand.Next(10000, 100000); 
			data[i, 1] = rand.Next(1, 11);        
		}

		return data;
	}
	// Method to calculate new salary and bonus
	static double[,] CalculateBonus(int[,] empData)
	{
		double[,] result = new double[EMP_COUNT, 2]; 
		for (int i = 0; i < EMP_COUNT; i++)
		{
			double salary = empData[i, 0];
			int years = empData[i, 1];
			double bonus;
			if (years > 5)
				bonus = salary * 0.05;
			else
				bonus = salary * 0.02;

			double newSalary = salary + bonus;
			result[i, 0] = Math.Round(newSalary, 2);
			result[i, 1] = Math.Round(bonus, 2);
		}
		return result;
	}

	// d. Method to calculate totals and display
	static void DisplayReport(int[,] empData, double[,] result)
	{
		double totalOldSalary = 0;
		double totalNewSalary = 0;
		double totalBonus = 0;
		Console.WriteLine("\nEmp\tOldSalary\tYears\tBonus\t\tNewSalary");

		for (int i = 0; i < EMP_COUNT; i++)
		{
			totalOldSalary += empData[i, 0];
			totalBonus += result[i, 1];
			totalNewSalary += result[i, 0];

			Console.WriteLine(
				(i + 1) + "\t" +
				empData[i, 0] + "\t\t" +
				empData[i, 1] + "\t" +
				result[i, 1] + "\t\t" +
				result[i, 0]
			);
		}
		Console.WriteLine("TOTAL\t" +
			Math.Round(totalOldSalary, 2) + "\t\t-\t" +
			Math.Round(totalBonus, 2) + "\t\t" +
			Math.Round(totalNewSalary, 2));
	}
}
