using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("INPUT N: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("You just entered the number {0}", n);

            // Test so chan le su dung toan tu so sanh
            if (n % 2 == 0)
                {
                    Console.WriteLine("Number {0} is an even number", n);
                }
            else
                {
                    Console.WriteLine("Number {0} is an odd number", n);

                }
            

            Console.ReadKey();

        }
    }
}
