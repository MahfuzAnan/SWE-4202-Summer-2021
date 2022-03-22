using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Result_Processing_System
{
    public partial class Form1 : Form
    {
        List<Student_Mark>student_Marks = new List<Student_Mark>();
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("SWE4201MarkSheet_.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] col = new string[10];
                col = line.Split(',');
                Student_Mark dummy = new Student_Mark(col[0], col[1], col[2], col[3], col[4], col[5], col[6], col[7], col[8], col[9]);
                student_Marks.Add(dummy);     
            } 
            for (int i = 0; i < student_Marks.Count; i++)
            {
                Result_listbox.Items.Add(student_Marks[i].getID() + "\t" + student_Marks[i].getName() + "\t" + "\t" + student_Marks[i].getPercentage(student_Marks[i].attendence, student_Marks[i].quiz[0], student_Marks[i].quiz[1], student_Marks[i].quiz[2], student_Marks[i].quiz[3], student_Marks[i].mid, student_Marks[i].final, student_Marks[i].viva) + "%");
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = Search_textbox.Text;
            var studentinfo= from marks in student_Marks
                             where marks.id == ID
                             select marks;
            foreach( var mark in studentinfo)
            {
                Attendence_textbox.Text = mark.attendence;
                Quiz_1_textbox.Text = mark.quiz[0];
                Quiz_2_textbox.Text = mark.quiz[1];
                Quiz_3_textbox.Text = mark.quiz[2];
                Quiz_4_textbox.Text = mark.quiz[3];
                Quiz_Total_textbox.Text = mark.getQuizMark();
                Mid_textbox.Text = mark.mid;
                Final_textbox.Text = mark.final;
                Total_textbox.Text = mark.getTotal(mark.attendence, mark.quiz[0], mark.quiz[1], mark.quiz[2], mark.quiz[3], mark.mid, mark.final, mark.viva);
                Percentage_textbox.Text = mark.getPercentage(mark.attendence, mark.quiz[0], mark.quiz[1], mark.quiz[2], mark.quiz[3], mark.mid, mark.final, mark.viva) + "%";
                Grade_textbox.Text = mark.getGrade(mark.getPercentage(mark.attendence, mark.quiz[0], mark.quiz[1], mark.quiz[2], mark.quiz[3], mark.mid, mark.final, mark.viva));
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
