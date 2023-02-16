using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide8_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add("item 3");
            lstDanhSach.Items.Add("item 4");
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int a = lstDanhSach.Items.Count;
            MessageBox.Show(a.ToString());
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstDanhSach.Items[1].ToString());
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.RemoveAt(2);
        }

        private void btnSelecID_Click(object sender, EventArgs e)
        {
            foreach(int i in lstDanhSach.SelectedIndices)
            {
                MessageBox.Show("Index: "+i);
            }
            //tra ve index phan tu dau tien trong list dc chon
            MessageBox.Show("tra ve index phan tu dau tien trong list dc chon: " + lstDanhSach.SelectedIndices[0]);
            //dem xem dang chon bao nhieu cai
            MessageBox.Show("dem xem dang chon bao nhieu cai: " + lstDanhSach.SelectedIndices.Count);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items[3] = "xup do cong san";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Index cua item dang dc chon la: " + lstDanhSach.SelectedIndex);
        }
    }
}
