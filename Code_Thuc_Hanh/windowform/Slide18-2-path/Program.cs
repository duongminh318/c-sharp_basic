using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Slide18_2_path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //D:\LEARNING\LEARNING_CODE\nhap
            //1. Path.Combine Kết hợp các chuỗi thành dường dẫn:
            string path = Path.Combine(@"D:\", "LEARNING", "LEARNING_CODE", "nhap","tuhoc3","teptin.txt");
            Console.WriteLine(path);

            //2. Path.ChangeExtension() Thay đổi phần mở rộng của đường dẫn
            string path2 = Path.ChangeExtension(path, "pdf");
            Console.WriteLine(path2);
           

            //3. Path.GetDirectoryName trả về thư mục chứa file theo đường dẫn path :
            string path3 = Path.GetDirectoryName(path);
            Console.WriteLine(path3);

            //4. Path.GetExtension : Lấy phần mở rộng
            string path4 = Path.GetExtension(path);
            Console.WriteLine(path4);

            //5. Path.GetFileName trả về tên file
            string path5 = Path.GetFileName(path);
            Console.WriteLine(path5);

            //6. Path.GetFullPath Lấy đường dẫn đầy đủ
                //TH1 : nếu path đặt trong dấu "" là đường dẫn tương đối
                //=> Câu lệnh này sẽ nối thư mục hiện tại với đường dẫn trong ""
                        string path6 = Path.GetFullPath("file1.txt");
                        Console.WriteLine(path6);
                        //chech thu muc hien tai
                        DirectoryInfo CurrDir = new DirectoryInfo(".");
                        Console.WriteLine(CurrDir.FullName);
            //TH2 : nếu path đặt trong dấu "" là đường dẫn tuyệt đối
            //=> Câu lệnh này trả về đường dẫn đầy đủ của đường dẫn tuyệt đối

                        string path6x = Path.GetFullPath("D:\\file1.txt");
                        Console.WriteLine(path6x);

            // 7. Path.GetPathRoot Lấy gốc của đường dẫn
            string path7 = Path.GetPathRoot(path);
            Console.WriteLine(path7);

            //8. Get path của thư mục đặc biệt
                //Để lấy đường dẫn đến một số thư mục đặc biệt của hệ thống,
                //có thể dùng phương thức Environment.GetFolderPath
                //Ví dụ, lấy thư mục MyMusic, MyDocument, Mypicture …
              string path8 = Environment.GetFolderPath(Environment.SpecialFolder.History); 
              Console.WriteLine(path8);

            Console.ReadKey();

        }
    }
}
