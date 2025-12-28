/*12.Write a program to calculate various trigonometric functions using Math class given an angle in degrees*/


using System;

class TrigonometryCalculator
{
	public double[] calculateTrigonometricFunctions(double angle)
	{
		double radians = angle * Math.PI / 180;

		double sin = Math.Sin(radians);
		double cos = Math.Cos(radians);
		double tan = Math.Tan(radians);

		return new double[] { sin, cos, tan };
	}
}
