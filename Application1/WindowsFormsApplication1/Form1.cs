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
            int a, b, c, d;
            for (a = 1; a <= 4; a++)
            {
                for (b = 1; b <= 4; b++)
                {
                    for (c = 1; c <= 4; c++)
                    {
                        if (a != b && a != c && b != c)
                        {
                            d = 10 - a - b - c;
                            if ((c == 1 ^ b == 2) && (c == 2 ^ d == 3) && (a == 2 ^ d == 4))
                            {
                                Console.Write("红球放置在{0}号，黄球放置在{1}号,", a, b);
                                Console.WriteLine("黑球放置在{0}号，白球放置在{1}号，", c, d);
                            }
                        }
                        Console.Read();
                    }


                }
            }
        }
    }
}
