using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_1_ex29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Csharp 29 :
              //  Viết chương trình sử dụng dict chứa 5 user name và password.
                  //  Chương trình yêu cầu nhập vào username và pass,
                 //   1.nếu user name o có trong dict, chương trình báo user name o tồn tại
                  //  2.nếu user name đúng mà password sai thì báo : PASSWORD SAI
                   // 3.nếu user, pass đúng thì báo bạn đã login thành công
            
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("user1", "1");
            dic.Add("user2", "2");
            dic.Add("user3", "3");
            dic.Add("user4", "4");
            dic.Add("user5", "5");

            // duyet dic
            foreach(KeyValuePair<string,string> pair in dic)
            {
                Console.WriteLine(pair);
            }


            //0. chuowng trinh yeu cau nhap vao username va pass


            Console.WriteLine("moi nhap username: ");
            string user = Console.ReadLine();
           
            // chech user co ton tai
            if (dic.ContainsKey(user)==false)
            {
                Console.WriteLine("user khong ton tai");
            
            }

            else
            {
                Console.WriteLine("moi nhap vao mat khau: ");
                string mk = Console.ReadLine();
                
                if (dic[user] == mk)    //lay value tu key
                    Console.WriteLine("dang nhap thanh cong" + dic[user]);
                   
                else
                    Console.WriteLine("sai mat khau");

            }
               
            Console.ReadKey();
        }
    }
}
