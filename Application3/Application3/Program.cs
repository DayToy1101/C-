using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("请输入一个四位整数：");
            String s = Console.ReadLine();
            int num = Convert.ToInt32(s);
            int[] each = new int[4];
            int max, min, i, j, temp;
            while (num != 6174 && num != 0) {
                i = 0;
                while (num != 0) {
                    each[i++] = num % 10;
                    num = num / 10;

                }
                for (i = 0; i < 3; i++) {
                    for (j= 0; j < 3-i; j++) {
                        if (each[j] > each[j + 1])
                        {
                            temp=each[j];
                            each[j] = each[j + 1];
                            each[j + 1] = temp;
                        }

                    }
                }
                max = each[0] * 1 + each[1] * 10 + each[2] * 100 + each[3] * 1000;
                min = each[0] * 1000 + each[1] * 100+ each[2] * 10 + each[3] * 1;
                num = max - min;
                Console.WriteLine("{0}-{1}={2}", max, min, num);
               // MessageBox.Show(Convert.ToString(max), Convert.ToString(min));
            }
            Console.Read();
        }
    }
        }
    

