using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tong = 0;
            for (int i = 0; i < 6; i++)
            {
                if (i == 3)
                  break;
                else
                {

                    Console.WriteLine("i: " + i);
                    tong += i;
                    //  Console.WriteLine("tong: " + tong);
                }

            }
            Console.WriteLine("tong: " + tong);
            Console.ReadKey();
        }
    }
}
