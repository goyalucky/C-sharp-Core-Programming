using System;

class Program
{
	static void Main()
	{
		string d1 = Console.ReadLine();
		string d2 = Console.ReadLine();
		DateComparer comparer = new DateComparer();
		comparer.CompareDates(d1, d2);

		DateFormatter formatter = new DateFormatter();
		formatter.ShowFormats();


		Console.Write("Enter date (dd-MM-yyyy): ");
		string input = Console.ReadLine();
		DateCalculator calculator = new DateCalculator();
		calculator.CalculateDate(input);


		TimeZoneService service = new TimeZoneService();
		service.DisplayTimeZones();
	}
}
