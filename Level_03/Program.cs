using System;

class Program
{
	static void Main(string[] args)
	{

		int rows = 3;
		int cols = 3;

		int[,] A = CreateRandomMatrix(rows, cols);
		int[,] B = CreateRandomMatrix(rows, cols);

		Console.WriteLine("Matrix A:");
		DisplayMatrix(A);

		Console.WriteLine("\nMatrix B:");
		DisplayMatrix(B);

		Console.WriteLine("\nAddition:");
		DisplayMatrix(AddMatrices(A, B));

		Console.WriteLine("\nSubtraction:");
		DisplayMatrix(SubtractMatrices(A, B));

		Console.WriteLine("\nMultiplication:");
		DisplayMatrix(MultiplyMatrices(A, B));

		Console.WriteLine("\nTranspose of Matrix A:");
		DisplayMatrix(TransposeMatrix(A));

		Console.WriteLine("\nDeterminant of 3x3 Matrix A:");
		double det3 = Determinant3x3(A);
		Console.WriteLine(det3);

		if (det3 != 0)
		{
			Console.WriteLine("\nInverse of 3x3 Matrix A:");
			DisplayDoubleMatrix(Inverse3x3(A));
		}
		else
		{
			Console.WriteLine("\nInverse not possible (Determinant = 0)");
		}
	}

	// a. Create random matrix
	static int[,] CreateRandomMatrix(int rows, int cols)
	{
		Random rand = new Random();
		int[,] matrix = new int[rows, cols];

		for (int i = 0; i < rows; i++)
			for (int j = 0; j < cols; j++)
				matrix[i, j] = rand.Next(1, 10);

		return matrix;
	}

	// b. Matrix addition
	static int[,] AddMatrices(int[,] A, int[,] B)
	{
		int[,] result = new int[A.GetLength(0), A.GetLength(1)];
		for (int i = 0; i < A.GetLength(0); i++)
			for (int j = 0; j < A.GetLength(1); j++)
				result[i, j] = A[i, j] + B[i, j];
		return result;
	}

	// c. Matrix subtraction
	static int[,] SubtractMatrices(int[,] A, int[,] B)
	{
		int[,] result = new int[A.GetLength(0), A.GetLength(1)];
		for (int i = 0; i < A.GetLength(0); i++)
			for (int j = 0; j < A.GetLength(1); j++)
				result[i, j] = A[i, j] - B[i, j];
		return result;
	}

	// d. Matrix multiplication
	static int[,] MultiplyMatrices(int[,] A, int[,] B)
	{
		int[,] result = new int[A.GetLength(0), B.GetLength(1)];

		for (int i = 0; i < A.GetLength(0); i++)
			for (int j = 0; j < B.GetLength(1); j++)
				for (int k = 0; k < A.GetLength(1); k++)
					result[i, j] += A[i, k] * B[k, j];

		return result;
	}

	// 5. Transpose
	static int[,] TransposeMatrix(int[,] matrix)
	{
		int[,] transpose = new int[matrix.GetLength(1), matrix.GetLength(0)];

		for (int i = 0; i < matrix.GetLength(0); i++)
			for (int j = 0; j < matrix.GetLength(1); j++)
				transpose[j, i] = matrix[i, j];

		return transpose;
	}

	// e. Determinant 2x2
	static double Determinant2x2(int[,] m)
	{
		return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
	}

	// f. Determinant 3x3
	static double Determinant3x3(int[,] m)
	{
		return m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
			 - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
			 + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
	}

	// g. Inverse 2x2
	static double[,] Inverse2x2(int[,] m)
	{
		double det = Determinant2x2(m);
		double[,] inv = new double[2, 2];

		inv[0, 0] = m[1, 1] / det;
		inv[0, 1] = -m[0, 1] / det;
		inv[1, 0] = -m[1, 0] / det;
		inv[1, 1] = m[0, 0] / det;

		return inv;
	}

	// h. Inverse 3x3
	static double[,] Inverse3x3(int[,] m)
	{
		double det = Determinant3x3(m);
		double[,] inv = new double[3, 3];

		inv[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / det;
		inv[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) / det;
		inv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / det;

		inv[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) / det;
		inv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / det;
		inv[1, 2] = (m[0, 2] * m[1, 0] - m[0, 0] * m[1, 2]) / det;

		inv[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / det;
		inv[2, 1] = (m[0, 1] * m[2, 0] - m[0, 0] * m[2, 1]) / det;
		inv[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) / det;

		return inv;
	}

	// i. Display matrix
	static void DisplayMatrix(int[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
				Console.Write(matrix[i, j] + "\t");
			Console.WriteLine();
		}
	}

	static void DisplayDoubleMatrix(double[,] matrix)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
				Console.Write($"{matrix[i, j]:F2}\t");
			Console.WriteLine();
		}
	}

		// Employee Bonus Calculation
		int[,] employeeData = GenerateEmployeeData();
		double[,] salaryDetails = CalculateBonus(employeeData);
		DisplayReport(employeeData, salaryDetails);

		// Student PCM Score Card
		int students = Convert.ToInt32(Console.ReadLine());
		int[,] scores = GeneratePCMScores(students);
		double[,] result = CalculateResults(scores, students);
		DisplayScoreCard(scores, result, students);

		// Calendar Program
		int month = Convert.ToInt32(Console.ReadLine());
		int year = Convert.ToInt32(Console.ReadLine());
		string monthName = GetMonthName(month);
		int totalDays = GetDaysInMonth(month, year);
		int firstDay = GetFirstDay(month, year);

		Console.WriteLine("\n   " + monthName + " " + year);
		Console.WriteLine(" Sun Mon Tue Wed Thu Fri Sat");

		for (int i = 0; i < firstDay; i++)
			Console.Write("    ");

		for (int day = 1; day <= totalDays; day++)
		{
			Console.Write($"{day,4}");
			if ((day + firstDay) % 7 == 0)
				Console.WriteLine();
		}
		Console.WriteLine();

		// Euclidean Distance
		int m1 = Convert.ToInt32(Console.ReadLine());
		int n1 = Convert.ToInt32(Console.ReadLine());
		int m2 = Convert.ToInt32(Console.ReadLine());
		int n2 = Convert.ToInt32(Console.ReadLine());
		double dist = EuclideanDistance.CalculateDistance(m1, n1, m2, n2);
		Console.WriteLine("Euclidean Distance: " + dist);

		// Triangle Collinearity
		int x1 = Convert.ToInt32(Console.ReadLine());
		int y1 = Convert.ToInt32(Console.ReadLine());
		int x2 = Convert.ToInt32(Console.ReadLine());
		int y2 = Convert.ToInt32(Console.ReadLine());
		int x3 = Convert.ToInt32(Console.ReadLine());
		int y3 = Convert.ToInt32(Console.ReadLine());

		bool collinear = TriangleCollinearity.ArePointsCollinear(x1, y1, x2, y2, x3, y3);
		Console.WriteLine(collinear
			? "The points are collinear."
			: "The points are not collinear.");

		// OTP Generation
		const int SIZE = 10;
		int[] otpArray = new int[SIZE];
		for (int i = 0; i < SIZE; i++)
			otpArray[i] = OTPUtility.GenerateOTP();

		Console.WriteLine("Generated OTPs:");
		foreach (int otp in otpArray)
			Console.WriteLine(otp);

		Console.WriteLine("All OTPs are unique: " + OTPUtility.AreOTPsUnique(otpArray));

		// NumberChecker4
		int number = Convert.ToInt32(Console.ReadLine());
		int[] factors = NumberChecker4.GetFactors(number);
		Console.WriteLine("Factors: " + string.Join(", ", factors));
		Console.WriteLine("Greatest Factor: " + NumberChecker4.GreatestFactor(factors));
		Console.WriteLine("Sum of Factors: " + NumberChecker4.SumOfFactors(factors));
		Console.WriteLine("Product of Factors: " + NumberChecker4.ProductOfFactors(factors));

		// NumberChecker3
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Prime: " + NumberChecker3.IsPrime(n));
		Console.WriteLine("Neon: " + NumberChecker3.IsNeon(n));
		Console.WriteLine("Spy: " + NumberChecker3.IsSpy(n));
		Console.WriteLine("Automorphic: " + NumberChecker3.IsAutomorphic(n));
		Console.WriteLine("Buzz: " + NumberChecker3.IsBuzz(n));


		int num = Convert.ToInt32(Console.ReadLine());
		int count = NumberChecker2.CountDigits(num);
		int[] digits = NumberChecker2.StoreDigits(num);
		int[] reversed = NumberChecker2.ReverseArray(digits);
		Console.WriteLine("\nCount of digits: " + count);
		Console.WriteLine("Digits: " + string.Join(", ", digits));
		Console.WriteLine("Reversed Digits: " + string.Join(", ", reversed));
		Console.WriteLine("Palindrome: " + NumberChecker2.IsPalindrome(num));
		Console.WriteLine("Duck Number: " + NumberChecker2.IsDuckNumber(digits));



		int no = 21235;
		int c = NumberChecker1.CountDigits(no);
		int[] dig = NumberChecker1.StoreDigits(no);
		Console.WriteLine("Number: " + no);
		Console.WriteLine("Digit Count: " + c);
		Console.Write("Digits: ");
		foreach (int d in dig)
		{
			Console.Write(d + " ");
		}
		Console.WriteLine("Sum of Digits: " + NumberChecker1.SumOfDigits(dig));
		Console.WriteLine("Sum of Squares of Digits: " + NumberChecker1.SumOfSquares(dig));
		Console.WriteLine("Is Harshad Number: " + NumberChecker1.IsHarshadNumber(no, dig));
		NumberChecker1.PrintDigitFrequency(dig);


		int nr = 153;
		int ct = NumberChecker.CountDigits(nr);
		int[] di = NumberChecker.StoreDigits(nr);
		Console.WriteLine("Number: " + nr);
		Console.WriteLine("Digit Count: " + ct);
		Console.Write("Digits: ");
		foreach (int d in di)
		{
			Console.Write(d + " ");
		}
		Console.WriteLine("Is Duck Number: " + NumberChecker.IsDuckNumber(di));
		Console.WriteLine("Is Armstrong Number: " + NumberChecker.IsArmstrong(nr, di));
		NumberChecker.FindLargestAndSecondLargest(di);
		NumberChecker.FindSmallestAndSecondSmallest(di);



		// Football Team
		FootballTeam team = new FootballTeam();
		team.GenerateHeights();
		team.DisplayHeights();
		Console.WriteLine("Sum: " + team.FindSum());
		Console.WriteLine("Mean: " + team.FindMean().ToString("F2"));
		Console.WriteLine("Shortest: " + team.FindShortest());
		Console.WriteLine("Tallest: " + team.FindTallest());
	}
}



