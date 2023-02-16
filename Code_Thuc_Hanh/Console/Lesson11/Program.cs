using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {//xuat cac so chan tu 0- 10
            int tong = 0;
            Console.WriteLine(" Cac so chan tu 0-> 10 la: ");
            for (int i = 0; i <=10; i+=2)
            {
              
                Console.WriteLine("i :{0}", i );
                tong += i;
                Console.WriteLine("tong :{0}", tong);
            }
            Console.ReadKey();
        }
    }
}
