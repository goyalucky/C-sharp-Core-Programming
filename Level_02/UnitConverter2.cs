/*Extend or Create a UnitConvertor utility class similar to the one shown in the notes to
do the following. Please define static methods for all the UnitConvertor class methods.*/


using System;

class UnitConverter2
{
	// Convert fahrenheit to celsius
	public static double farhenheit2celsius(double farhenheit)
	{
		double farhenheit2celsius = (farhenheit - 32) * 5 / 9;
		return farhenheit * farhenheit2celsius;
	}

	// Convert Celsius to fahrenheit
	public static double celsius2farhenheit(double celsius)
	{
		double celsius2farhenheit = (celsius * 9 / 5) + 32; ;
		return celsius * celsius2farhenheit;
	}

	// Convert Pounds to Kilograms
	public static double pounds2kilograms(double pounds)
	{
		double pounds2kilograms = 0.453592;
		return pounds * pounds2kilograms;
	}

	// Convert Kilograms to Pounds
	public static double kilograms2pounds(double kilograms)
	{
		double kilograms2pounds = 2.20462;
		return kilograms * kilograms2pounds;
	}

	// Convert gallons to liters
	public static double gallons2liters(double gallons)
	{
		double gallons2liters = 3.78541;
		return gallons * gallons2liters;
	}
	// Convert litres to gallons
	public static double liters2gallons(double liters)
	{
		double liters2gallons = 0.264172;
		return liters * liters2gallons;
	}
}
