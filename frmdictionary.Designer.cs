namespace KTV
{
    partial class frmdictionary
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
            this.bntOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodName = new System.Windows.Forms.TextBox();
            this.txtcodeReam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEsce = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(415, 205);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(75, 23);
            this.bntOK.TabIndex = 0;
            this.bntOK.Text = "确认";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "类型编号：";
            // 
            // txtcodeID
            // 
            this.txtcodeID.Location = new System.Drawing.Point(352, 51);
            this.txtcodeID.Name = "txtcodeID";
            this.txtcodeID.Size = new System.Drawing.Size(138, 25);
            this.txtcodeID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "类型名称：";
            // 
            // txtcodName
            // 
            this.txtcodName.Location = new System.Drawing.Point(127, 51);
            this.txtcodName.Name = "txtcodName";
            this.txtcodName.Size = new System.Drawing.Size(131, 25);
            this.txtcodName.TabIndex = 5;
            // 
            // txtcodeReam
            // 
            this.txtcodeReam.Location = new System.Drawing.Point(127, 120);
            this.txtcodeReam.Name = "txtcodeReam";
            this.txtcodeReam.Size = new System.Drawing.Size(131, 25);
            this.txtcodeReam.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "类型扩展：";
            // 
            // txtEsce
            // 
            this.txtEsce.Location = new System.Drawing.Point(295, 203);
            this.txtEsce.Name = "txtEsce";
            this.txtEsce.Size = new System.Drawing.Size(69, 25);
            this.txtEsce.TabIndex = 8;
            this.txtEsce.Text = "  退出";
            this.txtEsce.Click += new System.EventHandler(this.txtEsce_Click);
            // 
            // frmdictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 439);
            this.Controls.Add(this.txtEsce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodeReam);
            this.Controls.Add(this.txtcodName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntOK);
            this.Name = "frmdictionary";
            this.Text = "歌曲类型设置";
            this.Load += new System.EventHandler(this.frmdictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodName;
        private System.Windows.Forms.TextBox txtcodeReam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEsce;
    }
}