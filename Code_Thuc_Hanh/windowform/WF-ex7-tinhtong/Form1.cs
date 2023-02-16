using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ex7_tinhtong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            Console.WriteLine(txtSoA.Text);
            tong = int.Parse(txtSoA.Text) + int.Parse(txtSoB.Text);
            lblKetQua.Text = txtSoA.Text+" + " +txtSoB.Text+" = " +tong.ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int Hieu;
            Console.WriteLine(txtSoA.Text);
            Hieu = int.Parse(txtSoA.Text) - int.Parse(txtSoB.Text);
            lblKetQua.Text = txtSoA.Text + " - " + txtSoB.Text + " = " + Hieu.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure reset??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (result == DialogResult.Yes)
            {
                lblKetQua.Text = " nhap lai";
                txtSoA.Text = "";
                txtSoB.Text = "";
            }    
            
        }
    }
}
