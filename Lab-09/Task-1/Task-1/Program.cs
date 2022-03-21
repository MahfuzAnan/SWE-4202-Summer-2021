using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a shape:");
            string shape=Console.ReadLine();

            if(shape=="circle")
            {
                Circle circle = new Circle();
                Console.WriteLine("Enter Radius:");
                double radius = Convert.ToDouble(Console.ReadLine());
                circle.radius = radius;

                double area = circle.areaCircle(radius);
                double perimeter= circle.perimeterCircle(radius);
                Console.WriteLine("Area =" + Convert.ToString(area));
                Console.WriteLine("Perimeter =" + Convert.ToString(perimeter));
                Console.ReadLine();
            }

            if(shape=="rectangle")
            {
                Rectangle rectangle = new Rectangle();
                Console.WriteLine("Enter Length:");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Width:");
                double width = Convert.ToDouble(Console.ReadLine());
                rectangle.length = length;
                rectangle.width = width;

                double area = rectangle.areaRectangle(length,width);
                double perimeter = rectangle.perimeterRectangle(length,width);

                Console.WriteLine("Area =" + Convert.ToString(area));
                Console.WriteLine("Perimeter =" + Convert.ToString(perimeter));
                Console.ReadLine();
            }
             
            if(shape=="cube")
            {
                Cube cube = new Cube();
                Console.WriteLine("Enter Length:");
                double length = Convert.ToDouble(Console.ReadLine());
                cube.length = length;

                double surface_area = cube.surfaceareaCube(length);
                double volume = cube.volumeCube(length);
                Console.WriteLine("Surface Area :" + Convert.ToString(surface_area));
                Console.WriteLine("Volume :" + Convert.ToString(volume));
                Console.ReadLine();
            }

            if (shape == "sphere")
            {
                Sphere sphere = new Sphere();
                Console.WriteLine("Enter Radius:");
                double radius = Convert.ToDouble(Console.ReadLine());
                sphere.radius = radius;

                double surface_area = sphere.surfaceareaSphere(radius);
                double volume = sphere.volumeSphere(radius);
                Console.WriteLine("Surface Area :" + Convert.ToString(surface_area));
                Console.WriteLine("Volume :" + Convert.ToString(volume));
                Console.ReadLine();
            }
        }
    }
}
