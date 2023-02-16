using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int tong = 0;

            Console.WriteLine("moi thim nhap vao n: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                if (i == 3)
                    continue;
                else
                    if(i%2!=0)

                        tong += i;
            }
            Console.WriteLine("tong = {0}", tong);
            Console.ReadKey();
        }
    }
}
