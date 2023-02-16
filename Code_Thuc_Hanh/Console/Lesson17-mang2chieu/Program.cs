using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17_mang2chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kieudulieu[,] ten= new kieudulieu [ y (sohang),x (so cot)]
            int[,] arr = new int[3, 5]; //( 3 dòng, 5 cột)

            //3 . Khởi tạo và gán giá trị cho mảng :
               //    int[,] arr2= new int[2, 3] { { 1, 2, 3 }, { 2, 4, 6 } };
            int[,] arr2 = { { 1, 2, 3 }, { 2, 4, 6 } };
          //4. nhap gia tri cho mang dung 2 vong for
          Random r = new Random();
            int dong = 3;
            int cot = 4;
            int[,] arr3 = new int[dong, cot];
            for (int i = 0; i < dong; i++)
            {
                for(int j=0; j < cot; j++)
                {
                    //Console.Write(i);
                    //Console.Write(j+"\t");
                    arr3[i, j] = r.Next(51);
                }
               // Console.WriteLine();
            }

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i,j]+"\t");
                   
                }
                Console.WriteLine();
            }


            //Console.WriteLine(arr3[0, 0]);
          //  Console.WriteLine(arr3[0, 1]);
            Console.ReadKey();
        }
    }
}
