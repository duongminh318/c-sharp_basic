using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide19_openfileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile= new OpenFileDialog();
            openFile.Title = "hop thoai mo file tuhoc.cc";
            // chech dieu kien loc file
            openFile.Filter = "File anh|*.jpg;*.gif;*.png; |All File|*.*";
            // check xem nguoi dung da chon file hay chua
            if (openFile.ShowDialog() == DialogResult.OK)
            {
               // MessageBox.Show(openFile.FileName);
               // MessageBox.Show(openFile.SafeFileName);
               pictureBox1.Image=Image.FromFile(openFile.FileName);
            }

           // openFile.ShowDialog();
        }
    }
}
