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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Selenium_buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            IWebDriver driver= new ChromeDriver();
            //set
            driver.Url = "http://google.com";
            driver.Navigate();

            //get
            string link_hien_tai=driver.Url;
            //rtxOutput.Text = link_hien_tai;

            //get title
            string title = driver.Title;
          //  rtxOutput.Text = title;

            //get page source
            string pagesource= driver.PageSource;
            rtxOutput.Text = pagesource;

            //close
           // driver.Quit();

           //drive.Navigate
           driver.Navigate().GoToUrl("http://youtube.com");

            //.Back tro lai
            driver.Navigate().Back();
            Thread.Sleep(2000); //delay 2 giay
            //forward tien len
            driver.Navigate().Forward();

            // tai lai trang (f5)
            Thread.Sleep(2000);
            driver.Navigate().Refresh();
        }
    }
}
