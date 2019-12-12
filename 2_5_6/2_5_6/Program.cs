using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            int x = Convert.ToInt32(Console.ReadLine());
            //注意得到的只是单个表示
            string t = Convert.ToString(x,16);
            //输出最后结果
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
