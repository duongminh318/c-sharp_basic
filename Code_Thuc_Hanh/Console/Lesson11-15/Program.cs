using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bai tập 15
             * viet chuong trinh
             * tim nhung so chia het cho 3 tu 10 den 50
             */
            for(int i = 10; i <=50; i++)
            {
                if(i%3==0)
                  Console.Write(i+ " ");
            }
            Console.ReadKey();
        }
    }
}
