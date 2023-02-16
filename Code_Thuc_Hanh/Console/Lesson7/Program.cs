using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             nhap vao diem tb, va kq xep loai cua hoc sinh theo tieu chuan sau:
                - Gioi: neu diem dat kq>=8
                - Kha: 8 > diem > 6.5
                - TB:   6.5 >  diem > 5
                - Yeu: diem < 5
             */
            float diemTN;
            Console.Write("moi nhap vao diem toot nghiep: ");
            diemTN = float.Parse(Console.ReadLine());

            
              if(diemTN>=8 && diemTN<=10)
                {
                    Console.WriteLine("diem tot nghiep cua la {0}, ban da do ", diemTN);
                    Console.WriteLine("ban dat loai gioi");
                }
              else if(diemTN>6.5 && diemTN<8)
                {
                    Console.WriteLine("diem tot nghiep cua la {0}, ban da do ", diemTN);
                    Console.WriteLine("ban dat loai KHa");

                   }
              else if(diemTN>5 && diemTN<6.5)
                {
                    Console.WriteLine("diem tot nghiep cua la {0}, ban da do ", diemTN);
                    Console.WriteLine("ban dat loai TB");

                }

               else if ( diemTN < 5 && diemTN>=0)
                {
                Console.WriteLine("diem tot nghiep cua la {0}, ban da fail ", diemTN);
                Console.WriteLine("ban dat loai Yeu");

            }
                else
                    {

               
                     Console.WriteLine("diem nhap khong hop le");
                }


            Console.ReadKey();
        }
    }
}
