using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b= 2;
            float f = a/b;
            Console.WriteLine("gia tri cua f la : "+f);

            //ep kieu du lieu sang kieu lon hon
            float f2 = (float)a / b;
            Console.WriteLine("gia tri cua f2 la : "+f2);

            //ep kieu du lieu sang kieu nho hon
            // luy y khi ep phai dam bao giu lieu nam trong khoang cho phep

            int k = 40000;
            Console.WriteLine("gia tri cua k la : " + k);
            // co ep ma gia tri nam ngoai khoan
            byte l = (byte)k;
            Console.WriteLine("gia tri cua l la : " + l);
            //nen lam sai lech gia tri

            //ep nho hon nhung nam trong khoang gia tri
            int k2 = 40;
            Console.WriteLine("gia tri cua k2 la : " + k2);
            // co ep ma gia tri nam ngoai khoan
            byte l2 = (byte)k2;
            Console.WriteLine("gia tri cua l2 la : " + l2);

            Console.ReadKey();
        }
    }
}
