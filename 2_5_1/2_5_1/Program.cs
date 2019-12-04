using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//斐波那契
namespace ConsoleApplicationLesson_4_feibonaqi
{
    class Program
    {

        public int[] GetData()
        {
            int num = 0;
            int[] array = new int[20];
            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i < 20; i++)
            {
                array[i] = array[i - 1] + array[i - 2];

            }
            foreach (int u in array)
            {
                Console.Write(u + ",");
                num++;
                if (num == 5)
                {
                    Console.WriteLine();
                    num = 0;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Program st = new Program();

            st.GetData();

            Console.ReadLine();

        }
    }
}
