using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolkoikrzyzyk
{
    public partial class Form2 : Form
    {
        string player = "X";



        public Form2()
        {
            InitializeComponent();
        }

        public void check()
        {




            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") ||
        (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") ||
        (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") ||
        (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") ||
        (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") ||
        (button3.Text == "X" && button6.Text == "X" && button9.Text == "X") ||
        (button1.Text == "X" && button5.Text == "X" && button9.Text == "X") ||
        (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                MessageBox.Show("Gracz X wygrywa!");
                return;
            }

            // Sprawdzanie wygranej dla gracza O
            if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") ||
                (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") ||
                (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") ||
                (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") ||
                (button3.Text == "O" && button6.Text == "O" && button9.Text == "O") ||
                (button1.Text == "O" && button5.Text == "O" && button9.Text == "O") ||
                (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                MessageBox.Show("Gracz O wygrywa!");
                return;
            }

            // Sprawdzanie, czy wszystkie pola są wypełnione (remis)
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                MessageBox.Show("Remis!");
            }


        }
        public void zjendcie(Image img1, Image img2, string name1, string name2)
        {
            label1.Text = name1;
            label2.Text = name2;
            pictureBox1.Image = img1;
            pictureBox2.Image = img2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == string.Empty)
            {
                button1.Text = player;
                if (player == "X")
                {
                    player = "O";
                }
                else { player = "X"; }

            }
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == string.Empty)
            {
                button2.Text = player;
                if (player == "X")
                {
                    player = "O";
                }
                else { player = "X"; }

            }
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == string.Empty)
            {
                button3.Text = player;
                if (player == "X")
                {
                    player = "O";
                }
                else { player = "X"; }

            }
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == string.Empty)
            {
                button6.Text = player;
                if (player == "X")
                {
                    player = "O";
                }
                else { player = "X"; }

            }
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == string.Empty)
            {
                button5.Text = player;
                if (player == "X")
                {
                    player = "O";
                }
                else { player = "X"; }

            }
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == string.Empty)
            {
                button4.Text = player;
                if (player == "X")
                {
                    player = "O";
                }
                else { player = "X"; }

            }
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == string.Empty)
            {
                button9.Text = player;
                if (player == "X")
                {
                    player = "O";
                }
                else { player = "X"; }

            }
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == string.Empty)
            {
                button8.Text = player;
                if (player == "X")
                {
                    player = "O";
                }
                else { player = "X"; }

            }
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == string.Empty)
            {
                button7.Text = player;
                if (player == "X")
                {
                    player = "O";
                }
                else { player = "X"; }

            }
            check();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            player = "X";
        }
    }
}
