using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Registration_System
{
    internal class Participant
    {
        public string name, regNo, contactNo, email, type;
        public string Level = "Beginner";
        public List<Course> courses = new List<Course>();
    }
}
