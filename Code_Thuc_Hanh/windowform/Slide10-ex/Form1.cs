using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide10_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items =
                chklbLeft.CheckedItems;
            foreach(string item in items)
            {
                //Console.WriteLine(item);
                chklbRight.Items.Add(item);
            }

            // duyet xoa pt ben trai
            foreach(string s in chklbRight.Items)
            {
                chklbLeft.Items.Remove(s);
            }
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            for (int i=0; i<chklbLeft.Items.Count; i++)
            {
                chklbRight.Items.Add(chklbLeft.Items[i]);
            }
            // duyet xoa all ben trai
            for (int i = 0; i < chklbLeft.Items.Count; i++)
            {
                chklbLeft.Items.Clear();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

            CheckedListBox.CheckedItemCollection items =
                chklbRight.CheckedItems;
            foreach (string item in items)
            {
                //Console.WriteLine(item);
                chklbLeft.Items.Add(item);
            }

            // duyet xoa pt ben trai
            foreach (string s in chklbLeft.Items)
            {
                chklbRight.Items.Remove(s);
            }
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < chklbRight.Items.Count; i++)
            {
                chklbLeft.Items.Add(chklbRight.Items[i]);
            }
            // duyet xoa all ben phai
            for (int i = 0; i < chklbRight.Items.Count; i++)
            {
                chklbRight.Items.Clear();
            }
        }
    }
}
