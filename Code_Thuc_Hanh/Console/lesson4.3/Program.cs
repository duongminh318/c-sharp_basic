using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Pi = 3.14f, p, s, r;
            
            Console.Write("Input circle radius r: ");
            r = float.Parse(Console.ReadLine());

            p = 2 * r * Pi;
            s = Pi * (r * r);
            Console.WriteLine("Circle of radius {0} has perimeter {1}", r, p);
            Console.WriteLine("Circle of radius {0} has area {1}", r, s);
            Console.ReadKey();
        }
    }
}
