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
            int n = Convert.ToInt32(Console.ReadLine());
            float y = 0;
            for (int i = 1; i <= n; i++)
            {
                float aa = 1;
                for (int j = 1; j <= i; j++)
                {
                    aa = j * aa;
                }
                y += aa;
            }
            Console.WriteLine(n.ToString());
            Console.WriteLine(y.ToString());
            Console.ReadKey();

        }
    }
}



