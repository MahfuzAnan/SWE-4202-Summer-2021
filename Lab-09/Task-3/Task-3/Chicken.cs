using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Chicken : Animal
    {
        public Chicken(string Name, string HabitatArea, string Sound, double Weight, double Height, int BirthDate) : base(Name, HabitatArea, Sound, Weight, Height, BirthDate)
        { }
    }
}
