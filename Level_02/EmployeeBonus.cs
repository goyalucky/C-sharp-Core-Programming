//Create a program to find the bonus of 10 employees based on their years of service and the
//total bonus amount the company Zara has to pay, along with the old and new salary.

using System;

class EmployeeBonus
{
	public void CalculateBonus()
	{
		int size = 10;
		double[] s = new double[size];
		double[] years = new double[size];
		double[] b = new double[size];
		double[] newSal = new double[size];

		double totalBonus = 0;
		double totalOldSalary = 0;
		double totalNewSalary = 0;

		for (int i = 0; i < size; i++)
		{
			Console.WriteLine("\nEmployee " + (i + 1));
			s[i] = Convert.ToDouble(Console.ReadLine());
			years[i] = Convert.ToDouble(Console.ReadLine());

			if (s[i] <= 0 || years[i] < 0)
			{
				i--;
				continue;
			}
		}
		for (int i = 0; i < size; i++)
		{
			if (years[i] > 5)
				b[i] = s[i] * 0.05;
			else
				b[i] = s[i] * 0.02;

			newSal[i] = s[i] + b[i];

			totalBonus += b[i];
			totalOldSalary += s[i];
			totalNewSalary += newSal[i];
		}
		Console.WriteLine("\nTotal Old Salary: " + totalOldSalary);
		Console.WriteLine("Total Bonus Paid: " + totalBonus);
		Console.WriteLine("Total New Salary: " + totalNewSalary);
	}
}
