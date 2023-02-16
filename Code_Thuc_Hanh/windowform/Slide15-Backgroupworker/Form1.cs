using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Slide15_Backgroupworker
{
    public partial class frmabc : Form
    {
        public frmabc()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // cong viec chinh mat thoi gian
            int sum = 0;
            for(int i=0; i <= 100; i++)
            {
                Thread.Sleep(100);
                    sum+=i;
                //goi su kien progresschanged len
                backgroundWorker1.ReportProgress(i);
                //neu nhan cancel
                    if(backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
            }
            e.Result = sum;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //update % len value bar (tien do phan tram)
            progressBar1.Value=e.ProgressPercentage;
            //update % len value label
            label1.Text=e.ProgressPercentage.ToString()+"%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                label2.Text = "tien trinh bi huy roi ong chau ạ";
            }   
            else if (e.Error!=null)
            {
                label2.Text = "da co loi sai ra";
            }
            else
            {
                label2.Text = "ket qua : " + e.Result.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //check backgroudworker co dang chay roi hay khong
            label2.Text = "";
            if(!backgroundWorker1.IsBusy)
            {

                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                label2.Text = " cho ti , dang chay roi thim";
            }
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //neu worker dang chay thi cancel de dung
            if(backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            else
            {
                label2.Text = " co dang chay dau ma dung thim";
            }
        }
    }
}
