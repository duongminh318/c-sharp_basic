using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Slide20_SaveDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //tieu de
            saveFileDialog1.Title = "tieu de sfd";
            //filter
            saveFileDialog1.Filter = "Text file|*.txt|Pdf file|*.pdf|All file|*.*";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, rxtContent.Text);
                MessageBox.Show("saved");
            }
            else
            {
                MessageBox.Show("chua luu noi dung");
            }
        }
    }
}
