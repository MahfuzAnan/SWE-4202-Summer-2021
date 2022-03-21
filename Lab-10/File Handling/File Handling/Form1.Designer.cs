namespace File_Handling
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
            this.employeelist_listbox = new System.Windows.Forms.ListBox();
            this.ID_search_textbox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_textbox = new System.Windows.Forms.TextBox();
            this.ID_textbox = new System.Windows.Forms.TextBox();
            this.Hire_Date_textbox = new System.Windows.Forms.TextBox();
            this.Salary_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // employeelist_listbox
            // 
            this.employeelist_listbox.FormattingEnabled = true;
            this.employeelist_listbox.Location = new System.Drawing.Point(12, 12);
            this.employeelist_listbox.Name = "employeelist_listbox";
            this.employeelist_listbox.Size = new System.Drawing.Size(306, 264);
            this.employeelist_listbox.TabIndex = 0;
            // 
            // ID_search_textbox
            // 
            this.ID_search_textbox.Location = new System.Drawing.Point(340, 13);
            this.ID_search_textbox.Name = "ID_search_textbox";
            this.ID_search_textbox.Size = new System.Drawing.Size(121, 20);
            this.ID_search_textbox.TabIndex = 1;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(386, 39);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 23);
            this.Search_button.TabIndex = 2;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hire Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salary :";
            // 
            // Name_textbox
            // 
            this.Name_textbox.Location = new System.Drawing.Point(401, 81);
            this.Name_textbox.Name = "Name_textbox";
            this.Name_textbox.Size = new System.Drawing.Size(121, 20);
            this.Name_textbox.TabIndex = 7;
            // 
            // ID_textbox
            // 
            this.ID_textbox.Location = new System.Drawing.Point(401, 114);
            this.ID_textbox.Name = "ID_textbox";
            this.ID_textbox.Size = new System.Drawing.Size(121, 20);
            this.ID_textbox.TabIndex = 8;
            // 
            // Hire_Date_textbox
            // 
            this.Hire_Date_textbox.Location = new System.Drawing.Point(401, 146);
            this.Hire_Date_textbox.Name = "Hire_Date_textbox";
            this.Hire_Date_textbox.Size = new System.Drawing.Size(121, 20);
            this.Hire_Date_textbox.TabIndex = 9;
            // 
            // Salary_textbox
            // 
            this.Salary_textbox.Location = new System.Drawing.Point(401, 175);
            this.Salary_textbox.Name = "Salary_textbox";
            this.Salary_textbox.Size = new System.Drawing.Size(121, 20);
            this.Salary_textbox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salary_textbox);
            this.Controls.Add(this.Hire_Date_textbox);
            this.Controls.Add(this.ID_textbox);
            this.Controls.Add(this.Name_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.ID_search_textbox);
            this.Controls.Add(this.employeelist_listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeelist_listbox;
        private System.Windows.Forms.TextBox ID_search_textbox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_textbox;
        private System.Windows.Forms.TextBox ID_textbox;
        private System.Windows.Forms.TextBox Hire_Date_textbox;
        private System.Windows.Forms.TextBox Salary_textbox;
    }
}

