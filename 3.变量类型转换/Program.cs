using System;

namespace 变量类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //强制类型转换 如：(int) (float)
            int a = 1;
            float b = 2.2f;
            Console.WriteLine(a + b);
            Console.WriteLine((int)(a * b));

            string s1 = "123";
            string s2 = "123.123";
            //Convert转换
            Console.WriteLine(Convert.ToInt32(s1));
            Console.WriteLine(Convert.ToDouble(s2));
            //xx.Parse转换
            Console.WriteLine(int.Parse(s1));
            Console.WriteLine(double.Parse(s2));
            //xx.TryParse(string,out math) string:需要转换的字符串；math：保存转换的结果。
            //返回值：正确转换返回 True；否则返回 Flase
            int math;
            bool result = int.TryParse(s1, out math);
            Console.WriteLine($"{result} {math}");
            double math1;
            result = double.TryParse(s2, out math1);
            Console.WriteLine($"{result} {math1}");
            //转义字符
            Console.WriteLine($"{result} \n \\\t{math1}");
        }
    }
}