using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide10_ChekedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chklb.Items.Add("4");
            chklb.Items.Add("5");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            chklb.Items.Insert(1, "dkm");
        }

        private void btnAddRange_Click(object sender, EventArgs e)
        {
            string [] mang = new string [] { "tran", "hao", "nam" };
            chklb.Items.AddRange(mang);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = chklb.Items.Count;
            MessageBox.Show("so phan tu cua chklb la: " + count);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            chklb.Items.Remove("1");
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            chklb.Items.RemoveAt(1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chklb.Items.Clear();
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection indexCollection=
                chklb.CheckedIndices;
            string strChecked = "";
            foreach(int i in indexCollection)
            {
                strChecked += i + " ";            
            }
            MessageBox.Show("index cac pt dc chon " + strChecked);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection itemsCollection =
              chklb.CheckedItems;
            string chkItems = "";
            foreach (string i in itemsCollection)
            {
                chkItems += i + " ";
            }
            MessageBox.Show("gia tri cac pt dc chon " + chkItems);
        }

        private void btnGetItemChecked_Click(object sender, EventArgs e)
        {
            // check xem co dang chon vao index nao do ko neu co tra ve true
            // bool ck=chklb.GetItemChecked(0);
            //MessageBox.Show("co dang chon pt thu 0 " + ck);

            string chkIndex = "";
            string title = " index";
            for (int i=0;i<chklb.Items.Count;i++)
            {
                if(chklb.GetItemChecked(i)== true)
                {
                    chkIndex += i + " ";
                }
                    
              
            }
            MessageBox.Show(chkIndex, title);

            //

            string chkItems = ""; 
            string title2 = " Items: ";
            for (int i = 0; i < chklb.Items.Count; i++)
            {
                if (chklb.GetItemChecked(i) == true)
                {
                    chkItems += chklb.Items[i] + " ";
                }


            }
            MessageBox.Show(chkItems, title2);





        }

     
    }
}
