namespace _19.Path类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = @"C:\3000soft\Red Spider\Data\Message\张三.wav";

            //获取文件名
            Console.WriteLine(Path.GetFileName(str));
            //获取文件名不含扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //获取文件的扩展名
            Console.WriteLine(Path.GetExtension(str));
            //获取文件所在的文件夹的名称
            Console.WriteLine(Path.GetDirectoryName(str));
            //获取文件所在的全路径
            Console.WriteLine(Path.GetFullPath(str));
            //链接两个字符串作为路径
            Console.WriteLine(Path.Combine(@"c:\a\", "b.txt"));
        }
    }
}