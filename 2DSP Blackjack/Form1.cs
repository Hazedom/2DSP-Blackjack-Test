using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DSP_Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly string[] PKKarten = new string[] { "C:/Users/Lukas/Downloads/sbs_-_2d_poker_pack/Playing Cards/red_joker.png", "C:/Users/Lukas/Downloads/sbs_-_2d_poker_pack/Playing Cards/black_joker.png"};




        public void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            Button btnHit = new Button();           //Hit Button
            btnHit.Text = "Hit";
            int newSize = 10;
            btnHit.Font = new Font(btnHit.Font.FontFamily, newSize);
            btnHit.Height = 50;
            btnHit.Width = 150;
            btnHit.Location = new Point(100, 300);
            Controls.Add(btnHit);
            Button btnStand = new Button();         //Stand Button
            btnStand.Text = "Stand";
            btnStand.Font = new Font(btnStand.Font.FontFamily, newSize);
            btnStand.Height = 50;
            btnStand.Width = 150;
            btnStand.Location = new Point(300, 300);
            Controls.Add(btnStand);
            Button btnDeal = new Button();          //Deal Button
            btnDeal.Click += new System.EventHandler(btnDeal_Click);
            btnDeal.Text = "Deal";
            btnDeal.Font = new Font(btnDeal.Font.FontFamily, newSize);
            btnDeal.Height = 50;
            btnDeal.Width = 150;
            btnDeal.Location = new Point(500, 300);
            Controls.Add(btnDeal);
        }

        public void btnDeal_Click(object sender, EventArgs e)
        {
       
            PictureBox PK1 = new PictureBox();
            PK1.Height = 150;
            PK1.Width = 100;
            PK1.Image = new Bitmap(PKKarten[0]);
            PK1.Location = new Point(250, 100);
            PK1.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(PK1);
            PictureBox PK2 = new PictureBox();
            PK2.Height = 150;
            PK2.Width = 100;
            PK2.Image = new Bitmap( PKKarten[1]);
            PK2.Location = new Point(400, 100);
            PK2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(PK2);

        }
       



    }

}
