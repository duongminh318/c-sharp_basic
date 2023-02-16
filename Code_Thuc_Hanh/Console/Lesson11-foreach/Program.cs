using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thang;     
            int[] lst = { 1, 3, 5, 7, 9 }; // khoi tao list

            Console.WriteLine("moi nhap thang");
            thang = int.Parse(Console.ReadLine());
            foreach(int i in lst)
            {

                Console.WriteLine("i: "+i);
                if(thang==i)
                {
                    Console.WriteLine("thang {0} co 31 ngay",thang);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
