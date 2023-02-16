using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide14__Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // code here
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // timer1.Enabled = true;
            timer1.Start();
            lblTime.Visible = true;

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            //lblTime.Visible = false;
            timer1.Enabled = false;
        }
    }
}
