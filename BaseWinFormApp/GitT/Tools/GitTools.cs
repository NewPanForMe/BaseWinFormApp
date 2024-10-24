using System;
using System.Diagnostics;

namespace GitT.Tools
{
    public  static  class GitTools
    {
        /// <summary>
        /// git文件夹
        /// </summary>
        public static string GitFileFolder=string.Empty;
        public static Process process=null;


        /// <summary>
        /// Git初始化
        /// </summary>
        public static void Init()
        {
            process = new Process();
            process.StartInfo.WorkingDirectory = GitFileFolder;
            process.StartInfo.FileName = "cmd.exe ";
            process.StartInfo.UseShellExecute = false; //是否使用操作系统shell启动
            process.StartInfo.RedirectStandardInput = true; //接受来自调用程序的输入信息
            process.StartInfo.RedirectStandardOutput = true; //由调用程序获取输出信息
            process.StartInfo.RedirectStandardError = true; //重定向标准错误输出
            process.StartInfo.CreateNoWindow = true; //不显示程序窗口
        }

        /// <summary>
        /// 克隆
        /// </summary>
        /// <param name="url"></param>
        public static void Clone(string url)
        {
            Init();
            process.Start();
            //向cmd窗口写入命令
            process.StandardInput.WriteLine($" git clone {url}");
            process.StandardInput.AutoFlush = true;
            process.Close();
        }

        /// <summary>
        /// 推送
        /// </summary>
        public static void Pull( )
        {
            Init();
            process.Start();
            //向cmd窗口写入命令
            process.StandardInput.WriteLine($" git pull ");
            process.StandardInput.AutoFlush = true;
            process.Close();
        }
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="commit">提交备注</param>
        public static void Commit(string commit)
        {
            Init();
            process.Start();
            //向cmd窗口写入命令
            process.StandardInput.WriteLine($" git add  . ");
            process.StandardInput.WriteLine($" git commit -m {commit} ");
            process.StandardInput.AutoFlush = true;

            process.Close();
        }

        /// <summary>
        /// 推送
        /// </summary>
        public static void Push()
        {
            Init();
            process.Start();
            //向cmd窗口写入命令
            process.StandardInput.WriteLine($" git push ");
            process.StandardInput.AutoFlush = true;
            process.WaitForExit();
            process.Close();

        }
    }
}
