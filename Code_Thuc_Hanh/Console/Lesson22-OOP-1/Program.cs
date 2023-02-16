using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //1. tao 1 doi tuong moi khong truyen gia tri
           SinhVien sinhvien1= new SinhVien();
           SinhVien sinhvien2= new SinhVien();

            //xuat
          //  Console.WriteLine(sinhvien1.MaSV);
           // Console.WriteLine(sinhvien1.TenSV);

           // Console.WriteLine(sinhvien2.MaSV);
           // Console.WriteLine(sinhvien2.TenSV);

            //Console.WriteLine("ten sinh vien la : " +sinhvien1.TenSV+ "ma sinhvien1: "+sinhvien2.TenSV);

            //service method & support  method
            SinhVien sinhvien3 = new SinhVien(1,"Duong Khoi Minh", 22);

            // check diem
            //  bool check = sinhvien3.CheckDiemThiDH();

            //  Console.WriteLine(check);
           // sinhvien3.XuatThongTin();

            
           // Console.WriteLine(sinhvien3.Tong(1,2,2.3));
            Console.WriteLine();

            //Parametter list method

            //Console.WriteLine(sinhvien2.TBKetThucHocKy(3, 4, 5, 6, 3, 10));
            Console.WriteLine();

            //15. Auto-Implemented Properties
            HocSinh hocsinh1 = new HocSinh();
            hocsinh1.Name = "Nguyen Van 1";
            hocsinh1.Phone = "911";
            hocsinh1.Email = "duongminh318@gmail.com";

            Console.WriteLine(hocsinh1);

            Console.ReadKey();
        }
    }
}
