using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("三位数中：");
            for (int i = 100; i <= 999; ++i)
            {
                if (num(i) == true)
                {
                    Console.Write("{0}是水仙花数   ", i);
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey(false);
        }
        static bool num(int number)
        {
            int d3 = number / 100;
            int d2 = number % 100 / 10;
            int d1 = number % 100 % 10;
            int N = d3 * d3 * d3 + d2 * d2 * d2 + d1 * d1 * d1;
            if (number == N)
            {
                return true;
            }
            return false;
        }
    }
}
