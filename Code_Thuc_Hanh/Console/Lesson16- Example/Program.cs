using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16__Example
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          *  1. Viết chương trình tạo 1 mảng 1 chiều gồm các phần tử là số nguyên, có
                n phần tử ngẫu nhiên, n do người dùng nhập từ bàn phím
                2. Xuất các giá trị trong mảng
                3. Đảo ngược mảng, và xuất mảng sau khi đảo ngược
                4. Sắp xếp mảng tăng dần
                5. Tính tổng các phần tử trong mảng
                6. Cho người dùng nhập 1 số bất kỳ, kiểm tra số đó có tồn tại trong mảng
                hay không, nếu có xuất ra vị trí index của số đó trong mảng
          */
            Console.WriteLine("moi nhap vao so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            // khai bao mang
            int[] Mang = new int[n];
            for (int i = 0; i < n; i++)
            { 
                Console.Write(Mang[i]+"\t"); 
            
            }
            Console.WriteLine();
            //1. nhap gia tri ngau nhien
            Random r = new Random();
            // xuat mang
            Console.WriteLine(" mang ngau nhien la : ");
            for (int i = 0; i < n; i++)
            {
                Mang[i]=r.Next(101);
                Console.Write(Mang[i]+ "\t");
            }
            Console.WriteLine();
            //3. dao nguoc mang
            Array.Reverse(Mang);
            Console.WriteLine(" mang dao nguoc la : ");
            for (int i = 0; i < n; i++)
            {
             
                Console.Write(Mang[i] + "\t");
            }
            Console.WriteLine();
            //4. sx tang dan
            Array.Sort(Mang);
            Console.WriteLine(" mang sx tang dan la : ");
            for (int i = 0; i < n; i++)
            {

                Console.Write(Mang[i] + "\t");
            }
            Console.WriteLine();

            //5. tinh tong mang
            int tong = 0;
            Console.Write(" Tong mang la : ");
            for (int i = 0; i < n; i++)
            {
                tong += Mang[i];
               
            }
            Console.Write(tong+ "\t");
            Console.WriteLine();

            // kt gia tri xem co trong mang ko va xuat index cua gt can tim
            Console.WriteLine("moi nhap gt can tim");
            int x = int.Parse(Console.ReadLine());
            int kt = 0;
            int[] id;
            for (int i = 0; i < n; i++)
            {
                if (x - Mang[i] == 0)
                {
                    Console.WriteLine(i);
                  
                    kt++;
                  
                }
                

            }
            if(kt==0)
            {
                Console.WriteLine("ko co so do trong mang");
            }
          
            
               
          

          
            Console.WriteLine();




            Console.ReadKey();

        }
    }
}
