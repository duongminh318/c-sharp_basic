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


namespace Selenium_Up_Hinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpAnh_Click(object sender, EventArgs e)
        {
            //tat ban den
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow=true;
            // khai bao
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Url=("https://upanh.tv/?lang=vi");
            driver.Navigate();

            IWebElement upload = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/a"));
            //upload.Click();
              upload.SendKeys("C:\\Users\\Admin\\Pictures\\noel\\1");
           // upload.SendKeys("bk.jpg");
        }
    }
}
