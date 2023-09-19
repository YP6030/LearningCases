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

        static void Test(int[] buf, out int max, out int min, out float avg)
        {
            int sum = 0;
            max = buf[0];
            min = buf[0];
            avg = 0;

            for (int i = 0; i < buf.Length; i++)
            {
                if (buf[i] > max)
                    max = buf[i];
                if (buf[i] < min)
                    min = buf[i];
                sum += buf[i];
            }

            avg = (float)sum / buf.Length;
        }

        //out参数
        //可以输出多个不同类型的值
        //out修饰的变量在方法内必须赋值，方法外可以不用。
        static bool Test1(string usr, string pwd, out string msg)
        {
            if (usr == "admin" && pwd == "88888")
            {
                msg = "登录成功";
                return true;
            }
            else if (usr == "admin")
            {
                msg = "密码错误";
            }
            else if (pwd == "88888")
            {
                msg = "用户名错误";
            }
            else
            {
                msg = "都错了";
            }

            return false;
        }

        //ref参数
        //可以把修饰的变量带入方法并返回出去
        //ref修饰的变量方法外必须赋值，方法内可以不用
        static void Exchange(ref int n1 ,ref int n2)//交换两个变量的值
        {
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
        }
        
        //params参数
        //可以把实参列表里的相同类型的参数，变成数组中的元素
        static void Test3(string name, params int[] score)
        {
            int sum = 0;

            for (int i = 0; i < score.Length; i++)
                sum += score[i];

            Console.WriteLine($"{name}的总分为{sum}");
        }


        //方法的重载
        static void Fun(int a, int b)
        {
            int c = a + b;
        }

        static void Fun(int a, int b, int c)
        {
            c = a + b;
        }

        static void Fun(float a, int b)
        {
            float c = a + b;
        }

        static int i = 0;
        //递归
        static void TellStoty()
        {
            Console.WriteLine("从前有座山");
            Console.WriteLine("山上有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("老和尚给小和尚讲故事，故事是");
            i++;
            if (i > 10)
            {
                i = 0;
                return;
            }
            TellStoty();
        }

        static void Main(string[] args)
        {
            Random random = new Random();

            //int a, b, c;
            //int i = random.Next(1, 100);
            //Console.WriteLine(random.Next(1, 100));
            //a = InputNum(1);
            //b = InputNum(2);
            //c = InputNum(3);
            //Console.WriteLine($"{a} {b} {c}，这三个数字的和为：" + (a + b + c));

            //int Max, Min;
            //float avg;
            //int[] nums = {2,3,4,1,55,6};

            //Test(nums, out Max, out Min, out avg);

            //Console.WriteLine($"max={Max},min={Min},avg={avg}");

            //int a = 1, b = 2;

            //Exchange(ref a, ref b);
            //Console.WriteLine(a + " " + b);

            //Test3("张三", 80, 90, 100);
            //Test3("李四", 80, 90, 100, 60);

            //Fun(1, 2);
            //Fun(1, 2, 3);
            //Fun(1.1f, 3);
            TellStoty();
        }

    }
}