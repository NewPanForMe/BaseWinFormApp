using SqlT.Tools;
using System;
using System.Windows.Forms;
using Public.Alert;
using SqlT.Models;

namespace SqlT
{
    public partial class FormTestDb : Form
    {
        public FormTestDb()
        {
            InitializeComponent();
            sqlConnComBx.DropDownStyle = ComboBoxStyle.DropDownList;
            RefreshSqlConnComBx();
        }
        /// <summary>
        /// 重新加载数据库框数据
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
            }
        }

        /// <summary>
        /// 下啦变化监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sqlConnComBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var conn = (SqlConn)(((ComboBox)sender).SelectedItem);
            dbIpTb.Text = conn.Ip;
            userNameTb.Text = conn.UserName;
            passwordTb.Text = conn.Password;
            dbNameTb.Text = conn.DataBase;
        }
    }
}
