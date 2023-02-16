using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide14_ex_Game_Timer_Number
{
    public partial class Form1 : Form
    {
        int TienNguoiChoi = 100;
        Random rd= new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TienNguoiChoi<20)
            {
                MessageBox.Show("Ban khong du 20 xu, nap them xu ban nhe !!");

            }
            else
            {
                // tru tien nguoi choi
                TienNguoiChoi -= 20;
                lblMoney.Text=TienNguoiChoi.ToString();

                //start time
                timer1.Start();

                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNum1.Text = rd.Next(0, 8).ToString();
            lblNum2.Text = rd.Next(0, 9).ToString();
            lblNum3.Text = rd.Next(0, 10).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(int.Parse(lblNum1.Text)==7)
            {
                TienNguoiChoi += 30;

            }
             if(int.Parse(lblNum2.Text) == 7)
            {
                TienNguoiChoi += 40;
            }
            if (int.Parse(lblNum3.Text) == 7)
            {
                TienNguoiChoi += 50;
            }
            button1.Enabled = true;
            button2.Enabled = false;

            lblMoney.Text = TienNguoiChoi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            TienNguoiChoi = 100;
            lblMoney.Text = TienNguoiChoi.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
        }
    }
}
