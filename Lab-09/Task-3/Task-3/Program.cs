using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chicken chicken = new Chicken("Chicken", "BD", "Buck Buck", 2, 3, 2002);
            Console.WriteLine(chicken.Sound);
            Console.ReadLine();

            Cat cat = new Cat("Neko", "myHome", "Meow", 50, 5, 2000);
            Console.WriteLine(cat.Sound);
            Console.ReadKey();

            Cow cow = new Cow("Cow", "Gowal_Ghor", "Moo", 100, 10, 2000);
            Console.WriteLine(cow.Sound);
            Console.ReadKey();
        }
    }
}
