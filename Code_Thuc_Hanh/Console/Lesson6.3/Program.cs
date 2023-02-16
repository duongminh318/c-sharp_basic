using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, p, s;
            Console.Write("Input Number a (length of rectangle) : ");
            a=float.Parse(Console.ReadLine());
         

            Console.Write("Input Number b (width of rectangle) : ");
            b = float.Parse(Console.ReadLine());

            //kiem tra xem nhap dung khong
            if(a==0 ||b==0)
            {
                Console.WriteLine("invalid rectangle !!");

            }
            else
            {

                //tinh chu vi
                p = (a + b)*2;
                Console.WriteLine("perimeter of the rectangle ({0}+{1})X2: {2} ", a, b, p);

                // tinh dien tich
                s = a * b;
                Console.WriteLine("area of the rectangle {0}x{1}: {2} ", a, b, s);
            }

            Console.ReadKey();

        }
    }
}
