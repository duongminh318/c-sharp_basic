using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Slide6_ex
{
    public partial class Form1 : Form
    {
        private SoundPlayer playmusic;
        public Form1()
        {
            InitializeComponent();
            playmusic = new SoundPlayer(@"D:\LEARNING\LEARNING_CODE\c# basic_ga_lai_lap_trinh\Window_Form\pic\nhactap.wav");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picHaTa.Visible = false;
            picNangTa.Visible = true;
          
        }

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show(
                        " Cụ có muốn thoát chương trình ?",
                        "Confirm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
            if (DialogResult.Yes == Exit)
            {
                Close();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
            btnClick.Text = txtName.Text;
            if(picHaTa.Visible==false)
                btnClick.Text= txtName.Text + " !! Click vào đây để hạ tạ đi Cụ";
            else
                {
                btnClick.Text = txtName.Text + " !! Click vào đây để nâng tạ đi Cụ";
            }
        }
        int count = 1;
        private void btnClick_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="")
            {
                MessageBox.Show("Cụ chưa nhập tên mà, phải nhập tên trước đã",":)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
            }
            else
            {
                if (picHaTa.Visible == false)
                {
                    picHaTa.Visible = true;
                    picNangTa.Visible = false;
                    btnClick.Text = btnClick.Text.Replace("hạ", "nâng");

                }
                else
                {
                    picHaTa.Visible = false;
                    picNangTa.Visible = true;
                    btnClick.Text = txtName.Text + " !! Click vao day de hạ tạ đi Cụ";
                    lblDem.Text = count.ToString();
                    count++;
                    if (count == 11)
                    {
                        DialogResult result = MessageBox.Show(
                            "Cụ nâng được 10 cái rồi cụ khoẻ quá! hoàn thành ngày hôm nay cụ khoẻ quá !!, cụ có muốn nâng tiếp không?",
                            "Confirm",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            DialogResult Exit = MessageBox.Show(
                            "Mệt rồi à, Cụ có muốn thoát chương trình?",
                            "Confirm",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                            if (DialogResult.Yes == Exit)
                            {
                                Close();
                            }
                        }

                    }

                }
          

            }
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusic.Checked == true)
                playmusic.Play();
            else
                playmusic.Stop();
        }
    }
}
