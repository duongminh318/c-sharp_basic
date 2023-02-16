using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            x = 5;
            y = 4;

            Console.WriteLine("X = " +x);
            Console.WriteLine("Y = " + y);

            x += y; //x = x + y
            Console.WriteLine(" x = x + y : "+x);

            x -= y;
            Console.WriteLine(" x = x - y : " + x);
            x *= y;
            Console.WriteLine(" x = x X y : " + x);
            x /= y;
            Console.WriteLine(" x = x / y : " + x);
            x %=y;
            Console.WriteLine(" x = x mod y : " + x);
            Console.ReadKey();
        }
    }
}
