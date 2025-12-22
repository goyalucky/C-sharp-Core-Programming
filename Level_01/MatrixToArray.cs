using System;

class MatrixToArray
{
	public void Copy2DTo1D()
	{
		int rows = Convert.ToInt32(Console.ReadLine());
		int cols = Convert.ToInt32(Console.ReadLine());

		int[,] matrix = new int[rows, cols];

		Console.WriteLine("Enter matrix elements:");
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < cols; j++)
			{
				matrix[i, j] = Convert.ToInt32(Console.ReadLine());
			}
		}

		int []arr = new int[rows * cols];
		int index = 0;

		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < cols; j++)
			{
				arr[index++] = matrix[i, j];
			}
		}

		Console.WriteLine("\n1D Array elements:");
		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write(arr[i] + " ");
		}
	}
}
