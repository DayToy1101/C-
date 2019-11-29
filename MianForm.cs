using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多文档界面
{
    public partial class MianForm : Form
    {
        public MianForm()
        {
            InitializeComponent();
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm MDIChild = new ChildForm();
            MDIChild.MdiParent = this;
            MDIChild.Show();
        }
    }
}
