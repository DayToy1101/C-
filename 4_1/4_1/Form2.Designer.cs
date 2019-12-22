namespace _4_1
{
    partial class MyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_lan = new System.Windows.Forms.RadioButton();
            this.radioButton_lv = new System.Windows.Forms.RadioButton();
            this.radioButton_hong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_zi = new System.Windows.Forms.CheckBox();
            this.checkBox_lan = new System.Windows.Forms.CheckBox();
            this.checkBox_huang = new System.Windows.Forms.CheckBox();
            this.checkBox_lv = new System.Windows.Forms.CheckBox();
            this.checkBox_cheng = new System.Windows.Forms.CheckBox();
            this.checkBox_Hong = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_lan);
            this.groupBox1.Controls.Add(this.radioButton_lv);
            this.groupBox1.Controls.Add(this.radioButton_hong);
            this.groupBox1.Location = new System.Drawing.Point(41, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "背景颜色";
            // 
            // radioButton_lan
            // 
            this.radioButton_lan.AutoSize = true;
            this.radioButton_lan.Location = new System.Drawing.Point(25, 123);
            this.radioButton_lan.Name = "radioButton_lan";
            this.radioButton_lan.Size = new System.Drawing.Size(43, 19);
            this.radioButton_lan.TabIndex = 2;
            this.radioButton_lan.TabStop = true;
            this.radioButton_lan.Text = "蓝";
            this.radioButton_lan.UseVisualStyleBackColor = true;
            this.radioButton_lan.CheckedChanged += new System.EventHandler(this.radioButton_lan_CheckedChanged);
            // 
            // radioButton_lv
            // 
            this.radioButton_lv.AutoSize = true;
            this.radioButton_lv.Location = new System.Drawing.Point(25, 84);
            this.radioButton_lv.Name = "radioButton_lv";
            this.radioButton_lv.Size = new System.Drawing.Size(43, 19);
            this.radioButton_lv.TabIndex = 1;
            this.radioButton_lv.TabStop = true;
            this.radioButton_lv.Text = "绿";
            this.radioButton_lv.UseVisualStyleBackColor = true;
            this.radioButton_lv.CheckedChanged += new System.EventHandler(this.radioButton_lv_CheckedChanged);
            // 
            // radioButton_hong
            // 
            this.radioButton_hong.AutoSize = true;
            this.radioButton_hong.Location = new System.Drawing.Point(25, 45);
            this.radioButton_hong.Name = "radioButton_hong";
            this.radioButton_hong.Size = new System.Drawing.Size(43, 19);
            this.radioButton_hong.TabIndex = 0;
            this.radioButton_hong.TabStop = true;
            this.radioButton_hong.Text = "红";
            this.radioButton_hong.UseVisualStyleBackColor = true;
            this.radioButton_hong.CheckedChanged += new System.EventHandler(this.radioButton_Hong_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_zi);
            this.groupBox2.Controls.Add(this.checkBox_lan);
            this.groupBox2.Controls.Add(this.checkBox_huang);
            this.groupBox2.Controls.Add(this.checkBox_lv);
            this.groupBox2.Controls.Add(this.checkBox_cheng);
            this.groupBox2.Controls.Add(this.checkBox_Hong);
            this.groupBox2.Location = new System.Drawing.Point(223, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "你喜欢的颜色";
            // 
            // checkBox_zi
            // 
            this.checkBox_zi.AutoSize = true;
            this.checkBox_zi.Location = new System.Drawing.Point(112, 122);
            this.checkBox_zi.Name = "checkBox_zi";
            this.checkBox_zi.Size = new System.Drawing.Size(44, 19);
            this.checkBox_zi.TabIndex = 5;
            this.checkBox_zi.Text = "紫";
            this.checkBox_zi.UseVisualStyleBackColor = true;
            this.checkBox_zi.CheckedChanged += new System.EventHandler(this.checkBox_zi_CheckedChanged);
            // 
            // checkBox_lan
            // 
            this.checkBox_lan.AutoSize = true;
            this.checkBox_lan.Location = new System.Drawing.Point(19, 123);
            this.checkBox_lan.Name = "checkBox_lan";
            this.checkBox_lan.Size = new System.Drawing.Size(44, 19);
            this.checkBox_lan.TabIndex = 4;
            this.checkBox_lan.Text = "蓝";
            this.checkBox_lan.UseVisualStyleBackColor = true;
            this.checkBox_lan.CheckedChanged += new System.EventHandler(this.checkBox_lan_CheckedChanged);
            // 
            // checkBox_huang
            // 
            this.checkBox_huang.AutoSize = true;
            this.checkBox_huang.Location = new System.Drawing.Point(112, 85);
            this.checkBox_huang.Name = "checkBox_huang";
            this.checkBox_huang.Size = new System.Drawing.Size(44, 19);
            this.checkBox_huang.TabIndex = 3;
            this.checkBox_huang.Text = "黄";
            this.checkBox_huang.UseVisualStyleBackColor = true;
            this.checkBox_huang.CheckedChanged += new System.EventHandler(this.checkBox_huang_CheckedChanged);
            // 
            // checkBox_lv
            // 
            this.checkBox_lv.AutoSize = true;
            this.checkBox_lv.Location = new System.Drawing.Point(19, 85);
            this.checkBox_lv.Name = "checkBox_lv";
            this.checkBox_lv.Size = new System.Drawing.Size(44, 19);
            this.checkBox_lv.TabIndex = 2;
            this.checkBox_lv.Text = "绿";
            this.checkBox_lv.UseVisualStyleBackColor = true;
            this.checkBox_lv.CheckedChanged += new System.EventHandler(this.checkBox_lv_CheckedChanged);
            // 
            // checkBox_cheng
            // 
            this.checkBox_cheng.AutoSize = true;
            this.checkBox_cheng.Location = new System.Drawing.Point(112, 46);
            this.checkBox_cheng.Name = "checkBox_cheng";
            this.checkBox_cheng.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_cheng.Size = new System.Drawing.Size(44, 19);
            this.checkBox_cheng.TabIndex = 1;
            this.checkBox_cheng.Text = "橙";
            this.checkBox_cheng.UseVisualStyleBackColor = true;
            this.checkBox_cheng.CheckedChanged += new System.EventHandler(this.checkBox_cheng_CheckedChanged);
            // 
            // checkBox_Hong
            // 
            this.checkBox_Hong.AutoSize = true;
            this.checkBox_Hong.Location = new System.Drawing.Point(19, 46);
            this.checkBox_Hong.Name = "checkBox_Hong";
            this.checkBox_Hong.Size = new System.Drawing.Size(44, 19);
            this.checkBox_Hong.TabIndex = 0;
            this.checkBox_Hong.Text = "红";
            this.checkBox_Hong.UseVisualStyleBackColor = true;
            this.checkBox_Hong.CheckedChanged += new System.EventHandler(this.checkBox_Hong_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 247);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(369, 170);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "你喜欢的颜色：";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 510);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyForm";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_lan;
        private System.Windows.Forms.RadioButton radioButton_lv;
        private System.Windows.Forms.RadioButton radioButton_hong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_zi;
        private System.Windows.Forms.CheckBox checkBox_lan;
        private System.Windows.Forms.CheckBox checkBox_huang;
        private System.Windows.Forms.CheckBox checkBox_lv;
        private System.Windows.Forms.CheckBox checkBox_cheng;
        private System.Windows.Forms.CheckBox checkBox_Hong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}