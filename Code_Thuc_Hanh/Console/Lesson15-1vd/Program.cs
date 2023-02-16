using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_1vd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int demSo=0, demChuThuong=0, demInHoa =0, demSpace = 0;
            string chuoi = "I am i ronMan 3000";
            char[] lst = chuoi.ToCharArray();
            foreach(char c in lst)
            {
                if (char.IsDigit(c))
                    demSo++;
                else if (char.IsLower(c))
                    demChuThuong++;
                else if (char.IsUpper(c))
                    demInHoa++;
                else if (char.IsWhiteSpace(c))
                    demSpace++;
               // Console.WriteLine(c);
            }
            Console.WriteLine("chuoi co {0} ky tu viet thuong", demChuThuong );
            Console.WriteLine("chuoi co {0} ky tu so", demSo);
            Console.WriteLine("chuoi co {0} ky tu viet Hoa",demInHoa );
            Console.WriteLine("chuoi co {0} ky tu space", demSpace );
            Console.ReadKey();

        }
    }
}
