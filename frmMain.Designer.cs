namespace KTV
{
    partial class frmMain
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.bntExit = new System.Windows.Forms.Button();
            this.bntAut = new System.Windows.Forms.Button();
            this.bntAuUpdate = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntMuserAdd = new System.Windows.Forms.Button();
            this.bntMuserUpdate = new System.Windows.Forms.Button();
            this.bntMuserDelete = new System.Windows.Forms.Button();
            this.bntKindAdd = new System.Windows.Forms.Button();
            this.bntKindUpdate = new System.Windows.Forms.Button();
            this.bntKindDelete = new System.Windows.Forms.Button();
            this.bntUserAdd = new System.Windows.Forms.Button();
            this.bntUserUpdate = new System.Windows.Forms.Button();
            this.bntUserDelete = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LvDitcy = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LvMuscie = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LvUser = new System.Windows.Forms.ListView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.LvAuton = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(305, 187);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(216, 25);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(305, 115);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(216, 25);
            this.txtPassWord.TabIndex = 1;
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(198, 345);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(75, 30);
            this.bntExit.TabIndex = 2;
            this.bntExit.Text = "关闭";
            this.bntExit.UseVisualStyleBackColor = true;
            // 
            // bntAut
            // 
            this.bntAut.Location = new System.Drawing.Point(6, 6);
            this.bntAut.Name = "bntAut";
            this.bntAut.Size = new System.Drawing.Size(75, 23);
            this.bntAut.TabIndex = 3;
            this.bntAut.Text = "添加";
            this.bntAut.UseVisualStyleBackColor = true;
            this.bntAut.Click += new System.EventHandler(this.bntAut_Click);
            // 
            // bntAuUpdate
            // 
            this.bntAuUpdate.Location = new System.Drawing.Point(153, 6);
            this.bntAuUpdate.Name = "bntAuUpdate";
            this.bntAuUpdate.Size = new System.Drawing.Size(75, 23);
            this.bntAuUpdate.TabIndex = 4;
            this.bntAuUpdate.Text = "修改";
            this.bntAuUpdate.UseVisualStyleBackColor = true;
            this.bntAuUpdate.Click += new System.EventHandler(this.bntAuUpdate_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(295, 6);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 5;
            this.bntDelete.Text = "删除";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntMuserAdd
            // 
            this.bntMuserAdd.Location = new System.Drawing.Point(10, 6);
            this.bntMuserAdd.Name = "bntMuserAdd";
            this.bntMuserAdd.Size = new System.Drawing.Size(75, 23);
            this.bntMuserAdd.TabIndex = 6;
            this.bntMuserAdd.Text = "添加";
            this.bntMuserAdd.UseVisualStyleBackColor = true;
            this.bntMuserAdd.Click += new System.EventHandler(this.bntMuserAdd_Click);
            // 
            // bntMuserUpdate
            // 
            this.bntMuserUpdate.Location = new System.Drawing.Point(145, 6);
            this.bntMuserUpdate.Name = "bntMuserUpdate";
            this.bntMuserUpdate.Size = new System.Drawing.Size(75, 23);
            this.bntMuserUpdate.TabIndex = 7;
            this.bntMuserUpdate.Text = "修改";
            this.bntMuserUpdate.UseVisualStyleBackColor = true;
            this.bntMuserUpdate.Click += new System.EventHandler(this.bntMuserUpdate_Click);
            // 
            // bntMuserDelete
            // 
            this.bntMuserDelete.Location = new System.Drawing.Point(280, 6);
            this.bntMuserDelete.Name = "bntMuserDelete";
            this.bntMuserDelete.Size = new System.Drawing.Size(75, 23);
            this.bntMuserDelete.TabIndex = 8;
            this.bntMuserDelete.Text = "删除";
            this.bntMuserDelete.UseVisualStyleBackColor = true;
            this.bntMuserDelete.Click += new System.EventHandler(this.bntMuserDelete_Click);
            // 
            // bntKindAdd
            // 
            this.bntKindAdd.Location = new System.Drawing.Point(10, 6);
            this.bntKindAdd.Name = "bntKindAdd";
            this.bntKindAdd.Size = new System.Drawing.Size(75, 23);
            this.bntKindAdd.TabIndex = 9;
            this.bntKindAdd.Text = "添加";
            this.bntKindAdd.UseVisualStyleBackColor = true;
            // 
            // bntKindUpdate
            // 
            this.bntKindUpdate.Location = new System.Drawing.Point(153, 6);
            this.bntKindUpdate.Name = "bntKindUpdate";
            this.bntKindUpdate.Size = new System.Drawing.Size(75, 23);
            this.bntKindUpdate.TabIndex = 10;
            this.bntKindUpdate.Text = "修改";
            this.bntKindUpdate.UseVisualStyleBackColor = true;
            // 
            // bntKindDelete
            // 
            this.bntKindDelete.Location = new System.Drawing.Point(294, 6);
            this.bntKindDelete.Name = "bntKindDelete";
            this.bntKindDelete.Size = new System.Drawing.Size(75, 23);
            this.bntKindDelete.TabIndex = 11;
            this.bntKindDelete.Text = "删除";
            this.bntKindDelete.UseVisualStyleBackColor = true;
            // 
            // bntUserAdd
            // 
            this.bntUserAdd.Location = new System.Drawing.Point(10, 6);
            this.bntUserAdd.Name = "bntUserAdd";
            this.bntUserAdd.Size = new System.Drawing.Size(75, 23);
            this.bntUserAdd.TabIndex = 12;
            this.bntUserAdd.Text = "添加";
            this.bntUserAdd.UseVisualStyleBackColor = true;
            this.bntUserAdd.Click += new System.EventHandler(this.bntUserAdd_Click);
            // 
            // bntUserUpdate
            // 
            this.bntUserUpdate.Location = new System.Drawing.Point(156, 6);
            this.bntUserUpdate.Name = "bntUserUpdate";
            this.bntUserUpdate.Size = new System.Drawing.Size(75, 23);
            this.bntUserUpdate.TabIndex = 13;
            this.bntUserUpdate.Text = "修改";
            this.bntUserUpdate.UseVisualStyleBackColor = true;
            this.bntUserUpdate.Click += new System.EventHandler(this.bntUserUpdate_Click);
            // 
            // bntUserDelete
            // 
            this.bntUserDelete.Location = new System.Drawing.Point(303, 6);
            this.bntUserDelete.Name = "bntUserDelete";
            this.bntUserDelete.Size = new System.Drawing.Size(75, 23);
            this.bntUserDelete.TabIndex = 14;
            this.bntUserDelete.Text = "删除";
            this.bntUserDelete.UseVisualStyleBackColor = true;
            this.bntUserDelete.Click += new System.EventHandler(this.bntUserDelete_Click);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(446, 345);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(75, 30);
            this.bntSave.TabIndex = 15;
            this.bntSave.Text = "保存";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 494);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtUser);
            this.tabPage2.Controls.Add(this.bntSave);
            this.tabPage2.Controls.Add(this.txtPassWord);
            this.tabPage2.Controls.Add(this.bntExit);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "管理员权限";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "登录密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "登录用户：";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LvDitcy);
            this.tabPage1.Controls.Add(this.bntKindAdd);
            this.tabPage1.Controls.Add(this.bntKindDelete);
            this.tabPage1.Controls.Add(this.bntKindUpdate);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 465);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "歌曲类型信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LvDitcy
            // 
            this.LvDitcy.FullRowSelect = true;
            this.LvDitcy.Location = new System.Drawing.Point(10, 35);
            this.LvDitcy.MultiSelect = false;
            this.LvDitcy.Name = "LvDitcy";
            this.LvDitcy.Size = new System.Drawing.Size(905, 424);
            this.LvDitcy.TabIndex = 12;
            this.LvDitcy.UseCompatibleStateImageBehavior = false;
            this.LvDitcy.View = System.Windows.Forms.View.Details;
            this.LvDitcy.Click += new System.EventHandler(this.LvDitcy_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LvMuscie);
            this.tabPage3.Controls.Add(this.bntMuserAdd);
            this.tabPage3.Controls.Add(this.bntMuserDelete);
            this.tabPage3.Controls.Add(this.bntMuserUpdate);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(924, 465);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "歌曲信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LvMuscie
            // 
            this.LvMuscie.FullRowSelect = true;
            this.LvMuscie.Location = new System.Drawing.Point(10, 35);
            this.LvMuscie.MultiSelect = false;
            this.LvMuscie.Name = "LvMuscie";
            this.LvMuscie.Size = new System.Drawing.Size(905, 424);
            this.LvMuscie.TabIndex = 9;
            this.LvMuscie.UseCompatibleStateImageBehavior = false;
            this.LvMuscie.View = System.Windows.Forms.View.Details;
            this.LvMuscie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvMuscie_MouseClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.LvUser);
            this.tabPage4.Controls.Add(this.bntUserAdd);
            this.tabPage4.Controls.Add(this.bntUserDelete);
            this.tabPage4.Controls.Add(this.bntUserUpdate);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(924, 465);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "用户信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LvUser
            // 
            this.LvUser.FullRowSelect = true;
            this.LvUser.Location = new System.Drawing.Point(7, 35);
            this.LvUser.MultiSelect = false;
            this.LvUser.Name = "LvUser";
            this.LvUser.Size = new System.Drawing.Size(908, 424);
            this.LvUser.TabIndex = 15;
            this.LvUser.UseCompatibleStateImageBehavior = false;
            this.LvUser.View = System.Windows.Forms.View.Details;
            this.LvUser.Click += new System.EventHandler(this.LvUser_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.LvAuton);
            this.tabPage5.Controls.Add(this.bntAut);
            this.tabPage5.Controls.Add(this.bntDelete);
            this.tabPage5.Controls.Add(this.bntAuUpdate);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(924, 465);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "明星信息";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // LvAuton
            // 
            this.LvAuton.FullRowSelect = true;
            this.LvAuton.Location = new System.Drawing.Point(7, 35);
            this.LvAuton.MultiSelect = false;
            this.LvAuton.Name = "LvAuton";
            this.LvAuton.Size = new System.Drawing.Size(908, 424);
            this.LvAuton.TabIndex = 6;
            this.LvAuton.UseCompatibleStateImageBehavior = false;
            this.LvAuton.View = System.Windows.Forms.View.Details;
            this.LvAuton.Click += new System.EventHandler(this.LvAuton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "后台数据维护";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.Button bntAut;
        private System.Windows.Forms.Button bntAuUpdate;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntMuserAdd;
        private System.Windows.Forms.Button bntMuserUpdate;
        private System.Windows.Forms.Button bntMuserDelete;
        private System.Windows.Forms.Button bntKindAdd;
        private System.Windows.Forms.Button bntKindUpdate;
        private System.Windows.Forms.Button bntKindDelete;
        private System.Windows.Forms.Button bntUserAdd;
        private System.Windows.Forms.Button bntUserUpdate;
        private System.Windows.Forms.Button bntUserDelete;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView LvDitcy;
        public System.Windows.Forms.ListView LvMuscie;
        public System.Windows.Forms.ListView LvUser;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.ListView LvAuton;
    }
}