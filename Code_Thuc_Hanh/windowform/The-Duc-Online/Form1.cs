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

namespace The_Duc_Online
{
    public partial class Form1 : Form
    {
        private SoundPlayer playMusic;
        public Form1()
        {
            playMusic= new SoundPlayer(@"nhactap.wav");
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnClick.Text = txtName.Text + "!! Click vào đây để nâng tạ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picHa.Visible = true;
            picNang.Visible = false;
        }
        int count = 1;
        private void btnClick_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Cụ chưa nhập tên mà ! phải nhập tên trước chứ.", "ConFirm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.Focus();
            }

            else
            {
                if (picHa.Visible == true)
                {

                    picHa.Visible = false;
                    picNang.Visible = true;
                    btnClick.Text = txtName.Text + "!! Click vào đây để hạ tạ";
                    lblCount.Text = count.ToString();
                    count++;
                    if (count == 11)
                    {
                        DialogResult kq = MessageBox.Show("Cụ nâng được 10 cái rồi, hoàn thành ngày hôm nay, cụ khoẻ quá. Cụ có muốn tiếp tục",
                             "Confirm",
                             MessageBoxButtons.YesNoCancel,
                             MessageBoxIcon.Question);
                        if (kq == DialogResult.No)
                        {
                            {
                                DialogResult exit = MessageBox.Show("Cụ có thực sự muốn Thoát",
                                "Confirm",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Question);
                                if (exit == DialogResult.Yes)
                                {
                                    Close();

                                }

                            }
                        }
                    }
                }
                else if (picNang.Visible == true)
                {
                    picHa.Visible = true;
                    picNang.Visible = false;
                    btnClick.Text = btnClick.Text.Replace("hạ", "nâng");
                }

              
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Cụ có thực sự muốn Thoát",
                            "Confirm",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Close();

            }
        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusic.Checked == true)
                playMusic.Play();
            else
                playMusic.Stop();
        }
    }
    }

