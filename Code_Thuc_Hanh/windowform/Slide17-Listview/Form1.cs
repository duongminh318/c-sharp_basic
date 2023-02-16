using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide17_Listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = listView1.SelectedItems[0];
                string ma=lv1.SubItems[0].Text;
                string ten=lv1.SubItems[1].Text;
                string gia=lv1.SubItems[2].Text;
                // MessageBox.Show(ma + "\t" + ten + "\t" + gia);

                // hien thi nguoc lai tu list sang textbox
                txtMa.Text = ma;
                txtGia.Text = gia;
                txtTen.Text = ten;
            }
           
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //MessageBox.Show(""+e.Column);  // lay gia tri index cua cot
           // MessageBox.Show(listView1.Columns[0].ToString()); // lay text tai index nao do
            if(e.Column!=-1)
            {
                ColumnHeader cot = listView1.Columns[e.Column]; // ket hop lay text o index click chuot
                MessageBox.Show("cot ban chon la: "+cot.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtMa.Text);
            item.SubItems.Add(txtTen.Text);
            item.SubItems.Add(txtGia.Text);

            listView1.Items.Add(item);
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            while(listView1.SelectedItems.Count>0)
            {
                //Console.WriteLine(listView1.SelectedItems[0].Index); // xoa nhieu dong trong danh sach cac items da chon
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
                MessageBox.Show("da xoa 1 dong");
            }
            else
            {
                MessageBox.Show("chua chon dong nao de xoa");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item2 = listView1.SelectedItems[0];
                item2.SubItems[0].Text = txtMa.Text;
                item2.SubItems[1].Text = txtTen.Text;
                item2.SubItems[2].Text = txtGia.Text;

            }
        }
    }
}
