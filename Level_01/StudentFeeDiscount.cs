using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class StudentFeeDiscount()
    { 
        public void Discount()
        {
            double fee = double.Parse(Console.ReadLine());
            double discountPercent = double.Parse(Console.ReadLine());
            double discount = fee * discountPercent / 100;
            double finalFee = fee - discount;
            Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
        }
    }
}
