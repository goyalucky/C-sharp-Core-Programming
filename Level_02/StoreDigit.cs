//Rework the program 2, especially the Hint: if index equals maxDigit, we break from the loop.
//Here we want to modify to increase the size of the array i, e maxDigit by 10 if the index is
//equal to maxDigit. This is done to consider all digits to find the largest and second-largest
//number

using System;

class StoreDigit
{
	public void StoreDigits()
	{
		Console.Write("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		int maxDigit = 10;
		int[] digits = new int[maxDigit];
		int index = 0;

		while (number > 0)
		{
			if (index == maxDigit)
			{
				maxDigit += 10;
				int[] temp = new int[maxDigit];

				for (int i = 0; i < index; i++)
				{
					temp[i] = digits[i];
				}

				digits = temp;
			}

			digits[index++] = number % 10;
			number /= 10;
		}

		Console.WriteLine("\nDigits in the number:");
		for (int i = 0; i < index; i++)
		{
			Console.Write(digits[i] + " ");
		}

		int largest = digits[0];
		int secondLargest = int.MinValue;

		for (int i = 1; i < index; i++)
		{
			if (digits[i] > largest)
			{
				secondLargest = largest;
				largest = digits[i];
			}
			else if (digits[i] > secondLargest && digits[i] != largest)
			{
				secondLargest = digits[i];
			}
		}

		Console.WriteLine("\n\nLargest digit: " + largest);
		Console.WriteLine("Second largest digit: " + secondLargest);
	}
}
