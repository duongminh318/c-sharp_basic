using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Slide18_io_lesson1
{
    internal class Program
    {
        static void DSThuMucFile(string path)
        {

            string[] dsThuMuc = Directory.GetDirectories(path);
            string[] dsFile = Directory.GetFiles(path);



            // xuat ds file
            foreach (string file in dsFile)
            {
                Console.WriteLine(file);

            }


            // xuat ds folder
            foreach (string folder in dsThuMuc)
            {
                Console.WriteLine(folder);
                DSThuMucFile(folder);
            }

        }
        static void Main(string[] args)
        {
            //ham
          

            //get ten thu muc
            DirectoryInfo currDir = new DirectoryInfo(".");
            Console.WriteLine(currDir.FullName);
            Console.WriteLine(currDir.Name);

            //get path
            DirectoryInfo duongdan = new DirectoryInfo("D:\\LEARNING\\LEARNING_CODE\\nhap");
            Console.WriteLine(duongdan.FullName);

            // lay ten thu muc
            Console.WriteLine(duongdan.Name);

            //get thu muc cha
            Console.WriteLine(duongdan.Parent);

            //get thuoc tinh
            Console.WriteLine(duongdan.Attributes);

            //get thoi gian tao thu muc
            Console.WriteLine(duongdan.CreationTime);

            // thu muc goc
            Console.WriteLine(duongdan.Root);

            //tao thu muc
            //cach 1:
            DirectoryInfo thumuc1 = new DirectoryInfo("D:\\LEARNING\\LEARNING_CODE\\nhap\\tuhoc.cc");
            thumuc1.Create();

            //cach 2:
            string thumuc2 = "D:\\LEARNING\\LEARNING_CODE\\nhap\\tuhoc2.cc";
            Directory.CreateDirectory(thumuc2+ "\\");

            //4. exists (path) kiem tra xem thu muc co ton tai hay khong (true/false)
            string path1 = "D:\\LEARNING\\LEARNING_CODE\\nhap\\tuhoc2.cc";
            if(Directory.Exists(path1)) /// if(==true)
            {
                Console.WriteLine("co ton tai duong dan D:\\LEARNING\\LEARNING_CODE\\nhap\\tuhoc2.cc roi thim oi");
            }
            else
            {
                Console.WriteLine("ko ton tai duong dan D:\\LEARNING\\LEARNING_CODE\\nhap\\tuhoc2.cc roi thim oi");
            }

            //5.xoa thu muc
            Directory.Delete("D:\\LEARNING\\LEARNING_CODE\\nhap\\tuhoc.cc");

            //Directory.GetFiles(path) Trả về danh sách file nằm trong path
            string path2 = "D:\\LEARNING\\LEARNING_CODE\\nhap";
            string[] files = Directory.GetFiles(path2);
            Console.WriteLine($"Danh sach file trong thu muc {path2} la ");
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }
        
            Console.WriteLine("/---------------/");

            //Directory.GetDirectories(Directories) Trả về danh sách thu muc nằm trong path
            string path3 = "D:\\LEARNING\\LEARNING_CODE\\nhap";
            string[] files2 = Directory.GetDirectories(path3);
            Console.WriteLine($"Danh sach file trong thu muc {path3} la ");
            foreach (string file in files2)
            {
                Console.WriteLine(file);
            }
            
            Console.WriteLine("/---------------/");
            Console.WriteLine();
            //
           // string path5 = "D:\\LEARNING\\LEARNING_CODE\\nhap";
           // Console.WriteLine($"ds file va thu muc trong {path5}");
        //    DSThuMucFile(path5);

            //8. tim kiem file: vi du  tim kiem all file txt trong 1 thu muc
            DirectoryInfo myDataDir = new DirectoryInfo("D:\\LEARNING\\LEARNING_CODE\\nhap");

            // get all txt files
            // TopDirectoryOnly chi tim thu muc chi dinh
            // AllDirectories: tim ca trong cac thu muc con cua no
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Tim Thay: {0}", txtFiles.Length);
            foreach( FileInfo txtFile in txtFiles)
            {
                Console.WriteLine(txtFile.Name);

                //get byte in file
                Console.WriteLine(txtFile.Length);
            }


            Console.ReadKey();
        }
    }
}
