using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.Write("InPut x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("InPut y: ");
            y = float.Parse(Console.ReadLine());

             var Sum = x + y;
            Console.WriteLine("{0} + {1} = {2} ", x, y, Sum);

            var Sub = x - y;
            Console.WriteLine("{0} - {1} = {2} ", x, y, Sub);

            var Mul = x * y;
            Console.WriteLine("{0} X {1} = {2} ", x, y, Mul);

            var Div = x / y;
            Console.WriteLine("{0} / {1} = {2} ", x, y, Div);

            var Mod = x % y;
            Console.WriteLine("{0} chia {1} du {2} ", x, y, Mod);

            Console.ReadKey();
            

        }
    }
}
