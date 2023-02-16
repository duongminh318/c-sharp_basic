using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_3_ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ;
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] lst = str1.Split(' ');
            string strSo = "";
            foreach(string x in lst) // duyet tung thanh phan cua lst thanh tung chuoi x
            {
              //  Console.WriteLine(x);
                foreach (char c in x)// duyet tung thanh phan cua chuoi x thanh char c
                {
                   //Console.WriteLine(c);
                    if(char.IsDigit(c))
                    {
                        strSo += x + " ";
                        break;
                    }
                }
            }
            Console.WriteLine(strSo);
            //Console.WriteLine(strSo.Length);
           strSo = strSo.Trim(); //xoa khoang trang dau va cuoi
            //Console.WriteLine(strSo.Length);

            // tach strso theo space
            string[] lst2=strSo.Split(' ');
            int tong = 0;
            foreach(string y in lst2)
            {

                Console.WriteLine(y);
                //Console.WriteLine(y.GetType().ToString());
                tong +=int.Parse(y);

            }
            Console.WriteLine("tong cac so can tim la: "+tong);
            float tbc=(float)tong/ (lst2.Length);
            Console.WriteLine(lst2.Length);
            Console.WriteLine("TBC cac so can tim la: " + tbc);
            Console.ReadKey();

        }
    }
}
