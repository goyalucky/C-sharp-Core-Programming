using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class DistanceYard
    {
        public void Yards()
        {
            string input = Console.ReadLine();
            double num=0;

            if (!string.IsNullOrWhiteSpace(input))
            {
                num = double.Parse(input);
            }

            double distanceInCm = num * 30;
            double distanceInInches = distanceInCm / 2.54;

            Console.WriteLine($"Your Height in cm is {distanceInCm} while in feet is {num} and inches is {distanceInInches:F2}");       
        }
    }
}
