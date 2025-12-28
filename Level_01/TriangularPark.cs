/*An athlete runs in a triangular park with sides provided as input by the user in meters. If
the athlete wants to complete a 5 km run, then how many rounds must the athlete
complete*/

using System;

class TriangularPark
{
	// method to calculate the number of rounds
	public void CalculateRound()
	{
		//take first side as input from user
		int side1 = Convert.ToInt32(Console.ReadLine());
		//take second side as input from user
		int side2 = Convert.ToInt32(Console.ReadLine());
		//take third side as input from user
		int side3 = Convert.ToInt32(Console.ReadLine());
		int p = side1 + side2 + side3;
		int dis = 5000;
		//Caculate no of rounds
		int rounds = dis / p;
		Console.WriteLine("Number of rounds: " + rounds);
	}
}