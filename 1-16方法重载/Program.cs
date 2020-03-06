using System;

namespace _1_16方法重载
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 
             * 方法重载
             * 1方法同名
             * 2参数类型不一样
             * 3参数个数不一样
             * 4参数类型顺序不一样
             * 5注意跟返回值无关!!!
             * */
            Console.WriteLine("Hello World!");
        }
    }

    class X1 {
        public int Add(int x, int y) {
            return x + y;
        }
        public double Add(double x, int y) {
            return x + y;
        }
        public double Add(int y,double x) {
            return x + y;
        }
    }
}
