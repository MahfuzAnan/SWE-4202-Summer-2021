using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        List<book>books = new List<book>();
        List<user> users = new List<user>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void USER_ID_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SHOW_BOOK_HISTORY_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BOOK_ID_HISTORY_textbox.Text);
            bool flag = false;
            foreach (book book in books)
            {
                if (book.book_id == id)
                {
                    flag = true;
                    show_id_history_textbox.Text = book.book_id.ToString();
                    show_book_name_history_textbox.Text = book.book_name;
                    show_book_author_history_textbox.Text = book.author;
                    show_book_publisher_history_textbox.Text = book.publisher;
                    show_book_quantity_history_textbox.Text = book.quantity.ToString();
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Book could not be found!");
            }
        }


        private bool userExists(int id)
        {
            foreach (user user in users)
            {
                if (user.std_id == id)
                {
                    return true;
                }
            }
            return false;
        }
        private bool bookExists(int id)
        {
            foreach (book book in books)
            {
                if (book.book_id == id)
                {
                    return true;
                }
            }
            return false;
        }


        private void ADD_BOOK_button_Click(object sender, EventArgs e)
        {
            int book_id = Convert.ToInt32(BookID_textbox.Text);
            string book_name = BookName_textbox.Text;
            string author = Author_Name_textbox.Text;
            string publisher = Publisher_Name_textbox.Text;
            int quantity = Convert.ToInt32(Quantity_textbox.Text);

            if (quantity < 0)
            {
                MessageBox.Show("Quantity can not be negative.");
                return;
            }

            book dummy = new book(book_id, book_name, author, publisher, quantity);

            books.Add(dummy);
            MessageBox.Show("Book has been added successfully!");
        }

        private void ADD_USER_button_Click(object sender, EventArgs e)
        {
            int std_id = Convert.ToInt32(UserID_textbox.Text);
            string name = Name_textbox.Text;
            string address = Address_textbox.Text;

            user dummy = new user(std_id, name, address);
            users.Add(dummy);
            MessageBox.Show("User has been added successfully!");
        }

        private void BorrowBook_button_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(USER_ID_textbox.Text);
            int bookID = Convert.ToInt32(Book_ID_textbox.Text);

            if (bookExists(bookID) && userExists(userID))
            {
                foreach (book book in books)
                {
                    if (book.book_id == bookID)
                    {
                        if (book.quantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock.");
                            break;
                        }
                        book.quantity -= 1;
                        foreach (user user in users)
                        {
                            if (user.std_id == userID)
                            {
                                user.books.Add(bookID);
                                MessageBox.Show("Book has been added to the user.");
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }


        }

        private void SHOW_USER_HISTORY_button_Click(object sender, EventArgs e)
        {
            int id_std = Convert.ToInt32(User_ID_History_textbox.Text);
            user dummy = new user();
            bool flag = false;
            foreach (user user in users)
            {
                if (user.std_id == id_std)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("User could not be found!");
            }
            BookList_list.Items.Clear();
            for (int i = 0; i < dummy.books.Count; i++)
            {
                int id_book = dummy.books[i];
                for (int j = 0; j < books.Count; j++)
                {
                    if (books[j].book_id == id_book)
                    {
                        BookList_list.Items.Add(books[j].history());
                    }
                }
            }
        }
    }
}
