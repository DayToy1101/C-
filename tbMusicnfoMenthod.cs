﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KTV
{
    class tbMusicnfoMenthod
    {
        OleDbCommand oledcmd = null;
        OleDbConnection oledCon = null;
        OleDbDataReader oleRed = null;
        public int tbMusicnfoAdd(tb_musicinfo tb_aut)
        {
            int intResult = 0;
            try
            {
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "insert into tb_musicinfo values(";
                strAdd += "'" + tb_aut.strMusic_code + "','" + tb_aut.strMusic_name + "',";
                strAdd += "'" + tb_aut.strMusic_author + "','" + tb_aut.strMusic_Kind + "',";
                strAdd += "'" + tb_aut.strMusic_chinse + "','" + tb_aut.strMusic_filepath + "',";
                strAdd += "'" + tb_aut.strMusic_Ping + "','" + tb_aut.daMusic_date + "',";
                strAdd += "'" + tb_aut.intMusic_falg + "')";
                oledcmd = new OleDbCommand(strAdd, oledCon);
                intResult = oledcmd.ExecuteNonQuery();
                return intResult;
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return intResult;
            }
        }
        public int tbMusicnfoUpdate(tb_musicinfo tb_aut)
        {
            int intResult = 0;
            try
            {
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "update tb_musicinfo set";
                strAdd += "Music_name='" + tb_aut.strMusic_name + "',";
                strAdd += "Music_author='" + tb_aut.strMusic_author + "',Msuic_Kind='" + tb_aut.strMusic_Kind + "',";
                strAdd += "Music_chinse='" + tb_aut.strMusic_chinse + "',Music_filepath='" + tb_aut.strMusic_filepath + "',";
                strAdd += "Music_Ping='" + tb_aut.strMusic_Ping + "',Music_date='" + tb_aut.daMusic_date + "',";
                strAdd += "Music_falg='" + tb_aut.intMusic_falg + "'where Music_code='" + tb_aut.strMusic_code + "'";
                oledcmd = new OleDbCommand(strAdd, oledCon);
                intResult = oledcmd.ExecuteNonQuery();
                return intResult;
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return intResult;
            }
        }
        public int tbMusicnfoDelete(string tb_aut)
        {
            int intResult = 0;
            try
            {
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "delete * from tb_musicinfo where";
                strAdd += "Music_code ='" + tb_aut + "'";
                oledcmd = new OleDbCommand(strAdd, oledCon);
                intResult = oledcmd.ExecuteNonQuery();
                return intResult;
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return intResult;
            }
        }
        public int tbMusicnfoID()
        {
            int intResult = 0;
            try
            {
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd="select Max(Music_code) from tb_musicinfo";
                oledcmd=new OleDbCommand(strAdd,oledCon);
                oleRed=oledcmd.ExecuteReader();
                oleRed.Read();
                 if (oleRed.HasRows)
                {
                    if (oleRed[0].ToString() == "")
                    { intResult = 1; }
                    else
                    {
                        intResult = Convert.ToInt32(oleRed[0].ToString()) + 1;
                    }
                }
                return intResult;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return intResult;
            }
        }
        public void tbMusicnfoFill(object obj)
        {
            try
            {
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "select * from tb_musicinfo ";
                oledcmd = new OleDbCommand(strAdd, oledCon);
                oleRed = oledcmd.ExecuteReader();
   
                    ListView lv = (ListView)obj;
                    lv.Items.Clear();
                    while (oleRed.Read())
                    {
                        ListViewItem lv1 = new ListViewItem(oleRed[0].ToString());
                        lv1.SubItems.Add(oleRed[1].ToString());
                        lv1.SubItems.Add(oleRed[2].ToString());
                        lv1.SubItems.Add(oleRed[3].ToString());
                        lv1.SubItems.Add(oleRed[4].ToString());
                        lv1.SubItems.Add(oleRed[5].ToString());
                        lv.Items.Add(lv1);
                    }
                    oleRed.Close();
         
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        public OleDbDataReader tbMusicnfoFillReder(string obj)
        {
            try
            {
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                string strAdd = "select * from tb_musicinfo  where Music_code='"+obj+"'";
                oledcmd = new OleDbCommand(strAdd, oledCon);
                oleRed = oledcmd.ExecuteReader();
                return oleRed;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return oleRed;
            }
        }
        public int  tbFill( object obj,string strResult,int intFalg)
        {
            int intResult = 0;
            try
            {
                
                string strSelect = null;
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                switch (intFalg)
                { 
                    case 1://数字
                        strSelect = "select * from tb_musicinfo where  Music_code  like '%" + strResult + "%'";
                        break;
                    case 2://拼音
                        strSelect = "select * from tb_musicinfo where  Music_Ping  like '%" + strResult + "%'";
                        break;
                    case 3://明星
                        strSelect = "select * from tb_musicinfo where  Music_author like '%" + strResult + "%'";
                        break;
                    case 4://明名
                        strSelect = "select * from tb_musicinfo where  MusicC_name  like '%" + strResult + "%'";
                        break;
                
                }
                oledcmd = new OleDbCommand(strSelect, oledCon);
                oleRed = oledcmd.ExecuteReader();
                ListView lv = (ListView)obj;
                lv.Items.Clear();
                while (oleRed.Read())
                {
                    ListViewItem lv1 = new ListViewItem(oleRed[0].ToString());
                    lv1.SubItems.Add(oleRed[1].ToString());
                    lv1.SubItems.Add(oleRed[2].ToString());
                    lv1.SubItems.Add(oleRed[3].ToString());
                    lv.Items.Add(lv1);
                    intResult++;
                }
                oleRed.Close();
                return intResult;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return intResult;
            }
        }
        public string tbFillName(string strResult)
        {
            string Result = null;
            try
            {
                string strSelect = null;
                getConnection getCon = new getConnection();
                oledCon = getCon.OledCon();
                oledCon.Open();
                strSelect = "select Music_filepath from tb_musicinfo where  Music_code= '" + strResult + "'";
                oledcmd = new OleDbCommand(strSelect, oledCon);
                oleRed = oledcmd.ExecuteReader();
                oleRed.Read();
                if(oleRed.HasRows)
                {
                    Result = oleRed[0].ToString();
                }
                oleRed.Close();
                return Result;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
                return Result;
            }
        }
    }
}