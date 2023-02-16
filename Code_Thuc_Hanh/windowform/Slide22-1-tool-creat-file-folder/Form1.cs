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
using System.Deployment.Application;

namespace Slide22_1_tool_creat_file_folder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpath_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                MessageBox.Show("ban chua chon thu muc thanh cong !!");
            }
        }
        int a, b;
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            
            if(txtpath.Text!="")
            {
               //chech thu muc co ton tai khong, neu khong -> bao loi
               string path=txtpath.Text;
                if(Directory.Exists(path))
                {
                    if(txtden.Text=="" || txttu.Text=="")
                    {
                        MessageBox.Show("chua nhap vao text box tu file nao den file nao");
                    }    
                    else
                    {
                        a = int.Parse(txttu.Text);
                        b = int.Parse(txtden.Text);
                        //duyet for de tao hang loat
                        for (int i = a; i <= b; i++)
                        {
                            //them file hang loat
                            string pathCreat = path + @"\teptin" + i + ".txt";
                            //Console.WriteLine(pathCreat);
                            FileInfo f = new FileInfo(pathCreat);
                            //tao
                            f.Create();
                            //xoa
                            // f.Delete();

                        }
                        MessageBox.Show("da tao xong");

                    }

                }
                else
                {
                    MessageBox.Show("duong dan khong ton tai, kt lai!");
                }

            }
            else
            {
                MessageBox.Show("ban chua nhap duong dan");
            }
        }

        private void btnRun2_Click(object sender, EventArgs e)
        {
            a = int.Parse(txttu.Text);
            b = int.Parse(txtden.Text);
            if (txtpath.Text != "")
            {
                //chech thu muc co ton tai khong, neu khong -> bao loi
                string path = txtpath.Text;
                if (Directory.Exists(path))
                {
                    //duyet for de tao hang loat
                    for (int i = a; i <= b;i+=2)
                    {
                        //them folder hang loat
                        string pathCreat = path + @"\thumuc" + i ;
                        //Console.WriteLine(pathCreat);
                        //tao
                         Directory.CreateDirectory(pathCreat);
                        //xoa
                      //  Directory.Delete(pathCreat);
              
                    }
                    MessageBox.Show("da xong");

                }
                else
                {
                    MessageBox.Show("duong dan khong ton tai, kt lai!");
                }

            }
            else
            {
                MessageBox.Show("ban chua nhap duong dan");
            }
        }
    }
}
