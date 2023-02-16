using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pi= "+Math.PI);
            Console.WriteLine("Kieu du lieu cua Math.Pi la :  "+Math.PI.GetType().ToString());
            float pi= (float)Math.PI;
            Console.WriteLine("Pi sao khi ep kieu= " +pi);

            // can bac 2
            int a = 4;
            int b = 10;
            Console.WriteLine("can bac hai cua so a la :"+Math.Sqrt(a));
            Console.WriteLine("Kieu du lieu cua Math.sqrt la :  " + Math.Sqrt(a).GetType().ToString());

            // luy thua
            Console.WriteLine("2 luy thua 3 la : " + Math.Pow(2,3));
            Console.WriteLine("Kieu du lieu cua  Math.Pow(2,3) la :  " + Math.Pow(2, 3).GetType().ToString());

            //max- min
            Console.WriteLine("Max 2 va 3 la : " + Math.Max(2, 3));
            Console.WriteLine("Min {0} va {1} la : {2} ",a,b, Math.Min(a, b));

            //lam tron
            float c = 1.23456789f;
            Console.WriteLine("so c sau khi lam tron 2 chu so la: "+ Math.Round(c,2));

            //sin
            //nhan so do voi *(PI/180) de chuyen doi sang radian
            Console.WriteLine("sin cua 30 do= "+Math.Sin(30*Math.PI/180));





            Console.ReadKey();
        }
    }
}
