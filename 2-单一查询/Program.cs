using System;
using System.Data.SqlClient;
namespace _2_单一查询
{
    class Program
    {
        private static readonly string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=stu;Integrated Security=True";

        static void Main(string[] args)
        {
            /*
             * 1复习上节  列和行   
             *  列是字段
             *  行是一个实体
             * 2复习创建student表
             * 3主键
             * 4字符类型
             *  char     ansi
             *  nchar       unicode
             *  varchar    可变 ansi
             *  nvarchar     可变unicode
             * 5ADO.NET 用于和数据库交互的面象对象类库
             *  connection commond DataReader
             *  connection commond datatable和dataset
             *  
             *  
             *  vs内置的查询中文需要在前面加N
             *  
             *  /
             */
            SqlConnection conn = new SqlConnection(connString);
            string sql = "select * from students";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            object result = cmd.ExecuteScalar();
            conn.Close();
            Console.WriteLine(result.ToString());

            Console.WriteLine("Hello World!");
        }
    }
}
