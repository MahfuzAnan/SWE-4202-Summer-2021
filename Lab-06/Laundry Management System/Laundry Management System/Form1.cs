using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Management_System
{
    public partial class Form1 : Form
    {
        int balance = 0;
        int order_no = 0;
        List<User> users = new List<User>();
        List<Place_Order> orders = new List<Place_Order>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Create_Account_Button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(User_ID_Textbox.Text);
            string name = User_Name_Textbox.Text;
            string address = User_Address_Textbox.Text;

            User dummy = new User();
            dummy.id=id;
            dummy.name=name;
            dummy.address=address;

            users.Add(dummy);
            MessageBox.Show("User has been added!!");
        }

        private void Place_Order_Button_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Order_User_ID_Textbox.Text);
            int shirt = Convert.ToInt32(Order_Shirt_Textbox.Text);
            int pants = Convert.ToInt32(Order_Pants_Textbox.Text);
            int suits = Convert.ToInt32(Order_Suits_Textbox.Text);
            int sheets = Convert.ToInt32(Order_Bed_Sheets_Textbox.Text);
            string shirt_to_do = Shirt_Combo_Box.Text;
            string pants_to_do = Pants_Combo_Box.Text;
            string suits_to_do = Suits_Combo_Box.Text;
            string sheets_to_do = Bed_Sheets_Combo_Box.Text;

            Place_Order dummy = new Place_Order();
            dummy.shirt = shirt;
            dummy.pants = pants;
            dummy.suits = suits;
            dummy.sheets = sheets;
            dummy.shirt_to_do = shirt_to_do;
            if (shirt_to_do == "Wash")
            {
                dummy.price_shirt = 7;
            }
            else if (shirt_to_do == "Iron")
            {
                dummy.price_shirt = 8;
            }
            else if (shirt_to_do == "Both")
            {
                dummy.price_shirt = 15;
            }
            dummy.pants_to_do = pants_to_do;
            if (pants_to_do == "Wash")
            {
                dummy.price_pants = 10;
            }
            else if (pants_to_do == "Iron")
            {
                dummy.price_pants = 13;
            }
            else if (pants_to_do == "Both")
            {
                dummy.price_pants = 23;
            }
            dummy.suits_to_do = suits_to_do;
            if (suits_to_do == "Wash")
            {
                dummy.price_suits = 15;
            }
            else if (suits_to_do == "Iron")
            {
                dummy.price_suits = 20;
            }
            else if (suits_to_do == "Both")
            {
                dummy.price_suits = 35;
            }
            dummy.sheets_to_do = sheets_to_do;
            if (sheets_to_do == "Wash")
            {
                dummy.price_sheets = 12;
            }
            else if (sheets_to_do == "Iron")
            {
                dummy.price_sheets = 14;
            }
            else if (sheets_to_do == "Both")
            {
                dummy.price_sheets = 26;
            }
            dummy.order_id = order_no;
            bool flag = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].id == Id)
                {
                    flag = true;
                    users[i].order_id = order_no;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("User could not be found!");
            }
            else
            {
                orders.Add(dummy);
                MessageBox.Show("Your order has been placed and Order ID: " + order_no);
                order_no++;
            }

        }

        private void Set_Status_Button_Click(object sender, EventArgs e)
        {
            int order_id = Convert.ToInt32(Order_ID_Textbox.Text);
            bool flag = false;

            for (int i = 0; i < orders.Count; i++)
            {
                if (order_id == orders[i].order_id)
                {
                    orders[i].status = Owner_Section_Combo_Box.Text;
                    flag = true;
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Order Not Found!");
            }
        }

        private void Show_Order_ID_Button_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Details_Order_ID_Textbox.Text);
            bool flag = false;
            Details_ListBox.Items.Clear();

            for (int i = 0; i < orders.Count; i++)
            {
                if (ID == orders[i].order_id)
                {
                    Details_ListBox.Items.Add(orders[i].ShirtHistory());
                    Details_ListBox.Items.Add(orders[i].PantsHistory());
                    Details_ListBox.Items.Add(orders[i].SuitHistory());
                    Details_ListBox.Items.Add(orders[i].SheetHistory());
                    Details_Status_Textbox.Text = orders[i].status;
                    Details_Amount_Textbox.Text = orders[i].GetAmount();
                    balance += Convert.ToInt32(orders[i].GetAmount());
                    if (Details_Status_Textbox.Text == "Delivered")
                    {
                        Current_Balance_Textbox.Text = orders[i].GetAmount();
                    }
                    flag = true;
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Order not found!");
            }

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].order_id == ID)
                {
                    Details_Name_Textbox.Text = users[i].name;
                    Details_Address_Textbox.Text = users[i].address;
                }
            }
        }
    }
}
