using System;

namespace _1_8ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "早上2";
            if (name =="早上")
            {
                Console.WriteLine("早上好");
            }
            else if (name=="中午")
            {
                Console.WriteLine("中午好");
            }
            else if (name=="晚上")
            {
                Console.WriteLine("晚上好");
            }
            else
            {
                Console.WriteLine("输入有误！！！");
            }
            Console.ReadKey();
        }
    }
}
