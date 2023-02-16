using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_OOP_1
{
    public class SinhVien
    {
        #region bien lop
        // khai bao bien lop
        private int maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion

        #region constructor
        // khai bao constructor
        // dang 1: gan gia tri mac dinh cho doi tuong

        public SinhVien()
        {
            this.maSV = 0;
            this.tenSV = "No Name";
            this.diemThiDH = 0;
        }
        
      
        // khai bao constructor
        // dang 2: khoi tao gia tri cho doi tuong do nguoi dung truyen vao

        public SinhVien( int maSV, string teSV, float diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV= teSV;
            this.diemThiDH= diemThiDH ;
        }
        #endregion

        #region Properties
        //khai bao Properties giúp ta có thể truy xuất xem, sửa đổi dữ liệu
        public string TenSV
        {
            get { return tenSV; } // get gia tri de doc
            set { tenSV = value; } // set gia tri
        }

        public int MaSV
        {
            get { return maSV; }
            set { maSV = value; }   
        }

        public float DiemThiDH
        {
            get { return diemThiDH; }
            set { diemThiDH = value; }
        }

        #endregion

        #region  Cac phuong thuc 
        // phuong thuc Tostring
        public override string ToString()
        {
            return this.MaSV +"\t" +this.TenSV+ "\t"+this.diemThiDH;
        }

        //support method
        // kiem tra dieu kien nhap sinh vien moi
        private bool CheckDiemThiDH()
        {

            return (this.diemThiDH - 21 >= 0);
        }

        // service method (xuat thong tin)

        public void XuatThongTin()
        {
            if(CheckDiemThiDH()==false)
                Console.WriteLine("Diem thi dh<21, can kiem tra lai HS sv nay");
            else
                Console.WriteLine(ToString());
        }
        //over_loading
        //tong 

        public int Tong(int x, int y)
        {

            return x + y;

        }  
        
        public int Tong(int x, int y, int z)
        {

            return x + y+z;

        } 
        
        public double Tong(double x, double y, double z)
        {

            return x + y+z;

        }


        //Parametter list method
        // tinh tong diem tb ket thuc hoc ky

        public float TBKetThucHocKy(params float[] mang)
        {
            float s = 0;
            foreach (float f in mang)
            {
                s += f;
            }
            return s / mang.Count();
        }


       

        #endregion
    }
}
