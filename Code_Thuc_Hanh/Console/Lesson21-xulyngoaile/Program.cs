using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21_xulyngoaile
{
    internal class Program
    {
        static void Ngoaile1()
        {
            try
            {
                Console.WriteLine("moi thim nhap vao ngay thang nam sinh (thang/ngay/nam) ");
                string s = Console.ReadLine();
                DateTime birthday = DateTime.Parse(s);
                Console.WriteLine("ngay sinh cua ban la " + birthday.ToString("dd/MM/yyyy"));

            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("cam on ban da su dung phan mem");
            }
           
        }

        static void Ngoaile2()
        {
            Console.WriteLine("moi nahp vao tu so: ");
            int tu = int.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap vao mau so: ");
            int mau = int.Parse(Console.ReadLine());

            if (mau == 0)
                throw new ArithmeticException("loi mau bang 0 roi thim oi");

           // Console.WriteLine("tu so la: "+tu);
        }

        static void Main(string[] args)
        {
            //  Ngoaile1();
            try
            {
                Ngoaile2();

            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
