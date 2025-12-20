using System;

class Countdown
{
	public void Launch(int counter)
	{
		Console.WriteLine("Rocket Launch Countdown:");
		while (counter >= 1)
		{
			Console.WriteLine(counter);
			counter--;
		}
		Console.WriteLine("Lift off!");
	}
}
