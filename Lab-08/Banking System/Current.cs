using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Current : Accounts
    {
        protected override void transamount(int maxtransamount)
        {
            maxTransAmount = 100000;
        }
    }
}
