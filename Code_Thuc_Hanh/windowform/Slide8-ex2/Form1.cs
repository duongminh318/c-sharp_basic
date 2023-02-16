using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide8_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Sinhvien sv = new Sinhvien();
            sv.Ma = int.Parse(txtID.Text);
            sv.Ten =txtName.Text;
            string s = sv.Ma + " - " + sv.Ten;
            lstList.Items.Add(s);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstList.Items.Clear();
        }
    }
}
