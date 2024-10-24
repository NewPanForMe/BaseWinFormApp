using System;
using System.Windows.Forms;
using Desktop;
using FileT;
using GitT;
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
            Desk();
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

        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desk();
        }
        
        /// <summary>
        /// 首页
        /// </summary>
        private void Desk()
        {
            var form = new FormDeskTop()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            AddToolStrip(form);
            form.Show();
        }

        private void 连接测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormTestDb()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            AddToolStrip(form);
            form.Show();
        }

        private void pDM转ClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormClass()
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            AddToolStrip(form);
            form.Show();
        }

        private void git操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Git()
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
