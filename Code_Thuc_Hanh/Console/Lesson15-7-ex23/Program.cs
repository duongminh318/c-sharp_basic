using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_7_ex23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("moi cu  nhap vao mot chuoi :");
            string s=Console.ReadLine();
            string chu = "";
            string so = "";
            foreach (char c in s)
            {
                //  Console.WriteLine(c);
                if (char.IsDigit(c)) // kt phai la so ko
                    so += c;
                else if (char.IsLetter(c))  // kt phai la chu ko
                    chu +=c;
            }
            Console.WriteLine("chuoi chi gom so : "+so);
            Console.WriteLine("chuoi chi gom chu: "+chu);
            Console.ReadKey();
        }
    }
}
