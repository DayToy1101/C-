using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2_5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();//定义一个动态数组
            String s = Console.ReadLine();
            int num = 0;
            Boolean b = false;   //b用来判断上一个字符是否为数字
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)(s[i]) >= 48 && (int)(s[i]) <= 58)//判断是否为数字
                {
                    b = true;
                    num = num * 10 + s[i] - 48;
                }
                else if (b)  //此处表示当前字符为字母 上一个为数字 就把前面数字放入数组并且num置零
                {
                    a.Add(num);
                    b = false;
                    num = 0;
                }
                if ((int)(s[i]) >= 48 && (int)(s[i]) <= 58 && i == s.Length - 1)//如果最后一个字符为数字 前面程序没把num放入数组
                {
                    a.Add(num);
                }
            }
            Console.WriteLine(a.Count);
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}

