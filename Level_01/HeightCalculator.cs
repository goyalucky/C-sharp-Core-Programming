using System;

class HeightCalculator
{
	public void CalculateHeight()
	{
		double[] height = new double[11];
		double sum = 0.0;
		for(int i = 0; i < height.Length; i++)
		{
			height[i] = Convert.ToDouble(Console.ReadLine());
			sum += height[i];
		}
		double mean = sum / height.Length;
		Console.WriteLine("Mean Height: " + mean);
	}
}