using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace KTV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmdictionaryMenthod frmDictyin = new frmdictionaryMenthod();
        tb_authorinfoMenthod tbAuto = new tb_authorinfoMenthod();
        tbMusicnfoMenthod tbMuseic = new tbMusicnfoMenthod();
        tb_computer computer = new tb_computer();
        private void bntAut_Click(object sender, EventArgs e)
        {
            //添加明星
            frmAuton frmAuAdd = new frmAuton(1, "");
            frmAuAdd.Owner = this;
            frmAuAdd.ShowDialog();
        }

        private void bntAuUpdate_Click(object sender, EventArgs e)
        {
            //修改明星
            if (strNameAuton != null)
            {
                frmAuton frmAuAdd = new frmAuton(2, strNameAuton);
                frmAuAdd.Owner = this;
                frmAuAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择要修改的内容！");
                return;
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            //删除明星
            if (strNameAuton != null)
            {
                tbAuto.dictionaryDelete(strNameAuton);//刷新控件
                MessageBox.Show("删除成功");
                tbAuto.tb_authorinfoFill("2", LvAuton);

            }
            else
            {
                MessageBox.Show("请选择要删除的内容！");
                return;
            }
        }

        private void bntMuserUpdate_Click(object sender, EventArgs e)
        {
            if (strMuseName != null)
            {
                frmMusicinfo frmInfo = new frmMusicinfo(2, strMuseName);
                frmInfo.Owner = this;
                frmInfo.ShowDialog();

            }
            else
            {
                MessageBox.Show("选择要修改歌典");
            }
        }

        private void bntMuserDelete_Click(object sender, EventArgs e)
        {
            if (strMuseName != null)
            {
                if (tbMuseic.tbMusicnfoDelete(strMuseName) == 1)
                {
                    MessageBox.Show("删除成功");
                    tbMuseic.tbMusicnfoFill(LvMuscie);
                }
                else
                {
                    MessageBox.Show("删除失败");
                    tbMuseic.tbMusicnfoFill(LvMuscie);
                }
            }
            else
            {
                MessageBox.Show("选择要删除歌典");

            }
        }

        private void bntMuserAdd_Click(object sender, EventArgs e)
        {
            frmMusicinfo frmInfo = new frmMusicinfo(1, "");
            frmInfo.Owner = this;
            frmInfo.ShowDialog();
        }
        
        public void fillScoure()
        {

            OleDbDataReader dr = computer.tbFill(strUser);
            dr.Read();
            if (dr.HasRows)
            {
                txtUser.Text = dr[1].ToString();
                txtUser.Enabled = false;
            }
        }
        private void bntUserAdd_Click(object sender, EventArgs e)
        {
            //添加用户
            intFalg = 1;
            txtPassWord.Text = "";
            txtUser.Text = "";
            txtUser.Enabled = true;
            bntUserAdd.Enabled = true;
            bntUserDelete.Enabled = false;
            bntUserUpdate.Enabled = false;
        }

        private void bntUserUpdate_Click(object sender, EventArgs e)
        {
            ////修改用户
            intFalg = 2;
            bntUserAdd.Enabled = false;
            bntUserDelete.Enabled = false;
            bntUserUpdate.Enabled = true;
        }

        private void bntUserDelete_Click(object sender, EventArgs e)
        {
            intFalg = 3;
            bntUserAdd.Enabled = false;
            bntUserDelete.Enabled = true;
            bntUserUpdate.Enabled = false;
        }
        public int intFalg = 0;

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
                txtUser.Focus();
                return;
            }
            if (intFalg != 3)
            {
                if (txtPassWord.Text == "")
                {
                    MessageBox.Show("用户密码不能为空！");
                    txtPassWord.Focus();
                    return;
                }
            }


            if (intFalg == 1)
            {
                computer.strcmp_ID = computer.getSellID();
                computer.strcmp_name = txtUser.Text;
                computer.strcmp_Paww = txtPassWord.Text;
                computer.strcmp_DataTime = DateTime.Now.Date.ToString();
                computer.strcmp_Falg = "0";
                if (computer.tb_computerLogin(computer, 1) == 1)
                {
                    MessageBox.Show("此用户名已被占用");
                    txtUser.Text = "";
                    txtUser.Focus();
                    txtPassWord.Text = "";
                    return;
                }
                if (computer.tb_computerAdd(computer) == 1)
                {
                    MessageBox.Show("添加成功！", "提示");
                    computer.tbMusicnfoFill(LvUser);
                    txtUser.Enabled = true;
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }
                else
                {
                    MessageBox.Show("失败失败！", "提示");
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }
            }
            if (intFalg == 2)
            {
                if (strUser == null)
                {
                    MessageBox.Show("选择要修改的用户");
                    return;
                }
                else
                {
                    computer.strcmp_ID = strUser;
                }
                computer.strcmp_name = txtUser.Text;
                computer.strcmp_Paww = txtPassWord.Text;
                computer.strcmp_DataTime = DateTime.Now.Date.ToString();
                computer.strcmp_Falg = "0";
                if (computer.tb_computerUpdate(computer) == 1)
                {
                    MessageBox.Show("修改成功！", "提示");
                    computer.tbMusicnfoFill(LvUser);
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }

            }
            if (intFalg == 3)
            {
                if (strUser == null)
                {
                    MessageBox.Show("选择要删除的用户");
                    return;
                }
                else
                {
                    computer.strcmp_ID = strUser;
                }
                computer.strcmp_Falg = "1";
                if (computer.tb_computerDelete(computer) == 1)
                {
                    MessageBox.Show("删除成功！", "提示");
                    computer.tbMusicnfoFill(LvUser);
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }
                else
                {
                    MessageBox.Show("删除失败！", "提示");
                    txtPassWord.Text = "";
                    txtUser.Text = "";
                    bntUserAdd.Enabled = true;
                    bntUserDelete.Enabled = true;
                    bntUserUpdate.Enabled = true;

                }
            }
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public string strUser = null;
        //用户
        private void LvUser_Click(object sender, EventArgs e)
        {
            strUser = LvUser.SelectedItems[0].SubItems[0].Text;
            if (strUser != null)
            { 
                fillScoure();
            }
        }
        public string strMuseName = null;
        //歌曲
        private void LvMuscie_MouseClick(object sender, MouseEventArgs e)
        {
            strMuseName = LvMuscie.SelectedItems[0].SubItems[0].Text;
        }
        public string strNameAuton = null;
        //明星
        private void LvAuton_Click(object sender, EventArgs e)
        {
            strNameAuton = LvAuton.SelectedItems[0].SubItems[0].Text;//当前选择的值
        }
        public string strName = null;
        //歌曲类型
        private void LvDitcy_Click(object sender, EventArgs e)
        {
            strName = LvDitcy.SelectedItems[0].SubItems[0].Text;//当前选择的值
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDictyin.dictionaryFind("2", LvDitcy);//绑定控件数据
            tbAuto.tb_authorinfoFill("2", LvAuton);//绑定控件数据
            tbMuseic.tbMusicnfoFill(LvMuscie);
            computer.tbMusicnfoFill(LvUser);
        }

    }
}
