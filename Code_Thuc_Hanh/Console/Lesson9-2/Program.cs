using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; 
            Console.ForegroundColor = ConsoleColor.Red; // change mau ky tu
            Console.WriteLine("Chuong Trinh Tim Kiem");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("1. Tim kiem theo ten");
            Console.WriteLine("2. Tim kiem theo tac gia ");
            Console.WriteLine("3. Tim kiem theo NxB ");
            Console.WriteLine("4. Tim kiem theo Tieu De ");

            Console.WriteLine("Vui Long Nhap Truong Hop Ban Muon TIm Kiem");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine(" Ban Vua Nhap {0} ", n);
                    Console.WriteLine("Tim kiem theo ten");
                    break;


                case 2:
                    Console.WriteLine(" Ban Vua Nhap {0} ", n);
                    Console.WriteLine("Tim kiem theo tac gia");
                    break;

                case 3:
                    Console.WriteLine(" Ban Vua Nhap {0} ", n);
                    Console.WriteLine("Tim kiem theo NxB");
                    break;

                case 4:
                    Console.WriteLine(" Ban Vua Nhap {0} ", n);
                    Console.WriteLine("Tim kiem theo Tieu De");
                    break;
                default:
                    
                    Console.WriteLine("khong hop le");
                    
                    break;

            }

            Console.ReadKey();
        }
    }
}
