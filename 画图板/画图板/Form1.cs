using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 画图板
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point pStart, pEnd;
        int ChoiceGraph;
        int penWidth;
        enum mySelected
        {
            Pencil,          	// 铅笔
            Line,            	// 直线
            Ellipse,         	// 空心椭圆
            FillEllipse,       	// 填充椭圆
            Rec,             	// 空心矩形
            FillRec,         	// 填充矩形
            Eraser          	// 橡皮擦
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnLine1_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度
        }

        private void btnLine2_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度
        }

        private void btnLine3_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度
        }

        private void btnLine4_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度
        }

        private void btnLine5_Click(object sender, EventArgs e)
        {
            //把所有按钮的背景色都设为 White
            btnLine1.BackColor = Color.White;
            btnLine2.BackColor = Color.White;
            btnLine3.BackColor = Color.White;
            btnLine4.BackColor = Color.White;
            btnLine5.BackColor = Color.White;
            ((Button)sender).BackColor = Color.Black;          // 选中的按钮背景色为黑色
            penWidth = Convert.ToInt32(((Button)sender).Tag);   // 将宽度按钮的 Tag 值设为画笔宽度
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.pictureBox1.CreateGraphics();
            ChoiceGraph = (int)mySelected.Pencil;    		// 默认选择为铅笔工具
            penWidth = 3;          	 			// 初始化画笔宽度
            btnControl.BackColor = btnBlack.BackColor;  	// 默认黑色笔
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();			// 刷新
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();					// 关闭
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)        // 如果单击鼠标左键，则将当前点坐标赋给起始点
            {
                pStart.X = e.X;
                pStart.Y = e.Y;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "X:" + e.X.ToString() + ",Y:" + e.Y.ToString();

            if (e.Button == MouseButtons.Left)
            {
                switch (ChoiceGraph)
                {
                    case (int)mySelected.Pencil:       	 			// 选择的是铅笔
                        Pen pen1 = new Pen(btnControl.BackColor, penWidth);
                        pEnd.X = e.X;
                        pEnd.Y = e.Y;
                        g.DrawLine(pen1, pStart, pEnd);
                        pStart = pEnd;      				// 将已经绘制的终点作为下一次绘制的起点
                        break;
                    case (int)mySelected.Eraser:
                        Pen pen2 = new Pen(Color.White, penWidth);   		// 定义白色画笔作为擦除效果
                        pEnd.X = e.X;
                        pEnd.Y = e.Y;
                        g.DrawLine(pen2, pStart, pEnd);
                        pStart = pEnd;   					// 将已经绘制的终点作为下一次绘制的起点
                        break;
                    default:
                        break;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnFillEllipse_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnFillRec_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            ChoiceGraph = Convert.ToInt32(((Button)sender).Tag);
        }
        private void Change_Point()
        {
            Point pTemp = new Point();			// 定义临时点
            if (pStart.X < pEnd.X)
            {
                if (pStart.Y > pEnd.Y)
                {
                    pTemp.Y = pStart.Y;
                    pStart.Y = pEnd.Y;
                    pEnd.Y = pTemp.Y;
                }
            }
            if (pStart.X > pEnd.X)
            {
                if (pStart.Y < pEnd.Y)
                {
                    pTemp.X = pStart.X;
                    pStart.X = pEnd.X;
                    pEnd.X = pTemp.X;
                }
                if (pStart.Y > pEnd.Y)
                {
                    pTemp = pStart;
                    pStart = pEnd;
                    pEnd = pTemp;
                }
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "C")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnControl.BackColor = colorDialog1.Color;
                }
            }
            else
            {

                btnControl.BackColor = ((Button)sender).BackColor;
            }
        }
    }
}
