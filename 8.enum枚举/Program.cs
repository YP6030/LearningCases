namespace _8.enum枚举
{
    internal class Program
    {
        enum 星期
        {
            星期一 = 1,
            星期二,
            星期三,
            星期四,
            星期五,
            星期六,
            星期日,
        }
        enum 水果
        {
            苹果 = 1,
            香蕉,
            桔子,
            葡萄,
        }
        enum Fruit
        {
            Apple = 1,
            Banana,
            Orange,
            Grape,
        }
        enum Vaule
        {
            Apple = 4,
            Banana = 6,
            Orange = 5,
            Grape = 20,
        }
        static void 计算价格()
        {
            水果 tem;
            Fruit fruit;
            int weight = 0, menoy = 0, value = 0;
            Console.WriteLine("请输入需要购买的水果");
            tem = (水果)int.Parse(Console.ReadLine());
            fruit = (Fruit)((int)tem);
            switch((int)tem)
            {
                case 1:
                    menoy = (int)Vaule.Apple;
                    break;
                case 2:
                    menoy = (int)Vaule.Banana;
                    break;
                case 3:
                    menoy = (int)Vaule.Orange;
                    break;
                case 4:
                    menoy = (int)Vaule.Grape;
                    break;
            }
            Console.WriteLine("请输入需要购买几斤");
            weight = int.Parse(Console.ReadLine());
            value = weight * menoy;


            Console.WriteLine($"您购买了{weight}斤{tem},英文为{fruit}，单价为{menoy}元每斤，总价格为{value}元，请问扫码还是现金支付？");
        }
        static void Main(string[] args)
        {
            星期 day = 星期.星期三;
            Console.WriteLine(day);
            Console.WriteLine((int)day);
            Console.WriteLine((星期)3);

            计算价格();
        }
    }
}