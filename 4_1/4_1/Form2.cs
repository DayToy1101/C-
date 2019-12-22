using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_1
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_Hong_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_hong.Checked == true)
                this.BackColor = Color.Red;
        }

        private void radioButton_lv_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_lv.Checked == true)
                this.BackColor = Color.Green;
        }

        private void radioButton_lan_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_lan.Checked == true)
                this.BackColor = Color.Blue;
        }

        private void checkBox_Hong_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Hong.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox_Hong.Text + ",";
        }

        private void checkBox_lv_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_lv.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox_lv.Text + ",";
        }

        private void checkBox_lan_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_lan.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox_lan.Text + ",";
        }

        private void checkBox_cheng_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_cheng.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox_cheng.Text + ",";
        }

        private void checkBox_huang_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_huang.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox_huang.Text + ",";
        }

        private void checkBox_zi_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_zi.Checked == true)
                this.textBox1.Text = textBox1.Text + checkBox_zi.Text + ",";
        }


    }
}
