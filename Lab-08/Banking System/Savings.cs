using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Savings : Accounts
    {
        protected override void translimit(int transLimit)
        {
            this.transLimit = 5;
        }
        protected override void setWithdrawCharge(int withdrawch)
        {
            withdrawCharge = 15;
        }
    }
}
