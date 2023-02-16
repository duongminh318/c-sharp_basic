using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Viet chuong trinh nhpa so a, tu ban phim,
             * neu a chan thi tinh tong cac so chan tu 0 den a
             * neu a le thi in ra dong chu toi khong tinh so le bybye va thoat chuowng trinhf
             */
            int a, tongChan=0;
            Console.WriteLine("moi thim nhap vao a: ");
            a=int.Parse(Console.ReadLine());
            
            if(a%2==0)
            {
                for(int i=0;i<=a;i++)
                {
                    if(i%2==0)
                    {
                        tongChan += i;
                    }
                }
                Console.WriteLine("tong chan tu 0 den {0} = {1}",a, tongChan);
            }
            else
            {
                Console.WriteLine("toi ko tinh so le byebye");
            }
          
            Console.ReadKey();

        }
    }
}
