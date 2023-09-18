using System.Xml.Linq;

namespace _17.类的组合
{
    internal class Program
    {
        //枚举一个方位
        enum Where
        {
            左前 = 1,
            右前,
            左后,
            右后,
        };
        //发动机类
        class Engine
        {
            private string model = "1.5L";

            public void Start()
            {
                Console.WriteLine($"{model} 启动引擎");
            }
        }
        //车轮类
        class Wheel
        {
            public Where where;
            public float radius;//半径
        }
        //车类Car 由 发动机类 Engine 和车轮类 Whell 及类的组合
        class Car
        {
            //Car类中new 发动机类 Engine 和车轮类 Whell对象
            private Engine engine = new();
            private Wheel[] wheels = new Wheel[4];

            //构造函数
            public Car()
            {
                //对象列表需要遍历new
                for (int i = 0; i < wheels.Length; i++)
                {
                    wheels[i] = new Wheel();
                    wheels[i].where = (Where)(i + 1);
                    wheels[i].radius = 1.5f;
                }
            }

            //方法
            public void Start()
            {
                this.engine.Start();
                for (int i = 0; i < wheels.Length; i++)
                {
                    Console.WriteLine($"{wheels[i].where}车轮的尺寸为{wheels[i].radius}");
                }
                Console.WriteLine("准备行驶");
            }
        }

        static void Test()
        {
            Address addr = new Address
            {
                Street = "凤凰路",
                City = "泰州",
                Contry = "中国",
            };

            Person person = new Person
            {
                Name = "你大爷",
                Addr = addr,
            };

            person.Printf();
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Start();

            Test();
        }
    }
}