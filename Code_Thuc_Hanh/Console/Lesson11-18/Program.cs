using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("moi thim nhap vao so n kt");
            n=int.Parse(Console.ReadLine());

            while(n<0)
            {
                Console.WriteLine("Nhap sai roi nhap lai n di thim, n phai lon hon ko ");
                n = int.Parse(Console.ReadLine());
            }
            int demUoc=0;
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    demUoc += 1;
                    Console.WriteLine(demUoc);
                }

            }
            if(demUoc==2)
            {
                Console.WriteLine("la so nguyen to");
            }
            else
            {
                Console.WriteLine("ko la so nguyen to");
            }
               
               
            Console.ReadLine();
        }
    }
}
