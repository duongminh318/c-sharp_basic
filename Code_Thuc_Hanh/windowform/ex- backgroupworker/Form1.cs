using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex__backgroupworker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bgk1_DoWork(object sender, DoWorkEventArgs e)
        {
            int tong = 0;
            for(int i=0; i<=100;i++)
            {
                Thread.Sleep(1000);
                tong+=i;
                //goi su kien progress changed len
                bgk1.ReportProgress(i);
                if(bgk1.CancellationPending)
                {
                    e.Cancel = true;
                    bgk1.ReportProgress(0);
              
                    return;

                }
                e.Result = tong;

            }
        }

        private void bgk1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //update len progress bar
            progressBar1.Value = e.ProgressPercentage;

            label1.Text= e.ProgressPercentage.ToString() +" %";

        }

        private void bgk1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            
            
                label2.Text = "ket qua : " + e.Result.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgk1.RunWorkerAsync();
        }
    }
}
