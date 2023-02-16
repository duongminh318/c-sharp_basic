using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_4_ex27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào 1 list
            //  #1 in ra có bao nhiêu số nhỏ hơn 5,
            //  #2 và in ra vị trí index các số đó
            Console.WriteLine("moi nhap vao so phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> List = new List<int>();
            for(int i=0; i < n; i++)
            {
                Console.Write("nhap vao phan tu tu {0} cua List: ", i+1);
                List.Add(int.Parse(Console.ReadLine()));
            }
            // xuat ds
            Console.WriteLine("DS ban vua nhap la: ");
            foreach(int i in List)
            {
                Console.Write(i+ " ");
            }

            //  #1 in ra có bao nhiêu số nhỏ hơn 5,
            Console.WriteLine();
            int dem = 0;
            foreach (int i in List)
            {
                if (i < 5)
                    dem++;
            }
            Console.WriteLine("so phan tu nho hon 5 la: "+dem);
            //  #2 và in ra vị trí index các số đó
            Console.WriteLine("phan tu nho hon 5 xuat hien o vi tri index: ");
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i]<5)
                    Console.Write(i+1+" ");
            }

            Console.ReadKey();  
        }
    }
}
