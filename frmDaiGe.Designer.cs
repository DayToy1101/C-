namespace KTV
{
    partial class frmDaiGe
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
            this.bntNumber = new System.Windows.Forms.Button();
            this.bntPing = new System.Windows.Forms.Button();
            this.bntAuthor = new System.Windows.Forms.Button();
            this.bntName = new System.Windows.Forms.Button();
            this.bntSelect = new System.Windows.Forms.Button();
            this.bntPlay = new System.Windows.Forms.Button();
            this.bntEsce = new System.Windows.Forms.Button();
            this.lvPlay = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // bntNumber
            // 
            this.bntNumber.Location = new System.Drawing.Point(24, 25);
            this.bntNumber.Name = "bntNumber";
            this.bntNumber.Size = new System.Drawing.Size(75, 73);
            this.bntNumber.TabIndex = 0;
            this.bntNumber.Text = "数字点歌";
            this.bntNumber.UseVisualStyleBackColor = true;
            this.bntNumber.Click += new System.EventHandler(this.bntNumber_Click);
            // 
            // bntPing
            // 
            this.bntPing.Location = new System.Drawing.Point(134, 25);
            this.bntPing.Name = "bntPing";
            this.bntPing.Size = new System.Drawing.Size(75, 73);
            this.bntPing.TabIndex = 1;
            this.bntPing.Text = "拼音点歌";
            this.bntPing.UseVisualStyleBackColor = true;
            this.bntPing.Click += new System.EventHandler(this.bntPing_Click);
            // 
            // bntAuthor
            // 
            this.bntAuthor.Location = new System.Drawing.Point(254, 25);
            this.bntAuthor.Name = "bntAuthor";
            this.bntAuthor.Size = new System.Drawing.Size(75, 73);
            this.bntAuthor.TabIndex = 2;
            this.bntAuthor.Text = "明星点歌";
            this.bntAuthor.UseVisualStyleBackColor = true;
            this.bntAuthor.Click += new System.EventHandler(this.bntAuthor_Click);
            // 
            // bntName
            // 
            this.bntName.Location = new System.Drawing.Point(362, 25);
            this.bntName.Name = "bntName";
            this.bntName.Size = new System.Drawing.Size(75, 73);
            this.bntName.TabIndex = 3;
            this.bntName.Text = "歌名点歌";
            this.bntName.UseVisualStyleBackColor = true;
            this.bntName.Click += new System.EventHandler(this.bntName_Click);
            // 
            // bntSelect
            // 
            this.bntSelect.Location = new System.Drawing.Point(468, 25);
            this.bntSelect.Name = "bntSelect";
            this.bntSelect.Size = new System.Drawing.Size(75, 73);
            this.bntSelect.TabIndex = 4;
            this.bntSelect.Text = "选择";
            this.bntSelect.UseVisualStyleBackColor = true;
            this.bntSelect.Click += new System.EventHandler(this.bntSelect_Click);
            // 
            // bntPlay
            // 
            this.bntPlay.Location = new System.Drawing.Point(576, 25);
            this.bntPlay.Name = "bntPlay";
            this.bntPlay.Size = new System.Drawing.Size(75, 73);
            this.bntPlay.TabIndex = 5;
            this.bntPlay.Text = "播放";
            this.bntPlay.UseVisualStyleBackColor = true;
            this.bntPlay.Click += new System.EventHandler(this.bntPlay_Click);
            // 
            // bntEsce
            // 
            this.bntEsce.Location = new System.Drawing.Point(677, 25);
            this.bntEsce.Name = "bntEsce";
            this.bntEsce.Size = new System.Drawing.Size(75, 73);
            this.bntEsce.TabIndex = 6;
            this.bntEsce.Text = "退出";
            this.bntEsce.UseVisualStyleBackColor = true;
            this.bntEsce.Click += new System.EventHandler(this.bntEsce_Click);
            // 
            // lvPlay
            // 
            this.lvPlay.FullRowSelect = true;
            this.lvPlay.Location = new System.Drawing.Point(24, 123);
            this.lvPlay.Name = "lvPlay";
            this.lvPlay.Size = new System.Drawing.Size(728, 310);
            this.lvPlay.TabIndex = 7;
            this.lvPlay.UseCompatibleStateImageBehavior = false;
            this.lvPlay.View = System.Windows.Forms.View.Details;
            this.lvPlay.Click += new System.EventHandler(this.lvPlay_Click);
            // 
            // frmDaiGe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 470);
            this.Controls.Add(this.lvPlay);
            this.Controls.Add(this.bntEsce);
            this.Controls.Add(this.bntPlay);
            this.Controls.Add(this.bntSelect);
            this.Controls.Add(this.bntName);
            this.Controls.Add(this.bntAuthor);
            this.Controls.Add(this.bntPing);
            this.Controls.Add(this.bntNumber);
            this.Name = "frmDaiGe";
            this.Text = "系统点歌";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntNumber;
        private System.Windows.Forms.Button bntPing;
        private System.Windows.Forms.Button bntAuthor;
        private System.Windows.Forms.Button bntName;
        private System.Windows.Forms.Button bntSelect;
        private System.Windows.Forms.Button bntPlay;
        private System.Windows.Forms.Button bntEsce;
        public System.Windows.Forms.ListView lvPlay;
    }
}