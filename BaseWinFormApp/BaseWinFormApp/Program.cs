using System;
using System.Diagnostics;
using System.Windows.Forms;
using BaseWinFormApp;

namespace BaseWinFormApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Process[] processes = Process.GetProcesses();
            Process currentProcess = Process.GetCurrentProcess();
            bool processExist = false;
            foreach (Process p in processes)
            {
                if (p.ProcessName == currentProcess.ProcessName && p.Id != currentProcess.Id)
                {
                    processExist = true;
                }
            }

            if (processExist)
            {
                MessageBox.Show($@"当前应用{currentProcess.ProcessName}已打开");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
        }
    }
}
