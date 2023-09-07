namespace _11.类和对象
{
    internal class Program
    {
        //创建类
        class Students
        {
            public string name;
            public int age;
            public int id;
        }
        static void Test()
        {
            //创建对象
            Students a = new Students();
            a.name = "小明";
            a.age = 10;
            a.id = 1;
            //申请对象数组，这里只是申请了数组，并没有对象
            Students[] students = new Students[10];
            //给数组中的元素添加对象
            for (int i = 0; i < students.Length; i++)
                students[i] = new Students();

            //使用
            for (int i = 0; i < students.Length; i++)
                students[i].id = i + 1;

            for (int i = 0; i < students.Length; i++)
                Console.WriteLine(students[i].id);
        }

        class Cha
        {
            public string name;
            public int hp;
            public int attack;
            public int def;
        }

        static void PrintPlayer(Cha player)
        {
            Console.WriteLine(player.name);
            Console.WriteLine(player.hp);
            Console.WriteLine(player.attack);
            Console.WriteLine(player.def);
        }

        static void Main(string[] args)
        {
            Cha player1 = new Cha();
            Cha player2 = new Cha();
            int damage = 0;

            player1.name = "皮卡丘";
            player1.hp = 30;
            player1.attack = 20;
            player1.def = 0;

            player2.name = "妙蛙种子";
            player2.hp = 20;
            player2.attack = 15;
            player2.def = 5;

            PrintPlayer(player1);
            PrintPlayer(player2);

            while (true)
            {
                Console.WriteLine($"----------{player1.name} 进攻-----------");
                damage = player1.attack - player2.def;
                player2.hp -= damage;
                Console.WriteLine($"{player1.name}造成{damage}伤害");
                PrintPlayer(player1);
                PrintPlayer(player2);
                if (player2.hp <= 0)
                {
                    Console.WriteLine($"{player1.name} 获胜");
                    break;
                }
                Console.WriteLine($"----------{player2.name} 进攻-----------");
                damage = player2.attack - player1.def;
                player1.hp -= damage;
                Console.WriteLine($"{player2.name}造成{damage}伤害");
                PrintPlayer(player1);
                PrintPlayer(player2);
                if (player1.hp <= 0)
                {
                    Console.WriteLine($"{player2.name} 获胜");
                    break;
                }
            }
        }
    }
}