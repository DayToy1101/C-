namespace KTV
{
    partial class frmMusicinfo
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
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntOpen = new System.Windows.Forms.Button();
            this.txtMusic_name = new System.Windows.Forms.TextBox();
            this.cmbMusic_author = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMusic_Kind = new System.Windows.Forms.ComboBox();
            this.txtMusic_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMusic_chinse = new System.Windows.Forms.ComboBox();
            this.txtMusic_filepath = new System.Windows.Forms.TextBox();
            this.txtMusic_Ping = new System.Windows.Forms.TextBox();
            this.openPath = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(82, 330);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(104, 33);
            this.bntAdd.TabIndex = 0;
            this.bntAdd.Text = "添加/修改";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntOpen
            // 
            this.bntOpen.Location = new System.Drawing.Point(528, 330);
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(84, 33);
            this.bntOpen.TabIndex = 1;
            this.bntOpen.Text = "歌曲来源";
            this.bntOpen.UseVisualStyleBackColor = true;
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // txtMusic_name
            // 
            this.txtMusic_name.Location = new System.Drawing.Point(164, 46);
            this.txtMusic_name.Name = "txtMusic_name";
            this.txtMusic_name.Size = new System.Drawing.Size(164, 25);
            this.txtMusic_name.TabIndex = 2;
            this.txtMusic_name.TextChanged += new System.EventHandler(this.txtMusic_name_TextChanged);
            // 
            // cmbMusic_author
            // 
            this.cmbMusic_author.FormattingEnabled = true;
            this.cmbMusic_author.Location = new System.Drawing.Point(447, 46);
            this.cmbMusic_author.Name = "cmbMusic_author";
            this.cmbMusic_author.Size = new System.Drawing.Size(165, 23);
            this.cmbMusic_author.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "歌手：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "歌曲类型：";
            // 
            // cmbMusic_Kind
            // 
            this.cmbMusic_Kind.FormattingEnabled = true;
            this.cmbMusic_Kind.Location = new System.Drawing.Point(164, 119);
            this.cmbMusic_Kind.Name = "cmbMusic_Kind";
            this.cmbMusic_Kind.Size = new System.Drawing.Size(164, 23);
            this.cmbMusic_Kind.TabIndex = 6;
            // 
            // txtMusic_code
            // 
            this.txtMusic_code.Location = new System.Drawing.Point(447, 119);
            this.txtMusic_code.Name = "txtMusic_code";
            this.txtMusic_code.Size = new System.Drawing.Size(165, 25);
            this.txtMusic_code.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "歌曲编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "歌曲名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "歌曲语言：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "歌曲路径：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "拼音缩写：";
            // 
            // cmbMusic_chinse
            // 
            this.cmbMusic_chinse.FormattingEnabled = true;
            this.cmbMusic_chinse.Location = new System.Drawing.Point(164, 182);
            this.cmbMusic_chinse.Name = "cmbMusic_chinse";
            this.cmbMusic_chinse.Size = new System.Drawing.Size(164, 23);
            this.cmbMusic_chinse.TabIndex = 14;
            // 
            // txtMusic_filepath
            // 
            this.txtMusic_filepath.Location = new System.Drawing.Point(447, 182);
            this.txtMusic_filepath.Name = "txtMusic_filepath";
            this.txtMusic_filepath.Size = new System.Drawing.Size(165, 25);
            this.txtMusic_filepath.TabIndex = 15;
            // 
            // txtMusic_Ping
            // 
            this.txtMusic_Ping.Location = new System.Drawing.Point(164, 227);
            this.txtMusic_Ping.Name = "txtMusic_Ping";
            this.txtMusic_Ping.Size = new System.Drawing.Size(164, 25);
            this.txtMusic_Ping.TabIndex = 16;
            // 
            // openPath
            // 
            this.openPath.FileName = "openFileDialog1";
            // 
            // frmMusicinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 427);
            this.Controls.Add(this.txtMusic_Ping);
            this.Controls.Add(this.txtMusic_filepath);
            this.Controls.Add(this.cmbMusic_chinse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusic_code);
            this.Controls.Add(this.cmbMusic_Kind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMusic_author);
            this.Controls.Add(this.txtMusic_name);
            this.Controls.Add(this.bntOpen);
            this.Controls.Add(this.bntAdd);
            this.Name = "frmMusicinfo";
            this.Text = "修改歌曲信息";
            this.Load += new System.EventHandler(this.frmMusicinfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntOpen;
        private System.Windows.Forms.TextBox txtMusic_name;
        private System.Windows.Forms.ComboBox cmbMusic_author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMusic_Kind;
        private System.Windows.Forms.TextBox txtMusic_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMusic_chinse;
        private System.Windows.Forms.TextBox txtMusic_filepath;
        private System.Windows.Forms.TextBox txtMusic_Ping;
        private System.Windows.Forms.OpenFileDialog openPath;
    }
}