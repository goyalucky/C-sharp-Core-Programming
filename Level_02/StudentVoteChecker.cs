/*Write a program to take user input for the age of all 10 students in a class and check
whether the student can vote depending on his/her age is greater or equal to 18.*/


using System;

class StudentVoteChecker
{
	// Method to check whether a student can vote
	public bool CanStudentVote(int age)
	{
		if (age < 0)      // Negative age is invalid
			return false;
		else if (age >= 18) // Eligible to vote
			return true;
		else               // Not eligible
			return false;
	}
}
