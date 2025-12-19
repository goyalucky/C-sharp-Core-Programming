using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class UniversityDiscount
    { 
        public void Discount()
        {
            double fees = 125000;
            double discountPercent = 10;
            double discount = discountPercent / 100 * 125000;
            double fianlAmount = fees - discount;

            Console.WriteLine($"The discount amount is INR {discount} and final discounted fee is INR {fianlAmount}");
        }
    }
}
