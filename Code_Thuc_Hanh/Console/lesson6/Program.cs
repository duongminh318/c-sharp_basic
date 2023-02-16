using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kq;
            int a = 6, b = 10;
            // kq = (a != b) || (a < 3); //or
            // kq = (a != b) && (a < 3);    //and
            kq = !((a != b) && (a < 3));        // phu dinh
            Console.WriteLine("gia tri cua ket qua la "+kq);

            int x = 1, y = 2,z;
            z = x++ - ++y + 1;
            Console.WriteLine("x={0} , y= {1}, z={2} ",x,y,z);

            Console.ReadKey();
        }
    }
}
