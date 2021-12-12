namespace Library_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserID_textbox = new System.Windows.Forms.TextBox();
            this.Address_textbox = new System.Windows.Forms.TextBox();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.ADD_USER_button = new System.Windows.Forms.Button();
            this.BookName_textbox = new System.Windows.Forms.TextBox();
            this.Author_Name_textbox = new System.Windows.Forms.TextBox();
            this.BookID_textbox = new System.Windows.Forms.TextBox();
            this.Author_textbox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Quantity_textbox = new System.Windows.Forms.TextBox();
            this.Publisher_Name_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Publisher_textbox = new System.Windows.Forms.Label();
            this.ADD_BOOK_button = new System.Windows.Forms.Button();
            this.USER_ID_textbox = new System.Windows.Forms.TextBox();
            this.Book_ID_textbox = new System.Windows.Forms.TextBox();
            this.BorrowBook_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.User_ID_History_textbox = new System.Windows.Forms.TextBox();
            this.SHOW_USER_HISTORY_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SHOW_BOOK_HISTORY_button = new System.Windows.Forms.Button();
            this.BOOK_ID_HISTORY_textbox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.show_author_history_textbox = new System.Windows.Forms.Label();
            this.show_name_history_textbox = new System.Windows.Forms.Label();
            this.show_publisher_history_textbox = new System.Windows.Forms.Label();
            this.show_quantity_history_textbox = new System.Windows.Forms.Label();
            this.show_id_history_textbox = new System.Windows.Forms.TextBox();
            this.show_book_quantity_history_textbox = new System.Windows.Forms.TextBox();
            this.show_book_publisher_history_textbox = new System.Windows.Forms.TextBox();
            this.show_book_author_history_textbox = new System.Windows.Forms.TextBox();
            this.show_book_name_history_textbox = new System.Windows.Forms.TextBox();
            this.BookList_list = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UserID_textbox
            // 
            this.UserID_textbox.Location = new System.Drawing.Point(76, 12);
            this.UserID_textbox.Name = "UserID_textbox";
            this.UserID_textbox.Size = new System.Drawing.Size(100, 20);
            this.UserID_textbox.TabIndex = 3;
            this.UserID_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Address_textbox
            // 
            this.Address_textbox.Location = new System.Drawing.Point(76, 91);
            this.Address_textbox.Name = "Address_textbox";
            this.Address_textbox.Size = new System.Drawing.Size(100, 20);
            this.Address_textbox.TabIndex = 4;
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(76, 52);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(100, 20);
            this.Name_textbox.TabIndex = 5;
            this.Name_textbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ADD_USER_button
            // 
            this.ADD_USER_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_USER_button.Location = new System.Drawing.Point(76, 132);
            this.ADD_USER_button.Name = "ADD_USER_button";
            this.ADD_USER_button.Size = new System.Drawing.Size(100, 23);
            this.ADD_USER_button.TabIndex = 6;
            this.ADD_USER_button.Text = "ADD USER";
            this.ADD_USER_button.UseVisualStyleBackColor = true;
            this.ADD_USER_button.Click += new System.EventHandler(this.ADD_USER_button_Click);
            // 
            // BookName_textbox
            // 
            this.BookName_textbox.Location = new System.Drawing.Point(383, 52);
            this.BookName_textbox.Name = "BookName_textbox";
            this.BookName_textbox.Size = new System.Drawing.Size(100, 20);
            this.BookName_textbox.TabIndex = 12;
            // 
            // Author_Name_textbox
            // 
            this.Author_Name_textbox.Location = new System.Drawing.Point(383, 91);
            this.Author_Name_textbox.Name = "Author_Name_textbox";
            this.Author_Name_textbox.Size = new System.Drawing.Size(100, 20);
            this.Author_Name_textbox.TabIndex = 11;
            // 
            // BookID_textbox
            // 
            this.BookID_textbox.Location = new System.Drawing.Point(383, 12);
            this.BookID_textbox.Name = "BookID_textbox";
            this.BookID_textbox.Size = new System.Drawing.Size(100, 20);
            this.BookID_textbox.TabIndex = 10;
            // 
            // Author_textbox
            // 
            this.Author_textbox.AutoSize = true;
            this.Author_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_textbox.Location = new System.Drawing.Point(304, 98);
            this.Author_textbox.Name = "Author_textbox";
            this.Author_textbox.Size = new System.Drawing.Size(52, 13);
            this.Author_textbox.TabIndex = 9;
            this.Author_textbox.Text = "Author :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Book Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Book ID :";
            // 
            // Quantity_textbox
            // 
            this.Quantity_textbox.Location = new System.Drawing.Point(383, 176);
            this.Quantity_textbox.Name = "Quantity_textbox";
            this.Quantity_textbox.Size = new System.Drawing.Size(100, 20);
            this.Quantity_textbox.TabIndex = 18;
            this.Quantity_textbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Publisher_Name_textbox
            // 
            this.Publisher_Name_textbox.Location = new System.Drawing.Point(383, 132);
            this.Publisher_Name_textbox.Name = "Publisher_Name_textbox";
            this.Publisher_Name_textbox.Size = new System.Drawing.Size(100, 20);
            this.Publisher_Name_textbox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantity :";
            // 
            // Publisher_textbox
            // 
            this.Publisher_textbox.AutoSize = true;
            this.Publisher_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher_textbox.Location = new System.Drawing.Point(304, 139);
            this.Publisher_textbox.Name = "Publisher_textbox";
            this.Publisher_textbox.Size = new System.Drawing.Size(67, 13);
            this.Publisher_textbox.TabIndex = 13;
            this.Publisher_textbox.Text = "Publisher :";
            // 
            // ADD_BOOK_button
            // 
            this.ADD_BOOK_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_BOOK_button.Location = new System.Drawing.Point(383, 217);
            this.ADD_BOOK_button.Name = "ADD_BOOK_button";
            this.ADD_BOOK_button.Size = new System.Drawing.Size(100, 23);
            this.ADD_BOOK_button.TabIndex = 19;
            this.ADD_BOOK_button.Text = "ADD BOOK";
            this.ADD_BOOK_button.UseVisualStyleBackColor = true;
            this.ADD_BOOK_button.Click += new System.EventHandler(this.ADD_BOOK_button_Click);
            // 
            // USER_ID_textbox
            // 
            this.USER_ID_textbox.Location = new System.Drawing.Point(156, 315);
            this.USER_ID_textbox.Name = "USER_ID_textbox";
            this.USER_ID_textbox.Size = new System.Drawing.Size(100, 20);
            this.USER_ID_textbox.TabIndex = 20;
            this.USER_ID_textbox.TextChanged += new System.EventHandler(this.USER_ID_textbox_TextChanged);
            // 
            // Book_ID_textbox
            // 
            this.Book_ID_textbox.Location = new System.Drawing.Point(156, 351);
            this.Book_ID_textbox.Name = "Book_ID_textbox";
            this.Book_ID_textbox.Size = new System.Drawing.Size(100, 20);
            this.Book_ID_textbox.TabIndex = 21;
            // 
            // BorrowBook_button
            // 
            this.BorrowBook_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowBook_button.Location = new System.Drawing.Point(136, 393);
            this.BorrowBook_button.Name = "BorrowBook_button";
            this.BorrowBook_button.Size = new System.Drawing.Size(120, 23);
            this.BorrowBook_button.TabIndex = 22;
            this.BorrowBook_button.Text = "BORROW BOOK";
            this.BorrowBook_button.UseVisualStyleBackColor = true;
            this.BorrowBook_button.Click += new System.EventHandler(this.BorrowBook_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(690, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "User History";
            // 
            // User_ID_History_textbox
            // 
            this.User_ID_History_textbox.Location = new System.Drawing.Point(647, 59);
            this.User_ID_History_textbox.Name = "User_ID_History_textbox";
            this.User_ID_History_textbox.Size = new System.Drawing.Size(100, 20);
            this.User_ID_History_textbox.TabIndex = 25;
            // 
            // SHOW_USER_HISTORY_button
            // 
            this.SHOW_USER_HISTORY_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOW_USER_HISTORY_button.Location = new System.Drawing.Point(776, 56);
            this.SHOW_USER_HISTORY_button.Name = "SHOW_USER_HISTORY_button";
            this.SHOW_USER_HISTORY_button.Size = new System.Drawing.Size(75, 23);
            this.SHOW_USER_HISTORY_button.TabIndex = 26;
            this.SHOW_USER_HISTORY_button.Text = "SHOW";
            this.SHOW_USER_HISTORY_button.UseVisualStyleBackColor = true;
            this.SHOW_USER_HISTORY_button.Click += new System.EventHandler(this.SHOW_USER_HISTORY_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(690, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Book History";
            // 
            // SHOW_BOOK_HISTORY_button
            // 
            this.SHOW_BOOK_HISTORY_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHOW_BOOK_HISTORY_button.Location = new System.Drawing.Point(781, 348);
            this.SHOW_BOOK_HISTORY_button.Name = "SHOW_BOOK_HISTORY_button";
            this.SHOW_BOOK_HISTORY_button.Size = new System.Drawing.Size(75, 23);
            this.SHOW_BOOK_HISTORY_button.TabIndex = 32;
            this.SHOW_BOOK_HISTORY_button.Text = "SHOW";
            this.SHOW_BOOK_HISTORY_button.UseVisualStyleBackColor = true;
            this.SHOW_BOOK_HISTORY_button.Click += new System.EventHandler(this.SHOW_BOOK_HISTORY_button_Click);
            // 
            // BOOK_ID_HISTORY_textbox
            // 
            this.BOOK_ID_HISTORY_textbox.Location = new System.Drawing.Point(652, 351);
            this.BOOK_ID_HISTORY_textbox.Name = "BOOK_ID_HISTORY_textbox";
            this.BOOK_ID_HISTORY_textbox.Size = new System.Drawing.Size(100, 20);
            this.BOOK_ID_HISTORY_textbox.TabIndex = 31;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(691, 413);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(28, 13);
            this.ID.TabIndex = 33;
            this.ID.Text = "ID :";
            // 
            // show_author_history_textbox
            // 
            this.show_author_history_textbox.AutoSize = true;
            this.show_author_history_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_author_history_textbox.Location = new System.Drawing.Point(691, 477);
            this.show_author_history_textbox.Name = "show_author_history_textbox";
            this.show_author_history_textbox.Size = new System.Drawing.Size(52, 13);
            this.show_author_history_textbox.TabIndex = 34;
            this.show_author_history_textbox.Text = "Author :";
            // 
            // show_name_history_textbox
            // 
            this.show_name_history_textbox.AutoSize = true;
            this.show_name_history_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_name_history_textbox.Location = new System.Drawing.Point(691, 445);
            this.show_name_history_textbox.Name = "show_name_history_textbox";
            this.show_name_history_textbox.Size = new System.Drawing.Size(47, 13);
            this.show_name_history_textbox.TabIndex = 35;
            this.show_name_history_textbox.Text = "Name :";
            // 
            // show_publisher_history_textbox
            // 
            this.show_publisher_history_textbox.AutoSize = true;
            this.show_publisher_history_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_publisher_history_textbox.Location = new System.Drawing.Point(691, 509);
            this.show_publisher_history_textbox.Name = "show_publisher_history_textbox";
            this.show_publisher_history_textbox.Size = new System.Drawing.Size(67, 13);
            this.show_publisher_history_textbox.TabIndex = 36;
            this.show_publisher_history_textbox.Text = "Publisher :";
            // 
            // show_quantity_history_textbox
            // 
            this.show_quantity_history_textbox.AutoSize = true;
            this.show_quantity_history_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_quantity_history_textbox.Location = new System.Drawing.Point(691, 543);
            this.show_quantity_history_textbox.Name = "show_quantity_history_textbox";
            this.show_quantity_history_textbox.Size = new System.Drawing.Size(62, 13);
            this.show_quantity_history_textbox.TabIndex = 37;
            this.show_quantity_history_textbox.Text = "Quantity :";
            // 
            // show_id_history_textbox
            // 
            this.show_id_history_textbox.Location = new System.Drawing.Point(756, 406);
            this.show_id_history_textbox.Name = "show_id_history_textbox";
            this.show_id_history_textbox.Size = new System.Drawing.Size(100, 20);
            this.show_id_history_textbox.TabIndex = 38;
            // 
            // show_book_quantity_history_textbox
            // 
            this.show_book_quantity_history_textbox.Location = new System.Drawing.Point(756, 536);
            this.show_book_quantity_history_textbox.Name = "show_book_quantity_history_textbox";
            this.show_book_quantity_history_textbox.Size = new System.Drawing.Size(100, 20);
            this.show_book_quantity_history_textbox.TabIndex = 39;
            // 
            // show_book_publisher_history_textbox
            // 
            this.show_book_publisher_history_textbox.Location = new System.Drawing.Point(756, 502);
            this.show_book_publisher_history_textbox.Name = "show_book_publisher_history_textbox";
            this.show_book_publisher_history_textbox.Size = new System.Drawing.Size(100, 20);
            this.show_book_publisher_history_textbox.TabIndex = 40;
            // 
            // show_book_author_history_textbox
            // 
            this.show_book_author_history_textbox.Location = new System.Drawing.Point(756, 470);
            this.show_book_author_history_textbox.Name = "show_book_author_history_textbox";
            this.show_book_author_history_textbox.Size = new System.Drawing.Size(100, 20);
            this.show_book_author_history_textbox.TabIndex = 41;
            // 
            // show_book_name_history_textbox
            // 
            this.show_book_name_history_textbox.Location = new System.Drawing.Point(756, 438);
            this.show_book_name_history_textbox.Name = "show_book_name_history_textbox";
            this.show_book_name_history_textbox.Size = new System.Drawing.Size(100, 20);
            this.show_book_name_history_textbox.TabIndex = 42;
            // 
            // BookList_list
            // 
            this.BookList_list.FormattingEnabled = true;
            this.BookList_list.Location = new System.Drawing.Point(647, 98);
            this.BookList_list.Name = "BookList_list";
            this.BookList_list.Size = new System.Drawing.Size(204, 160);
            this.BookList_list.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "BookID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "UserID :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 652);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BookList_list);
            this.Controls.Add(this.show_book_name_history_textbox);
            this.Controls.Add(this.show_book_author_history_textbox);
            this.Controls.Add(this.show_book_publisher_history_textbox);
            this.Controls.Add(this.show_book_quantity_history_textbox);
            this.Controls.Add(this.show_id_history_textbox);
            this.Controls.Add(this.show_quantity_history_textbox);
            this.Controls.Add(this.show_publisher_history_textbox);
            this.Controls.Add(this.show_name_history_textbox);
            this.Controls.Add(this.show_author_history_textbox);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.SHOW_BOOK_HISTORY_button);
            this.Controls.Add(this.BOOK_ID_HISTORY_textbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SHOW_USER_HISTORY_button);
            this.Controls.Add(this.User_ID_History_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BorrowBook_button);
            this.Controls.Add(this.Book_ID_textbox);
            this.Controls.Add(this.USER_ID_textbox);
            this.Controls.Add(this.ADD_BOOK_button);
            this.Controls.Add(this.Quantity_textbox);
            this.Controls.Add(this.Publisher_Name_textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Publisher_textbox);
            this.Controls.Add(this.BookName_textbox);
            this.Controls.Add(this.Author_Name_textbox);
            this.Controls.Add(this.BookID_textbox);
            this.Controls.Add(this.Author_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ADD_USER_button);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.Address_textbox);
            this.Controls.Add(this.UserID_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LIBRARY MANAGEMENT SYSTEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserID_textbox;
        private System.Windows.Forms.TextBox Address_textbox;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.Button ADD_USER_button;
        private System.Windows.Forms.TextBox BookName_textbox;
        private System.Windows.Forms.TextBox Author_Name_textbox;
        private System.Windows.Forms.TextBox BookID_textbox;
        private System.Windows.Forms.Label Author_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Quantity_textbox;
        private System.Windows.Forms.TextBox Publisher_Name_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Publisher_textbox;
        private System.Windows.Forms.Button ADD_BOOK_button;
        private System.Windows.Forms.TextBox USER_ID_textbox;
        private System.Windows.Forms.TextBox Book_ID_textbox;
        private System.Windows.Forms.Button BorrowBook_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox User_ID_History_textbox;
        private System.Windows.Forms.Button SHOW_USER_HISTORY_button;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SHOW_BOOK_HISTORY_button;
        private System.Windows.Forms.TextBox BOOK_ID_HISTORY_textbox;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label show_author_history_textbox;
        private System.Windows.Forms.Label show_name_history_textbox;
        private System.Windows.Forms.Label show_publisher_history_textbox;
        private System.Windows.Forms.Label show_quantity_history_textbox;
        private System.Windows.Forms.TextBox show_id_history_textbox;
        private System.Windows.Forms.TextBox show_book_quantity_history_textbox;
        private System.Windows.Forms.TextBox show_book_publisher_history_textbox;
        private System.Windows.Forms.TextBox show_book_author_history_textbox;
        private System.Windows.Forms.TextBox show_book_name_history_textbox;
        private System.Windows.Forms.ListBox BookList_list;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}

