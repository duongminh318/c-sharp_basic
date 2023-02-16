using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SoLuong = 0; //khoi tao bien
            float DiemTB = 8.5f;
            string name = "Minh";
            byte tuoi;  // khai bao bien
            tuoi = 13;
            Console.WriteLine("so luong la : {0}, ten la  {1}, Diem la {2}", SoLuong, name, DiemTB);
            Console.Write("tuoi la {0}", tuoi);
            Console.ReadKey();
        }
    }
}
