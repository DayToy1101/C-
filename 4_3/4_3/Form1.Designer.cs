namespace _4_3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Bookname = new System.Windows.Forms.TextBox();
            this.comboBox_Publishing = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.listBox_Book = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入书名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择出版社";
            // 
            // textBox_Bookname
            // 
            this.textBox_Bookname.Location = new System.Drawing.Point(80, 86);
            this.textBox_Bookname.Name = "textBox_Bookname";
            this.textBox_Bookname.Size = new System.Drawing.Size(162, 25);
            this.textBox_Bookname.TabIndex = 2;
            // 
            // comboBox_Publishing
            // 
            this.comboBox_Publishing.FormattingEnabled = true;
            this.comboBox_Publishing.Items.AddRange(new object[] {
            "清华大学出版社",
            "电子工业出版社",
            "中国电力出版社",
            "机械工业出版社",
            "人民邮电出版社"});
            this.comboBox_Publishing.Location = new System.Drawing.Point(80, 177);
            this.comboBox_Publishing.Name = "comboBox_Publishing";
            this.comboBox_Publishing.Size = new System.Drawing.Size(162, 23);
            this.comboBox_Publishing.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(52, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Remove);
            this.groupBox2.Controls.Add(this.button_Add);
            this.groupBox2.Location = new System.Drawing.Point(285, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 179);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(21, 38);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "添加>>";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(21, 116);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 1;
            this.button_Remove.Text = "移出<<";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // listBox_Book
            // 
            this.listBox_Book.FormattingEnabled = true;
            this.listBox_Book.ItemHeight = 15;
            this.listBox_Book.Location = new System.Drawing.Point(419, 58);
            this.listBox_Book.Name = "listBox_Book";
            this.listBox_Book.Size = new System.Drawing.Size(183, 169);
            this.listBox_Book.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 351);
            this.Controls.Add(this.listBox_Book);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox_Publishing);
            this.Controls.Add(this.textBox_Bookname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Bookname;
        private System.Windows.Forms.ComboBox comboBox_Publishing;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ListBox listBox_Book;
    }
}

