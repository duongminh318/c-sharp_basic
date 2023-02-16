using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_3_ex26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình trả lời kết quả các phép tính
            // quest = {"2 + 5 + 7 =","5 * 10 =","sqrt(16) =","12%2 =","5//2=“}
            int demDung = 0;
            int demSai = 0;
            List<string> quest = new List<string>(){"2 + 5 + 7 =","5 * 10 =","sqrt(16) =","12%2 =","5//2="};
            List<int> traloi = new List<int>() { 14, 50, 4, 0, 2 };
            for (int i=0;i<quest.Count;i++)
            {
                Console.WriteLine(quest[i]);
                Console.WriteLine();
                int ans = int.Parse(Console.ReadLine());
                if (ans == traloi[i])
                {
                    Console.WriteLine("Corect");
                    demDung++;
                }
                else
                {
                    Console.WriteLine("Wrong, the asnwer is " + traloi[i]);
                    demSai++;
                }
            }
            Console.WriteLine("so cau tra loi dung : " + demDung);
            Console.WriteLine("so cau tra loi sai : " + demSai);
            Console.ReadLine();

        }
    }
}
