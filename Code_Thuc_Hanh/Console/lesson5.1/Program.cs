using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b=2;
            Console.Write("InPut a: ");
            a = int.Parse(Console.ReadLine());

            //Console.WriteLine("a = {0}",a+=a); //a=a+a

            a -= b + 7; //a=a-(b+7)
            Console.WriteLine("a = {0}", a);

            Console.ReadKey();

        }
    }
}
