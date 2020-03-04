using System;

namespace _1_15方法的定义和使用
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *
             * 介绍方法 实例方法和静态方法
             *
             *
             * 方法的定义首字母大写
             *
             *
             * 静态方法和实例方法 最大的区别就是生命周期，静态方法成员启动就存在，而方法是有对象后才会被调用
             */
            Program111 p1 = new Program111();

            p1.Ptintx();
            Console.WriteLine(p1.Addi(1, 3)  ); 
            Console.WriteLine("Hello World!");


            int x = 1;
            Printxxx();
        }
        /// <summary>
        /// Main方法中可以直接调用，如不在当前内 使用类名.静态方法 直接调用
        /// 静态方法只能调用静态成员
        /// 非静态方法可以访问类中的任何成员
        /// </summary>
        static void Printxxx()
        {
            //x = 3;  不存在
            Console.WriteLine("xxx");
        }

    }

    /// <summary>
    /// 
    /// </summary>
    class Program111 {

        /// <summary>
        /// void 无返回值的方法
        /// </summary>
        public void Ptintx() {
            Console.WriteLine("HHHH");
        }

        /// <summary>
        /// 带有返回值的方法
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Addi(int a,int b) {
            return a + b;
        }
    }
}
