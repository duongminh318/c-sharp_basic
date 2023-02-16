using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao bien
            int i1 = 2;
            int i2 = 5;
            int i3 = -3;
            float d1 = 2.0f;
            float d2 = 5.0f;
            float d3 = -0.5f;
            // Tinh toan
            // toan tu voi int
            float a = i1 + (i2 * i3);
            float b = i1 * (i2 + i3);
            float c = i1 / (i2 + i3);
            float e = (float)i1 / i2 + i3;
            float g = 3 + 4 + (float)5 / 3;
            float i = (3 + 4 + 5) / 3;

            // toan tu float
            float k = d1 + (d2 * d3);
            float l = d1 + d2 * d3;
            //
            float m = d1 / d2 - d3;
            float n = d1 / (d2 - d3);
            float o = d1 + d2 + d3 / 3;
            float p = (d1 + d2 + d3)/3;
            float q = d1 + d2 + (d3 / 3);
            float r = 3 * (d1 + d2) * (d1 - d3);
            Console.WriteLine("a)  {0} + ({1} * {2}) = {3}", i1, i2, i3, a);
            Console.WriteLine("b)  {0} * ({1} + {2}) = {3}", i1, i2, i3, b);
            Console.WriteLine("c)  {0} / ({1} + {2}) = {3}", i1, i2, i3, c);
            Console.WriteLine("e)  {0} / {1} + {2} = {3}", i1, i2, i3, e);

            Console.WriteLine("g)  3 + 4 + 5/3 = {0}", g);
            Console.WriteLine("i) (3 + 4 + 5) / 3 = {0}", i);
            Console.WriteLine("k)  {0} + ({1} * {2}) = {3}", d1, d2, d3, k);
            Console.WriteLine("l) {0} + {1} * {2} = {3}", d1, d2, d3, l);

            Console.WriteLine("m)  {0} / {1} - {2} = {3}", d1, d2, d3, m);
            Console.WriteLine("n)  {0} / ({1} -{2})  = {3}", d1, d2, d3, n);
            Console.WriteLine("o)  {0} + {1} + {2} /3  = {3}", d1, d2, d3, o);
            Console.WriteLine("p)  ({0} + {1} + {2}) /3  = {3}", d1, d2, d3, p);

            Console.WriteLine("q)  {0} + {1} + ({2}/3) = {3}", d1, d2, d3, q);
            Console.WriteLine("r)  3 * ({0} +{1}) * ({0} - {2}) = {3}", d1, d2, d3, r);
            Console.ReadKey();
        }
    }
}
