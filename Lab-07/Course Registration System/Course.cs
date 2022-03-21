using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Registration_System
{
    internal class Course
    {
        public string title, level = "Beginner", fee, date;

        public Course(string title, string level, string fee)
        {
            this.title = title;
            this.level = level;
            this.fee = fee;
        }

        public string getInfo()
        {
            string s = title + "\t" + level + "\t" + date + "\t" + fee;
            return s;
        }
    }
}
