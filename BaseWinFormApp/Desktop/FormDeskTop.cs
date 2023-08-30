using System;
using System.Windows.Forms;
using Desktop.Tools;

namespace Desktop
{
    public partial class FormDeskTop : Form
    {
        /// <summary>
        /// 剩余时间
        /// </summary>
        private const int LessTime = 10;    //单位为：秒

        public FormDeskTop()
        {
            InitializeComponent();
        }

        private void shutDownBtn_Click(object sender, EventArgs e)
        {

            var af = MessageBox.Show(@"确认关机吗", @"提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (af == DialogResult.OK)
            {
                ProcessHelper.Shutdown(LessTime);
                MessageBox.Show($@"将在{DateTime.Now.AddSeconds(LessTime):hh:mm:ss}关机");
            }


        
        }

        private void rebootBtn_Click(object sender, EventArgs e)
        {


            var af = MessageBox.Show(@"确认重启吗", @"提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (af == DialogResult.OK)
            {
                ProcessHelper.Restart(LessTime);
                MessageBox.Show($@"将在{DateTime.Now.AddSeconds(LessTime):hh:mm:ss}重启");
            }

  
        }
    }
}
