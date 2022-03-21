using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int player_1 = 0;
        int player_2 = 0;
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void BOX_1_Click(object sender, EventArgs e)
        {
            if(Player_1_Button.Checked == true)
            {
                BOX_1.BackColor = Color.DarkGreen;
                Player_1_Button.Checked = false;
                Player_2_Button.Checked = true;
            }
            else if(Player_2_Button.Checked = true)
            {
                BOX_1.BackColor = Color.DarkRed;
                Player_2_Button.Checked = false;
                Player_1_Button.Checked = true;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_2.BackColor == Color.DarkGreen && BOX_3.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_4.BackColor == Color.DarkGreen && BOX_7.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_5.BackColor == Color.DarkGreen && BOX_9.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
        }

        private void BOX_2_Click(object sender, EventArgs e)
        {
            if (Player_1_Button.Checked == true)
            {
                BOX_2.BackColor = Color.DarkGreen;
                Player_1_Button.Checked = false;
                Player_2_Button.Checked = true;
            }
            else if (Player_2_Button.Checked = true)
            {
                BOX_2.BackColor = Color.DarkRed;
                Player_2_Button.Checked = false;
                Player_1_Button.Checked = true;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_2.BackColor == Color.DarkGreen && BOX_3.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_4.BackColor == Color.DarkGreen && BOX_7.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_5.BackColor == Color.DarkGreen && BOX_9.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
        }

        private void BOX_3_Click(object sender, EventArgs e)
        {
            if (Player_1_Button.Checked == true)
            {
                BOX_3.BackColor = Color.DarkGreen;
                Player_1_Button.Checked = false;
                Player_2_Button.Checked = true;
            }
            else if (Player_2_Button.Checked = true)
            {
                BOX_3.BackColor = Color.DarkRed;
                Player_2_Button.Checked = false;
                Player_1_Button.Checked = true;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_2.BackColor == Color.DarkGreen && BOX_3.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_4.BackColor == Color.DarkGreen && BOX_7.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_5.BackColor == Color.DarkGreen && BOX_9.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
        }

        private void BOX_4_Click(object sender, EventArgs e)
        {
            if (Player_1_Button.Checked == true)
            {
                BOX_4.BackColor = Color.DarkGreen;
                Player_1_Button.Checked = false;
                Player_2_Button.Checked = true;
            }
            else if (Player_2_Button.Checked = true)
            {
                BOX_4.BackColor = Color.DarkRed;
                Player_2_Button.Checked = false;
                Player_1_Button.Checked = true;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_2.BackColor == Color.DarkGreen && BOX_3.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_4.BackColor == Color.DarkGreen && BOX_7.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_5.BackColor == Color.DarkGreen && BOX_9.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
        }

        private void BOX_5_Click(object sender, EventArgs e)
        {
            if (Player_1_Button.Checked == true)
            {
                BOX_5.BackColor = Color.DarkGreen;
                Player_1_Button.Checked = false;
                Player_2_Button.Checked = true;
            }
            else if (Player_2_Button.Checked = true)
            {
                BOX_5.BackColor = Color.DarkRed;
                Player_2_Button.Checked = false;
                Player_1_Button.Checked = true;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_2.BackColor == Color.DarkGreen && BOX_3.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_4.BackColor == Color.DarkGreen && BOX_7.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_5.BackColor == Color.DarkGreen && BOX_9.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
        }

        private void BOX_6_Click(object sender, EventArgs e)
        {
            if (Player_1_Button.Checked == true)
            {
                BOX_6.BackColor = Color.DarkGreen;
                Player_1_Button.Checked = false;
                Player_2_Button.Checked = true;
            }
            else if (Player_2_Button.Checked = true)
            {
                BOX_6.BackColor = Color.DarkRed;
                Player_2_Button.Checked = false;
                Player_1_Button.Checked = true;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_2.BackColor == Color.DarkGreen && BOX_3.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_4.BackColor == Color.DarkGreen && BOX_7.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_5.BackColor == Color.DarkGreen && BOX_9.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
        }

        private void BOX_7_Click(object sender, EventArgs e)
        {
            if (Player_1_Button.Checked == true)
            {
                BOX_7.BackColor = Color.DarkGreen;
                Player_1_Button.Checked = false;
                Player_2_Button.Checked = true;
            }
            else if (Player_2_Button.Checked = true)
            {
                BOX_7.BackColor = Color.DarkRed;
                Player_2_Button.Checked = false;
                Player_1_Button.Checked = true;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_2.BackColor == Color.DarkGreen && BOX_3.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_4.BackColor == Color.DarkGreen && BOX_7.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_5.BackColor == Color.DarkGreen && BOX_9.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
        }

        private void BOX_8_Click(object sender, EventArgs e)
        {
            if (Player_1_Button.Checked == true)
            {
                BOX_8.BackColor = Color.DarkGreen;
                Player_1_Button.Checked = false;
                Player_2_Button.Checked = true;
            }
            else if (Player_2_Button.Checked = true)
            {
                BOX_8.BackColor = Color.DarkRed;
                Player_2_Button.Checked = false;
                Player_1_Button.Checked = true;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_2.BackColor == Color.DarkGreen && BOX_3.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_4.BackColor == Color.DarkGreen && BOX_7.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_5.BackColor == Color.DarkGreen && BOX_9.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
        }

        private void BOX_9_Click(object sender, EventArgs e)
        {
            if (Player_1_Button.Checked == true)
            {
                BOX_9.BackColor = Color.DarkGreen;
                Player_1_Button.Checked = false;
                Player_2_Button.Checked = true;
            }
            else if (Player_2_Button.Checked = true)
            {
                BOX_9.BackColor = Color.DarkRed;
                Player_2_Button.Checked = false;
                Player_1_Button.Checked = true;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_2.BackColor == Color.DarkGreen && BOX_3.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_4.BackColor == Color.DarkGreen && BOX_7.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
            if (BOX_1.BackColor == Color.DarkGreen && BOX_5.BackColor == Color.DarkGreen && BOX_9.BackColor == Color.DarkGreen)
            {
                MessageBox.Show("Player 1 Wins !!");
                player_1 = player_1 + 1;
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            BOX_1.BackColor = Color.Transparent;
            BOX_2.BackColor = Color.Transparent;
            BOX_3.BackColor = Color.Transparent;
            BOX_4.BackColor = Color.Transparent;
            BOX_5.BackColor = Color.Transparent;
            BOX_6.BackColor = Color.Transparent;
            BOX_7.BackColor = Color.Transparent;
            BOX_8.BackColor = Color.Transparent;
            BOX_9.BackColor = Color.Transparent;
        }
    }
}
