using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    abstract class Animal
    {
        string nameOfAnimal, habitatArea, sound;
        double height, weight;
        int birthDate = 2021;

        public Animal(string Name, string HabitatArea, string Sound, double Weight, double Height, int BirthDate)
        {
            nameOfAnimal = Name;
            habitatArea = HabitatArea;
            sound = Sound;
            weight = Weight;
            height = Height;
            birthDate = BirthDate;
        }

        public string Name
        {
            get { return nameOfAnimal; }
            set { nameOfAnimal = value; }
        }
        public string HabitatArea
        {
            get { return habitatArea; }
            set { habitatArea = value; }
        }
        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public int BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public int GetAge()
        {
            int time = 2021 - birthDate;
            return time;
        }

        public string GetInformation()
        {
            string s = "Name " + nameOfAnimal + "\n" + "Habitat Area " + habitatArea + "\n" + "Sound " + sound + "\n" + "Weight " + weight + "\n" + "Height " + height + "\n";
            return s;
        }

        public double ChangeWeight(double amount)
        {
            weight += amount;
            return weight;
        }
    }
}
