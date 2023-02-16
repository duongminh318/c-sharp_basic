using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * sử dụng toán tử 3 ngôi xép loại học sinh 
             * >=8 gioi
             * <8-6.5 khá
             * 
             */

            float diem;
            Console.WriteLine("moi nhap diem: ");
            diem=float.Parse(Console.ReadLine());

            string xl = (diem >= 8) ? "gioi" : ((diem < 8 && diem >= 6.5) ? "kha" : ((diem<6.5 && diem>=5)?"tb":"yeu"));
            Console.WriteLine(xl);
            Console.ReadKey();
        }
    }
}
