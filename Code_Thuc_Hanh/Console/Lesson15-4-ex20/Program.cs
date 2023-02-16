using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_4_ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                             * Csharp 20 
                Viết chương trình kiểm tra tính hợp lệ của mật khẩu: aaaaaAAAAAA1
                  *  mật khẩu hợp lệ khi có ít nhất 6 ký tự chứa ít nhất 1 chữ cái ( chữ cái thường hoặc hoa đều được) 
                  *chứa ít nhất 1 chữ số => khong hop le bat nhap lai
                 2. cho người dùng nhập vào mật khẩu để login / so sánh, nếu đúng mở của, sai quá 5 lần khóa đăng nhập, thoát chương trình

             */
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("moi nhap mat khau (it nhat 6 ky tu, it nhat mot chu cai, it nhat 1 chu so)");
            string mk = Console.ReadLine(); //123456a
            bool check = true;
            int demSo = 0,demKyTu = 0;
            while(check) // while(check==true)
            {
                foreach(char c in mk)
                {
                    if (char.IsDigit(c))                 
                        demSo++;                   
                    else if (char.IsLetter(c))                   
                        demKyTu++;                     
                }
                Console.WriteLine(demSo);
                Console.WriteLine(demKyTu);
              
                if (demKyTu * demSo != 0 && mk.Length >= 6)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("nhap lai mat khau de thim/ (it nhat 6 ky tu, it nhat mot chu cai, it nhat 1 chu so");
                    mk = Console.ReadLine();
                    check = true;
                }                 
            }
            Console.WriteLine("ban da thiet lap mk thanh cong, mk cua ban la: " + mk);

            //  2. cho người dùng nhập vào mật khẩu để login /
            //  so sánh, nếu đúng mở của, sai quá 5 lần khóa đăng nhập, thoát chương trình
            string login;
            Console.WriteLine("moi nhap vao mk, mk dang nhap: ");
            login = Console.ReadLine();
            int demLogin = 0;
            while(true)
            {
                bool kq=mk.Equals(login);
                if(kq)
                {
                    Console.WriteLine("dang nhap thanh cong ");
                    break;
                }
                else
                {
                    demLogin++;
                    if(demLogin<5)
                    {
                        Console.WriteLine("moi nhap lai mk, nhap sai {0}/5 lan " ,demLogin);
                        login = Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("mat khau da bi khoa do nhap sai 5 lan");
                        break;
                    }
                }
            }
            Console.ReadKey();    
        }
    }
}
