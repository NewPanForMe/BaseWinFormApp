using Public.Alert;
using SqlT.Tools;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SqlT
{
    public partial class FormClass : Form
    {
        /// <summary>
        /// PDM上传路径
        /// </summary>
        private string _pdmPath = string.Empty;

        /// <summary>
        /// 生成类文件夹
        /// </summary>
        private string _generateClassFilePath = string.Empty;

        public FormClass()
        {
            InitializeComponent();
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

        private void selectGenClassBtn_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                genClassPath.Text = dialog.SelectedPath;
                _generateClassFilePath = dialog.SelectedPath;
            }
        }

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
    }
}
