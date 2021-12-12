using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class book
    {
        public int book_id;
        public string book_name;
        public string author;
        public string publisher;
        public int quantity;


        public book(int book_id, string book_name, string author, string publisher, int quantity)
        {
            this.book_id = book_id;
            this.book_name = book_name;
            this.author = author;
            this.publisher = publisher;
            this.quantity = quantity;
        }

        public string history()
        {
            return this.book_id.ToString() + "\t" + this.book_name;
        }
    }
}
