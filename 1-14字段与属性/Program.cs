using System;

namespace _1_14字段与属性
{
    class Program
    {
        static void Main(string[] args)
        {
            //控制访问  get和set可以 
            Student s1 = new Student();
            s1.PhoneNumber = 172;
            Console.WriteLine(s1.PhoneNumber);


            //防止非法数据

            s1.Age = -1;
            Console.WriteLine(s1.Age);
            Console.ReadLine();
        }
    }
    class Student {
        private string name;  //camel 驼峰命名
        private int age;
        public string Name {  //pascal命名
            get { return name; }
            set { name = value; }
        }


        public int Age {
            get { return age;}
            set {
                if (value >= 0 && value<=18)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
           
        }

        //自动属性.net 3.0及以后出现
        public int PhoneNumber { set; get; }
    }
}
