using System;

namespace _1_12数组
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 数组下标是从0开始的，下面三种都可以创建数字，推荐第三种
             */
            string[] names = new string[3] { "x","y","z"};
            string[] names2 = new string[] { "o","p","q","y"};
            string[] names3 = { "a","b","c","d","e"};

            Console.WriteLine(names[1]);

            Console.ReadKey();
        }
    }
}
