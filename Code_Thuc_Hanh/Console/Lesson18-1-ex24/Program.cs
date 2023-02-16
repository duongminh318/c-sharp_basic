using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_1_ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("moi nhap vaao so phan tu : ");
            int n = int.Parse(Console.ReadLine());
            Random r= new Random();
            List<int> ds = new List<int>();
            for(int i=0; i<n; i++)
            {
                ds.Add(r.Next(1,101)); // them so phan tu tuong ung voi i
                // add n lan vao ds
            }
            Console.WriteLine("danh sach ngau nhien vua tao ra la: ");
            foreach(int i in ds)
            {
                Console.Write(i+ " ");
            }
            Console.ReadKey();
        }

    }
}
