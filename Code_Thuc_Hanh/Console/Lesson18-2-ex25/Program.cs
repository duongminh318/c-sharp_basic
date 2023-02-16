using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_2_ex25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào 1 danh sách list sau đó:
            //#1. tạo ra 1 list mới bình phương các phần từ
            //#2.Xác định bao nhiêu phần tử lớn hơn 50

            Console.WriteLine("moi nhap vao so phan tu cua danh sach: ");
            int n=int.Parse(Console.ReadLine()); // nhap so phan tu
            List<int> list = new List<int>();   // tao list moi
            //nhap
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("moi nhap vao phan tu thu {0} cua danh sach : ",i+1); ;
                list.Add(int.Parse(Console.ReadLine())); //add gia tri phan tu vao ds[i]
            }
            // 0. xuat
            Console.WriteLine("list ban vua nhap la");
            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            //#1. tạo ra 1 list mới bình phương các phần từ
            List<double> List2 = new List<double>();

            foreach (int i in list)
            {
                List2.Add(Math.Pow(i, 2));
                
            }
            Console.WriteLine("list 2 ban vua nhap la");
            foreach (int i in List2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //#2.Xác định bao nhiêu phần tử lớn hơn 50
            int dem = 0;
            foreach (int i in List2)
            {
                if (i > 50)
                    dem++;
            }
            Console.WriteLine("co {0} phan tu lon hon 50 tron ds 2 ",dem);
            Console.ReadLine();


        }
    }
}
