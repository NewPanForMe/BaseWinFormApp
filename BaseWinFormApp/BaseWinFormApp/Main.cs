using System;
using System.Diagnostics;
using System.Windows.Forms;
using FileT;
using SqlT;
using SysT;
using TimerT;

namespace BaseWinFormApp
{
    public partial class Main : System.Windows.Forms.Form
    {
        public Main()
        {
            InitializeComponent();
            MaximizeBox=false;
            FormBorderStyle=FormBorderStyle.FixedSingle;
        }

        #region MyRegion

        private void AddToolStrip(System.Windows.Forms.Form form)
        {
            ClearToolStrip();
            this.toolStripContainer1.ContentPanel.Controls.Add(form);
        }
        private void ClearToolStrip()
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
        }

        #endregion

        private void 文件遍历ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FileForeach()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            AddToolStrip(form);
            form.Show();
        }

        private void 计时器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormTime()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            AddToolStrip(form);
            form.Show();
        }

        private void PDM处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormPdm()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            AddToolStrip(form);
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void 系统当前信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormSystem()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            AddToolStrip(form);
            form.Show();
        }

        private void 关机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int time = 10;    //单位为：秒
            MessageBox
                .Show($@"将在{time}s后关机");
            Process.Start("c:/windows/system32/shutdown.exe", "-s -t " + time);
        }

        private void 重启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int time = 10;    //单位为：秒
            MessageBox
                .Show($@"将在{time}s后重启");
            Process.Start("c:/windows/system32/shutdown.exe", "-r -t " + time);
        }
    }
}
