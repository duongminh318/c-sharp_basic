using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string hoTen;
            float diemToan;
            float diemVan;

            Console.Write("Input Your Name : "); 
            hoTen=Console.ReadLine();

            Console.Write("Input Math Scores: ");
            diemToan= float.Parse(Console.ReadLine());

            Console.Write("Input Literary Scores: ");
            diemVan = float.Parse(Console.ReadLine());

            Console.WriteLine(" Your Name is : "+hoTen);
            Console.WriteLine(" Your Math Scores is : " +diemToan);
            Console.WriteLine(" Your Literay Scores is : " +diemVan);

            Console.ReadKey();
        }
    }
}
