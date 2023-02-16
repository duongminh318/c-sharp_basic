using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while(true) lap vo han
            int n = 0;
            while(true)
            {
                n++; // n=n+1;
                Console.WriteLine("n= "+n);

                //thoat vong lap ko chay lien tuc
                if (n == 10)
                    break;
            }
            Console.ReadKey();
        }
    }
}
