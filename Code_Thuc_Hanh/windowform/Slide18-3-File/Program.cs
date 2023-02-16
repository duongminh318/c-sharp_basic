using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;

namespace Slide18_3_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  để làm việc với văn bản
            // 1 StreamWriter : Ghi file văn bản
            FileStream fs =new FileStream("data1.txt",FileMode.Create,FileAccess.ReadWrite);
            StreamWriter streamWriter= new StreamWriter(fs);

            streamWriter.WriteLine("Hello Stream");
            streamWriter.Flush();
            streamWriter.Close();

            //2 StreamReader : Đọc file văn bản
            fs = new FileStream("data1.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader streamReader= new StreamReader(fs);
            string readstr= streamReader.ReadToEnd();
            Console.WriteLine(readstr);
            fs.Close();         // dong luong

            //3. BinaryWriter / BinaryReader
            //  Để làm việc với các kiểu dữ liệu cơ sở (int, bool,char...);
            //ghi
            FileStream fs2 = new FileStream("data2.txt", FileMode.Create, FileAccess.ReadWrite);
            BinaryWriter binaryWriter= new BinaryWriter(fs2);
            binaryWriter.Write(318888);         
            fs2.Close();

            //doc
            FileStream fs3 = new FileStream("data2.txt", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader binaryReader= new BinaryReader(fs3);
            var so = binaryReader.ReadInt32();
            Console.WriteLine(so);
           // fs3.Close();

            //4. Using
            using (FileStream fs4 = new FileStream("data3.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                BinaryWriter bw= new BinaryWriter(fs4);
                bw.Write(978512);
                StreamWriter sw = new StreamWriter(fs4);
                sw.Write("dkm");
                sw.Flush();


            }

            using(FileStream fs5 = new FileStream("data3.txt", FileMode.Open, FileAccess.ReadWrite))
            {
                BinaryReader br= new BinaryReader(fs5);
                var so1= br.ReadInt32();
                Console.WriteLine(so1);
                StreamReader sr= new StreamReader(fs5);
                var str= sr.ReadToEnd();
                Console.WriteLine(str);
               // fs5.Close();
            }
            //Một số phương thức “tắt”-> ghi truc tiep vao bo nho khong can mo dong luong
                // nhung khong hieu qua voi du lieu lon
                    //7. File.WriteAllText :
                    string path = "newfile.txt";
                    string content = "dmcs thich ghi gi vao day thi ghi";
                    File.WriteAllText(path, content);

                    //8 . File.WriteAllLines
                    string[] content2 = { "dong 1", "this is 2 item", "this is 3 line " };
                    File.WriteAllLines(path, content2);

                    //9 . File.AppendAllLines
                    string[] content3 = { "dong 4", "this is 5 item", "this is 6 line " };
                    File.AppendAllLines(path, content3);

                     //10.File.ReadAllText
                     Console.WriteLine("------------");
                    string ReadContent = File.ReadAllText(path);
                     Console.WriteLine(ReadContent);
                     Console.WriteLine(ReadContent.GetType().ToString());

                    //11 . File.ReadAllLines
                    Console.WriteLine("xuat noi dung theo mang: ");
                    string[] arrContent= File.ReadAllLines(path);
                    foreach(var line in arrContent)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("xuat dong thu 2: "+arrContent[1]);
                    //12.File.Move(pathgoc, pathchuyentoi) ->Di chuyển và đổi tên nếu tên file đích khác tên gốc
                    string path1 = "filegoc.txt";
                    string path2 = "D:\\LEARNING\\LEARNING_CODE\\C#-Basic\\Code_Thuc_Hanh\\filedich.txt";
                    File.Move(path1,path2);

                    //13. File.Copy() -> copy va tao ra 1 file moi
                    // File.Copy(path, "filecopy.txt");
                    Console.WriteLine("da coppy");

                    //14. File.Delete()
                    File.Delete("filecopy.txt");
                    Console.WriteLine("da xoa");



            Console.ReadKey();
        }
    }
}
