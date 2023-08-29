using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileT
{
    public partial class FileRead : Form
    {
        private string FileName = string.Empty;
        public FileRead()
        {
            InitializeComponent();
            contentRichTb.ReadOnly = true;
        }
        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = @"请选择文件";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                this.fileLbl.Text = ofd.FileName;
                ReadFile();
            }
        }



        private void ReadFile()
        {
            if (string.IsNullOrEmpty(FileName))
            {
                MessageBox.Show("请选择文件");
                return;
            }


            var content = System.IO.File.ReadAllText(FileName);
            var _strStoT = Strings.StrConv(content, VbStrConv.SimplifiedChinese);
            contentRichTb.Text = _strStoT;

        }


    }
}
