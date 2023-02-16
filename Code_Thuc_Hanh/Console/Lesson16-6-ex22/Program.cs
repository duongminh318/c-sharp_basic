using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16_6_ex22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Csharp 22 :
            Cho chuỗi : 
	            a= “
	            tôi chăm học
	            tôi chịu khó
	            tôi đẹp zai
	            “
	            đếm từ tôi trong string a trên
             * 
             */
            int dem = 0;
            Console.OutputEncoding=Encoding.UTF8;  
            string a = @" toi chăm học
                         toi chịu kho
                         toi đẹp zai";
            string[] lst=a.Split(' ');
            foreach(string s in lst)
            {
                //  Console.WriteLine(s);
                if ("toi".Equals(s))
                    dem++;


            }
            Console.WriteLine("co {0} tu toi trong cau tren",dem);
            Console.ReadKey();


        }
    }
}
