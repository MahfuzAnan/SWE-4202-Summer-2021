using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        int accId = 1;
        List<Accounts> accounts = new List<Accounts>();
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxUserName.Text;
            string address = textBoxUserAddress.Text;
            string accType = comboBoxAccType.Text;
            int minBalance = Convert.ToInt32(textBoxUserBalance.Text);

            if(accType == "Current Account")
            {
                if(minBalance < 500)
                {
                    MessageBox.Show("You need minimum 500BDT to create this account.");
                }
                else
                {
                    Current dummy = new Current();
                    dummy.accType = accType;
                    dummy.minBalance = minBalance;
                    dummy.mainBalance = minBalance;
                    dummy.accNo = accId;
                    accounts.Add(dummy);

                    User dummyuser = new User();
                    dummyuser.Name = name;
                    dummyuser.address = address;
                    dummyuser.accType = accType;
                    dummyuser.accId = accId;
                    users.Add(dummyuser);
                    
                    MessageBox.Show("Your account has been created succesfully. Your acc ID: " + accId);
                    accId++;
                }
            }
            else
            {
                Current dummy = new Current();
                dummy.accType = accType;
                dummy.minBalance = minBalance;
                dummy.mainBalance = minBalance;
                dummy.accNo = accId;
                accounts.Add(dummy);

                User dummyuser = new User();
                dummyuser.Name = name;
                dummyuser.address = address;
                dummyuser.accType = accType;
                dummyuser.accId = accId;
                users.Add(dummyuser);

                MessageBox.Show("Your account has been created succesfully. Your acc ID: " + accId);
                accId++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int accId = Convert.ToInt32(textBoxDepAccId.Text);
            int amount = Convert.ToInt32(textBoxDepAmount.Text);

            if (amount < 0)
            {
                MessageBox.Show("Invalid Transaction");
            }
            else
            {
                foreach (Accounts acc in accounts)
                {
                    if (acc.accNo == accId)
                    {
                        acc.mainBalance += amount;
                        acc.trans += amount;
                        acc.transDone++;
                        MessageBox.Show("Deposit Succesful.");
                        if (acc.accType == "Current Account")
                        {
                            if (acc.trans > 100000)
                            {
                                MessageBox.Show("Maximum transaction amount exceeded!");
                                acc.mainBalance -= amount;
                            }
                        }
                        if (acc.accType == "Savings Account")
                        {
                            if (acc.transDone > 5)
                            {
                                MessageBox.Show("Maximum transaction limit Exceeded");
                                acc.mainBalance -= amount;
                            }

                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int accId = Convert.ToInt32(textBoxDepAccId.Text);
            int amount = Convert.ToInt32(textBoxDepAmount.Text);
            if (amount < 0)
            {
                MessageBox.Show("Invalid Transaction!");
            }
            else
            {
                foreach (Accounts acc in accounts)
                {
                    if (acc.accNo == accId)
                    {
                        if (amount > acc.mainBalance)
                        {
                            MessageBox.Show("Not Enough Balance!");
                        }
                        else
                        {
                            acc.mainBalance -= amount;
                            acc.trans += amount;
                            acc.transDone++;
                            MessageBox.Show("Withdraw Successful.");
                        }
                        if (acc.accType == "Current Account")
                        {
                            if (acc.trans > 100000)
                            {
                                MessageBox.Show("Maximum transaction amount exceeded!");
                                acc.mainBalance += amount;
                            }
                        }
                        if (acc.accType == "Savings Account")
                        {
                            acc.mainBalance -= 15;
                            if (acc.transDone > 5)
                            {
                                MessageBox.Show("Maximum transaction limit Exceeded");
                                acc.mainBalance += (amount+15);
                            }

                        }
                        if(acc.accType == "Loan Account")
                        {
                            MessageBox.Show("You can't withdraw from a loan account!");
                            acc.mainBalance += amount;
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxShowBalId.Text);

            foreach(Accounts acc in accounts)
            {
                if(acc.accNo == id)
                {
                    label14.Text = acc.mainBalance.ToString();
                }
            }
        }
    }
}
