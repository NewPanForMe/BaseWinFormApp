using System;
using System.Windows.Forms;
using Desktop.Tools;
using Public.Alert;

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

        /// <summary>
        /// 关机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shutDownBtn_Click(object sender, EventArgs e)
        {

            var af = MessageAlert.ShowWarningCancel(@"确认关机吗");
            if (af == DialogResult.OK)
            {
                ProcessHelper.Shutdown(LessTime);
                MessageBox.Show($@"将在{DateTime.Now.AddSeconds(LessTime):hh:mm:ss}关机");
            }
        }

        /// <summary>
        /// 重启
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rebootBtn_Click(object sender, EventArgs e)
        {
            var af = MessageAlert.ShowWarningCancel(@"确认重启吗");
            if (af == DialogResult.OK)
            {
                ProcessHelper.Restart(LessTime);
                MessageBox.Show($@"将在{DateTime.Now.AddSeconds(LessTime):hh:mm:ss}重启");
            }
        }
    }
}
