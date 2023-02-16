using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide5_ex_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn có chắc muốn thoát???",
                "Xác Nhận", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Close();
            }    


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked=true;
           // chkBold.Checked=true;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text=txtInput.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if(radRed.Checked)
            {
                lblOutput.ForeColor=Color.Red;

            }  
            
          
            
        }

     

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblOutput.ForeColor = Color.Green;

            }

        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblOutput.ForeColor = Color.Blue;

            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblOutput.ForeColor = Color.Black;

            }
        }


        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
           //essageBox.Show(lblOutput.Font.Name);
           //essageBox.Show(lblOutput.Font.Size.ToString());
            lblOutput.Font = new Font(
                lblOutput.Font.Name,
                20,
                lblOutput.Font.Style ^ FontStyle.Bold
                );
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(
                lblOutput.Font.Name,
                20,
                lblOutput.Font.Style ^ FontStyle.Italic
                );
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Font = new Font(
                lblfont.Font.Name,
                lblfont.Font.Size,
                lblOutput.Font.Style ^ FontStyle.Underline
                );
        }
    }
}
