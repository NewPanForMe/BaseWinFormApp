using System;
using System.IO;
using System.Text;

namespace FileUploadApp
{
    public class LogHelper
    {
        private  string _logFile;
        public int LogCount =0;
        public LogHelper(string fileName)
        {
            string directory = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            _logFile = directory + "\\" + fileName + ".txt";
            if (!File.Exists(_logFile))
            {
                FileStream fs = File.Create(_logFile);
                fs.Close();
            }
        }
        /// <summary>
        /// 追加一行信息
        /// </summary>
        /// <param name="text"></param>
        public void WriteLine(string text)
        {
            text += "\r\n";
            using (StreamWriter sw = new StreamWriter(_logFile, true, Encoding.UTF8))
            {
                if (LogCount == 0)
                    sw.Write("============================================================="+"\r\n");
                sw.Write(DateTime.Now.ToString("【yyyy-MM-dd HH:mm:ss】 ") + text);
            }
        }
    }
}