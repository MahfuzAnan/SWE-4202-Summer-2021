namespace TicTacToe
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
            this.BOX_1 = new System.Windows.Forms.Button();
            this.BOX_2 = new System.Windows.Forms.Button();
            this.BOX_3 = new System.Windows.Forms.Button();
            this.BOX_4 = new System.Windows.Forms.Button();
            this.BOX_5 = new System.Windows.Forms.Button();
            this.BOX_6 = new System.Windows.Forms.Button();
            this.BOX_7 = new System.Windows.Forms.Button();
            this.BOX_8 = new System.Windows.Forms.Button();
            this.BOX_9 = new System.Windows.Forms.Button();
            this.Player_1_Button = new System.Windows.Forms.RadioButton();
            this.Player_2_Button = new System.Windows.Forms.RadioButton();
            this.reset_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BOX_1
            // 
            this.BOX_1.Location = new System.Drawing.Point(12, 38);
            this.BOX_1.Name = "BOX_1";
            this.BOX_1.Size = new System.Drawing.Size(75, 70);
            this.BOX_1.TabIndex = 0;
            this.BOX_1.UseVisualStyleBackColor = true;
            this.BOX_1.Click += new System.EventHandler(this.BOX_1_Click);
            // 
            // BOX_2
            // 
            this.BOX_2.Location = new System.Drawing.Point(93, 38);
            this.BOX_2.Name = "BOX_2";
            this.BOX_2.Size = new System.Drawing.Size(75, 70);
            this.BOX_2.TabIndex = 1;
            this.BOX_2.UseVisualStyleBackColor = true;
            this.BOX_2.Click += new System.EventHandler(this.BOX_2_Click);
            // 
            // BOX_3
            // 
            this.BOX_3.Location = new System.Drawing.Point(174, 38);
            this.BOX_3.Name = "BOX_3";
            this.BOX_3.Size = new System.Drawing.Size(75, 70);
            this.BOX_3.TabIndex = 2;
            this.BOX_3.UseVisualStyleBackColor = true;
            this.BOX_3.Click += new System.EventHandler(this.BOX_3_Click);
            // 
            // BOX_4
            // 
            this.BOX_4.Location = new System.Drawing.Point(12, 114);
            this.BOX_4.Name = "BOX_4";
            this.BOX_4.Size = new System.Drawing.Size(75, 70);
            this.BOX_4.TabIndex = 3;
            this.BOX_4.UseVisualStyleBackColor = true;
            this.BOX_4.Click += new System.EventHandler(this.BOX_4_Click);
            // 
            // BOX_5
            // 
            this.BOX_5.Location = new System.Drawing.Point(93, 114);
            this.BOX_5.Name = "BOX_5";
            this.BOX_5.Size = new System.Drawing.Size(75, 70);
            this.BOX_5.TabIndex = 4;
            this.BOX_5.UseVisualStyleBackColor = true;
            this.BOX_5.Click += new System.EventHandler(this.BOX_5_Click);
            // 
            // BOX_6
            // 
            this.BOX_6.Location = new System.Drawing.Point(174, 114);
            this.BOX_6.Name = "BOX_6";
            this.BOX_6.Size = new System.Drawing.Size(75, 70);
            this.BOX_6.TabIndex = 5;
            this.BOX_6.UseVisualStyleBackColor = true;
            this.BOX_6.Click += new System.EventHandler(this.BOX_6_Click);
            // 
            // BOX_7
            // 
            this.BOX_7.Location = new System.Drawing.Point(12, 190);
            this.BOX_7.Name = "BOX_7";
            this.BOX_7.Size = new System.Drawing.Size(75, 70);
            this.BOX_7.TabIndex = 6;
            this.BOX_7.UseVisualStyleBackColor = true;
            this.BOX_7.Click += new System.EventHandler(this.BOX_7_Click);
            // 
            // BOX_8
            // 
            this.BOX_8.Location = new System.Drawing.Point(93, 190);
            this.BOX_8.Name = "BOX_8";
            this.BOX_8.Size = new System.Drawing.Size(75, 70);
            this.BOX_8.TabIndex = 7;
            this.BOX_8.UseVisualStyleBackColor = true;
            this.BOX_8.Click += new System.EventHandler(this.BOX_8_Click);
            // 
            // BOX_9
            // 
            this.BOX_9.Location = new System.Drawing.Point(174, 190);
            this.BOX_9.Name = "BOX_9";
            this.BOX_9.Size = new System.Drawing.Size(75, 70);
            this.BOX_9.TabIndex = 8;
            this.BOX_9.UseVisualStyleBackColor = true;
            this.BOX_9.Click += new System.EventHandler(this.BOX_9_Click);
            // 
            // Player_1_Button
            // 
            this.Player_1_Button.AutoSize = true;
            this.Player_1_Button.Location = new System.Drawing.Point(325, 114);
            this.Player_1_Button.Name = "Player_1_Button";
            this.Player_1_Button.Size = new System.Drawing.Size(100, 17);
            this.Player_1_Button.TabIndex = 11;
            this.Player_1_Button.TabStop = true;
            this.Player_1_Button.Text = "Player 1\'s Move";
            this.Player_1_Button.UseVisualStyleBackColor = true;
            // 
            // Player_2_Button
            // 
            this.Player_2_Button.AutoSize = true;
            this.Player_2_Button.Location = new System.Drawing.Point(325, 157);
            this.Player_2_Button.Name = "Player_2_Button";
            this.Player_2_Button.Size = new System.Drawing.Size(100, 17);
            this.Player_2_Button.TabIndex = 12;
            this.Player_2_Button.TabStop = true;
            this.Player_2_Button.Text = "Player 2\'s Move";
            this.Player_2_Button.UseVisualStyleBackColor = true;
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(325, 236);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 13;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 300);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.Player_2_Button);
            this.Controls.Add(this.Player_1_Button);
            this.Controls.Add(this.BOX_9);
            this.Controls.Add(this.BOX_8);
            this.Controls.Add(this.BOX_7);
            this.Controls.Add(this.BOX_6);
            this.Controls.Add(this.BOX_5);
            this.Controls.Add(this.BOX_4);
            this.Controls.Add(this.BOX_3);
            this.Controls.Add(this.BOX_2);
            this.Controls.Add(this.BOX_1);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOX_1;
        private System.Windows.Forms.Button BOX_2;
        private System.Windows.Forms.Button BOX_3;
        private System.Windows.Forms.Button BOX_4;
        private System.Windows.Forms.Button BOX_5;
        private System.Windows.Forms.Button BOX_6;
        private System.Windows.Forms.Button BOX_7;
        private System.Windows.Forms.Button BOX_8;
        private System.Windows.Forms.Button BOX_9;
        private System.Windows.Forms.RadioButton Player_1_Button;
        private System.Windows.Forms.RadioButton Player_2_Button;
        private System.Windows.Forms.Button reset_button;
    }
}

