using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * viet chuong trinh:
             * tinh tong s= 1!+2!+...10!
             */
            int m = 1, tong=0;
            for(int i = 1; i <=10; i++)
            {
                m = i * m;
                Console.WriteLine(m);
                //1. m=1
                //2, i=2, m=1 => m=2
                //3. i=3, m=2 => m=6
                //4. i=4, m=6 => m=24
                tong += m;

            }    
            Console.WriteLine(tong);
            Console.ReadKey();
        }
    }
}
