namespace Notepad
{
    partial class frmTxt
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.页面设置UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打印PCtrlPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销UCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切TCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除LDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.查找FCtrlFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找下一个NF3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.替换RCtrlHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转到GCtrlGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ACtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间日期DF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.从右到左的阅读顺序RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(356, 247);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(137, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销UToolStripMenuItem,
            this.toolStripSeparator5,
            this.剪切TToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.删除DToolStripMenuItem,
            this.toolStripSeparator6,
            this.全选AToolStripMenuItem,
            this.toolStripSeparator7,
            this.从右到左的阅读顺序RToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(234, 190);
            // 
            // toolStatusStrip1
            // 
            this.toolStatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.toolStatusStrip1.Location = new System.Drawing.Point(0, 484);
            this.toolStatusStrip1.Name = "toolStatusStrip1";
            this.toolStatusStrip1.Size = new System.Drawing.Size(756, 25);
            this.toolStatusStrip1.TabIndex = 3;
            this.toolStatusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.保存SCtrlSToolStripMenuItem,
            this.另存为AToolStripMenuItem,
            this.toolStripSeparator1,
            this.页面设置UToolStripMenuItem,
            this.打印PCtrlPToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.新建NToolStripMenuItem.Text = "新建(&N)  Ctrl+N";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.打开OToolStripMenuItem.Text = "打开(&O) Ctrl+O";
            // 
            // 保存SCtrlSToolStripMenuItem
            // 
            this.保存SCtrlSToolStripMenuItem.Name = "保存SCtrlSToolStripMenuItem";
            this.保存SCtrlSToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.保存SCtrlSToolStripMenuItem.Text = "保存(&S) Ctrl+S";
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            // 
            // 页面设置UToolStripMenuItem
            // 
            this.页面设置UToolStripMenuItem.Name = "页面设置UToolStripMenuItem";
            this.页面设置UToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.页面设置UToolStripMenuItem.Text = "页面设置(&U)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // 打印PCtrlPToolStripMenuItem
            // 
            this.打印PCtrlPToolStripMenuItem.Name = "打印PCtrlPToolStripMenuItem";
            this.打印PCtrlPToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.打印PCtrlPToolStripMenuItem.Text = "打印(&P) Ctrl+P";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销UCtrlZToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪切TCtrlXToolStripMenuItem,
            this.复制CCtrlCToolStripMenuItem,
            this.粘贴PCtrlVToolStripMenuItem,
            this.删除LDeleteToolStripMenuItem,
            this.toolStripSeparator4,
            this.查找FCtrlFToolStripMenuItem,
            this.查找下一个NF3ToolStripMenuItem,
            this.替换RCtrlHToolStripMenuItem,
            this.转到GCtrlGToolStripMenuItem,
            this.全选ACtrlAToolStripMenuItem,
            this.时间日期DF5ToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 撤销UCtrlZToolStripMenuItem
            // 
            this.撤销UCtrlZToolStripMenuItem.Name = "撤销UCtrlZToolStripMenuItem";
            this.撤销UCtrlZToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.撤销UCtrlZToolStripMenuItem.Text = "撤销(&U) Ctrl+Z";
            this.撤销UCtrlZToolStripMenuItem.Click += new System.EventHandler(this.撤销UCtrlZToolStripMenuItem_Click);
            // 
            // 剪切TCtrlXToolStripMenuItem
            // 
            this.剪切TCtrlXToolStripMenuItem.Name = "剪切TCtrlXToolStripMenuItem";
            this.剪切TCtrlXToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.剪切TCtrlXToolStripMenuItem.Text = "剪切(&T) Ctrl+X";
            this.剪切TCtrlXToolStripMenuItem.Click += new System.EventHandler(this.剪切TCtrlXToolStripMenuItem_Click);
            // 
            // 复制CCtrlCToolStripMenuItem
            // 
            this.复制CCtrlCToolStripMenuItem.Name = "复制CCtrlCToolStripMenuItem";
            this.复制CCtrlCToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.复制CCtrlCToolStripMenuItem.Text = "复制(&C) Ctrl+C";
            this.复制CCtrlCToolStripMenuItem.Click += new System.EventHandler(this.复制CCtrlCToolStripMenuItem_Click);
            // 
            // 粘贴PCtrlVToolStripMenuItem
            // 
            this.粘贴PCtrlVToolStripMenuItem.Name = "粘贴PCtrlVToolStripMenuItem";
            this.粘贴PCtrlVToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.粘贴PCtrlVToolStripMenuItem.Text = "粘贴(&P) Ctrl+V";
            this.粘贴PCtrlVToolStripMenuItem.Click += new System.EventHandler(this.粘贴PCtrlVToolStripMenuItem_Click);
            // 
            // 删除LDeleteToolStripMenuItem
            // 
            this.删除LDeleteToolStripMenuItem.Name = "删除LDeleteToolStripMenuItem";
            this.删除LDeleteToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.删除LDeleteToolStripMenuItem.Text = "删除(&L) Delete";
            this.删除LDeleteToolStripMenuItem.Click += new System.EventHandler(this.删除LDeleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // 查找FCtrlFToolStripMenuItem
            // 
            this.查找FCtrlFToolStripMenuItem.Name = "查找FCtrlFToolStripMenuItem";
            this.查找FCtrlFToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.查找FCtrlFToolStripMenuItem.Text = "查找(&F) Ctrl+F";
            // 
            // 查找下一个NF3ToolStripMenuItem
            // 
            this.查找下一个NF3ToolStripMenuItem.Name = "查找下一个NF3ToolStripMenuItem";
            this.查找下一个NF3ToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.查找下一个NF3ToolStripMenuItem.Text = "查找下一个(&N) F3";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // 替换RCtrlHToolStripMenuItem
            // 
            this.替换RCtrlHToolStripMenuItem.Name = "替换RCtrlHToolStripMenuItem";
            this.替换RCtrlHToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.替换RCtrlHToolStripMenuItem.Text = "替换(&R) Ctrl+H";
            // 
            // 转到GCtrlGToolStripMenuItem
            // 
            this.转到GCtrlGToolStripMenuItem.Name = "转到GCtrlGToolStripMenuItem";
            this.转到GCtrlGToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.转到GCtrlGToolStripMenuItem.Text = "转到(&G) Ctrl+G";
            // 
            // 全选ACtrlAToolStripMenuItem
            // 
            this.全选ACtrlAToolStripMenuItem.Name = "全选ACtrlAToolStripMenuItem";
            this.全选ACtrlAToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.全选ACtrlAToolStripMenuItem.Text = "全选(&A) Ctrl+A";
            // 
            // 时间日期DF5ToolStripMenuItem
            // 
            this.时间日期DF5ToolStripMenuItem.Name = "时间日期DF5ToolStripMenuItem";
            this.时间日期DF5ToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.时间日期DF5ToolStripMenuItem.Text = "时间/日期(&D) F5";
            // 
            // 撤销UToolStripMenuItem
            // 
            this.撤销UToolStripMenuItem.Name = "撤销UToolStripMenuItem";
            this.撤销UToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.撤销UToolStripMenuItem.Text = "撤销(&U)";
            // 
            // 剪切TToolStripMenuItem
            // 
            this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
            this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.剪切TToolStripMenuItem.Text = "剪切(&T)";
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.删除DToolStripMenuItem.Text = "删除(&D)";
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.全选AToolStripMenuItem.Text = "全选(&A)";
            // 
            // 从右到左的阅读顺序RToolStripMenuItem
            // 
            this.从右到左的阅读顺序RToolStripMenuItem.Name = "从右到左的阅读顺序RToolStripMenuItem";
            this.从右到左的阅读顺序RToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.从右到左的阅读顺序RToolStripMenuItem.Text = "从右到左的阅读顺序(&R)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(230, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(230, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(230, 6);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 20);
            this.toolStripStatusLabel1.Text = "行：       列：      ";
            // 
            // frmTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 509);
            this.Controls.Add(this.toolStatusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTxt";
            this.Text = "无标题-记事本";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStatusStrip1.ResumeLayout(false);
            this.toolStatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 页面设置UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印PCtrlPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤销UCtrlZToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 剪切TCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除LDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 查找FCtrlFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找下一个NF3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 替换RCtrlHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转到GCtrlGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ACtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间日期DF5ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 撤销UToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 从右到左的阅读顺序RToolStripMenuItem;
        private System.Windows.Forms.StatusStrip toolStatusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

