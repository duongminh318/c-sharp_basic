using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * nhap vao mot thang cho biet thang do thuoc quy may
             * goi y
             *      - quy 1: thang 1->3
             *      -2: 4->....
             */

            int month;

            Console.Write("Input Month: ");
            month = int.Parse(Console.ReadLine());

            if(month>0 && month < 4)
            {
                Console.WriteLine("month {0} in fund one ", month);
            }
            else if (month > 3 && month < 7)
            {
                Console.WriteLine("month {0} in fund TWO ", month);
            }
            else if (month > 6 && month < 10)
            {
                Console.WriteLine("month {0} in fund THREE ", month);
            }
            else if (month > 9 && month < 13)
            {
                Console.WriteLine("month {0} in fund FOUR ", month);
            }
            else
            {

                Console.WriteLine("Invalid month entered !!");
            }

            Console.ReadKey();
        }
    }
}
