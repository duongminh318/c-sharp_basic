using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2, z;
            z = x++ - ++y + 1;
            Console.WriteLine("x={0} , y= {1}, z={2} ", x, y, z);

            Console.ReadKey();
        }
    }
}
