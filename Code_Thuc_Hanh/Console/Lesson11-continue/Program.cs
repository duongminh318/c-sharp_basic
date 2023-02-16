using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tinh tong cac so tu 1 - 5 (nhung khong bao gom 3) 1+2+4+5
            int tong = 0;
            for(int i = 0; i <6; i++)
            {
                if (i == 3)
                    continue;
                else
                {

                    Console.WriteLine("i: "+i);
                    tong += i;
                  //  Console.WriteLine("tong: " + tong);
                }

            }
            Console.WriteLine("tong: " + tong);
            Console.ReadKey();
        }
    }
}
