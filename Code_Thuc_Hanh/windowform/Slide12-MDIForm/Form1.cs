using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide12_MDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuOpenForm1_Click(object sender, EventArgs e)
        {
            frm1 frm1 = new frm1();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void mnuOpenForm2_Click(object sender, EventArgs e)
        {
            frm2 frm2 = new frm2();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void mnuOpenForm3_Click(object sender, EventArgs e)
        {
            frm3 frm3 = new frm3();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void sapXepKieu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void sapXepKieu1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void sapXepKieu1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void sapXepKieu1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm5 frm3 = new frm5();         
            frm3.ShowDialog();
        }
    }
}
