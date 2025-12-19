using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class BasicCalculator
    {
        public void Calculator()
        {
            double number1;
            double number2;

            double.TryParse(Console.ReadLine(), out number1);
            double.TryParse(Console.ReadLine(), out number2);

            Console.WriteLine(
                $"The addition, subtraction, multiplication and division value of 2 numbers {number1} and {number2} is " +
                $"{number1 + number2}, {number1 - number2}, {number1 * number2}, {number1 / number2}");
         }

    }
}
