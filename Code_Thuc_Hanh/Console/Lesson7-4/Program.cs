using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * kiem tra nam nhuan
             * nam nhuan((nam%4==0)&&(nam%100!=0)|| (nam%400==0) )
             * 
             * case test
             * nam nhuan: 2004, 2008, 2012, 2016, 2020, 2024
             * khong nhuan: 1900, 2005
             */

            int year;
            Console.WriteLine("vui long nhap nam ban muon kiem tra: ");
            year=int.Parse(Console.ReadLine());

            if(((year%4==0)&&(year%100!=0))||(year%400==0))
            {
                Console.WriteLine("nam {0} la nam nhuan", year);


            }
            else
            {
                Console.WriteLine("nam {0} la nam khong nhuan", year);
            }

            Console.ReadKey();


        }
    }
}
