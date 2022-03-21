using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_System
{
    public partial class Form1 : Form
    {
        List<Participant> participants = new List<Participant>();
        List<Course> enterCourses = new List<Course>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentReg = comboBoxSelectStudent.Text;
            string selectCourse = comboBoxSelectCourse.Text;
            string date = textBoxDate.Text;

            foreach(Participant p in participants)
            {
                if(p.regNo == studentReg)
                {
                    foreach(Course c in enterCourses)
                    {
                        if(c.title == selectCourse)
                        {
                            c.level = p.Level;
                            c.date = date;
                            double temp = Convert.ToDouble(c.fee);
                            if (p.type == "Professional")
                            {
                                labelShowCourseFee.Text = (temp + temp * .1).ToString();
                                c.fee = (temp + temp * .1).ToString();
                            }
                            else
                                labelShowCourseFee.Text = (temp).ToString();
                            p.courses.Add(c);
                        }
                    }
                }
            }

            MessageBox.Show("Enrollment Successful.");
        }

        private void buttonAddpARTICIPANT_Click(object sender, EventArgs e)
        {
            string name = textBoxParticipantName.Text;
            string reg = textBoxParticipantReg.Text;
            string contact = textBoxParticipantContact.Text;
            string email = textBoxParticipantMail.Text;
            string level = comboBoxParticipantLevel.Text;
            string type = comboBoxParticipantType.Text;

            comboBoxSelectStudent.Items.Add(reg);
            comboBoxStudentSelect.Items.Add(reg);

            Participant dummy = new Participant();
            dummy.name = name;
            dummy.regNo = reg;
            dummy.contactNo = contact;
            dummy.email = email;
            dummy.Level = level;
            dummy.type = type;

            int flag = 0;
            foreach(Participant p in participants)
            {
                if(p.regNo == reg)
                {
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                participants.Add(dummy);
                MessageBox.Show("Participant has been added.");
            }
            else
            {
                MessageBox.Show("This participant has already been added.");
            }
        }

        private void buttonCourseAdd_Click(object sender, EventArgs e)
        {
            string title = textBoxCourseTitle.Text;
            string level = comboBoxCourseLevel.Text;
            string fee = textBoxCourseFee.Text;
            int flag = 0;

            foreach(Course c in enterCourses)
            {
                if(c.title == title)
                {
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                comboBoxSelectCourse.Items.Add(title);
                Course dummy = new Course(title, level, fee);
                enterCourses.Add(dummy);
                MessageBox.Show("Course has been added.");
            }
            else
            {
                MessageBox.Show("This course has already been added");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string reg = comboBoxStudentSelect.Text;

            listBoxShow.Items.Clear();
            foreach(Participant p in participants)
            {
                if(p.regNo == reg)
                {
                    foreach(Course c in p.courses)
                    {
                        listBoxShow.Items.Add(c.getInfo());
                    }
                }
            }
        }
    }
}
