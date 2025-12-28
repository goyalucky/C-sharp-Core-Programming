/*Write a program that converts temperatures between Fahrenheit and Celsius.The program should have separate functions for converting from Fahrenheit to
Celsius and from Celsius to Fahrenheit.*/


using System;

class Temperature
{
	// Method to convert Celsius to Fahrenheit
	public double CelsiusToFahrenheit(double celsius)
	{
		return (celsius * 9 / 5) + 32;
	}
	// Method to convert Fahrenheit to Celsius
	public double FahrenheitToCelsius(double fahrenheit)
	{
		return (fahrenheit - 32) * 5 / 9;
	}
}