using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Accounts
    {
        public int accNo, minBalance = 0, mainBalance = 0, transLimit, maxTransAmount, withdrawCharge, trans = 0, transDone = 0;
        public string accType;

        protected virtual void setWithdrawCharge(int withdrawch)
        {
            withdrawCharge = withdrawch;
        }
        protected virtual void translimit(int transLimit)
        {
            this.transLimit = transLimit;
        }
        protected virtual void transamount(int maxtransamount)
        {
            this.maxTransAmount = maxtransamount;
        }
    }
}
