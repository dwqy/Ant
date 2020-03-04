using System;

namespace _1_13类与对象
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 类和对象
             * 类就是模板 对象是实体
             * 类的属性和方法  （颜色是属性，启动时方法）
             */
            Student stu = new Student();
            stu.name = "123";
            Console.WriteLine(stu.name);
            Console.Read();
        }
    }
    /// <summary>
    /// 手动创建一个类 
    /// 类的修饰符 public
    /// </summary>
    class Student {
        public string name = "校长";
    }
}
