using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class ProfitLoss
    {
        public void ProfitPercentage()
        {
            double cost_price = 129;
            double Selling_price = 191;

            double profit = Selling_price - cost_price;
            double percentage = (profit / cost_price) * 100;


            Console.WriteLine($"The Cost Price is INR {cost_price} and Selling Price is INR {Selling_price}");
            Console.WriteLine($"The Profit is INR {profit} and the Profit Percentage is {percentage.ToString("F2")}");
        }
    }
}
