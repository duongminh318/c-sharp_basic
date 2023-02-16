using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Bai tap 07: nhap thang bat ky cho biet thang do co bao nhieu ngay
             * Goi y
             * thang 1,3,5,7, 8, 10, 12 co 31 ngay
             * thang 4,6, 9,11 co 30 ngay
             * neu thang 2 thi yeu cao nhap them nam:
             *  + neu nam nhuan thi thang 2 co 29 ngay
                + neu nam khong nhuan thi thang 2 co 28 ngay
             */

            int month;

            Console.WriteLine("vui long nhap thang: ");
            month=int.Parse(Console.ReadLine());

            if(month==1 || month==3 || month==5 ||
              month == 7 || month == 9 || month == 10 || month == 12)
                 {
                     Console.WriteLine(" thang {0} co 31 ngay", month);
                 }

            else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    Console.WriteLine(" thang {0} co 30 ngay", month);
                }

            else if (month == 2)
            {
                int year;
                Console.WriteLine("vui long nhap nam: ");
                year = int.Parse(Console.ReadLine());
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    Console.WriteLine("nam {0} la nam nhuan", year);
                    Console.WriteLine("va thang {0} co 29 ngay", month);


                }
                else
                {
                    Console.WriteLine("nam {0} la nam khong nhuan", year);
                    Console.WriteLine("va thang {0} co 28 ngay", month);
                }
            }
            else
            {
                Console.WriteLine("thang nhap ko hop le");
            }
            Console.ReadLine();

        }
    }
}
