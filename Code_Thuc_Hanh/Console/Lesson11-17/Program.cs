using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * tim tat ca nhung so hoan hảo trong phạm vi tư 1- 10000
             * 6=1+2+3
             * 
             * nhap vao 1 so, kt xem so do co phai la so hoan hao hay ko
             */
            Console.OutputEncoding = Encoding.UTF8;
            /*  int n;
              int tong =0;
              Console.WriteLine("moi thim nhap vao n: ");
              n = int.Parse(Console.ReadLine());
              for (int i=1; i<n; i++)
              {
                  Console.WriteLine("i= "+i);
                  if(n%i==0)
                  {

                      tong += i;
                      Console.WriteLine("tong= "+tong);

                  }
              }
              if(tong==n)
                  Console.WriteLine("số {0} là sô hoàn hảo",n);
              else
                  Console.WriteLine("số {0} ko là sô hoàn hảo", n);

              Console.WriteLine(tong);*/
            Console.Write("cac so hoan hao tu 1->1000:  ");
            for(int n =1;n<=1000; n++)
            {
                int tong = 0;
                for(int i = 1;i<n;i++)
                {
                    if(n%i==0)
                        tong += i;
 
                }
                if (tong == n)
                {
                    Console.Write(n + "; ");
                }
            }


            Console.ReadKey();


        }
    }
}
