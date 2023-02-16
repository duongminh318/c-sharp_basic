using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nhap vao 1 so kiem tra chan le
            int a;
            Console.WriteLine("InPut a: ");
            a = int.Parse(Console.ReadLine());

            int div = a % 2;

            //swithc case

            switch(div)
                {
                case 0:
                    Console.WriteLine("{0} la so chan", a);
                    goto case 1;
                case 1:
                    Console.WriteLine("{0} la so le", a);
                    break;
            }
            Console.ReadKey();

        }
    }
}
