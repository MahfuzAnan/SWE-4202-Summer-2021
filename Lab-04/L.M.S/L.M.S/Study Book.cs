using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.M.S
{
    internal class Study_Book:Book
    {
        public string isbn;
        public string genre;

        public Study_Book(int id, string title, string author, string publisher, int quantity, string isbn, string genre)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publihser = publisher;
            this.quantity = quantity;   
            this.isbn = isbn;
            this.genre = genre;
        }

        public string history()
        {
            return this.id.ToString() + "\t" + this.title + "\t" + this.author + "\t" + this.isbn + "\t" + this.quantity.ToString();
        }
    }
}
