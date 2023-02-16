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

namespace Selenium_buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            ChromeDriverService cds =  ChromeDriverService.CreateDefaultService();
            cds.HideCommandPromptWindow = true;
            // dieu huong trinh duyet
            IWebDriver driver = new ChromeDriver(cds);
            driver.Navigate().GoToUrl("http://google.com.vn");
            //close
            //driver.Close();
            //input j do vao o tim kiem
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys(txtUrl.Text);
          

        }
        //cach 2
        private void btnOpenBrowser2_Click(object sender, EventArgs e)
        {
            IWebDriver driver= new ChromeDriver();
            driver.Url = "http://"+txtUrl.Text;
            driver.Navigate();

        }
    }
}
