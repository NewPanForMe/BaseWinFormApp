using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlT.Tools;

namespace SqlT
{
    public partial class FormPdm : Form
    {
        private string _pdmPath = string.Empty;
        public FormPdm()
        {
            InitializeComponent();
        }

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
            this.pdmPathLabel.Text = _pdmPath;
            ParsePdm();
        }

        /// <summary>
        /// 处理PDM
        /// </summary>
        private void ParsePdm()
        {
            PdmReaders.Reads(_pdmPath);
            var pdm = PdmReaders.Pdm;

            pdm.ListTableData.ForEach(Console.WriteLine);

        }


    }
}
