using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.M.S
{
    internal class Research_Article:Book
    {
        public string doi;
        public string publish_date;
        public string conf_jour;


        public Research_Article(int id, string title, string author, string publisher, int quantity, string doi, string publish_date, string conf_jour)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publihser = publisher;
            this.quantity = quantity;
            this.doi = doi;
            this.publish_date = publish_date;
            this.conf_jour = conf_jour;
        }

        public string history()
        {
            return this.id.ToString() + "\t" + this.title + "\t" + this.author + "\t" + this.doi + "\t" + this.quantity.ToString() + "\t" + conf_jour;
        }
    }
}
