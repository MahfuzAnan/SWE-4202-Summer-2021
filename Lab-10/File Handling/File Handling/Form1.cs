using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Handling
{
    public partial class Form1 : Form
    {
        List<employee> employeeList = new List<employee>();
        public Form1()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader(@"D:\New folder (2)\employees.csv");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] column = new string[7];
                column = line.Split(',');
                employee dummy = new employee(column[0], column[1], column[2], column[3], column[4], column[5], column[6], column[7]);
                employeeList.Add(dummy);
            }

            for(int i = 1;i < employeeList.Count;i++)
            {
                employeelist_listbox.Items.Add(employeeList[i].GetEmployee());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Search_button_Click(object sender, EventArgs e)
        {
            string ID = ID_search_textbox.Text;
            bool flag = false;
            DateTime time = DateTime.Now;
            for (int i = 1; i <employeeList.Count; i++)
            { 
                string dummy_id = employeeList[i].id;
                if (ID == dummy_id)
                {
                    Name_textbox.Text = employeeList[i].first_name + " " + employeeList[i].last_name;
                    ID_textbox.Text = employeeList[i].id;
                    Hire_Date_textbox.Text = employeeList[i].hire_date;
                    Salary_textbox.Text = employeeList[i].salary;
                    flag = true;
                }
            }
            StreamWriter wr = File.AppendText("log.txt");
            if (flag == false)
            {
                wr.WriteLine("no id" + "\t" + ID + "\t" + time);
                MessageBox.Show("Invalid ID");
                wr.Close();
            }
            else
            {
                wr.WriteLine("id verified" + "\t" + ID + "\t" + time);
                wr.Close();
            }
        } 
    }
}
