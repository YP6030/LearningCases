﻿namespace while语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine(i++);
            }
            Console.WriteLine("------------------------------");
            do
            {
                Console.WriteLine(i++);
            } while(i < 10);
        }
    }
}