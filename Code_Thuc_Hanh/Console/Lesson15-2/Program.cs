using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14 indexof vi tri xuat hien dau tien
            string chuoi20 = "u1aau";
            int kq4 = chuoi20.IndexOf('a');
            Console.WriteLine("vi tri xuat hien dau tien cua a la " +kq4);
            Console.WriteLine(chuoi20[3]);
            Console.WriteLine(chuoi20.Length);

            //15 lastIndexof vi tri xuat hien cuoi cung
            string chuoi21= "u1aau";
            int kq5 = chuoi21.LastIndexOf('u');
            Console.WriteLine("vi tri xuat hien cuoi cung cua u la "+kq5);

            //16. remove (index, count)
            string chuoi22 = "123456";
            Console.WriteLine(chuoi22);
            chuoi22 = chuoi22.Remove(0, 2);
            // xoa tu vi tri index =0, xoa 2 ky tu (xoa so 2 va 3)
            Console.WriteLine(chuoi22);

            //17. replace ("str old", "str new" )
            // thay the toan bo chuoi old bang chuoi new
            string chuoi23 = "Duong Khoi Minh Xau Trai";
            string chuoi24 = chuoi23.Replace("Xau Trai", "Dep Trai");
            // thay the chuoi Xau Trai bang Dep Trai
            Console.WriteLine(chuoi24);
            // tre ve Duong Khoi Minh Dep Trai

            //18. bool StartsWith, kt xem chuoi co bat dau bang chuoi con hay ko
            string chuoi25 = "ahihi do ngoc";
            bool kt6;
            kt6 = chuoi25.StartsWith("ahiho");
            Console.WriteLine(kt6);

            //19. substring trich loc chuoi con tu chuoi ban dau
            string chuoi26 = "Duong Khoi Minh Dep Trai ";
            string chuoi27 = chuoi26.Substring(10,14);
            // lay tu vi tri index 10, va lay 14 ky tu
            Console.WriteLine(chuoi27);

            // 20. Tolower(); tra ve chu thuong, ToUpper() chu hoa
            string chuoi28 = "Wasup My Friends ";
            chuoi28 = chuoi28.ToLower();
            Console.WriteLine("thanh chu thuong: "+chuoi28);

            string chuoi29 = "Wasup My Friends ";
            chuoi29 = chuoi29.ToUpper();
            Console.WriteLine("THANH CHU IN HOA: " + chuoi29);

            // 21. Trim() xoa toan bo khoang trang o dau va cuoi
            string chuoi30 = "    KUma Huy    ";
            Console.WriteLine(chuoi30.Length);
            chuoi30 = chuoi30.Trim();
            Console.WriteLine("sau khi da xoa khoang trang dau cuoi: " + chuoi30);
            Console.WriteLine(chuoi30.Length);

            //22. TrimEnd() xoa taon bo khoang trang o cuoi chuoi
            string chuoi31 = "xoa het khoang trang o cuoi           ";
            Console.WriteLine("do dai trc khi xoa khoang trang o cuoi: "+chuoi31.Length);
            chuoi31 = chuoi31.TrimEnd();
            Console.WriteLine(chuoi31);
            Console.WriteLine("do dai sau khi xoa khoang trang o cuoi: " + chuoi31.Length);


            // 23.TrimStart() xoa taon bo khoang trang o dau chuoi
            string chuoi32 = "              xoa het khoang trang o dau";
            Console.WriteLine("do dai trc khi xoa khoang trang o dau: " + chuoi32.Length);
            chuoi32 = chuoi32.TrimStart();
            Console.WriteLine(chuoi32);
            Console.WriteLine("do dai sau khi xoa khoang trang o dau: " + chuoi32.Length);

            //24 split tach chuoi tra ve magn
            string chuoi33 = "mot,hai,ba";
            string[] lst5 = chuoi33.Split(','); // tao ra mot list chua
            // ham tach chuoi33 dua vao ky tu ,
            Console.WriteLine(lst5[0]);
            Console.WriteLine(lst5[1]);
            Console.WriteLine(lst5[2]);
            

            //joint string noica phan tu cua 1 list thanh 1 chuoi
            string chuoi34=string.Join("-",lst5);
            // noi cac thanh phan cua mang lai phan cach thanh phan boi dau - cua lst5
            // trai nguoc liaj voi slpit phan tach o tren

            Console.WriteLine(chuoi34);

            Console.ReadKey();
        }
    }
}
