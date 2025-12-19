using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class HeightConversion
    {
        public void HeightConvert()
        {
            string input = Console.ReadLine();
            double heightCm = double.Parse(input);
            double totalInches = heightCm / 2.54;
            int feet = (int)(totalInches / 12);
            double inches = totalInches % 12;
            Console.WriteLine($"Your Height in cm is {heightCm} while in feet is {feet} and inches is {inches:F2}");
        }
    }
}
