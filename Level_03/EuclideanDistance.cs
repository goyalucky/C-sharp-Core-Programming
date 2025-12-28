/*Write a program Euclidean distance between two points as well as the equation of
the line using those two points.Use Math functions Math.Pow() and Math.Sqrt()

a). Take inputs for 2 points x1, y1, and x2, y2

b). Method to find the Euclidean distance between two points and return the distance
distance = (x2-x1)2 +(y2-y1)2

d). Write a Method to find the equation of a line given two points and return the equation
which includes the slope and the y-intercept

The equation of a line is given by the equation y = m*x + b Where m is the slope and b is the
y-intercept. So firstly compute the slope using the formulae
m = (y2 - y1) / (x2 - x1)
Post that compute the y-intercept b using the formulae

b = y1 - m * x1
Finally, return an array having slope m and y-intercept b*/


using System;

class EuclideanDistance
{

	public static double CalculateDistance(int m1, int n1, int m2, int n2)
	{
		int deltaX = m2 - m1;
		int deltaY = n2 - n1;
		return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
	}
}