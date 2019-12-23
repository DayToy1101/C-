﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging;

namespace EX7_2
{
    public partial class Form1 : Form
    {
        private Bitmap m_Bitmap = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(m_Bitmap!=null)
            {
                Graphics gra = e.Graphics;
                gra.DrawImage(m_Bitmap, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y, (int)(m_Bitmap.Width), (int)(m_Bitmap.Height)));
            }
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap 文件（*.bmp）|*.bmp|Jpeg 文件(*.jpg)|*.jpg|所有适合文件（*.bmp/*.jpg）|*.bmp/*.jpg";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if(DialogResult.OK==openFileDialog.ShowDialog())
            {
                m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);
                this.AutoScroll = true;
                this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width), (int)(m_Bitmap.Height));
                this.Invalidate();
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog .Filter= "Bitmap 文件（*.bmp）|*.bmp|Jpeg 文件(*.jpg)|*.jpg|所有适合文件（*.bmp/*.jpg）|*.bmp/*.jpg";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                m_Bitmap.Save(saveFileDialog.FileName);
            }
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
