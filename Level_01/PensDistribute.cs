using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class PensDistribute
    {
        internal void Pens() 
        {
            int totalPens = 14;
            int totalStudents = 3;

            Console.WriteLine($"The Pen Per Student is {totalPens / totalStudents} and the remaining pen not distributed is {totalPens % totalStudents}");
        }
    }
}
