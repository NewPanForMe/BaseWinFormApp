﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlT.Tools;

namespace SqlT
{
    public partial class FormPdm : Form
    {
        private string _pdmPath = string.Empty;
        private string _generateClassFilePath = string.Empty;
        private string _createTbSql = string.Empty;

        public FormPdm()
        {
            InitializeComponent();
            sqlTypeComb.DropDownStyle = ComboBoxStyle.DropDownList;
            sqlTypeComb.Items.Add("SqlServer");
            sqlTypeComb.Items.Add("PostgreSQL");
            sqlTypeComb.Items.Add("MySQL");
            this.pdmResRichBx.ReadOnly = true;
            genClassPath.ReadOnly = true;
        }
        /// <summary>
        /// 选择pdm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectPdmBtn_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = @"请选择PDM文件";
            ofd.Filter = @"PDM文件(*.pdm)|*.pdm";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _pdmPath = ofd.FileName;
            }

            if (string.IsNullOrEmpty(_pdmPath)) return;
            this.pdmPathLabel.Text = _pdmPath;
            ParsePdm();
        }

        /// <summary>
        /// 处理PDM
        /// </summary>
        private void ParsePdm()
        {
            PdmReaders.Reads(_pdmPath);
        }

        /// <summary>
        /// 生成sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genSqlBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_pdmPath))
            {
                MessageBox.Show(@"请选择PDM文件");
                return;
            }
            if (string.IsNullOrEmpty(sqlTypeComb.Text))
            {
                MessageBox.Show(@"请选择生成SQL类型");
                return;
            }
            var pdm = PdmReaders.Pdm;
            var generateSql = string.Empty;
            switch (sqlTypeComb.Text)
            {
                case "SqlServer":
                    generateSql = SqlTools.GenerateSqlServer(pdm);
                    break;
                case "PostgreSQL":
                    generateSql = SqlTools.GeneratePgSql(pdm);
                    break;
                case "MySQL":
                    generateSql = SqlTools.GenerateMySql(pdm);
                    break;
            }

            this.pdmResRichBx.Text = string.Empty;
            this.pdmResRichBx.Text = generateSql;
            _createTbSql = generateSql;
        }
        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_pdmPath))
            {
                MessageBox.Show(@"请先选择PDM文件");
                return;
            }
            this.pdmResRichBx.SelectAll();
            Clipboard.SetText(this.pdmResRichBx.Text);
        }

        /// <summary>
        /// 生成类文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void genClass_Click(object sender, EventArgs e)
        {
            var pdm = PdmReaders.Pdm;
            if (string.IsNullOrEmpty(_generateClassFilePath))
            {
                MessageBox.Show(@"请选择文件位置");
                return;
            }
            if (string.IsNullOrEmpty(nameSpaceTbx.Text))
            {
                MessageBox.Show(@"请输入命名空间");
                return;
            }
            GenClassTools.Generate(pdm,nameSpaceTbx.Text, _generateClassFilePath);
            Process.Start(_generateClassFilePath);
        }

        /// <summary>
        /// 选择生成类文件加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectGenClassBtn_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                genClassPath.Text = dialog.SelectedPath;
                _generateClassFilePath = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// 测试链接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testConnBtn_Click(object sender, EventArgs e)
        {
            var generateDbConn = SqlDbHelper.GenerateDbConn(dbIpTb.Text, userNameTb.Text, passwordTb.Text, dbNameTb.Text);
            if (generateDbConn)
            {
                var testDb = SqlDbHelper.TestDb();
                if (!testDb)
                {
                    MessageBox.Show(@"链接失败");
                    return;
                }
                else
                {
                    MessageBox.Show(@"链接成功");
                    return;
                }
            }
        }
        /// <summary>
        /// 执行SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void execSqlBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_createTbSql))
            {
                MessageBox.Show(@"SQL未生成");
                return;
            }
            var generateDbConn = SqlDbHelper.GenerateDbConn(dbIpTb.Text, userNameTb.Text, passwordTb.Text, dbNameTb.Text);
            if (generateDbConn)
            {
                var execute = SqlDbHelper.Execute(_createTbSql);
                if (execute > 0)
                {
                    MessageBox.Show(@"执行成功");
                }
            }
        }
    }
}
