using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_ham
{
    internal class Program
    {
        /// <summary>
        /// chu thih ham ham nay de tinh tong nhe thim oi
        /// </summary>
        /// <param name="x"> nhap x nguyen nhe thim oi</param>
        /// <param name="y">nhap y nguyen nhe thim oi</param>
        /// <param name="z">nhap z nguyen nhe thim oi</param>
        /// <returns>return ve tong 3 so nhe ku oi</returns>
        static int Tong(int x, int y, int z)
        {

            return x + y + z;
        }

        // giai thua
        static int GiaiThua( int n)
        {
            int gt = 1;
            for (int i=1; i<=n;i++)
            {
                gt=gt*i;
            }
            return gt;
        }

        // ham khong return
        static void XinChao(string m)
        {
            if(m== "nam")
            {
                Console.WriteLine("Xin Chao Minh la boy");
            }
            if(m== "nu")
            {
                Console.WriteLine("Xin Chao Minh la girl");
            }
        }

        //  Truyền tham trị : không thay đổi giá trị biến sau khi gọi hàm
        static void Thamtri(int a)
        {
            a = a + 1;
            Console.WriteLine("gia tri a trong ham tham tri la : "+a);
        }

        // ref: Truyền tham chiếu (truyền tham biến) - :Có thay giá trị của biến sau khi gọi hàm
        static void ThamchieuRef (ref int b)
        {
            b++;
            Console.WriteLine("b trong ham la: "+b);

        }

        //out: tuong tu ref nhung phai gan gia tri trong ham
        static void ThamchieuOut (out int c)
        {
            c = 5;
            Console.WriteLine("gia tri cua c trong ham la: "+c);
        }

        static void Main(string[] args)
        {
            int kq = Tong(2, 3, 4);
            Console.WriteLine("kq= "+kq);

         //   Console.WriteLine("moi nhap so can tinh giai thua");
        //    int n = int.Parse(Console.ReadLine());
            int gt = GiaiThua(3);
            Console.WriteLine("Giai Thua cua  la {0}", gt);

           // Console.WriteLine("moi nhap gioi tinh ");
             //   string ten = (Console.ReadLine());
           XinChao("nam");

            int kq3=Tong(1, 3, 4);

            int a = 2;
            Console.WriteLine("a truoc khi goi ham tham tri la: " + a);
            Thamtri(a);
            Console.WriteLine("a sau khi goi ham tham tri la: "+a);

            //Truyền tham chiếu (truyền tham biến) - ref :
            // ref phải khởi tạo giá trị cho biến trước khi gọi hàm
            //int b; // sẽ báo lỗi

            int b=3 ;
            Console.WriteLine("b truoc khi goi ham : "+b);

            ThamchieuRef(ref b);
            Console.WriteLine("b sau khi goi ham: "+b);


            //Truyền tham chiếu (truyền tham biến) - out :
            // out phải gán giá trị cho biến trước khi thoát khỏi hàm
            int c=4;
            ThamchieuOut(out c);
            Console.WriteLine("c sau khi goi ham la:"+c);
           
           
            Console.ReadKey();
        }

    }
}
