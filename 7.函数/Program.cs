namespace _7.函数
{
    internal class Program
    {
        static int InputNum(int a)
        {
            int num;
            Console.WriteLine($"请输入第{a}个数字:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");
            return num;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            a = InputNum(1);
            b = InputNum(2);
            c = InputNum(3);
            Console.WriteLine($"{a} {b} {c}，这三个数字的和为：" + (a + b + c));
        }
    }
}