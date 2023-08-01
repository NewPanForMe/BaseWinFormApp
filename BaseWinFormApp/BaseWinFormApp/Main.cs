using System;
using System.Windows.Forms;
using FileT;
using SqlT;
using TimerT;

namespace BaseWinFormApp
{
    public partial class Main : System.Windows.Forms.Form
    {
        public Main()
        {
            InitializeComponent();
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
    }
}
