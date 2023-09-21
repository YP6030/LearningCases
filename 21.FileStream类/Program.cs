using System.Text;

namespace _21.FileStream类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\..\..\test\test.txt";

            //读取文件
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int len = 0;
                string str;
                len = fsRead.Read(buffer, 0, buffer.Length);
                str = Encoding.UTF8.GetString(buffer, 0, len);
                Console.WriteLine(str);
            }

            //给文件追加数据
            using (FileStream fsWrite = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                string str = "FileStream Write";
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
        }
    }
}