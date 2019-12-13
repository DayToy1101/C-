using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_8
{
    class program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 30, 6, 1, 12, 45, 22 };
            int index = 0;
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {

                if (a[i] > max)
                {
                    max = a[i];
                    index = i;
                }
            }

            Console.WriteLine(a[index] + " " + index);
            Console.ReadLine();
        }
    }

}
