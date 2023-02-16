using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_oop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nhanvien1 = new NhanVien();
            nhanvien1.TenNv = "Nhan Vien 1";
            nhanvien1.MaNv = 1;
            Console.WriteLine(nhanvien1.TenNv+ " luong:"+nhanvien1.TinhLuong());

            NhanVienHanhChinh hc1=new NhanVienHanhChinh();
            hc1.TenNv = "Hanh la chinh";
            hc1.MaNv = 2;
            
            Console.WriteLine(hc1.TenNv);

            NhanVienDiCa ca1 = new NhanVienDiCa();
            ca1.TenNv = " Nguyen Van ca";
            ca1.MaNv = 3;
            ca1.Ca = "toi";
            ca1.TinhLuong();
            Console.WriteLine("ten nhan vien: "+ca1.TenNv+" - dang lam  ca: "+ca1.Ca+ "luong nv1 "+ ca1.TinhLuong() );

            Console.ReadLine();
        }
    }
}
