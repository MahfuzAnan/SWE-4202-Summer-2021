using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class user
    {
        public int std_id;
        public string std_name;
        public string std_address;
        public List<int> books = new List<int>();

        public user()
        {
        }

        public user(int std_id, string std_name, string std_address)
        {
            this.std_id = std_id;
            this.std_name = std_name;
            this.std_address = std_address;
        }

        public void addBook(int std_id)
        {
            books.Add(std_id);
        }

        public void returnBook(int std_id)
        {
            books.Remove(std_id);
        }
    }
}
