using System;

class EmployeeBonus
{
	public double CalculateBonus(int yearsOfService, double salary)
	{
		if (yearsOfService > 10)
		{
			return salary * 0.10;
		}
		else if (yearsOfService >= 5)
		{
			return salary * 0.05; 
		}
		else
		{
			return 0; 
		}
	}
}