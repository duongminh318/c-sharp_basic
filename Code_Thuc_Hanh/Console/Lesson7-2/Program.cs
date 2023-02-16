using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //x+y= a
            // x-y =b
            float a, b, x, y;
            Console.Write("Input sum of two number a: ");
            a=float.Parse(Console.ReadLine());

            Console.Write("Input sub of two number b: ");
            b = float.Parse(Console.ReadLine());     
                x = a - (a - b) / 2;
                y = (a - b) / 2;
                Console.WriteLine("Number x : " + x);
                Console.WriteLine("Number y : " + y);
            Console.ReadKey();
        }
    }
}
