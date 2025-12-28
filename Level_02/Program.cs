using System;

class Program
{
	static void Main(string[] args)
	{
		int age = Convert.ToInt32(Console.ReadLine());
		StudentVoteChecker c = new StudentVoteChecker();
		c.CanStudentVote();
	}
}