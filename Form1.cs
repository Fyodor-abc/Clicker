using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLep
{
    public partial class Form1 : Form
    {
        public bool tenClick;
        int autockick;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            label3.Parent = pictureBox2;
            label3.BackColor = Color.Transparent;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DataBanck.coin++;
            label3.Text = Convert.ToString(DataBanck.coin);
            if (tenClick)
            {
                for (int i = 0; i <= 1000; i++) { DataBanck.coin++; }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DataBanck.SwStore == 1)
            {
                pictureBox1.Image = new Bitmap(Properties.Resources.konan);
                pictureBox1.Size = new Size(400, 400);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Parent = pictureBox2;
                pictureBox1.BackColor = Color.Transparent;
                pictureBox1.Left = ClientSize.Width / 2 - pictureBox1.Width / 2;
                pictureBox1.Top = ClientSize.Height / 2 - pictureBox1.Height / 2;
            }
            if (DataBanck.SwStore == 2 || autockick == 2)
            {
                label3.Text= Convert.ToString(DataBanck.coin++);
                autockick = 2;
            }
            if (DataBanck.SwStore == 3)
            {
                tenClick = true;
            }
            if (DataBanck.SwStore == 4)
            {
                pictureBox2.Image = new Bitmap(Properties.Resources.konoha);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                button1.BackColor = Color.MistyRose;

            }
        }


    }
}

