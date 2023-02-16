using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide11_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl
                as Button;
           btn.BackColor=Color.Red;

            //Form frm= contextMenuStrip1.SourceControl
              //  as Form;
          //  frm.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl
             as Button;
            btn.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl
             as Button;
            btn.BackColor = Color.Blue;
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            // tao ra 100 button co text random
            Random rd = new Random();
            for(int i=0;i<100;i++)
            {
                Button btn = new Button();
                btn.Text = rd.Next(500).ToString();
                flowLayoutPanel1.Controls.Add(btn);
                //gan context menu strip cho button dong
                btn.ContextMenuStrip=contextMenuStrip1;
            }
        }
    }
}
