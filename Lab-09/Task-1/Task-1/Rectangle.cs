using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Rectangle:Shape
    {
        public double perimeterRectangle(double length, double width)
        {
            return length + width;
        }
        public double areaRectangle(double length, double width)
        {
            return length * width;
        }

        public Rectangle()
        {
            Console.WriteLine("I am two dimensional");
        }
    }
}
