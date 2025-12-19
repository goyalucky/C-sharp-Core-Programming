using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class Perimeter
    {
        public void perimeter()
        {
            String Input = Console.ReadLine();
            double num = double.Parse(Input);
            Console.WriteLine($"The length of the side is {Math.Sqrt(num)} whose perimeter is {num}");
        }
    }
}
