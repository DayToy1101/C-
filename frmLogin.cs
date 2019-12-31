﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            tb_computer computer = new tb_computer();
            if (txtUser.Text == "")
            {
                MessageBox.Show("登录名称不能为空！");
                txtUser.Focus();
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("登录密码不能为空！");
                txtPwd.Focus();
                return;
            }
            if (cmbLogin.Text == "")
            {
                MessageBox.Show("请选择登录界面");
                cmbLogin.Focus();
                return;
            }
            computer.strcmp_name = txtUser.Text;
            computer.strcmp_Paww = txtPwd.Text;
            if (computer.tb_computerLogin(computer, 2) == 1)
            {
                if (cmbLogin.Text == "后台数据维护")
                {
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                if (cmbLogin.Text == "系统点歌")
                {
                    frmDaiGe daige = new frmDaiGe();
                    daige.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("登录失败！");
                txtPwd.Text = "";
                txtUser.Text = "";
                cmbLogin.Text = "";
                txtUser.Focus();
            }
        }

        private void bntEsce_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
