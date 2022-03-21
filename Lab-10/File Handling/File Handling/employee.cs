using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class employee
    {
        public string id;
        public string first_name;
        public string last_name;
        public string email;
        public string phone_number;
        public string hire_date;
        public string job_id;
        public string salary;

        public employee(string id, string first_name, string last_name, string email, string phone_number, string hire_date, string job_id, string salary)
        {
            this.id = id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.hire_date = hire_date;
            this.job_id = job_id;
            this.salary = salary;
        }

        public string GetEmployee()
        {
            return id + '\t' + first_name + " " + last_name;
        }
    }
}
