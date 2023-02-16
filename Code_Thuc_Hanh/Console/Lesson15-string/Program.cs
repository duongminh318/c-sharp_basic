using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 khai bao chuoi
            string chuoi = "Minh Duong Lap Trinh";
            Console.WriteLine("Chuoi ban vua nhap la : "+chuoi);

            //2 khai bao nguyen van
            string chuoi2 = "D:\\minhlailaptrinh";
            string chuoi3="co nguoi noi rang: \" abc \" ";
            string chuoi4 = "co nguoi noi rang:\t \" abc \" ";
            Console.WriteLine(chuoi2);
            Console.WriteLine(chuoi3);
            Console.WriteLine(chuoi4);

            //3 chuyen doi sang chuoi
            int i = 318;
            //cach 1
            //string chuoi5 = i.ToString();
            Console.WriteLine(i);
            Console.WriteLine(i.GetType().ToString());
          //  Console.WriteLine(chuoi5);
            //Console.WriteLine(chuoi5.GetType().ToString());

            // cach 2
             string chuoi6=i+"";
            Console.WriteLine(chuoi6);
            Console.WriteLine(chuoi6.GetType().ToString());

            // cach3
            string chuoi7 = Convert.ToString(i);
            Console.WriteLine(chuoi7);
            Console.WriteLine(chuoi7.GetType().ToString());


            //4. tach chuoi ra thanh cac ky tu le, co vao mang
            string chuoi8 = "Xinchao";
            char[] lst = chuoi8.ToCharArray();

            Console.WriteLine(lst);
            Console.WriteLine(lst.GetType().ToString());

            //6 tra ve do dai cua chuoi, bao gom ca space
            string chuoi9 = "test hahA";
            int j = chuoi9.Length;

            Console.WriteLine(j);

            Console.WriteLine("ky tu thu 2 cua chuoi la: " + chuoi9[1]);
            Console.WriteLine("ky tu cuoi cung cua chuoi la: " + chuoi9[j-1]);

            //7 so sanh chuoi trong bang ascii

            string chuoi10 = "123456o";
            string chuoi11 = "123456o";

            int sosanh = chuoi11.CompareTo(chuoi10);

            Console.WriteLine(sosanh);
            // 8 kiem tra chuoi con


            string chuoi12 = "ab";
            string chuoi13 = "ab1c chao ban";
            bool l = chuoi13.Contains(chuoi12);// kt chuoi12 co phai con cua chuoi 13 hay ko
            Console.WriteLine(l);

            // 9. ham copyto
            string chuoi14 = "123456";
            char[] lst2 = new char[6]; // tao 1 mang cac ky tu ten la lst2, do dai=6
            lst2[0] = 'a';// gan lst2 vi tri index 0 bang ky tu a
            lst2[1] = 'b';// gan lst2 vi tri index 1 bang ky tu b
            Console.WriteLine(lst2); // xuat ra ab 
            chuoi14.CopyTo(1,lst2, 2, 4);
            //1. chuoi 14 copy vao lst2
            //2. so 1: copy tu vi tri index 1 cua chuoi 14
            //3. so 4 copy 4 ky tu (tinh tu index 1 cua chuoi14)
            //4. so 2: dan de vao tu vi tri index 2 cua lst2
            Console.WriteLine(lst2);

            //10. Ham bool endswith (string value)
            string chuoi15 = "ditimtinhyeu.mp3";
            bool kt = chuoi15.EndsWith(".mp3");
            Console.WriteLine(kt);

            //11. gan chuoi theo string format
            int n = 14;
            string chuoi16 = string.Format("n={0} va can bac 2 cua n la {1} ", n, Math.Sqrt(n));
            Console.WriteLine(chuoi16);
            Console.WriteLine("n={0} va can bac 2 cua n la {1} ", n, Math.Sqrt(n));

            //12 ham Equals
            string chuoi17 = "ahaha do ngoc";
            string chuoi18 = "ahaha do khon";
            bool kt2 = chuoi17.Equals(chuoi18);
            Console.WriteLine(kt2);

            //13 chen them vao chuoi
            string chuoi19 = "Hello ";
            string chuoi20 = "Every Body";
            chuoi19 = chuoi19.Insert(1, chuoi20);
            // chen chuoi20 vao chuoi19, tu vi tri index so 6 cua chuoi19
            Console.WriteLine(chuoi19);


            



            Console.ReadKey();
        }
    }
}
