using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutoItX3Lib;
using System.Threading;

namespace Selenium_buoi4_autoit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvent_Click(object sender, EventArgs e)
        {
            //tat ban den
            ChromeDriverService chrome= ChromeDriverService.CreateDefaultService(); 
            chrome.HideCommandPromptWindow = true;

            // tao thanh phan
            IWebDriver driver= new ChromeDriver(chrome);
            // gan url
            driver.Url = "https://online2pdf.com/";
            // dieu huong
            driver.Navigate();

            // tim select file
            IWebElement selectFile = driver.FindElement(By.XPath("//*[@id=\"div_file_box0_0\"]/div/div[1]/table/tbody/tr/td/div[1]/button"));
            selectFile.Click();

            // khoi tao doi tuong autoIT
            AutoItX3 auto = new AutoItX3();
            auto.WinActivate("Open");
            Thread.Sleep(1000);

            string path = "\""+ "D:\\LEARNING\\LEARNING_CODE\\nhap\\tuhoc1.pptx" + "\" " + "\"" + "D:\\LEARNING\\LEARNING_CODE\\nhap\\tuhoc2.pptx" + "\" ";
            auto.Send(path);
            Thread.Sleep(1000);

            // nhan phim enter
            auto.Send("{ENTER}");

            //tim nut convert
            IWebElement convert = driver.FindElement(By.ClassName("convert_button"));
            convert.Click();
        }
    }
}
