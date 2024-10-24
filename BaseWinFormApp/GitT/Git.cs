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
            TBGitFolder.ReadOnly=true;
        }

        private void BtnSelectDic_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;
            TBGitFolder.Text = dialog.SelectedPath;
            GitTools.GitFileFolder = dialog.SelectedPath;
        }

        private void BtnClone_Click(object sender, EventArgs e)
        {
            var cloneUrl = TbCloneGit.Text;

            GitTools.Clone(cloneUrl);
            TbCloneGit.Text = string.Empty;
            MessageBox.Show($@"克隆成功");
        }

        private void BtnPull_Click(object sender, EventArgs e)
        {
            GitTools.Pull( );
            MessageBox.Show($@"Pull成功");

        }

        private void BtnCommit_Click(object sender, EventArgs e)
        {
            var commit = TbCommit.Text;
            GitTools.Commit(commit);
            TbCommit.Text = string.Empty;
            MessageBox.Show($@"提交成功");

        }


        private void BtnPush_Click(object sender, EventArgs e)
        {
            GitTools.Push();
            MessageBox.Show($@"Push成功");
        }
    }
}
