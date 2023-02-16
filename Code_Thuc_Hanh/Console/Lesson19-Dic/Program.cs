using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Dic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. khai bao dic
            Dictionary<int, string> dic = new Dictionary<int, string>();

            //2. khoi tao và gán giá trị
            Dictionary<int, string> dic2 = new Dictionary<int, string>() { { 1, "Duong Khoi Minh" }, {2,"obama" }, {3, "tanaka"} };

            // key: bien so xe (kieu string)
            // value: chung minh thu (int)
            Dictionary<string, int> dic3 = new Dictionary<string, int>() { { "65L14712", 362586 }, { "67AK45878", 362527 }, { "65L14717", 362528 } };


            //4. add
            dic.Add(1, "Lo van moi");
            dic.Add(2, "Vui Thi Suong");
            dic.Add(3, "Duong Van TInnh");

            //5. duyet dic
            foreach(KeyValuePair<int, string> kvp in dic2)
            {
                Console.WriteLine(kvp);
                Console.WriteLine(kvp.Key);
                Console.WriteLine(kvp.Value);
                Console.WriteLine("key={0}, value={1}",kvp.Key, kvp.Value);
            }

            //6. dic.ContainsKey(2) Kiem tra xem 1 key co ton tai trong dic hay khong
            // true: neu co ton tai
            // false: neo 0 ton tai
            bool kq = dic.ContainsKey(1);
            Console.WriteLine(kq);
            //7 . dic.ContainsValue()
            //Kiểm tra xem 1 Value có tồn tại trong dic hay không
            //True : nếu có tồn tại
            //False : nếu không tồn tại

            bool kq2 = dic.ContainsValue("Lo van moi");
            Console.WriteLine(kq2);

            //8. dic[key] : lấy value từ key
            string name = dic[3];
            Console.WriteLine(name);
           
            //8.1. gan gia tri
            dic[2] = "doi van moi";
            Console.WriteLine(dic[2]);
          


            //9. xoa phan tu thoe key
            dic.Remove(1);
            Console.WriteLine("dic sau xoa la: ");
            foreach(KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine(kvp);
            }


            //10. xoa toan bo phan tu
            Console.WriteLine("so phan tu cua dic trc xoa "+ dic.Count());
            dic.Clear();
            Console.WriteLine("so phan tu cua dic sau xoa "+ dic.Count());

            // 11. chuyen values dic => List
            Dictionary<string, int> dic4 = new Dictionary<string, int>() 
            { { "65L14712", 362586 }, { "67AK45878", 362527 }, { "65L14717", 362528 } };

            List<int> ds = new List<int>();
            ds = dic4.Values.ToList();

            Console.WriteLine("danh sach value la: ");
            foreach(int i in ds)
            {
                Console.Write(i+ " ");
            }

            Console.WriteLine();
            //12. chuyen key dic sang list
            List<string> dsKey = new List<string>();
            dsKey = dic4.Keys.ToList();

            Console.WriteLine("danh sach key la: ");
            foreach (string i in dsKey)
            {
                Console.Write(i + " ");
            }


            Console.ReadKey();
        }
    }
}
