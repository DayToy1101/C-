using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a=1, b=1, c=1, d;
            while (a <= 4)
            {
                a++;
               while (b<=4)
               {
                   while  (c <= 4)
                   {
                       if (a != b && a != c&& b != c)
                       {
                           d = 10 - a - b - c;
                           if ((c == 1 ^ b == 2) && (c == 2 ^ d == 3) && (a == 2 ^ d == 4))
                           {
                               Console.WriteLine("红球放置在{0}号，黄球放置在{1}号,黑球放置在{0}号，白球放置在{1}号，", a,b,c, d);
                           }
                       }
                       c++;
                       Console.Read();
                   }
                   b++;
                }
            }
        }
    }
}
