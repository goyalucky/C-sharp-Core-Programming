using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class TotalHanshakes
    {
        public void Hanshakes()
        {
            String input = Console.ReadLine();
            int n = 0;
            if(!string.IsNullOrWhiteSpace(input))
            {
                n = int.Parse(input);
            }

            int maxHanshakes = (n * (n - 1)) / 2;

            Console.WriteLine($"the number of possible handshakes {maxHanshakes}");

        }
    }
}
