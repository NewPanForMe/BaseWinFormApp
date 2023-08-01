using System;
using System.Windows.Forms;
using FileUploadApp.Form.FileT;
using FileUploadApp.Forms.TimeT;

namespace FileUploadApp.Forms
{
    public partial class Main : System.Windows.Forms.Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 文件遍历ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Form1
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



        private void AddToolStrip(System.Windows.Forms.Form form)
        {
            ClearToolStrip();
            this.toolStripContainer1.ContentPanel.Controls.Add(form);
        }
        private void ClearToolStrip()
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
        }

    }
}
