namespace KTV
{
    partial class frmAuton
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
            this.txtauthorId = new System.Windows.Forms.TextBox();
            this.txtauthorName = new System.Windows.Forms.TextBox();
            this.txtauthorRecma = new System.Windows.Forms.TextBox();
            this.txtauthorzjm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbauthorSex = new System.Windows.Forms.ComboBox();
            this.cmbGuouji = new System.Windows.Forms.ComboBox();
            this.cmbauthorcompany = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bntSure = new System.Windows.Forms.Button();
            this.bntEsce = new System.Windows.Forms.Button();
            this.daAuthorbirthday = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtauthorId
            // 
            this.txtauthorId.Enabled = false;
            this.txtauthorId.Location = new System.Drawing.Point(138, 74);
            this.txtauthorId.MaxLength = 10;
            this.txtauthorId.Name = "txtauthorId";
            this.txtauthorId.Size = new System.Drawing.Size(192, 25);
            this.txtauthorId.TabIndex = 0;
            // 
            // txtauthorName
            // 
            this.txtauthorName.Location = new System.Drawing.Point(138, 135);
            this.txtauthorName.MaxLength = 20;
            this.txtauthorName.Name = "txtauthorName";
            this.txtauthorName.Size = new System.Drawing.Size(192, 25);
            this.txtauthorName.TabIndex = 1;
            this.txtauthorName.TextChanged += new System.EventHandler(this.txtauthorName_TextChanged);
            // 
            // txtauthorRecma
            // 
            this.txtauthorRecma.Location = new System.Drawing.Point(138, 208);
            this.txtauthorRecma.MaxLength = 50;
            this.txtauthorRecma.Name = "txtauthorRecma";
            this.txtauthorRecma.Size = new System.Drawing.Size(192, 25);
            this.txtauthorRecma.TabIndex = 2;
            // 
            // txtauthorzjm
            // 
            this.txtauthorzjm.Enabled = false;
            this.txtauthorzjm.Location = new System.Drawing.Point(138, 284);
            this.txtauthorzjm.MaxLength = 20;
            this.txtauthorzjm.Name = "txtauthorzjm";
            this.txtauthorzjm.Size = new System.Drawing.Size(192, 25);
            this.txtauthorzjm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "明星编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "明星姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "明星备注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "拼音缩写：";
            // 
            // cmbauthorSex
            // 
            this.cmbauthorSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbauthorSex.FormattingEnabled = true;
            this.cmbauthorSex.Location = new System.Drawing.Point(443, 74);
            this.cmbauthorSex.Name = "cmbauthorSex";
            this.cmbauthorSex.Size = new System.Drawing.Size(200, 23);
            this.cmbauthorSex.TabIndex = 8;
            // 
            // cmbGuouji
            // 
            this.cmbGuouji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuouji.FormattingEnabled = true;
            this.cmbGuouji.Location = new System.Drawing.Point(443, 137);
            this.cmbGuouji.Name = "cmbGuouji";
            this.cmbGuouji.Size = new System.Drawing.Size(200, 23);
            this.cmbGuouji.TabIndex = 9;
            // 
            // cmbauthorcompany
            // 
            this.cmbauthorcompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbauthorcompany.FormattingEnabled = true;
            this.cmbauthorcompany.Location = new System.Drawing.Point(443, 210);
            this.cmbauthorcompany.Name = "cmbauthorcompany";
            this.cmbauthorcompany.Size = new System.Drawing.Size(200, 23);
            this.cmbauthorcompany.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "明星性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "明星国籍：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "明星类型：";
            // 
            // bntSure
            // 
            this.bntSure.Location = new System.Drawing.Point(488, 352);
            this.bntSure.Name = "bntSure";
            this.bntSure.Size = new System.Drawing.Size(75, 23);
            this.bntSure.TabIndex = 14;
            this.bntSure.Text = "确定";
            this.bntSure.UseVisualStyleBackColor = true;
            this.bntSure.Click += new System.EventHandler(this.bntSure_Click);
            // 
            // bntEsce
            // 
            this.bntEsce.Location = new System.Drawing.Point(361, 351);
            this.bntEsce.Name = "bntEsce";
            this.bntEsce.Size = new System.Drawing.Size(75, 23);
            this.bntEsce.TabIndex = 15;
            this.bntEsce.Text = "取消";
            this.bntEsce.UseVisualStyleBackColor = true;
            this.bntEsce.Click += new System.EventHandler(this.bntEsce_Click);
            // 
            // daAuthorbirthday
            // 
            this.daAuthorbirthday.Location = new System.Drawing.Point(443, 266);
            this.daAuthorbirthday.Name = "daAuthorbirthday";
            this.daAuthorbirthday.Size = new System.Drawing.Size(200, 25);
            this.daAuthorbirthday.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "明星生日：";
            // 
            // frmAuton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 457);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.daAuthorbirthday);
            this.Controls.Add(this.bntEsce);
            this.Controls.Add(this.bntSure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbauthorcompany);
            this.Controls.Add(this.cmbGuouji);
            this.Controls.Add(this.cmbauthorSex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtauthorzjm);
            this.Controls.Add(this.txtauthorRecma);
            this.Controls.Add(this.txtauthorName);
            this.Controls.Add(this.txtauthorId);
            this.Name = "frmAuton";
            this.Text = "添加明星信息";
            this.Load += new System.EventHandler(this.frmAuton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtauthorId;
        private System.Windows.Forms.TextBox txtauthorName;
        private System.Windows.Forms.TextBox txtauthorRecma;
        private System.Windows.Forms.TextBox txtauthorzjm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbauthorSex;
        private System.Windows.Forms.ComboBox cmbGuouji;
        private System.Windows.Forms.ComboBox cmbauthorcompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntSure;
        private System.Windows.Forms.Button bntEsce;
        private System.Windows.Forms.DateTimePicker daAuthorbirthday;
        private System.Windows.Forms.Label label8;
    }
}