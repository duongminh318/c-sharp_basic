using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_oop3
{
    public class NhanVien
    {
        // khoi tao
        public int MaNv { get; set; }
        public string TenNv { get; set; }

       // public override string ToString()
      //  {
           // return 0;
       // }

        //phuong thuc itnh luong nv
        public double TinhLuong()
        {

            return 1000; //luong co ban
        }
    }
}
