using System;

namespace _1_17构造方法
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1每个类都有一个默认的构造方法 如果不指定
             * 2使用new来调用
             * 3不能有返回值
             * 4方法和类名相同
             * 
             * 构造方法用于初始化某些值
             * */
            Student s1 = new Student();
            Student s2 = new Student(1,3);
            Console.WriteLine("Hello World!");
        }
    }

    class Student {
        public Student() {
            Console.WriteLine("这是默认的构造方法");
        }

        public Student(int x ,int y)
        {

            Console.WriteLine(x+y);
        }
    }
}
