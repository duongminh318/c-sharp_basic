using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * viet chuong tirnh nhap vao so nguyen n, in ra ket qua n!
             * dung vong lap for
             * dung vong lap while 1*2*..n
             * 
             */
            int n, giaiThua=1;
            int i = 1;

            Console.WriteLine("moi thim nhap vao n: ");
            n = int.Parse(Console.ReadLine());
              while(i<=n)
            {
                giaiThua *= i;
                i++;
            }
            Console.WriteLine("{0}! = {1}",n, giaiThua);
            Console.ReadKey();
        }
    }
}
