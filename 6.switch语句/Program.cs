namespace switch语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s= Console.ReadLine();
            int i = int.Parse(s);

            switch(i)
            {
                case 1:
                    Console.WriteLine("攻击");
                    break;
                case 2:
                    Console.WriteLine("加盾");
                    Console.WriteLine("加血");
                    break;
                case 3:
                    Console.WriteLine("逃跑");
                    break;
                default:
                    break;
            }
        }
    }
}