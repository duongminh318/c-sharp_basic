using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red; // change mau ky tu
            Console.WriteLine("Chuong Trinh Tim Kiem");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine("1. Tim kiem theo ten");
            Console.WriteLine("2. Tim kiem theo tac gia ");
            Console.WriteLine("3. Tim kiem theo NxB ");
            Console.WriteLine("4. Tim kiem theo Tieu De ");

            Console.ReadKey();
           
        }
    }
}
