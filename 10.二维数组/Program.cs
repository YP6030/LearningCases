namespace _10.二维数组
{
    internal class Program
    {
        static bool[,] buf = new bool[4 , 4];

        static void Test()
        {
            //二位数组的创建
            int[,] array = new int[2, 3];
            int[,] array1 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //填写数据
            array[0, 1] = 2;
            array[1, 2] = 6;

            //读取数据
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write(array1[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void BufInit()
        {
            for (int i = 0; i < buf.GetLength(0); i++)
            {
                for (int j = 0; j < buf.GetLength(1); j++)
                    buf[i, j] = true;
            }
        }

        static void PrintBuf()
        {
            for (int i = 0; i < buf.GetLength(0); i++)
            {
                for (int j = 0; j < buf.GetLength(1); j++)
                {
                    if (buf[i, j])
                        Console.Write($"{i + 1}-{j + 1} 有票 ");
                    else
                        Console.Write($"{i + 1}-{j + 1} 无票 ");
                }
                Console.WriteLine();
            }
        }

        static bool 购买结果(int x, int y)
        {
            if (buf[x - 1, y - 1])
            {
                buf[x - 1, y - 1] = false;

                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            int x, y;

            BufInit();
            while (true) 
            {
                PrintBuf();
                Console.WriteLine("请输入要购买的行号：");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入要购买的列号：");
                y = int.Parse(Console.ReadLine());
                if (购买结果(x, y))
                    Console.WriteLine($"{x}-{y} 购买成功");
                else
                    Console.WriteLine($"{x}-{y} 购买失败");
                Console.WriteLine();
            }
        }
    }
}