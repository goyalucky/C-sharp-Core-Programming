using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class TotalPrice
    {
        public void Price()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            double unitPrice = 0, quantity = 0;

            if (!string.IsNullOrWhiteSpace(input1) && !string.IsNullOrWhiteSpace(input2))
            {
                unitPrice = double.Parse(input1);
                quantity = double.Parse(input2);
            }

            Console.WriteLine($"The total purchase price is INR {unitPrice * quantity} if the quantity {quantity} and unit price is INR {unitPrice}");

        }
    }
}
