using System.Text;

namespace _22.StreamReader和StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\..\..\test\test.txt";

            using (StreamReader stRead = new StreamReader(path, Encoding.UTF8))
            {
                string? str;
                while (!stRead.EndOfStream)
                {
                    str = stRead.ReadLine();
                    Console.WriteLine(str);
                }
            }

            using (StreamWriter stWrite = new StreamWriter(path, true, Encoding.UTF8))
            {
                string str = "StreamWriter 追加写入";
                stWrite.Write(str);//写完后没有换行
                stWrite.WriteLine(str);//写完后有换行
            }
        }
    }
}