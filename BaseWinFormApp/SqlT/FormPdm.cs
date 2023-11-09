using System;
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
using Public.Alert;
using SqlT.Models;
using SqlT.Tools;

namespace SqlT
{
    public partial class FormPdm : Form
    {
        /// <summary>
        /// PDM上传路径
        /// </summary>
        private string _pdmPath = string.Empty;
        /// <summary>
        /// 生成类文件夹
        /// </summary>
        private string _generateClassFilePath = string.Empty;
        /// <summary>
        /// 建表SQL
        /// </summary>
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
            sqlConnComBx.DropDownStyle = ComboBoxStyle.DropDownList;
            RefreshSqlConnComBx();
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
            PDMPathTbx.Text = _pdmPath;
            ParsePdm();
        }

        /// <summary>
        /// 处理PDM
        /// </summary>
        private void ParsePdm()
        {
            PdmReaders.Reads(_pdmPath);
            PdmReaders.PdmToList();
        }

        /// <summary>
        /// 重新加载数据库框s数据
        /// </summary>
        private void RefreshSqlConnComBx()
        {
            sqlConnComBx.Items.Clear();
            var generateDbConnSelect = SqlDbHelper.GenerateDbConnSelect();
            generateDbConnSelect.ForEach(x =>
            {
                sqlConnComBx.Items.Add(x);
            });
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
                MessageAlert.ShowInfo(@"请选择PDM文件");
                return;
            }
            if (string.IsNullOrEmpty(sqlTypeComb.Text))
            {
                MessageAlert.ShowInfo(@"请选择生成SQL类型");
                return;
            }
            var generateSql = string.Empty;
            switch (sqlTypeComb.Text)
            {
                case "SqlServer":
                    generateSql = SqlTools.GenerateSqlServer();
                    break;
                case "PostgreSQL":
                    generateSql = SqlTools.GeneratePgSql();
                    break;
                case "MySQL":
                    generateSql = SqlTools.GenerateMySql();
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
                MessageAlert.ShowInfo(@"请先选择PDM文件");
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
                MessageAlert.ShowWarning(@"请选择文件位置");
                return;
            }
            if (string.IsNullOrEmpty(nameSpaceTbx.Text))
            {
                MessageAlert.ShowWarning(@"请输入命名空间");
                return;
            }
            GenClassTools.Generate(pdm, nameSpaceTbx.Text, _generateClassFilePath);
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
                MessageAlert.ShowInfo(!testDb ? @"链接失败" : @"链接成功");
                SqlDbHelper.GenerateJsonFile(dbIpTb.Text, userNameTb.Text, passwordTb.Text, dbNameTb.Text);
                RefreshSqlConnComBx();
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
                MessageAlert.ShowWarning(@"SQL未生成");
                return;
            }
            var generateDbConn = SqlDbHelper.GenerateDbConn(dbIpTb.Text, userNameTb.Text, passwordTb.Text, dbNameTb.Text);
            if (generateDbConn)
            {
                var execute = SqlDbHelper.Execute(_createTbSql);
                if (execute == -1)
                {
                    MessageAlert.ShowInfo(@"执行成功");
                }
            }
        }

        /// <summary>
        /// sql选项改变方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sqlConnComBx_Change(object sender, EventArgs e)
        {
            var conn = (SqlConn)(((ComboBox)sender).SelectedItem);
            dbIpTb.Text = conn.Ip;
            userNameTb.Text = conn.UserName;
            passwordTb.Text = conn.Password;
            dbNameTb.Text = conn.DataBase;
        }

        /// <summary>
        /// 将表字段存至数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdmTbSave_Click(object sender, EventArgs e)
        {
            var generateDbConn = SqlDbHelper.GenerateDbConn(dbIpTb.Text, userNameTb.Text, passwordTb.Text, dbNameTb.Text);
             if(generateDbConn)
             {
                var savePdmTable = SqlTools.SavePdmTable();
                 if (savePdmTable)
                 {
                     MessageAlert.ShowInfo(@"执行成功");
                 }
             }
        }

        /// <summary>
        /// 对比数据库字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void compareBtn_Click(object sender, EventArgs e)
        {
            var generateDbConn = SqlDbHelper.GenerateDbConn(dbIpTb.Text, userNameTb.Text, passwordTb.Text, dbNameTb.Text);
            if (generateDbConn)
            {
                _createTbSql = SqlTools.CompareTableListSqlServer();
                this.pdmResRichBx.Text = string.Empty;
                this.pdmResRichBx.Text = _createTbSql;
            }
        }
    }
}
