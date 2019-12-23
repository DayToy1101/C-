using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics myGra = this.CreateGraphics();
            //画直线
            Pen myPen1 = new Pen(Color.Red, 2);
            myGra.DrawLine(myPen1, 100, 0, 300, 500);
            //画圆及椭圆
            Pen myPen2 = new Pen(Color.Orange, 2);
            myGra.DrawEllipse(myPen2, 100, 100, 60, 60);
            myGra.DrawEllipse(myPen2, 200, 100, 60, 120);
            //画矩形
            Pen myPen3 = new Pen(Color.Yellow, 3);
            myGra.DrawRectangle(myPen3, 123, 234, 60, 60);
            myGra.DrawRectangle(myPen3, 223, 234, 60, 120);
            //画自定义多边形
            Point[] myPoint = new Point[4];
            myPoint[0].Y = 100;
            myPoint[1].X = 200;
            myPoint[1].Y = 20;
            myPoint[2].X = 300;
            myPoint[2].Y = 100;
            myPoint[3].X = 123;
            myPoint[3].Y = 234;
            Pen myPen20 = new Pen(Color.Aqua);
            myGra.DrawPolygon(myPen20, myPoint);
        }
    }
}
