using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_oop3
{
    public class NhanVienDiCa: NhanVien
    {
        // ke thua va bo sung thuoc tinh moi
        public string Ca { get; set; }

        //overriding tai dinh nghia la phuong thuc
        //phuong thuc tinh luong cua nhan vien di ca
        public new double TinhLuong()
        {
            return base.TinhLuong() * 1.05;
        }
    }
}
