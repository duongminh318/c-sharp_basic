using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide3_messageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cam on da tin em, nhung trong nay khong co gi dau","thong bao",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //DialogResult cc=MessageBox.Show(
            //    "are you sure Exit???",
            //    "ConFirm", 
            //    MessageBoxButtons.YesNo, 
            //    MessageBoxIcon.Question);
            //if (cc == DialogResult.Yes)
            //    Application.Exit();
            //else if(cc == DialogResult.No)
            //{
            //    MessageBox.Show(
            //        "Please continue to use the software");
            //}

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult cc2 = MessageBox.Show(
            //    "Are you sure Exxxit ?? ",
            //    " Confirm",
            //    MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Exclamation
            //    );
            //if (cc2 == DialogResult.Yes)
            //    e.Cancel = false;
            //else
            //    e.Cancel = true;

            DialogResult cc2 = MessageBox.Show(
               "Biến con mịa m đê thằng mặt l ");
        }
    }
}
