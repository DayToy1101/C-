namespace KTV
{
    partial class frmPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlay));
            this.button1 = new System.Windows.Forms.Button();
            this.bntExce = new System.Windows.Forms.Button();
            this.bntZan = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntExce
            // 
            this.bntExce.Location = new System.Drawing.Point(334, 314);
            this.bntExce.Name = "bntExce";
            this.bntExce.Size = new System.Drawing.Size(127, 23);
            this.bntExce.TabIndex = 1;
            this.bntExce.Text = "退出";
            this.bntExce.UseVisualStyleBackColor = true;
            this.bntExce.Click += new System.EventHandler(this.bntExce_Click);
            // 
            // bntZan
            // 
            this.bntZan.Location = new System.Drawing.Point(580, 314);
            this.bntZan.Name = "bntZan";
            this.bntZan.Size = new System.Drawing.Size(123, 23);
            this.bntZan.TabIndex = 2;
            this.bntZan.Text = "暂停/继续";
            this.bntZan.UseVisualStyleBackColor = true;
            this.bntZan.Click += new System.EventHandler(this.bntZan_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(141, 138);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(562, 81);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 459);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.bntZan);
            this.Controls.Add(this.bntExce);
            this.Controls.Add(this.button1);
            this.Name = "frmPlay";
            this.Text = "歌曲播放";
            this.Load += new System.EventHandler(this.frmPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntExce;
        private System.Windows.Forms.Button bntZan;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}