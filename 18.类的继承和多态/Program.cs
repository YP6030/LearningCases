namespace _18.类的继承和多态
{
    internal class Program
    {
        //订单类
        //父类
        class Order
        {
            public string? name { get; protected set; }
            protected int num;
            protected float price;

            public Order(string name, int num, float price)
            { 
                this.name = name;
                this.num = num; 
                this.price = price;
            }

            //虚写
            public virtual float TotalPrice
            {
                get
                {
                    return this.price * this.num;
                }
            }

            public void Print()
            {
                Console.WriteLine($"{this.name}的单价为{this.price},{this.num}的价格为{TotalPrice}");
            }
        }

        //打折订单类
        //DiscountOrder继承了Order，子类
        class DiscountOrder : Order
        {
            protected float discount = 0.8f;

            public DiscountOrder(string name, int num, float price, float discount) : base(name, num, price)
            {
                //子类特有的初始化代码
                this.discount = discount;
            }

            //重写
            public override float TotalPrice
            {
                get
                {
                    return this.price * this.num * this.discount;
                }
            }
        }

        //满减订单类
        //FullSubOrder继承了Order，子类
        class FullSubOrder : Order 
        {
            protected int full = 10;
            protected int sub = 5;
            public FullSubOrder(string name, int num, float price, int full, int sub) : base(name, num, price)
            {
                //子类特有的初始化代码
                this.full = full;
                this.sub = sub; 
            }

            public override float TotalPrice
            {
                get
                {
                    float val = this.price * this.num;

                    if(val >= this.full)
                    {
                        val -= this.sub;
                    }

                    return val;
                }
            }
        }

        static void Main(string[] args)
        {
            Order o1 = new Order("苹果", 50, 10);
            DiscountOrder o2 = new DiscountOrder("橘子", 20, 4, 0.8f);
            FullSubOrder o3 = new FullSubOrder("香蕉", 10, 3.2f, 10, 5);

            //Console.WriteLine($"{o1.name}的价格{o1.TotalPrice}");
            //Console.WriteLine($"{o2.name}的价格{o2.TotalPrice}");
            //Console.WriteLine($"{o3.name}的价格{o3.TotalPrice}");
            //o1.Print();
            //o2.Print();
            //o3.Print();

            List<Order> orders = new List<Order> { o1, o2, o3 };

            for(int i = 0; i < orders.Count; i++) 
            {
                orders[i].Print();
            }
        }
    }
}