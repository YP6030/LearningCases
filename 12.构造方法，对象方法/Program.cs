using System;
using System.Numerics;

namespace _12.构造方法_对象方法
{
    
    internal class Program
    {
        static Random random = new Random();
        class Cha
        {
            //字段
            public string name;
            public int hp;
            public int attack;
            public int def;

            //构造函数
            //1.无参数
            public Cha()
            {
                this.name = "Test";
            }
            //2.用多个参数创建对象
            public Cha(string name, int hp, int attack, int def)
            {
                this.name = name;
                this.hp = hp;
                this.attack = attack;
                this.def = def;
            }
            //3.用2个参数创建对象，其它字段位默认值
            public Cha(string name, int hp)
            {
                this.name = name;
                this.hp = hp;
                this.attack = 1;
                this.def = 1;
            }
            public Cha(string name)
            {
                this.name = name;
                this.hp = random.Next(50, 101);
                this.attack = random.Next(10, 40);
                this.def = random.Next(0, 10);
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
                if(this.hp <= 0)
                    return true;
                return false;
            }
        }

        static void Main(string[] args)
        {
            Cha player1 = new Cha("皮卡丘");
            Cha player2 = new Cha("杰尼龟");

            player1.Print();
            player2.Print();
            while(true)
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