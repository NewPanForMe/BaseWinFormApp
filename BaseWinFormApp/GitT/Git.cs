using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitT.Tools;

namespace GitT
{
    public partial class Git : Form
    {
        public Git()
        {
            InitializeComponent();
            TBGitFolder.ReadOnly = true;
            CBGitDic.DropDownStyle = ComboBoxStyle.DropDownList;
            GitTools.GetList();
            GitTools.ListGitFileFolder.ForEach(x =>
            {
                CBGitDic.Items.Add(x.Dic);
            });
            WriteLogs("加载成功");
        }

        private void BtnSelectDic_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;
            TBGitFolder.Text = dialog.SelectedPath;
            GitTools.GitFileFolder = dialog.SelectedPath;

            GitTools.Add();
            GitTools.GetList();
            GitTools.ListGitFileFolder.ForEach(x =>
            {
                CBGitDic.Items.Add(x.Dic);
            });
        }

        private void BtnClone_Click(object sender, EventArgs e)
        {
            var cloneUrl = TbCloneGit.Text;
            if (string.IsNullOrWhiteSpace(cloneUrl))
            {
                WriteLogs("Git克隆链接为空");
                return;
            }

            GitTools.Clone(cloneUrl);
            TbCloneGit.Text = string.Empty;
            WriteLogs("克隆成功");

        }

        private void BtnPull_Click(object sender, EventArgs e)
        {
            GitTools.Pull();
            WriteLogs("Pull成功");

        }

        private void BtnCommit_Click(object sender, EventArgs e)
        {
            var commit = TbCommit.Text;
            if (string.IsNullOrWhiteSpace(commit))
            {
                WriteLogs("Git提交备注为空");

                return;
            }

            GitTools.Commit(commit);
            TbCommit.Text = string.Empty;
            WriteLogs("提交成功");

        }


        private void BtnPush_Click(object sender, EventArgs e)
        {
            GitTools.Push();
            WriteLogs("Push成功");

        }

        private void CBGitDic_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBGitFolder.Text = CBGitDic.Text;
            GitTools.GitFileFolder = CBGitDic.Text;
        }



        void WriteLogs(string log)
        {
            RTBLogs.AppendText($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}-{log} \n");

        }
    }
}
