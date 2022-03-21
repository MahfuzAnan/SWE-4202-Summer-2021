using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Account
    {
        float balance;
        string accountNo, accountName;

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }
        }

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

    }
}
