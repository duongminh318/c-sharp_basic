using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. khoi tao 1 list
            List<string> ds1 = new List<string>(); // danh sach cac phan tu la string
            List<int> ds2 = new List<int>();    // danh sach cac phan tu so nguyen

            //3. tao danh sach co san mot phan tu, thi cac phan tu lien ke sau {}
            List <int> ds3= new List<int> () { 1,2,5};
            Console.Write(" Danh sach 3 La : ");
            foreach (int i in ds3)
                    {
                Console.Write(  i+ " ");
            }
            Console.WriteLine();

            //4.add(Thêm phần từ vào cuối list)
            List<int> ds4 = new List<int>() { 1, 2, 5 };
            ds4.Add(100);
            ds4.Add(200);
            ds4.Add(300);
            ds4.Add(400);
            Console.Write(" Danh sach 4 La : ");
            foreach (int i in ds4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //5. Remove (object) ( xóa phần tử đầu tiên nếu tìm thấy trong list)
            List<int> ds5 = new List<int>() { 5, 1, 2, 5, 8,7, 9, 10,13};
            ds5.Remove(5);
            Console.Write(" Danh sach 4 La : ");
            foreach (int i in ds5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //6.Count : Đếm số phần tử trong danh sách (giống Length trong mảng 1 chiều)
            List<int> ds6 = new List<int>() { 5, 1, 2, 5, 8, 7, 9, 10, 13 };
            Console.WriteLine(" so phan tu cua danh sach 6 la: "+ds6.Count());

            //7 . Clear(); Xóa toàn bộ phần tử
            List<int> ds7 = new List<int>() { 5, 1, 2, 5, 8, 7, 9, 10, 13 };         
            Console.Write(" Danh sach 7 La : ");
            foreach (int i in ds7)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            ds7.Clear();
            Console.Write(" Danh sach 7 sau khi da clear La : ");
            foreach (int i in ds7)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            Console.WriteLine(" so phan tu cua danh sach 7 la: " + ds7.Count());

            // 8. ds8.AddRange(ds9) : Thêm toàn bộ danh sách 9 vào cuối danh sách 8
            List<int> ds8 = new List<int>() { 1, 2, 3 };
            List<int> ds9 = new List<int>() { 4, 5, 6 };
            ds8.AddRange(ds9);
            Console.Write(" Danh sach 8 sau khi da them ds9 La : ");
            foreach (int i in ds8)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //9. bool <ds>.Contains(<value>)
            // *Kiểm tra có tồn tại value trong list không
            // *Có trả về true, không trả về False
            List<int> ds10 = new List<int>() { 5, 2, 3 };
            bool kq=ds10.Contains(1);
            if(kq)
            {
                Console.WriteLine("co ton tai 1");
            }
            else
            {
                Console.WriteLine("khong ton tai 1");
            }

            //10 . GetRange(int index, int ount)
            //Trả về 1 list con, lấy từ index, và count ký tự của list nguồn

            List<int> ds11 = new List<int>() { 0,1,2,3,4};
            List<int> ds12 = ds11.GetRange(1, 2);
            Console.Write(" Danh sach 12 lat tu index 1 lay ra 2 pt tu ds 11 La : ");
            foreach (int i in ds12)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //11. 11. int IndexOf(<value>)
            // Trả về vị trí index giá trị tìm thấy, Nếu o thấy trả về - 1
            List<int> ds13 = new List<int>() { 0, 1, 2, 3,5, 4 };
            int checkIndex = ds13.IndexOf(4);
            Console.WriteLine("vi tri cua 4 trong mang la : "+checkIndex);

            //12.   Insert(int index, value);
            //  Chèn thêm value vào vị trí index chỉ định
            List<int> ds14 = new List<int>() { 0, 1, 2, 3, 5, 4 };
            ds14.Insert(0, 100); // o vi tri index 0 chen vao 100
            foreach (int i in ds14)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            //13. InsertRange(index, <danh sách chèn thêm>)
            // Chèn < danh sách chèn thêm > vào vị trí index của list gốc
            List<int> ds15 = new List<int>() { 0, 1, 2, 3, 5, 4 };
            List<int> ds16 = new List<int>() { 100, 200, 3000};
            ds15.InsertRange(2, ds16); // chen ds16 vao index 2 cua ds15
            foreach (int i in ds15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //14.RemoveAt(int index);
           // Xóa phần tử tại vị trí index chỉ định , may cai sau van giu lai
           List<int> ds17= new List<int> { 0, 1, 2, 3, 5, 4 };
            ds17.RemoveAt(2);
            foreach (int i in ds17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //15.RemoveRange(int index, int count)
            //  Xóa từ index và xóa đi count phần tử , may cai sau xoa luon
            List<int> ds18 = new List<int> { 0, 1, 2, 3, 5, 4 };
            ds18.RemoveRange(1, 2); // xoa tu index1 va xoa 2 phan tu
            foreach (int i in ds18)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //16.  <ds>.Reverse(); Đảo ngược danh sách
            List<int> ds19 = new List<int> { 0, 1, 12, 3, 5, 4, 8, 9 , };
            ds19.Reverse();
            foreach (int i in ds19)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 17. < ds >.Sort(); Sắp xếp tăng dần
            List<int> ds20 = new List<int> { 0, 1, 12, 3, 5, 4, 8, 9, };
            ds20.Sort();
            foreach (int i in ds20)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //18.BinarySearch
            //Tìm kiếm nhị phân, chỉ dùng sau khi đã sắp xếp mảng
            int kq2 = ds20.BinarySearch(12);
            Console.WriteLine(kq2);

            //19. Tìm max, min
            Console.WriteLine("gia tri max la: "+ds20.Max());
            Console.WriteLine("gia tri max la: " + ds20.Min());

            Console.ReadKey();
        }
    }
}
