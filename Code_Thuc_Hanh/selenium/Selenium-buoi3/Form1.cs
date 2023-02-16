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
using System.Threading;
using System.Collections.ObjectModel;

namespace Selenium_buoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            // tao 1 doi tuong
            IWebDriver driver= new ChromeDriver();

            // khai bao url
            driver.Url = "https://demosite.executeautomation.com/index.html?UserName=duongminh&Password=dminh318&Login=Login";
            driver.Navigate();

            //element
            //IWebElement element = driver.FindElement(By.Name("UserName"));
            //element.SendKeys(txtUser.Text);
            //IWebElement element2 = driver.FindElement(By.Name("Password"));
            //element2.SendKeys(txtPw.Text);

            //element.Clear();
            // nhap chuot
           // Thread.Sleep(2000);
            IWebElement login = driver.FindElement(By.Name("generate"));
            login.Click();

        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demosite.executeautomation.com/index.html?UserName=duongminh&Password=dminh318&Login=Login";

            IWebElement element = driver.FindElement(By.Id("Initial"));
            element.SendKeys(txtUser.Text);

            IWebElement element2 = driver.FindElement(By.Name("FirstName"));
            element2.SendKeys(txtPw.Text);

            IWebElement element3 = driver.FindElement(By.Name("MiddleName"));
            element3.SendKeys("Middle Part");
        }

        private void btnShoppe_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://shopee.vn/?utm_campaign=-&utm_content=affiliate06&utm_medium=affiliates&utm_source=an_17329180010&utm_term=7vi8zkxspu5h&gclid=Cj0KCQiA14WdBhD8ARIsANao07iEYyYFV6FH7akA2x9j12TAuhWjpoaEkcVQu1gAEfNpZ3npdx3HXJgaArD9EALw_wcB";
            IWebElement element = driver.FindElement(By.ClassName("shopee-searchbar-input__input"));
            element.SendKeys("laptop gaming");

            //by.linktext tìm link dựa vào text trên trang web
            IWebElement element2 = driver.FindElement(By.LinkText("Kênh Người Bán"));
             //txtOutPut.Text=  element2.GetAttribute("href");

                // tương tự nhưng tìm rộng hơn, không cần nhớ rõ từ tìm chính xác
                IWebElement element3 = driver.FindElement(By.PartialLinkText("Đăng "));
                txtOutPut.Text = element3.GetAttribute("href");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // tao 1 doi tuong
            IWebDriver driver = new ChromeDriver();

            // khai bao url
            driver.Url = "https://demosite.executeautomation.com/";
            driver.Navigate();

            //element
            IWebElement element = driver.FindElement(By.Name("UserName"));
            element.SendKeys("duongminh");

            IWebElement element2 = driver.FindElement(By.Name("Password"));
            element2.SendKeys("dminh318");

            // copy xpath
            IWebElement element3 = driver.FindElement(By.XPath("//*[@id=\"userName\"]/p[3]/input"));
            element3.Click();
        }

        private void btnWiki_Click(object sender, EventArgs e)
        {
            // tao 1 doi tuong
            IWebDriver driver = new ChromeDriver();

            // khai bao url
            driver.Url = "https://vi.wikipedia.org/wiki/Trang_Ch%C3%ADnh";
            driver.Navigate();


            IWebElement element3 = driver.FindElement(By.CssSelector("#pt-createaccount-2 > a > span"));
            element3.Click();
        }

        private void btnTagName_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();

            // khai bao url
            driver.Url = "https://en.wikipedia.org/wiki/I_Want_to_Love_You";
          //  driver.Navigate();
            
            // tim kiếm theo thẻ html
            IWebElement element3 = driver.FindElement(By.TagName("h2"));
            Console.WriteLine(element3.Text);

            // tìm kiếm tương tự nhưng tìm nhiều phần tử
           ReadOnlyCollection<IWebElement>  elements = driver.FindElements(By.TagName("h2"));
          // kiểu giống như mảng
             foreach(var element in elements)
            {
                 Console.WriteLine(element.Text);
               // MessageBox.Show(element+" ");
            }    

            driver.Quit();
        }
    }
}
