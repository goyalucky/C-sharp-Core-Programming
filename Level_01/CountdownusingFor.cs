using System;

class Countdown
{
	public void Launch(int counter)
	{
		Console.WriteLine("Rocket Launch Countdown:");
		for (int i = counter; i >= 1; i--)
		{
			Console.WriteLine(i);
		}
		Console.WriteLine("Lift off!");
	}
}
