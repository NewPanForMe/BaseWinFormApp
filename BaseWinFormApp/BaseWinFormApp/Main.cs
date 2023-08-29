using System;
using System.Diagnostics;
using System.Windows.Forms;
using BaseWinFormApp.Tools;
using FileT;
using SqlT;
using SysT;
using TimerT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BaseWinFormApp
{
    public partial class Main : System.Windows.Forms.Form
    {
        /// <summary>
        /// 剩余时间
        /// </summary>
       private const int LessTime = 10;    //单位为：秒

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


        private void shutDownBtn_Click(object sender, EventArgs e)
        {
            ProcessHelper.Shutdown(LessTime);
            MessageBox.Show($@"将在{DateTime.Now.AddSeconds(LessTime):hh:mm:ss}关机");

        }

        private void rebotBtn_Click(object sender, EventArgs e)
        {
            ProcessHelper.Restart(LessTime);
            MessageBox.Show($@"将在{DateTime.Now.AddSeconds(LessTime):hh:mm:ss}重启");
        }

        private void 文件读取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FileRead()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            AddToolStrip(form);
            form.Show();
        }
    }
}
