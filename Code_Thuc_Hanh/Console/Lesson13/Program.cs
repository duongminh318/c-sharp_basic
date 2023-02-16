using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rd = new Random(); // cu phap de tao ra 1 doi tuong co the sinh ra 1 so ngau nhien
            // random so ngau nhien
            int soNgauNhien= rd.Next(1,1000); // ngau nhien trong khoang 50- 100
                                                // co the bo trong begin nhu rand.Next(101);
            Console.WriteLine("so ngau nhien may sinh ra la: "+soNgauNhien);

            // muon lay so ngau nhien nam trong (0,1)
            double k2 = rd.NextDouble();
            Console.WriteLine("so ngau nhien 2 may sinh ra la: " + k2);

            //1.2525525
            double k3 = soNgauNhien + k2;
            Console.WriteLine("gia tri ngau nhien mng muon la: "+k3);
            

            //cach 2: 
            double k4 = k2 * 10;
            Console.WriteLine("gia tri ngau nhien mng muon cach 2 la: " + k4);

            Console.ReadKey();

        }
    }
}
