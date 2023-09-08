namespace _14.静态和属性
{
    internal class Program
    {
        //class Cha
        //{
        //    static public int count;
        //    public string name;
        //    public int hp;
        //    public int attack;
        //    public int def;
        //}

        //static void Main(string[] args)
        //{
        //    //Cha player1 = new Cha();
        //    //Console.WriteLine(Cha.count);
        //    ////访问static关键字修饰的字段
        //    //Cha.count++;

        //}

        static Random random = new Random();
        class Cha
        {
            static public int count;
            //字段
            public string name { get; private set; }
            public int hp { get; private set; }
            public int attack { get; private set; }
            public int def { get; private set; }

            //构造函数
            public Cha(string name)
            {
                this.name = name;
                this.hp = random.Next(50, 101);
                this.attack = random.Next(10, 40);
                this.def = random.Next(0, 10);
                count++;
            }

            //方法
            public void Print()
            {
                Console.WriteLine(this.name);
                Console.WriteLine(this.hp);
                Console.WriteLine(this.attack);
                Console.WriteLine(this.def);
            }
            //攻击一个玩家
            public int Attack(Cha other)
            {
                Console.WriteLine($"------{this.name} 进攻-------{other.name}-----------");
                int damage = this.attack - other.def;
                if (damage > 0)
                {
                    other.hp -= damage;
                    if (other.hp < 0) other.hp = 0;
                }
                Console.WriteLine($"对 {other.name} 造成 {damage} 伤害");
                return damage;
            }
            //自己是否死亡
            public bool IsDie()
            {
                if (this.hp <= 0)
                    return true;
                return false;
            }
        }

        static void Main(string[] args)
        {
            Cha player1 = new Cha("皮卡丘");
            Cha player2 = new Cha("杰尼龟");

            Console.WriteLine($"总共有{Cha.count}个玩家");
            player1.Print();
            player2.Print();
            while (true)
            {
                player1.Attack(player2);
                player1.Print();
                player2.Print();
                if (player2.IsDie())
                {
                    Console.WriteLine($"{player1.name} 获胜");
                    break;
                }
                player2.Attack(player1);
                player1.Print();
                player2.Print();
                if (player1.IsDie())
                {
                    Console.WriteLine($"{player2.name} 获胜");
                    break;
                }
            }

        }
    }
}