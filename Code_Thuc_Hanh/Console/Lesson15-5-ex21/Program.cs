using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_5_ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Csharp 21 :
                Viết chương trình chuyển tin nhắn sang mật mã theo bảng : 
                #a="abcdefghijklmnopqrstuvwxyz"   
                #b="zxcvbnmasdfghjklqwertyuiop“  
             */
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b= "zxcvbnmasdfghjklqwertyuiop";
            // Console.WriteLine(a[2]);
            //
            Console.WriteLine("moi nhap vao chuoi can ma hoa : ");
            string chuoiInPut = Console.ReadLine();
            string chuoiOutPut = "";
            foreach(char c in chuoiInPut)
            {
            //    Console.WriteLine(c);
                int indexKytu=a.IndexOf(c);
              //  Console.WriteLine(indexKytu);
              //  Console.WriteLine(b[indexKytu]);
                chuoiOutPut += b[indexKytu];
            }

            Console.WriteLine("chuoi trc ma hoa la : "+chuoiInPut);
            Console.WriteLine("chuoi sau ma hoa la : "+chuoiOutPut);
            Console.ReadKey();


        }
    }
}
