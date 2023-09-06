namespace _9.一维数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //申请数组的两种方式
            int[] array = new int[5];//不给初始值
            int[] array2 = { 1, 2, 3, 4, 5, 0 };//给初始值

            //改变数组中的值
            array[0] = 1;
            array[2] = 0x30;

            //使用数组
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine(array2[i]);
        }
    }
}