﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMIS
{
    public partial class Update : Form
    {
        public static string path;
        public static string info;
        public Update()
        {
            InitializeComponent();
            //path = @"图片\11.jpg"; 
            //pictureBox1.Image=Image.FromFile(path);
        }

        private void mySubBtn_Click(object sender, EventArgs e)
        {
            info = "学号：" + tbxId.Text + "\r\n";
            info += "姓名：" + tbxName.Text + "\r\n";
            info += "\r\n出生日期：" + dateTimePicker1.Text;
            info += "\r\n专     业：" + comboBox1.Text;
            foreach (Control control in gbxSex.Controls)
            {
                if ((control as RadioButton).Checked)
                {
                    info += "性别：" + (control as RadioButton).Text;
                }
            }
            info += "\r\n爱好：";
            foreach (Control control in gbxFavor.Controls)
            {
                if ((control as CheckBox).Checked)
                {
                    info += (control as CheckBox).Text + " ";
                }
            }
            Welcome.browserForm = new Browser();
            Welcome.browserForm.Show();
            this.Opacity = 0;
        }
        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("2012年度校优秀团员");
            listBox1.Items.Add("2012年度一等奖学金");
            listBox1.Items.Insert(2, "2012年度校运动会1000米游泳冠军");
            listBox1.SelectedIndex = 1;
            string msg = string.Format("已添加奖惩记录{0}条", listBox1.Items.Count);
            MessageBox.Show(msg, "提示");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabelNowTime.Text = string.Format("现在时间：{0}", DateTime.Now.ToLongTimeString());
            toolStripProgressBar1.PerformStep();
            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
            }
        }

        private void myOpenPictureBtn_Click(object sender, EventArgs e)
        {
            // 设置文件对话框显示的初始目录
            this.openFileDialog1.InitialDirectory = @"D:\My Documents\My Pictures";
            // 设置当前选定筛选器字符串以决定对话框中"文档类型"选项
            this.openFileDialog1.Filter = "bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif|jpeg文件(*.jpg)|*.jpg";
            // 设置对话框中当前选定筛选器的索引
            this.openFileDialog1.FilterIndex = 3;
            // 关闭对话框，还原当前的目录
            this.openFileDialog1.RestoreDirectory = true;
            // 设置对话框的标题
            this.openFileDialog1.Title = "选择学生照片";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = this.openFileDialog1.FileName;        			// 获取文件路径
            }
            pictureBox1.Image = Image.FromFile(path);          
        }

    }
}
