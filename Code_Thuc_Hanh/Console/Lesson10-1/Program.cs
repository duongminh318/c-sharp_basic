using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // viet chuong trinh nhap vao so n tu ban phim
            // n nam trong khoang tu  1->99
            int n;
            Console.Write(" moi nhap N nam trong khoang tu  1->99: ");
            n = int.Parse(Console.ReadLine());
            // CHECK DIEU KIEN
            while(n<1 || n>99)
            {
                Console.Write("  n khong hop le, moi nhap lai : ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(" nhap {0} dung roi ", n);
            Console.ReadKey();
        }
    }
}
