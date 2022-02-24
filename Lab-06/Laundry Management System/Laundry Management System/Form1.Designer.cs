namespace Laundry_Management_System
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
            this.Order_ID_Textbox = new System.Windows.Forms.TextBox();
            this.Owner_Section_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Set_Status_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.User_ID_Textbox = new System.Windows.Forms.TextBox();
            this.User_Name_Textbox = new System.Windows.Forms.TextBox();
            this.User_Address_Textbox = new System.Windows.Forms.TextBox();
            this.Create_Account_Button = new System.Windows.Forms.Button();
            this.Order_Pants_Textbox = new System.Windows.Forms.TextBox();
            this.Order_Shirt_Textbox = new System.Windows.Forms.TextBox();
            this.Order_User_ID_Textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Order_Bed_Sheets_Textbox = new System.Windows.Forms.TextBox();
            this.Order_Suits_Textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Shirt_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Place_Order_Button = new System.Windows.Forms.Button();
            this.Details_Name_Textbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Details_Address_Textbox = new System.Windows.Forms.TextBox();
            this.Details_Amount_Textbox = new System.Windows.Forms.TextBox();
            this.Details_ListBox = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Details_Status_Textbox = new System.Windows.Forms.TextBox();
            this.Details_Order_ID_Textbox = new System.Windows.Forms.TextBox();
            this.Show_Order_ID_Button = new System.Windows.Forms.Button();
            this.Pants_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Suits_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Bed_Sheets_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Current_Balance_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(509, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Section";
            // 
            // Order_ID_Textbox
            // 
            this.Order_ID_Textbox.Location = new System.Drawing.Point(83, 41);
            this.Order_ID_Textbox.Name = "Order_ID_Textbox";
            this.Order_ID_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Order_ID_Textbox.TabIndex = 3;
            // 
            // Owner_Section_Combo_Box
            // 
            this.Owner_Section_Combo_Box.FormattingEnabled = true;
            this.Owner_Section_Combo_Box.Items.AddRange(new object[] {
            "Processing",
            "Delivered"});
            this.Owner_Section_Combo_Box.Location = new System.Drawing.Point(200, 40);
            this.Owner_Section_Combo_Box.Name = "Owner_Section_Combo_Box";
            this.Owner_Section_Combo_Box.Size = new System.Drawing.Size(121, 21);
            this.Owner_Section_Combo_Box.TabIndex = 4;
            // 
            // Set_Status_Button
            // 
            this.Set_Status_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Set_Status_Button.Location = new System.Drawing.Point(344, 40);
            this.Set_Status_Button.Name = "Set_Status_Button";
            this.Set_Status_Button.Size = new System.Drawing.Size(75, 23);
            this.Set_Status_Button.TabIndex = 5;
            this.Set_Status_Button.Text = "Set Status";
            this.Set_Status_Button.UseVisualStyleBackColor = true;
            this.Set_Status_Button.Click += new System.EventHandler(this.Set_Status_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current Balance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "User ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Address :";
            // 
            // User_ID_Textbox
            // 
            this.User_ID_Textbox.Location = new System.Drawing.Point(578, 38);
            this.User_ID_Textbox.Name = "User_ID_Textbox";
            this.User_ID_Textbox.Size = new System.Drawing.Size(100, 20);
            this.User_ID_Textbox.TabIndex = 10;
            // 
            // User_Name_Textbox
            // 
            this.User_Name_Textbox.Location = new System.Drawing.Point(578, 70);
            this.User_Name_Textbox.Name = "User_Name_Textbox";
            this.User_Name_Textbox.Size = new System.Drawing.Size(100, 20);
            this.User_Name_Textbox.TabIndex = 11;
            // 
            // User_Address_Textbox
            // 
            this.User_Address_Textbox.Location = new System.Drawing.Point(578, 106);
            this.User_Address_Textbox.Name = "User_Address_Textbox";
            this.User_Address_Textbox.Size = new System.Drawing.Size(100, 20);
            this.User_Address_Textbox.TabIndex = 12;
            // 
            // Create_Account_Button
            // 
            this.Create_Account_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Account_Button.Location = new System.Drawing.Point(695, 56);
            this.Create_Account_Button.Name = "Create_Account_Button";
            this.Create_Account_Button.Size = new System.Drawing.Size(75, 55);
            this.Create_Account_Button.TabIndex = 13;
            this.Create_Account_Button.Text = " Create \r\nAccount";
            this.Create_Account_Button.UseVisualStyleBackColor = true;
            this.Create_Account_Button.Click += new System.EventHandler(this.Create_Account_Button_Click);
            // 
            // Order_Pants_Textbox
            // 
            this.Order_Pants_Textbox.Location = new System.Drawing.Point(889, 106);
            this.Order_Pants_Textbox.Name = "Order_Pants_Textbox";
            this.Order_Pants_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Order_Pants_Textbox.TabIndex = 19;
            // 
            // Order_Shirt_Textbox
            // 
            this.Order_Shirt_Textbox.Location = new System.Drawing.Point(889, 70);
            this.Order_Shirt_Textbox.Name = "Order_Shirt_Textbox";
            this.Order_Shirt_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Order_Shirt_Textbox.TabIndex = 18;
            // 
            // Order_User_ID_Textbox
            // 
            this.Order_User_ID_Textbox.Location = new System.Drawing.Point(889, 38);
            this.Order_User_ID_Textbox.Name = "Order_User_ID_Textbox";
            this.Order_User_ID_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Order_User_ID_Textbox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(836, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pants :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(842, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Shirt :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(825, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "User ID :";
            // 
            // Order_Bed_Sheets_Textbox
            // 
            this.Order_Bed_Sheets_Textbox.Location = new System.Drawing.Point(889, 178);
            this.Order_Bed_Sheets_Textbox.Name = "Order_Bed_Sheets_Textbox";
            this.Order_Bed_Sheets_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Order_Bed_Sheets_Textbox.TabIndex = 23;
            // 
            // Order_Suits_Textbox
            // 
            this.Order_Suits_Textbox.Location = new System.Drawing.Point(889, 142);
            this.Order_Suits_Textbox.Name = "Order_Suits_Textbox";
            this.Order_Suits_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Order_Suits_Textbox.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(803, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Bed Sheets :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(840, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Suits :";
            // 
            // Shirt_Combo_Box
            // 
            this.Shirt_Combo_Box.FormattingEnabled = true;
            this.Shirt_Combo_Box.Items.AddRange(new object[] {
            "Wash ",
            "Iron",
            "Both"});
            this.Shirt_Combo_Box.Location = new System.Drawing.Point(995, 69);
            this.Shirt_Combo_Box.Name = "Shirt_Combo_Box";
            this.Shirt_Combo_Box.Size = new System.Drawing.Size(121, 21);
            this.Shirt_Combo_Box.TabIndex = 24;
            // 
            // Place_Order_Button
            // 
            this.Place_Order_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Place_Order_Button.Location = new System.Drawing.Point(944, 217);
            this.Place_Order_Button.Name = "Place_Order_Button";
            this.Place_Order_Button.Size = new System.Drawing.Size(108, 23);
            this.Place_Order_Button.TabIndex = 28;
            this.Place_Order_Button.Text = "Place Order";
            this.Place_Order_Button.UseVisualStyleBackColor = true;
            this.Place_Order_Button.Click += new System.EventHandler(this.Place_Order_Button_Click);
            // 
            // Details_Name_Textbox
            // 
            this.Details_Name_Textbox.Location = new System.Drawing.Point(833, 334);
            this.Details_Name_Textbox.Name = "Details_Name_Textbox";
            this.Details_Name_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Details_Name_Textbox.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(121, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Order ID :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(133, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Status :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(126, 411);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Amount :";
            // 
            // Details_Address_Textbox
            // 
            this.Details_Address_Textbox.Location = new System.Drawing.Point(831, 371);
            this.Details_Address_Textbox.Name = "Details_Address_Textbox";
            this.Details_Address_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Details_Address_Textbox.TabIndex = 33;
            // 
            // Details_Amount_Textbox
            // 
            this.Details_Amount_Textbox.Location = new System.Drawing.Point(189, 404);
            this.Details_Amount_Textbox.Name = "Details_Amount_Textbox";
            this.Details_Amount_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Details_Amount_Textbox.TabIndex = 34;
            // 
            // Details_ListBox
            // 
            this.Details_ListBox.FormattingEnabled = true;
            this.Details_ListBox.Location = new System.Drawing.Point(344, 334);
            this.Details_ListBox.Name = "Details_ListBox";
            this.Details_ListBox.Size = new System.Drawing.Size(398, 225);
            this.Details_ListBox.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(765, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Address :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(778, 341);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Name :";
            // 
            // Details_Status_Textbox
            // 
            this.Details_Status_Textbox.Location = new System.Drawing.Point(189, 371);
            this.Details_Status_Textbox.Name = "Details_Status_Textbox";
            this.Details_Status_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Details_Status_Textbox.TabIndex = 39;
            // 
            // Details_Order_ID_Textbox
            // 
            this.Details_Order_ID_Textbox.Location = new System.Drawing.Point(191, 334);
            this.Details_Order_ID_Textbox.Name = "Details_Order_ID_Textbox";
            this.Details_Order_ID_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Details_Order_ID_Textbox.TabIndex = 38;
            // 
            // Show_Order_ID_Button
            // 
            this.Show_Order_ID_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Order_ID_Button.Location = new System.Drawing.Point(165, 458);
            this.Show_Order_ID_Button.Name = "Show_Order_ID_Button";
            this.Show_Order_ID_Button.Size = new System.Drawing.Size(124, 45);
            this.Show_Order_ID_Button.TabIndex = 40;
            this.Show_Order_ID_Button.Text = "Show Order Detais";
            this.Show_Order_ID_Button.UseVisualStyleBackColor = true;
            this.Show_Order_ID_Button.Click += new System.EventHandler(this.Show_Order_ID_Button_Click);
            // 
            // Pants_Combo_Box
            // 
            this.Pants_Combo_Box.FormattingEnabled = true;
            this.Pants_Combo_Box.Items.AddRange(new object[] {
            "Wash ",
            "Iron",
            "Both"});
            this.Pants_Combo_Box.Location = new System.Drawing.Point(995, 106);
            this.Pants_Combo_Box.Name = "Pants_Combo_Box";
            this.Pants_Combo_Box.Size = new System.Drawing.Size(121, 21);
            this.Pants_Combo_Box.TabIndex = 41;
            // 
            // Suits_Combo_Box
            // 
            this.Suits_Combo_Box.FormattingEnabled = true;
            this.Suits_Combo_Box.Items.AddRange(new object[] {
            "Wash ",
            "Iron",
            "Both"});
            this.Suits_Combo_Box.Location = new System.Drawing.Point(995, 141);
            this.Suits_Combo_Box.Name = "Suits_Combo_Box";
            this.Suits_Combo_Box.Size = new System.Drawing.Size(121, 21);
            this.Suits_Combo_Box.TabIndex = 42;
            // 
            // Bed_Sheets_Combo_Box
            // 
            this.Bed_Sheets_Combo_Box.FormattingEnabled = true;
            this.Bed_Sheets_Combo_Box.Items.AddRange(new object[] {
            "Wash ",
            "Iron",
            "Both"});
            this.Bed_Sheets_Combo_Box.Location = new System.Drawing.Point(995, 177);
            this.Bed_Sheets_Combo_Box.Name = "Bed_Sheets_Combo_Box";
            this.Bed_Sheets_Combo_Box.Size = new System.Drawing.Size(121, 21);
            this.Bed_Sheets_Combo_Box.TabIndex = 43;
            // 
            // Current_Balance_Textbox
            // 
            this.Current_Balance_Textbox.Location = new System.Drawing.Point(125, 84);
            this.Current_Balance_Textbox.Name = "Current_Balance_Textbox";
            this.Current_Balance_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Current_Balance_Textbox.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 580);
            this.Controls.Add(this.Current_Balance_Textbox);
            this.Controls.Add(this.Bed_Sheets_Combo_Box);
            this.Controls.Add(this.Suits_Combo_Box);
            this.Controls.Add(this.Pants_Combo_Box);
            this.Controls.Add(this.Show_Order_ID_Button);
            this.Controls.Add(this.Details_Status_Textbox);
            this.Controls.Add(this.Details_Order_ID_Textbox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Details_ListBox);
            this.Controls.Add(this.Details_Amount_Textbox);
            this.Controls.Add(this.Details_Address_Textbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Details_Name_Textbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Place_Order_Button);
            this.Controls.Add(this.Shirt_Combo_Box);
            this.Controls.Add(this.Order_Bed_Sheets_Textbox);
            this.Controls.Add(this.Order_Suits_Textbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Order_Pants_Textbox);
            this.Controls.Add(this.Order_Shirt_Textbox);
            this.Controls.Add(this.Order_User_ID_Textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Create_Account_Button);
            this.Controls.Add(this.User_Address_Textbox);
            this.Controls.Add(this.User_Name_Textbox);
            this.Controls.Add(this.User_ID_Textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Set_Status_Button);
            this.Controls.Add(this.Owner_Section_Combo_Box);
            this.Controls.Add(this.Order_ID_Textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Laundry Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Order_ID_Textbox;
        private System.Windows.Forms.ComboBox Owner_Section_Combo_Box;
        private System.Windows.Forms.Button Set_Status_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox User_ID_Textbox;
        private System.Windows.Forms.TextBox User_Name_Textbox;
        private System.Windows.Forms.TextBox User_Address_Textbox;
        private System.Windows.Forms.Button Create_Account_Button;
        private System.Windows.Forms.TextBox Order_Pants_Textbox;
        private System.Windows.Forms.TextBox Order_Shirt_Textbox;
        private System.Windows.Forms.TextBox Order_User_ID_Textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Order_Bed_Sheets_Textbox;
        private System.Windows.Forms.TextBox Order_Suits_Textbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Shirt_Combo_Box;
        private System.Windows.Forms.Button Place_Order_Button;
        private System.Windows.Forms.TextBox Details_Name_Textbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Details_Address_Textbox;
        private System.Windows.Forms.TextBox Details_Amount_Textbox;
        private System.Windows.Forms.ListBox Details_ListBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Details_Status_Textbox;
        private System.Windows.Forms.TextBox Details_Order_ID_Textbox;
        private System.Windows.Forms.Button Show_Order_ID_Button;
        private System.Windows.Forms.ComboBox Pants_Combo_Box;
        private System.Windows.Forms.ComboBox Suits_Combo_Box;
        private System.Windows.Forms.ComboBox Bed_Sheets_Combo_Box;
        private System.Windows.Forms.TextBox Current_Balance_Textbox;
    }
}

