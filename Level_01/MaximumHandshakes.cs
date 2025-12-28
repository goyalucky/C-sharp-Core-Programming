// Create a program to find the maximum number of handshakes among N number of students.


using System;

class MaximumHandshakes
{
	// This method calculates and displays the maximum number of handshakes
	public void ShowMaximumHandshakes()
	{
		// take n as input to Read the number of people 
		int n = Convert.ToInt32(Console.ReadLine());
		// calculate maximum handshakes 
		int maxHandshakes = n * (n - 1) / 2;
		Console.WriteLine("Maximum number of handshakes: " + maxHandshakes);
	}
}