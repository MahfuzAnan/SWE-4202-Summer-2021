using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_Processing_System
{
    internal class Student_Mark
    {
        public string id, name, attendence,  mid, final, viva, percent;
        public string[] quiz = new string[4];

        public Student_Mark()
        {

        }
        public Student_Mark(string id, string name, string attendence, string quiz_1, string quiz_2, string quiz_3, string quiz_4, string mid, string final, string viva)
        {
            this.id = id;
            this.name = name;
            this.attendence = attendence;
            this.quiz[0] = quiz_1;
            this.quiz[1] = quiz_2;
            this.quiz[2] = quiz_3;
            this.quiz[3]= quiz_4;
            this.mid = mid;
            this.final = final;
            this.viva = viva;
        }

        public string getQuizMark()
        {
            Array.Sort(quiz);
            int total = int.Parse(quiz[1]) + int.Parse(quiz[2]) + int.Parse(quiz[3]);
            return total.ToString();
        }

        public string getTotal(string attendence, string quiz_1, string quiz_2, string quiz_3, string quiz_4, string mid, string final, string viva)
        {
            int a = Convert.ToInt32(attendence);
            int q1 = Convert.ToInt32(quiz_1);
            int q2 = Convert.ToInt32(quiz_2);
            int q3 = Convert.ToInt32(quiz_3);
            int q4 = Convert.ToInt32(quiz_4);
            int m = Convert.ToInt32(mid);
            int f = Convert.ToInt32(final);
            int v = Convert.ToInt32(viva);

            int total = a+ q1 + q2 + q3 + q4 + m + f + v;

            return Convert.ToString(total);
        }

        public string getPercentage(string attendence, string quiz_1, string quiz_2, string quiz_3, string quiz_4, string mid, string final, string viva)
        {
            int a = Convert.ToInt32(attendence);
            int q1 = Convert.ToInt32(quiz_1);
            int q2 = Convert.ToInt32(quiz_2);
            int q3 = Convert.ToInt32(quiz_3);
            int q4 = Convert.ToInt32(quiz_4);
            int m = Convert.ToInt32(mid);
            int f = Convert.ToInt32(final);
            int v = Convert.ToInt32(viva);

            int total = a + q1 + q2 + q3 + q4 + m + f + v;

            float percentage = (((float)total / 300) * 100);

            return Convert.ToString(percentage);
        }

        public string getGrade(string percent)
        {
            double percentage = Convert.ToDouble(percent);
            if (percentage >= 80f && percentage <= 100f)
                return "A+";
            else if (percentage >= 75f && percentage <= 79f)
                return "A";
            else if (percentage >= 70f && percentage <= 74f)
                return "A-";
            else if (percentage >= 65f && percentage <= 69f)
                return "B+";
            else if (percentage >= 60f && percentage <= 64f)
                return "B";
            else if (percentage >= 55f && percentage <= 59f)
                return "B-";
            else if (percentage >= 50f && percentage <= 54f)
                return "C+";
            else if (percentage >= 45f && percentage <= 49f)
                return "C";
            else if (percentage >= 40f && percentage <= 44f)
                return "D";
            else
                return "F";
        }

        public string getID()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }
    }
}
