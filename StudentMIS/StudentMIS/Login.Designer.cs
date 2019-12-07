namespace StudentMIS
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUsr = new System.Windows.Forms.TextBox();
            this.tbxPwd = new System.Windows.Forms.TextBox();
            this.myCancelBtn = new System.Windows.Forms.Button();
            this.myDfaultBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            // 
            // tbxUsr
            // 
            this.tbxUsr.Location = new System.Drawing.Point(144, 58);
            this.tbxUsr.Name = "tbxUsr";
            this.tbxUsr.Size = new System.Drawing.Size(167, 25);
            this.tbxUsr.TabIndex = 2;
            // 
            // tbxPwd
            // 
            this.tbxPwd.Location = new System.Drawing.Point(144, 103);
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.PasswordChar = '*';
            this.tbxPwd.Size = new System.Drawing.Size(167, 25);
            this.tbxPwd.TabIndex = 3;
            // 
            // myCancelBtn
            // 
            this.myCancelBtn.Location = new System.Drawing.Point(235, 219);
            this.myCancelBtn.Name = "myCancelBtn";
            this.myCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.myCancelBtn.TabIndex = 5;
            this.myCancelBtn.Text = "重写";
            this.myCancelBtn.UseVisualStyleBackColor = true;
            this.myCancelBtn.Click += new System.EventHandler(this.myCancelBtn_Click);
            // 
            // myDfaultBtn
            // 
            this.myDfaultBtn.Location = new System.Drawing.Point(74, 218);
            this.myDfaultBtn.Name = "myDfaultBtn";
            this.myDfaultBtn.Size = new System.Drawing.Size(75, 23);
            this.myDfaultBtn.TabIndex = 6;
            this.myDfaultBtn.Text = "登录";
            this.myDfaultBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.myDfaultBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 461);
            this.Controls.Add(this.myDfaultBtn);
            this.Controls.Add(this.myCancelBtn);
            this.Controls.Add(this.tbxPwd);
            this.Controls.Add(this.tbxUsr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUsr;
        private System.Windows.Forms.TextBox tbxPwd;
        private System.Windows.Forms.Button myCancelBtn;
        private System.Windows.Forms.Button myDfaultBtn;
    }
}