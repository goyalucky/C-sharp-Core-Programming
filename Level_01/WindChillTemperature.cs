/*Write a program calculate the wind chill temperature given the temperature and wind speed*/


using System;

class WindChillTemperature
{
	public void ShowWindChillTemperature()
	{
		double temperature = Convert.ToDouble(Console.ReadLine());
		double windSpeed = Convert.ToDouble(Console.ReadLine());
		double windChill = 35.74 + 0.6215 * temperature - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);
		Console.WriteLine("The Wind Chill Temperature is: " + windChill);
	}
}