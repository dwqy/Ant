using System;

namespace _1_10for语句
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 运行顺序 int i =0 ,i<10 输出i i++ i<10 输出i i++ ....
             * 
             * 
             * 
             * 
             */
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            Print99();

            Console.ReadKey();
        }
        static void Print99() {
            /*
             * 1*1
             * 1*2  2*2
             * 1*3  2*3 3*3
             * 1*4  2*4 3*4
             * 1*5  2*5 3*5
             * 1*6  2*6 3*6
             * 1*7  2*7 3*7
             * 1*8  2*8 3*8
             * 1*9  2*9 3*9

             */
            for (int x = 1; x <= 9; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write("{0}*{1}={2} ", y, x, y * x);
                }
                Console.WriteLine();
            }
            
        }
    }
}
