using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmecy_Management_System
{
    public partial class Form1 : Form
    {
        List<Medicine>Medicines = new List<Medicine>();
        public Form1()
        {
            InitializeComponent();
        }

        int balance = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ADD_MEDICINE_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Add_Medicine_ID_Textbox.Text);
            string name = Add_Medicine_Name_Textbox.Text;
            string price = Add_Medicine_Unit_Price_Textbox.Text;
            int quantity = Convert.ToInt32(Add_Medicine_Quantity_Textbox.Text);

            if (quantity < 0)
            {
                MessageBox.Show("Quantity can not be negative.");
                return;
            }

            Medicine dummy = new Medicine(id, name, price, quantity);
            Medicines.Add(dummy);
            MessageBox.Show("Medicine has been added successfully!");
        }

        private void SHOW_STOCK_button_Click(object sender, EventArgs e)
        {
           
            Current_Stock_ListBox.Items.Clear();
            for(int i = 0; i < Medicines.Count; i++)
            { 
                Current_Stock_ListBox.Items.Add(Medicines[i].Stock());
            }
        }

        private bool medicineExists(int id)
        {
            foreach (Medicine medicine in Medicines)
            {
                if (medicine.id == id)
                {
                    return true;
                }
            }
            return false;
        }


        private void SELL_MEDICINE_button_Click(object sender, EventArgs e)
        {
            int sell_id = Convert.ToInt32(Sell_Medicine_ID_Textbox.Text);
            int sell_unit = Convert.ToInt32(Sell_Medicine_Units_Textbox.Text);
            int sell_price = Convert.ToInt32(Sell_Medicine_price_textbox.Text);

            if (medicineExists(sell_id))
            {
                foreach (Medicine medicine in Medicines)
                {
                    if (medicine.id == sell_id)
                    {
                        if (medicine.quantity < sell_unit)
                        {
                            MessageBox.Show("Not enough item in stock.");
                            break;
                        }
                        medicine.quantity -= sell_unit;
                        balance = balance + (sell_unit * sell_price);
                        MessageBox.Show("Medicine has been sold!");
                    }
                }
            }
        }
        private void Sell_Medicine_ID_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SHOW_BALANCE_button_Click(object sender, EventArgs e)
        {
            Balance_Textbox.Text = Convert.ToString(balance);
        }

        private void ADD_MEDICINE_CLEAR_button_Click(object sender, EventArgs e)
        {
            Add_Medicine_ID_Textbox.Text = string.Empty;
            Add_Medicine_Name_Textbox.Text = string.Empty;
            Add_Medicine_Unit_Price_Textbox.Text = string.Empty;
            Add_Medicine_Quantity_Textbox.Text = string.Empty;


            MessageBox.Show("Cleared successfully!");
        }

        private void SELL_MEDICINE_CLEAR_button_Click(object sender, EventArgs e)
        {
            Sell_Medicine_ID_Textbox.Text = string.Empty;
            Sell_Medicine_Units_Textbox.Text = string.Empty;
            Sell_Medicine_price_textbox.Text = string.Empty;


            MessageBox.Show("Cleared successfully!");
        }
    }
}
