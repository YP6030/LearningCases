namespace _13.引用类型和值类型
{
    internal class Program
    {
        //创建类
        class Students
        {
            public string name;
            public int age;
            public int score;

            public Students(string name, int age, int score)
            {
                this.name = name;
                this.age = age;
                this.score = score;
            }

            public void PrintScore()
            {
                Console.WriteLine($"{this.name}的成绩为{this.score}");
            }

            public void Print()
            {
                Console.WriteLine($"{this.name}");
                Console.WriteLine($"{this.age}");
                Console.WriteLine($"{this.score}");
            }

            public Students Copy()
            {
                Students other = new Students(this.name, this.age, this.score);
                return other;
            }
        }

        static void AddScore(Students other)
        {
            if (other != null)
            {
                other.score += 10;
            }
        }

        static void func(int[] array)
        {
            array[0] = 888;
            array = new int[3];
            array[0] = 999;
        }

        static void Main(string[] args)
        {
            //引用类型
            Students student1 = new Students("小明", 15, 50);
            //AddScore(student1);
            //student1.PrintScore();
            //如果是值类型则必须要返回赋值才能改变


            Students student2 = student1.Copy();

            AddScore(student2);

            student1.Print();
            student2.Print();

            //int[] array = new int[] { 1, 2, 3 };
            //func(array);
            //Console.WriteLine(array[0]);
        }
    }
}