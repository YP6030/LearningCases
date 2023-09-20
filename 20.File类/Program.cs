using System.Text;
using System;

namespace _20.File类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Desktop\学习资料\C#\test\test.txt";
            //创建一个文件
            //File.Create(@"D:\Desktop\学习资料\C#\test\new.csv");

            //删除一个文件
            //File.Delete(@"D:\Desktop\学习资料\C#\test\new.txt");

            //复制一个文件
            //File.Copy(@"D:\Desktop\学习资料\C#\test\test.txt", @"D:\Desktop\学习资料\C#\test\new1.txt");

            //剪贴一个文件
            //File.Move(@"D:\Desktop\学习资料\C#\test\test.txt", @"D:\Desktop\学习资料\C#\test.txt");

            //以二进制读取整个文件
            //byte[] buff = File.ReadAllBytes(path);
            //string str = Encoding.Default.GetString(buff);
            //Console.WriteLine(str);

            //按行读取这个文件
            //string[] buff = File.ReadAllLines(path);
            //foreach(var i in buff)
            //{
            //    Console.WriteLine(i);
            //}

            //读取整个文件
            //string buff = File.ReadAllText(path);
            //Console.WriteLine(buff);


            //给文件以二进制写入所有数据，覆盖
            //string dataStr = "写入hello world";
            //byte[] buff = Encoding.UTF8.GetBytes(dataStr);
            //File.WriteAllBytes(path, buff);//WriteAllBytes没有这个文件的时候，会自动创建。有的话会覆盖内容

            //以行的方式写入文件
            //string[] strings = { "大家好", "好什么" };
            //File.WriteAllLines(@"D:\Desktop\学习资料\C#\test\test1.txt", strings);

            //以字符串的形式写入文件
            //string str = "大家好才是真的好";
            //File.WriteAllText(@"D:\Desktop\学习资料\C#\test\test1.txt", str);

            //以行的方式追加写入文件
            //string[] strings = { "大家好", "好什么" };
            //File.AppendAllLines(path, strings);

            //以字符串的形式追加写入文件
            //string str = "大家好才是真的好";
            //File.AppendAllText(path, str);
        }
    }
}