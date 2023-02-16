using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide7_datetime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            bool check = true;
            errorProvider1.Clear();
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Ban chua nhap phone");
                check = false;
            }

            //tuoi
            int age;
            if(int.TryParse(txtAge.Text, out age)==false)
            {
                errorProvider1.SetError(txtAge, "sai dinh dang tuoi");
                check = false;
            }
            else
            {
                if(age<=17)
                {
                    errorProvider1.SetError(txtAge, "tuoi phai lon hon 17");
                    check = false;
                }
            }

            //k tra ngay dky
            if(dtpSign.Value.DayOfWeek==DayOfWeek.Monday)
            {
                check = false;
                errorProvider1.SetError(dtpSign, "khong dc vao thu 2");
            }
                if(check)
                    {
                MessageBox.Show("dk thanh cong");
                    }
        }
    }
}
