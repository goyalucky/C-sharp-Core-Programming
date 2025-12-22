using System;

class NumberCheck
{
	public void CheckNumber()
	{
		int[] arr = new int[5];

		for (int i = 0; i < 5; i++)
		{
			Console.Write("Enter number " + (i + 1) + ": ");
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}

		for (int i = 0; i < 5; i++)
		{
			int a = arr[i];

			if (a > 0)
			{
				Console.Write(a + " is Positive");

				if (a % 2 == 0)
					Console.WriteLine(" and Even");
				else
					Console.WriteLine(" and Odd");
			}
			else if (a < 0)
			{
				Console.WriteLine(a + " is Negative");
			}
			else
			{
				Console.WriteLine(a + " is Zero");
			}
		}

		if (arr[0] == arr[4])
			Console.WriteLine("First and Last elements are Equal");
		else if (arr[0] > arr[4])
			Console.WriteLine("First element is Greater than Last element");
		else
			Console.WriteLine("First element is Less than Last element");
	}
}
