using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide8_ex
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x= int.Parse(txtInput.Text);
            lstNumber.Items.Add(x);
            txtInput.Text = "";
            txtInput.Focus();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (int w in lstNumber.Items)
            {
              
                count=count+w;
                
            }
            MessageBox.Show("Cout of List Number: " + count);
        }

        private void btnRemoveFiteam_Click(object sender, EventArgs e)
        {
            lstNumber.Items.RemoveAt(0);
            lstNumber.Items.RemoveAt(lstNumber.Items.Count-1);
        }

        private void btnSitem_Click(object sender, EventArgs e)
        {
            while (lstNumber.SelectedIndex != -1)
                lstNumber.Items.RemoveAt(lstNumber.SelectedIndex);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            for(int i= 0; i < lstNumber.Items.Count; i++)
            {
                int k = (int)lstNumber.Items[i] + 2;
                lstNumber.Items[i] = k;
            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lstNumber.Items.Count; i++)
            {
                int k = (int)lstNumber.Items[i] * (int)lstNumber.Items[i];
                lstNumber.Items[i] = k;
            }
        }

        private void btnChooseEven_Click(object sender, EventArgs e)
        {
            lstNumber.SelectedIndex = -1;

            for (int i = 0; i < lstNumber.Items.Count; i++)
            {
                int k = (int)lstNumber.Items[i] ;
                if (k % 2 == 0)
                    lstNumber.SelectedIndex = i;
            }
        }

        private void btnChooseOdd_Click(object sender, EventArgs e)
        {

            lstNumber.SelectedIndex = -1;

            for (int i = 0; i < lstNumber.Items.Count; i++)
            {
                int k = (int)lstNumber.Items[i];
                if (k % 2 != 0)
                    lstNumber.SelectedIndex = i;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
