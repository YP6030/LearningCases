namespace _16.字典
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建字典
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<int, int> dictNume = new Dictionary<int, int>();
            Dictionary<string, string> data = new Dictionary<string, string> {
                { "AI", "人工智能"},
                { "PS", "PhotoShop"},
            };

            //添加内容，键key和值Value
            dict.Add("a", 1);
            dict.Add("b", 2);
            dict.Add("c", 3);
            dict.Add("d", 4);

            dictNume.Add(1, 15);


            //根据Key读到对应的Value
            //Console.WriteLine(dict["a"]);
            //Console.WriteLine(dict["b"]);
            //Console.WriteLine(dict["c"]);
            //Console.WriteLine(dict["d"]);

            //Console.WriteLine(dictNume[1]);
            //Console.WriteLine(data["AI"]);

            //修改元素
            dict["a"] = 999;
            dict["e"] = 777;//如果 e 不存在，则添加 e，相当于 dict.Add("e", 777)。否则就是修改

            //删除元素
            //dict.Remove("a");

            //循环打印字典,不能用for
            foreach(var pair in dict)// var -> KeyValuePair
            {
                Console.WriteLine($"key:{pair.Key} value:{pair.Value}");
            }

            //判断是否包含Key
            if(dict.ContainsKey("a"))
            {
                Console.WriteLine("dict包含a  " + dict["a"]);
            }
            else
            {
                Console.WriteLine("字典dict不包含a");
            }

            //可以为空
            string? input = Console.ReadLine();
            if(input != null)
            {
                if(data.ContainsKey(input))
                {
                    Console.WriteLine(data[input]);
                }
            }
        }
    }
}