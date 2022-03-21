using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Circle:Shape
    {
        public double perimeterCircle(double radius)
        {
            return 2 * 3.1416 * radius;
        }

        public double areaCircle(double radius)
        {
            return 3.1416 * radius * radius;
        }

        public Circle()
        {
            Console.WriteLine("I am two dimensional");
        }
    }
}
