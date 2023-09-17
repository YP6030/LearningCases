namespace _15.列表
{
    internal class Program
    {
        static void PrintList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static void Main(string[] args)
        {
            //列表的创建
            List<int> list = new List<int>();
            List<int> list2 = new();
            List<int> list1 = new List<int> {1,2,3,4,1};
            //添加元素
            list.Add(1);
            list.Add(2);
            list2.Add(2);

            //遍历读取元素
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.WriteLine("-----------------------");
            //删除列表元素，删除后后面的元素会往上顶
            //list1.RemoveAt(0);//输入下标
            //PrintList(list1);
            //在列表中指点位置插入元素
            //list.Insert(0, 1);//在 0 号位置插入元素 1

            //查找元素的下标
            //Console.WriteLine(list1.IndexOf(1));
            //Console.WriteLine(list1.LastIndexOf(1));

            //列表排序
            list1.Sort();//从小到大
            PrintList(list1);
            //列表反序
            list1.Reverse();
            PrintList(list1);


        }
    }
}