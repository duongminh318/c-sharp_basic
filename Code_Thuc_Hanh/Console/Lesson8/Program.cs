using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nhập vào 1 số n, kt xem n là chẵn hay lẻ
            Console.OutputEncoding=Encoding.UTF8;
            int n;
            Console.WriteLine("Input n: ");
            n = int.Parse(Console.ReadLine());

            string traloi = (n % 2 == 0) ? "chẵn" : "lẻ";
            Console.WriteLine("sô {0} là số {1}",n,traloi);
            Console.ReadKey();
        }
    }
}
