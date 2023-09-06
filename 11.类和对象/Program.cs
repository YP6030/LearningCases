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
            int def;
        }

        static void Main(string[] args)
        {
            Cha player1 = new Cha();
            Cha player2 = new Cha();

            player1.name = "皮卡丘";
        }
    }
}