using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV
{
    public partial class frmdictionary : Form
    {
        public int intCount;
        public string strGetID;
        public frmdictionary(int intFalg, string strId)
        {
            InitializeComponent();
            intCount = intFalg;
            strGetID = strId;
        }
        public frmdictionary()
        {
            InitializeComponent();
        }
        tb_dictionary tbDicty = new tb_dictionary();
        frmdictionaryMenthod frmDictity = new frmdictionaryMenthod();
        private void bntOK_Click(object sender, EventArgs e)
        {
            if (txtcodName.Text == "")
            {
                MessageBox.Show("歌典类型不能为空");
                txtcodName.Focus();
                return;
            }
            tbDicty.strcodeID = txtcodeID.Text;
            tbDicty.strcodeName = txtcodName.Text;
            tbDicty.strcodeReam = txtcodeReam.Text;
            if (intCount == 1)
            {
                int intResult = frmDictity.dictionaryAdd(tbDicty);
                if (intResult == 1)
                {
                    MessageBox.Show("添加成功");
                    frmMain frm = (frmMain)this.Owner;
                    frmDictity.dictionaryFind("2", frm.LvDitcy);
                    intCount = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                    intCount = 0; this.Close();
                }
            }
            if (intCount == 2)
            {
                if (frmDictity.dictionaryUpdate(tbDicty) == 1)
                {
                    MessageBox.Show("修改成功");
                    frmMain frm = (frmMain)this.Owner;
                    frmDictity.dictionaryFind("2", frm.LvDitcy);
                    intCount = 0;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                    intCount = 0;
                    this.Close();
                }


            }
        }

        private void frmdictionary_Load(object sender, EventArgs e)
        {
            txtcodeID.Enabled = false;
            if (intCount == 1)
            {
                txtcodeID.Text = frmDictity.getSellID();
            }
            if (intCount == 2)
            {
                txtcodeID.Text = strGetID;
            }
        }

        private void txtEsce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
