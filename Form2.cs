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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (DataBanck.f2_back)
            {
                pictureBox1.Image = new Bitmap(Properties.Resources.konoha_store);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                skin.BackColor = Color.MistyRose;
                autoclick.BackColor = Color.MistyRose;
                doubleclick.BackColor = Color.MistyRose;
                backgr.BackColor = Color.MistyRose;
                clse.BackColor = Color.MistyRose;
            }
        }
        private void skin_Click(object sender, EventArgs e)
        {
            if (DataBanck.coin >= 50)
            {
                DataBanck.SwStore = 1;
                DataBanck.coin = DataBanck.coin - 50;
            }
            else { MessageBox.Show("NEED MORE"); };
        }
        private void autoclick_Click(object sender, EventArgs e)
        {
            if (DataBanck.coin >= 30)
            {
                DataBanck.SwStore = 2;
                DataBanck.coin = DataBanck.coin - 30;
            }
            else { MessageBox.Show("NEED MORE"); };
        }

        private void doubleclick_Click(object sender, EventArgs e)
        {
            if (DataBanck.coin >= 300)
            {
                DataBanck.SwStore = 3;
                DataBanck.coin = DataBanck.coin - 300;
            }
            else { MessageBox.Show("NEED MORE"); };
        }

        private void backgr_Click(object sender, EventArgs e)
        {
            if (DataBanck.coin >= 150)
            {
                DataBanck.SwStore = 4;
                pictureBox1.Image = new Bitmap(Properties.Resources.konoha_store);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                DataBanck.f2_back = true;
                skin.BackColor = Color.MistyRose;
                autoclick.BackColor = Color.MistyRose;
                doubleclick.BackColor = Color.MistyRose;
                backgr.BackColor = Color.MistyRose;
                clse.BackColor = Color.MistyRose;
                DataBanck.coin = DataBanck.coin - 150;
            }
            else { MessageBox.Show("NEED MORE"); };
        }
        private void clse_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
    }
