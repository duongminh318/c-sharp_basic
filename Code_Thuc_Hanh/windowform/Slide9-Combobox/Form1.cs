using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide9_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboList.Items.Add("russa");
            cboList.Items.Add("ukraina");
            cboList.Items.Add("usa");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cboList.Items.Insert(0, "insert");
        }

        private void btnSelectedInded_Click(object sender, EventArgs e)
        {
            int index= cboList.SelectedIndex;
            if(index==-1)
            {
                MessageBox.Show("khong co pt nao dang duoc chon " );
            }
            else
            {
                MessageBox.Show("index pt dang chon la : " + index);
            }
          
        }

        private void btnSelectedItem_Click(object sender, EventArgs e)
        {
           //string content=cboList.SelectedItem.ToString();
           // if(content==null)
           // {
                //MessageBox.Show("khong co pt nao dang duoc chon ");
          //  }
          //  else
         //   {
                MessageBox.Show("gia tri pt dang chon la : " + cboList.SelectedItem);
           // }
           
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count= cboList.Items.Count;
            MessageBox.Show("so phan tu trong Combobox la : " + count);
        }

        // them vao 1 day cac phan tu
        private void btnAddRange_Click(object sender, EventArgs e)
        {
            // cboList.Items.AddRange(new string[] { "pt1", "pt2", "pt3" });
            string[] arg = new string[] { "pt4", "pt5", "pt6" };
            cboList.Items.AddRange(arg);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            cboList.Items.Remove("usa");
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            cboList.Items.RemoveAt(3);
        }

        // xoa toan bo
        private void btnClear_Click(object sender, EventArgs e)
        {
            cboList.Items.Clear();
        }
    }
}
