/*Write a program Quadratic to find the roots of the equation ax2+ bx + c. Use Math
functions Math.pow() and Math.sqrt()*/


using System;

class Quadratic
{
	// Method to find roots of quadratic equation
	public double[] FindRoots(double a, double b, double c)
	{
		double delta = Math.Pow(b, 2) - 4 * a * c;

		if (delta > 0)
		{
			double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
			double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
			return new double[] { root1, root2 };
		}
		else if (delta == 0)
		{
			double root = -b / (2 * a);
			return new double[] { root };
		}
		else
		{
			// No real roots
			return new double[0];
		}
	}
}
