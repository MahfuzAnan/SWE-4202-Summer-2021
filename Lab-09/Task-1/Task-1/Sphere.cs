using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Sphere:Shape
    {
        public double surfaceareaSphere(double radius)
        {
            return 4 * 3.1416 * Math.Pow(radius, 2);
        }
        public double volumeSphere(double radius)
        {
            return (4/3) * 3.1416 * Math.Pow(radius, 3);
        }
        public Sphere()
        {
            Console.WriteLine("I am three dimensional");
        }
    }
}
