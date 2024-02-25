using System.Linq.Expressions;
using System.Media;
using System.Windows.Forms;

namespace kolkoikrzyzyk
{
    public partial class Form1 : Form
    {
        void changeImage(PictureBox pictureBox)
        {

            switch (img)
            {
                case 1:
                    pictureBox.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox.Image = Properties.Resources._4;
                    break;
            }
        }

        private SoundPlayer soundPlayer = new SoundPlayer();
     
        private void PlayMusic()
        {
            soundPlayer.SoundLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "akcent.wav");
            soundPlayer.PlayLooping();
        }
        int img = 0;
        public Form1()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.zjendcie(pictureBox1.Image, pictureBox2.Image, textBox1.Text, textBox2.Text);
            form2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (img == 0)
            {
                img = 4;
            }
            img--;
            changeImage(pictureBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (img == 4)
            {
                img = 0;
            }
            img++;
            changeImage(pictureBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (img == 0)
            {
                img = 4;
            }
            img--;
            changeImage(pictureBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (img == 4)
            {
                img = 0;
            }
            img++;
            changeImage(pictureBox1);
        }
    }
}
