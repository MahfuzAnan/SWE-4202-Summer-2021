namespace Banking_System
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxUserAddress = new System.Windows.Forms.TextBox();
            this.comboBoxAccType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDepAccId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDepAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxWithAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWithId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxShowBalId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxShowHisId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.listBoxShowHistory = new System.Windows.Forms.ListBox();
            this.textBoxUserBalance = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Type";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(95, 46);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserName.TabIndex = 4;
            // 
            // textBoxUserAddress
            // 
            this.textBoxUserAddress.Location = new System.Drawing.Point(95, 71);
            this.textBoxUserAddress.Name = "textBoxUserAddress";
            this.textBoxUserAddress.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserAddress.TabIndex = 5;
            // 
            // comboBoxAccType
            // 
            this.comboBoxAccType.FormattingEnabled = true;
            this.comboBoxAccType.Items.AddRange(new object[] {
            "Current Account",
            "Savings Account",
            "Loan Account"});
            this.comboBoxAccType.Location = new System.Drawing.Point(95, 95);
            this.comboBoxAccType.Name = "comboBoxAccType";
            this.comboBoxAccType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAccType.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Deposit";
            // 
            // textBoxDepAccId
            // 
            this.textBoxDepAccId.Location = new System.Drawing.Point(312, 46);
            this.textBoxDepAccId.Name = "textBoxDepAccId";
            this.textBoxDepAccId.Size = new System.Drawing.Size(121, 20);
            this.textBoxDepAccId.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID";
            // 
            // textBoxDepAmount
            // 
            this.textBoxDepAmount.Location = new System.Drawing.Point(312, 71);
            this.textBoxDepAmount.Name = "textBoxDepAmount";
            this.textBoxDepAmount.Size = new System.Drawing.Size(121, 20);
            this.textBoxDepAmount.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Amount";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Deposit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(470, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Withdraw";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Withdraw";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxWithAmount
            // 
            this.textBoxWithAmount.Location = new System.Drawing.Point(523, 71);
            this.textBoxWithAmount.Name = "textBoxWithAmount";
            this.textBoxWithAmount.Size = new System.Drawing.Size(121, 20);
            this.textBoxWithAmount.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Amount";
            // 
            // textBoxWithId
            // 
            this.textBoxWithId.Location = new System.Drawing.Point(523, 46);
            this.textBoxWithId.Name = "textBoxWithId";
            this.textBoxWithId.Size = new System.Drawing.Size(121, 20);
            this.textBoxWithId.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Show Balance";
            // 
            // textBoxShowBalId
            // 
            this.textBoxShowBalId.Location = new System.Drawing.Point(41, 247);
            this.textBoxShowBalId.Name = "textBoxShowBalId";
            this.textBoxShowBalId.Size = new System.Drawing.Size(121, 20);
            this.textBoxShowBalId.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(19, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Balance:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(82, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Balance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(258, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Show History";
            // 
            // textBoxShowHisId
            // 
            this.textBoxShowHisId.Location = new System.Drawing.Point(284, 247);
            this.textBoxShowHisId.Name = "textBoxShowHisId";
            this.textBoxShowHisId.Size = new System.Drawing.Size(121, 20);
            this.textBoxShowHisId.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(260, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "ID";
            // 
            // listBoxShowHistory
            // 
            this.listBoxShowHistory.FormattingEnabled = true;
            this.listBoxShowHistory.Location = new System.Drawing.Point(262, 290);
            this.listBoxShowHistory.Name = "listBoxShowHistory";
            this.listBoxShowHistory.Size = new System.Drawing.Size(508, 134);
            this.listBoxShowHistory.TabIndex = 28;
            // 
            // textBoxUserBalance
            // 
            this.textBoxUserBalance.Location = new System.Drawing.Point(95, 122);
            this.textBoxUserBalance.Name = "textBoxUserBalance";
            this.textBoxUserBalance.Size = new System.Drawing.Size(121, 20);
            this.textBoxUserBalance.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Balance";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(168, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(415, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxUserBalance);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.listBoxShowHistory);
            this.Controls.Add(this.textBoxShowHisId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxShowBalId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxWithAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxWithId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxDepAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDepAccId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxAccType);
            this.Controls.Add(this.textBoxUserAddress);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxUserAddress;
        private System.Windows.Forms.ComboBox comboBoxAccType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDepAccId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDepAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxWithAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxWithId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxShowBalId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxShowHisId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox listBoxShowHistory;
        private System.Windows.Forms.TextBox textBoxUserBalance;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

