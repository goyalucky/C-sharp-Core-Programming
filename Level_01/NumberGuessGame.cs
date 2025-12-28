//Write a program where the user thinks of a number between 1 and 100, and the computer tries to guess the number by generating random guesses.


using System;

class NumberGuessGame
{
	private int min = 1;
	private int max = 100;
	private Random random = new Random();

	public void Start()
	{
		Console.WriteLine("Think of a number between 1 and 100.");
		Console.WriteLine("Respond with: high, low, or correct\n");

		bool isCorrect = false;

		while (!isCorrect)
		{
			int guess = GenerateGuess();
			Console.WriteLine($"Computer guess: {guess}");

			string feedback = GetUserFeedback();
			isCorrect = ProcessFeedback(feedback, guess);
		}

		Console.WriteLine("\nComputer guessed your number successfully!");
	}

	private int GenerateGuess()
	{
		return random.Next(min, max + 1);
	}

	private string GetUserFeedback()
	{
		Console.Write("Is it high, low, or correct? ");
		return Console.ReadLine().ToLower();
	}

	private bool ProcessFeedback(string feedback, int guess)
	{
		switch (feedback)
		{
			case "high":
				max = guess - 1;
				break;

			case "low":
				min = guess + 1;
				break;

			case "correct":
				return true;

			default:
				Console.WriteLine("Invalid input. Please try again.");
				break;
		}
		return false;
	}
}
