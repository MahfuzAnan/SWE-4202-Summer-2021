using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L.M.S
{
    public partial class Form1 : Form
    {
        List<Study_Book> study_books = new List<Study_Book>();
        List<Research_Article> research_articles = new List<Research_Article>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_S_BOOK_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(S_Book_ID_textbox.Text);
            string title = S_Book_Title_textbox.Text;
            string author = S_Book_Author_textbox.Text;
            string publisher = S_Book_Publisher_textbox.Text;
            int quantity = Convert.ToInt32(S_Book_Quantity_textbox.Text);
            string isbn = S_Book_ISBN_textbox.Text;
            string genre = S_Book_Genre_textbox.Text;

            Study_Book dummy = new Study_Book(id, title, author, publisher, quantity, isbn, genre);
            study_books.Add(dummy);
            MessageBox.Show("Study Book has been added successfully!");
        }

        private void ADD_ARTICLE_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(R_Article_Author_texbox.Text);
            string title = R_Article_Title_texbox.Text;
            string author = R_Article_Author_texbox.Text;
            string publisher = R_Article_Publisher_texbox.Text;
            int quantity = Convert.ToInt32(R_Article_Quantity_texbox.Text);
            string doi = R_Article_DOI_texbox.Text;
            string publish_date = R_Article_Pub_Date_texbox.Text;
            string conf_jour = R_Article_Conf_Jour_texbox.Text;

            Research_Article dummy1 = new Research_Article(id, title, author, publisher, quantity, doi, publish_date, conf_jour);
            research_articles.Add(dummy1);
            MessageBox.Show("Research Article has been added successfully!");
        }

        public bool bookExists(int id)
        {
            foreach (Study_Book study_Book in study_books)
            {
                if (study_Book.id == id)
                    return true;
            }
            return false;
        }

        public bool articleExists(int id)
        {
            foreach (Research_Article research_Article in research_articles)
            {
                if (research_Article.id == id)
                    return true;
            }
            return false;
        }

        private void Borrow_Book_button_Click(object sender, EventArgs e)
        {
            int book_id = Convert.ToInt32(Borrow_book_ID_textbox.Text);
            if (bookExists(book_id))
            {
                foreach (Study_Book study_Book in study_books)
                {
                    if (study_Book.id == book_id)
                    {
                        if (study_Book.quantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock.");
                            break;
                        }
                        study_Book.quantity -= 1;
                        MessageBox.Show("Book has been borrowed!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
        }

        private void Borrow_Article_button_Click(object sender, EventArgs e)
        {
            int article_id = Convert.ToInt32(Borrow_Article_ID_textbox.Text);
            if (articleExists(article_id))
            {
                foreach (Research_Article research_Article in research_articles)
                {
                    if (research_Article.id == article_id)
                    {
                        if (research_Article.quantity < 1)
                        {
                            MessageBox.Show("Not enough item in stock.");
                            break;
                        }
                        research_Article.quantity -= 1;
                        MessageBox.Show("Article has been borrowed!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Input.");
            }
        }

        private void Show_S_Book_button_Click(object sender, EventArgs e)
        {
            Show_S_Book_listbox.Items.Clear();

            for (int i = 0; i < study_books.Count; i++)
            {
                Show_S_Book_listbox.Items.Add(study_books[i].history());
            }
        }

        private void Show_Article_button_Click(object sender, EventArgs e)
        {
            Show_Article_listbox.Items.Clear();

            for (int i = 0; i < research_articles.Count; i++)
            {
                Show_Article_listbox.Items.Add(research_articles[i].history());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Show_S_Book_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}