using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class VolumeOfEarth
    {
        public void Volume()
        {
            double radius = 6378;
            double cubicKm = Math.PI * Math.Pow(radius, 3);
            double cubicMiles = Math.PI * Math.Pow((radius/1.6), 3);

            Console.WriteLine($"The volume of earth in cubic kilometers is {cubicKm} and cubic miles is {cubicMiles}");

        }
    }
}
