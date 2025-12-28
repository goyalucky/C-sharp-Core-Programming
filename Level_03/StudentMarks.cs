/* Create a program to take input marks of students in 3 subjects physics, chemistry,
and maths. Compute the total, average, and the percentage score

a. Take input for the number of students

b. Write a method to generate random 2-digit scores for Physics, Chemistry, and Math
(PCM) for the students and return the scores. This method returns a 2D array with PCM
scores for all students

c. Write a Method to calculate the total, average, and percentages for each student and
return a 2D array with the corresponding values. Please ensure to round off the values to 2
Digits using the Math.Round() method.

d.Finally, write a Method to display the scorecard of all students with their scores, total,
average, and percentage in a tabular format using "\t". */


using System;

class StudentMarks
{
	// Method to generate random 2-digit PCM scores
	static int[,] GeneratePCMScores(int students)
	{
		int[,] scores = new int[students, 3];
		Random rand = new Random();
		for (int i = 0; i < students; i++)
		{
			scores[i, 0] = rand.Next(10, 100); // Physics
			scores[i, 1] = rand.Next(10, 100); // Chemistry
			scores[i, 2] = rand.Next(10, 100); // Maths
		}
		return scores;
	}
	// Method to calculate Total, Average, Percentage
	static double[,] CalculateResults(int[,] scores, int students)
	{
		double[,] result = new double[students, 3];
		for (int i = 0; i < students; i++)
		{
			int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
			double average = total / 3.0;
			double percentage = (total / 300.0) * 100;

			result[i, 0] = Math.Round(total, 2);
			result[i, 1] = Math.Round(average, 2);
			result[i, 2] = Math.Round(percentage, 2);
		}
		return result;
	}
	// Method to display scorecard
	static void DisplayScoreCard(int[,] scores, double[,] result, int students)
	{
		Console.WriteLine("\nStudent\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
		for (int i = 0; i < students; i++)
		{
			Console.WriteLine(
				(i + 1) + "\t" +
				scores[i, 0] + "\t" +
				scores[i, 1] + "\t\t" +
				scores[i, 2] + "\t" +
				result[i, 0] + "\t" +
				result[i, 1] + "\t" +
				result[i, 2] + "%"
			);
		}
	}
}