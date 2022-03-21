using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Cube:Shape
    {
        public double surfaceareaCube(double length)
        {
            return 6*Math.Pow(length, 2);
        }
        public double volumeCube(double lenght)
        {
            return Math.Pow(lenght, 3);
        }
        public Cube ()
        {
            Console.WriteLine("I am three dimensional");
        }
    }
}
