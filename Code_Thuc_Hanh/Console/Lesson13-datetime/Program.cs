using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DateTime birthday = new DateTime(1998, 08, 13);
            Console.WriteLine("ngay thang nam sinh cua ban la: "+birthday.ToString("dd/MM/yyyy"));
            Console.WriteLine("ngay  sinh cua ban la: " + birthday.ToString("dd"));
            Console.WriteLine(" thang  sinh cua ban la: " + birthday.ToString("MM"));
            Console.WriteLine("nam sinh cua ban la: " + birthday.ToString("yyyy"));

            DateTime birthday2 = DateTime.Parse("11/24/1998");
            Console.WriteLine("ngay thang nam sinh cua ban la: " + birthday2.ToString("dd/MM/yyyy"));

            // viet chuong trinh nhap vao ngay thang nam sin tu ban phim
            Console.Write("moi thim nhap ngay thang nam sinh (thang/ngay/nam): ");
            DateTime birthday3= DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ngay thang nam sinh cua ban la: " + birthday3.ToString("dd/MM/yyyy"));
            Console.ReadKey();
        }
    }
}
