using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai bao bien
            char ch1 = 'a'; // khai bao bat buoc dung nhay don
            Console.WriteLine(ch1);
            Console.WriteLine("kieu loai: "+ch1.GetType().ToString());

            //khai bao cach 2 su dung ascii
            char ch2 = (char) 4;
            Console.WriteLine(ch2);
            Console.WriteLine("kieu loai: " + ch2.GetType().ToString());

            // ep kieu char cho du lieu nhap vao

            char ch3 = char.Parse("b");
            Console.WriteLine(ch3);
            Console.WriteLine("kieu loai: " + ch3.GetType().ToString());

            // chuyen doi kieu du lieu
            char ch4 = Convert.ToChar("c");
              Console.WriteLine(ch4);
            Console.WriteLine("kieu loai: " + ch4.GetType().ToString());

            // so sanh CompareTO tren ASCII
            char ch7 = 'a'; //97
            char ch8 = (char)98; //b
            char ch9 = 'm'; //109

            Console.WriteLine(ch7.CompareTo(ch8));
            Console.WriteLine(ch9.CompareTo(ch8));
            Console.WriteLine(ch7.CompareTo(ch7));


            Console.ReadKey();
        }
    }
}
