using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. khai bao mang
            int[] stt;
            char[] ch;
            string[] chuoi;

            //2. khoi toa mang
            // tenMang= new Kieudulieu[soPhanTu]
            stt = new int[5]; //mac dinh cac phan tu la 0

            foreach(int i in stt)
              {
                    Console.Write(i+ " ");
               }
            Console.WriteLine();
            Console.WriteLine("mang stt2 la: ");
            int[] stt2 = new int[7];
                 foreach (int i in stt2)
            {
                Console.Write(i + " ");
            }

            //3. khoi va gan luon gia tri cho mang
            // kieudulieu[] tenmang=new Kieudulieu[sophantu]{pt1,pt2,pt3...}
            int[] mang2 = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine();
            Console.WriteLine("mang2 la: ");
            foreach (int i in mang2)
            {
                Console.Write(i + " ");
            }

            //4. khoi tao mang ngau nhine
            Random r = new Random();
          //  int[] mang3 = new int[2] { r.Next(51), r.Next(51,61) };
            int[] mang3 = { r.Next(51), r.Next(51, 61) };
            Console.WriteLine();
            Console.WriteLine("mang3 la: ");
            foreach (int i in mang3)
            {
                Console.Write(i + " ");
            }

            //7. kt do dai mang
            Console.WriteLine();
            int dai = mang3.Length;
            Console.WriteLine("chieu dai mang 3 la: "+dai);

            //8. truy xuat phan tu qua index
            int[] mang4 = { 1, 2, 3, 4 };
            Console.WriteLine(mang4[0]);
            Console.WriteLine(mang4[1]);
            Console.WriteLine(mang4[2]);
            Console.WriteLine(mang4[mang4.Length-1]);

            //9. thay doi gia tri phan tu cua mang bang cach goi index
            int[] mang5 = new int[3] { 1, 3, 5 };
            Console.WriteLine("gia tri trc khi doi = " + mang5[1]);
        
            Console.Write("mang5 la: ");
            foreach (int i in mang5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            mang5[1] = 9;
            Console.WriteLine("gia tri sau khi doi = " + mang5[1]);

            //10. duyet mang for (duyet theo index)
            int[] mang6 = { 1, 2, 4, 5, 18, 35 };
            Console.Write(" mang 6 la: ");
            for (int i=0;i<mang6.Length;i++)
            {
                Console.Write(+mang6[i]+ "\t");
            }
            Console.WriteLine();
            //. duyet mang dung foreach
            int[] mang7 = { 3, 4, 4, 5, 18, 3 };
            Console.Write("mang7 la : ");
            foreach(int m in mang7)
             {
                Console.Write(m+ "\t");
            }
            Console.WriteLine();
            // phep gan mang
            string[] mang8 = {"duong", "khoi", "minh" };
            string[] mang9 = mang8;
            // do mảng là kiểu tham chiếu, nó sẽ tham chiếu đến 1 vùng nhớ
            Console.WriteLine("gia tri truowc khi doi  "+mang8[0]);
            Console.WriteLine("gia tri truowc khi doi  " +mang9[0]);
            mang9[0] = "Bruce";
            Console.WriteLine("gia tri sau khi doi  " + mang8[0]);
            Console.WriteLine("gia tri sau khi doi  " + mang9[0]);

            //10. copyto (copye de gia tri vao mang da co)
            int[] mang10 = { 1, 3, 5, 7, 9 };
            int[] mang11 = { 11, 13, 15, 17, 19,5,6 };
            mang10.CopyTo(mang11,2);
            // copy mang10 dem sang dan  tu index1 cua mang11
            //copy mảng nguồn vào mảng đích đến 11, copy đè lên index 2 của mảng
            //đích
            Console.WriteLine("mang 11 sau khi copy la ");
            foreach (int i in mang11)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //14. cop (Array_nguồn, Array_đích, Int32) (copy ra mảng mới trên vùng
            // nhớ mới)

            int[] mang12 = { 1, 3, 5, 7, 9,10};
            int[] mang13= new int[5];
            Array.Copy(mang12, mang13, 4); // copy 4 phan tu tu mang 12 sang mang 13
            Console.WriteLine("mang13 sau khi copy la : ");
            foreach (int i in mang13)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 15 clone (tạo ra mảng mới trên vùng nhớ mới)
            int[] mang14 = {1,3,4,5,6,7,8,11,22 };
            int[] mang15=(int[])mang14.Clone();
            mang14[0] = 111;
           // mang15[0] = 112;
            Console.WriteLine(mang14[0]);
            Console.WriteLine(mang15[0]);

            //16 . Array.Reverse() : Đảo ngược mảng
            int[] mang16 = { 1, 3, 4, 5, 6, 7, 8, 11, 22 };
            Array.Reverse(mang16);
            Console.WriteLine("mang16 sau khi dao nguoc la : ");
            foreach (int i in mang16)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //17.  Array.Sort() (Sắp xếp mảng tăng dần )
            int[] mang17 = { 10, 31, 14, 5, 6, 7, 8, 11, 22 };
            Array.Sort(mang17);
            Console.WriteLine("mang16 sau khi sx tang dan la : ");
            foreach (int i in mang17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

           



            Console.ReadKey();


        }
    }
}
