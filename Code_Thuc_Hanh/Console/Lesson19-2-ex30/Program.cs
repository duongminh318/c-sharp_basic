using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_2_ex30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> dic = new Dictionary<string, int>(){ {"A",1},{"B",2},{ "C",3},{ "D",2},{ "E",1},{ "F",4},{ "G",2},{ "H",4},{ "I",1},{ "J",8},{ "K",5},{ "L",1},{ "M",3},{ "N",1},{ "O",1},{ "P",3},{ "Q",10},{ "R",1},{ "S",1},{ "T",1},{ "U",1},{ "V",4},{ "W",4},{ "X",8},{ "Y",4},{ "Z",10} };
            //1: Tách số và chữ, hiển thị lên màn hình
            //  2: tính tổng các số
            // 3: chuyển đổi chuỗi: "University of Technology and Education" sang số

            Dictionary<string, int> dic = new Dictionary<string, int>() { { "A", 1 }, { "B", 2 }, { "C", 3 }, { "D", 2 }, { "E", 1 }, { "F", 4 }, { "G", 2 }, { "H", 4 }, { "I", 1 }, { "J", 8 }, { "K", 5 }, { "L", 1 }, { "M", 3 }, { "N", 1 }, { "O", 1 }, { "P", 3 }, { "Q", 10 }, { "R", 1 }, { "S", 1 }, { "T", 1 }, { "U", 1 }, { "V", 4 }, { "W", 4 }, { "X", 8 }, { "Y", 4 }, { "Z", 10 } };

            // duyet dic
            foreach(KeyValuePair<string,int> kvp in dic)
            {
                Console.WriteLine(kvp);
            }

            // 1. tach chu: toList()
            List<string> ds = new List<string>();
            ds = dic.Keys.ToList();
          //  Console.WriteLine("chu cai sau khi tach la: ");
            foreach(string key in ds)
            {
                Console.Write(key.PadRight(3)); // can le (can phai 3 ky tu)
            }
            Console.WriteLine();
            //2. tach so
            List<int> ds2 = new List<int>();
            ds2 = dic.Values.ToList();
           // Console.WriteLine("So sau khi tach la: ");
            foreach (int key in ds2)
            {
                Console.Write(key.ToString().PadRight(3));
            }
            Console.WriteLine();
            // 2. tinh tong
            int tong = ds2.Sum();
            Console.WriteLine("tong cac chu so la:  "+tong);

            //3. chuyen doi chuoi: "University of Technology and Education" sang số

            // chuyen chu thuong sang hoa
            string s = "University of Technology and Education";
            string s2 = "";
            foreach(char c in s)
            {
                s2+= char.ToUpper(c);
            }
            Console.WriteLine("chuoi sau khi viet hoa la: ");
            Console.WriteLine(s2);

            // chuyen sang so
            string strso = "";
            foreach (char c in s2)
            {
                //Console.WriteLine(c);
                if (c == ' ')
                    strso += c;
                else
                    strso += dic[c.ToString()];
            }
            Console.WriteLine(strso);
            Console.ReadLine();
        }
    }
}
