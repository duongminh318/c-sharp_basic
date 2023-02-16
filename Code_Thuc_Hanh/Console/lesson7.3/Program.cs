using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                * tính BMI dựa vào chiều cao cân nặng nhập vao
                * BMI<15
                * BMI>=15 and BMI<16 : Thân hình gầy
                * BMI>=16 and BMI<18.5; thân hình hơi gầy
                * BMI>=18.5 and BMI<25; thân hình bình thường
                * BMI>=25 and BMI<30;   thân hình hơi béo
                * BMI>=30 and BMI<35;   thân hình béo
                * BMI>35 and BMI<16;    thân hình quá béo
                * 
                * gợi ý cách tính BMI= cannang/(chieucao^2)
                * ham mũ
                * int x=2;
                * Math.Pow(x,2); x mũ 2
             */

            double canNang, chieuCao,bmi, chieuCaoBinh;
            Console.Write("Vui lòng nhập chiều cao: ");
            chieuCao = double.Parse(Console.ReadLine());

            Console.Write("Vui lòng nhập cân nặng: ");
            canNang=double.Parse(Console.ReadLine());
            chieuCaoBinh = (double)Math.Pow(chieuCao, 2);


            bmi =(canNang/chieuCaoBinh);
            //Console.WriteLine("BMI cua ban la "+bmi);
            Console.WriteLine("BMI cua ban la {0} " ,Math.Round(bmi,2));


            if (chieuCao==0 || canNang==0)
            {
                Console.WriteLine("du lieu khong hop le vui long nhap lai: ");
            }
            else
            {
                if (bmi < 15)
                {
                    Console.WriteLine("Than hinh gay ");

                }
                else if (bmi >= 15 && bmi < 18.5)
                {

                    Console.WriteLine("Than hinh hoi gay ");
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    Console.WriteLine("Than hinh binh thuong ");

                }

                else if (bmi >= 25 && bmi < 30)
                {
                    Console.WriteLine("Than hinh hoi beo ");

                }
                else if (bmi >= 30 && bmi < 35)
                {
                    Console.WriteLine("Than hinh beo ");

                }

                else if (bmi >= 35)
                {
                    Console.WriteLine("Than hinh qua beo ");

                }
                else
                {
                    Console.WriteLine("du lieu khong phu hop");

                }


            }

            Console.ReadKey();

        }
    }
}
