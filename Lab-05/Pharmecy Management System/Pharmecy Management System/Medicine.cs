using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmecy_Management_System
{
    internal class Medicine
    {
        public int id;
        public string name;
        public string price;
        public int quantity;
       
        public Medicine()
        {
        }

        public Medicine(int id, string name, string price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string Stock()
        {
            return this.id.ToString() + "\t" + this.name + "\t" + this.price.ToString() + "\t" + this.quantity.ToString();
        }
    }
}
