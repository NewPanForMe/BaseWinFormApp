using System.Windows.Forms;

namespace Public.Alert
{
    public class MessageAlert
    {
        /// <summary>
        /// 展示Info类型信息
        /// </summary>
        /// <param name="showText"></param>
        public static void ShowInfo(string showText)
        {
            MessageBox.Show(showText, @"提示框", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 展示Error类型信息
        /// </summary>
        /// <param name="showText"></param>
        public static void ShowError(string showText)
        {
             MessageBox.Show(showText, @"提示框", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 展示Warning类型信息
        /// </summary>
        /// <param name="showText"></param>
        public static void ShowWarning(string showText)
        {
             MessageBox.Show(showText, @"提示框", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        /// <summary>
        /// 展示Warning类型信息
        /// </summary>
        /// <param name="showText"></param>
        public static DialogResult ShowWarningCancel(string showText)
        {
          return  MessageBox.Show(showText, @"提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 展示Error类型信息
        /// </summary>
        /// <param name="showText"></param>
        public static DialogResult ShowErrorCancel(string showText)
        {
            return MessageBox.Show(showText, @"提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 展示Info类型信息
        /// </summary>
        /// <param name="showText"></param>
        public static DialogResult ShowInfoCancel(string showText)
        {
            return MessageBox.Show(showText, @"提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}