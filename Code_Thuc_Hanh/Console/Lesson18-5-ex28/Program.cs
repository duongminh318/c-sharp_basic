using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_5_ex28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Csharp 28 :
            // Viết chương trình in số lớn thứ 2 và số nhỏ thứ 2 trong list
            //#2: in ra vị trí index số đó
            // ví dụ list
            //lst = { 1, 2, 3, 4, 5 }
            //# số lớn thứ 2: 4 , vị trí index trong list là 3
            //# số nhỏ thứ 2 trong list là 2, vị trí index trong list là 1
          
            List<int> ds = new List<int> ();
            Console.WriteLine("moi nhap so luong phan tu cua ds ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("moi nhap so thu {0} ",i);
                ds.Add (int.Parse(Console.ReadLine()));
            }

            List<int> ds2 = new List<int>();
            ds2.AddRange(ds);
            Console.WriteLine("danh sach ban dau la: ");
            foreach (int i in ds)
            {
                Console.Write(i + " ");
            }
            // xuat ds2
            Console.WriteLine();
            Console.WriteLine("danh sach 2 sau khi copy la: ");
            ds2.Remove(ds2.Max());
            ds2.Remove(ds2.Min());
            foreach (int i in ds2)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("so lon thu 2 cua ds la "+ds2.Max());
            Console.WriteLine("so nho thu 2 cua ds la " + ds2.Min());
            
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i]==ds2.Max())
                    Console.WriteLine("so lon thu 2 o index: "+i);
            }
             Console.WriteLine();

            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i] == ds2.Min())
                    Console.WriteLine("so nho thu 2 o index: " + i);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
