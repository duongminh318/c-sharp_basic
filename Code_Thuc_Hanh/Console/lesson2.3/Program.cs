using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var y = 318;
            Console.WriteLine("Kieu du lieu cua y la {0}", y.GetType().ToString());

            var z = "duong minh 318";

            Console.WriteLine("Kieu du lieu cua z la {0}", z.GetType().ToString());

            Console.ReadKey();
        }
    }
}
