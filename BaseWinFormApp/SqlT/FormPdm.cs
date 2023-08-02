using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            sqlTypeComb.DropDownStyle = ComboBoxStyle.DropDownList;
            sqlTypeComb.Items.Add("SqlServer");
            sqlTypeComb.Items.Add("PostgreSQL");
            sqlTypeComb.Items.Add("MySQL");
            this.pdmResRichBx.ReadOnly = true;
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
        }

        private void genSqlBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_pdmPath))
            {
                MessageBox.Show(@"请选择PDM文件");
                return;
            }
            if (string.IsNullOrEmpty(sqlTypeComb.Text))
            {
                MessageBox.Show(@"请选择生成SQL类型");
                return;
            }
            var pdm = PdmReaders.Pdm;
            var generateSqlServer = string.Empty;
            switch (sqlTypeComb.Text)
            {
                case "SqlServer":
                    generateSqlServer = SqlTools.GenerateSqlServer(pdm);
                    break;
                case "PostgreSQL":
                    generateSqlServer = SqlTools.GeneratePgSql(pdm);
                    break;
                case "MySQL":
                    generateSqlServer = SqlTools.GenerateMySql(pdm);
                    break;
            }


            this.pdmResRichBx.Text = string.Empty;
            this.pdmResRichBx.Text = generateSqlServer;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_pdmPath))
            {
                MessageBox.Show(@"请先选择PDM文件");
                return;
            }
            this.pdmResRichBx.SelectAll();
            Clipboard.SetText(this.pdmResRichBx.Text);
        }
    }
}
