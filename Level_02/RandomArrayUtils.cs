/*Write a program that generates five 4 digit random values and then finds their
average value, and their minimum and maximum value. Use Math.Random(), Math.Min(),
and Math.Max().*/


using System;

class RandomArrayUtils
{
	// Generate array of 4-digit random numbers
	public int[] Generate4DigitRandomArray(int size)
	{
		int[] numbers = new int[size];
		Random rand = new Random();
		for (int i = 0; i < size; i++)
		{
			numbers[i] = rand.Next(1000, 10000); // 4-digit number
		}
		return numbers;
	}

	// Find average, min, and max values of the array
	public double[] FindAverageMinMax(int[] numbers)
	{
		int min = numbers[0];
		int max = numbers[0];
		int sum = 0;
		foreach (int num in numbers)
		{
			sum += num;
			min = Math.Min(min, num);
			max = Math.Max(max, num);
		}
		double average = (double)sum / numbers.Length;
		return new double[] { average, min, max };
	}
}
