using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * giải pt bậc 2 : ax^2+bx+c=0
             * delta=b^2-(4ac)
             *      - if(delta=0) -> có nghiệm kép x=-b/2a
             *      - if (delta<0) -> vô nghiệm
             *      - >0 -> 2 nghiệm phân biệt x=(-b+_sqrt(delta))/2a
             */
            Console.OutputEncoding=Encoding.UTF8;
            float a, b, c,delta, x1, x2;

            Console.WriteLine("Giải phương trình bậc 2 ax^2+bx+c=0 ");
            Console.WriteLine("Moi Thim nhap a: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Moi Thim nhap b: ");
            b= float.Parse(Console.ReadLine());

            Console.WriteLine("Moi Thim nhap c: ");
            c = float.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);
            Console.WriteLine("DelTa: "+delta);

            if(delta==0)
            {
                x1 = -b / 2 * a;
                Console.WriteLine("phương trình có nghiệm kép x1= x2 =  " + x1);
            }    
            else if(delta<0)
            {
                Console.WriteLine("phương trình vô nghiệm");
            }    
            else if(delta>0)
            {
                x1=(float)(-b+Math.Sqrt(delta))/(2*a);
                x2 = (float)(-b - Math.Sqrt(delta)) /(2*a);
                Console.WriteLine("phương trình có hai nghiệm phân biệt");
                Console.WriteLine("x1= "+x1);
                Console.WriteLine("x2= " + x2);
            }
            else
            {
                Console.WriteLine("Phương trình nhập không đúng");
            }

            Console.ReadKey();

        }
    }
}
