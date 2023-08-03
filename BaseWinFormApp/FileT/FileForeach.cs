using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileT
{

    public partial class FileForeach : System.Windows.Forms.Form
    {
        private string _dirName = "";
        private int _count = 1;
        private string _path = "";

        public FileForeach()
        {
            InitializeComponent();
            richTextBox.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = @"请选择文件夹";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;//将选择页面控制在桌面
            folderBrowserDialog.ShowNewFolderButton = false;//设置是否展示新建文件俺家
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _path = folderBrowserDialog.SelectedPath;
            }
            fileNameText.Text = _path;
            fileNameText.ReadOnly = true;
            this.richTextBox.Text = "";
            GetDic(_path);
        }

        private void GetDic(string path)
        {

            try
            {
                Console.WriteLine(path);
                if (!string.IsNullOrEmpty(path))
                {
                    DirectoryInfo dir = new DirectoryInfo(path);
                    FileInfo[] fileSystemInfo = dir.GetFiles();
                    DirectoryInfo[] dicInfos = dir.GetDirectories();
                    Write(fileSystemInfo);
                    ReadAndWrite(dicInfos);
                }
                _count = 1;
                _dirName = "";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        private void Write(FileInfo[] fileSystemInfo)
        {
            foreach (var item in fileSystemInfo)
            {
                richTextBox.Text += $@"{_count},{_path}\{_dirName}\{item.Name}" + "\r\n";
                _count++;
            }
        }
        private void ReadAndWrite(DirectoryInfo[] dicInfos)
        {
            foreach (DirectoryInfo dd in dicInfos)
            {
                if (!string.IsNullOrEmpty(_dirName)) _dirName += "\\" + dd.Name;
                else _dirName += dd.Name;
                FileInfo[] fileSystemInfo = dd.GetFiles();
                Write(fileSystemInfo);
                ReadAndWrite(dd.GetDirectories());
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string uid = Guid.NewGuid().ToString();
            this.richTextBox.Text = "";
            this.richTextBox.Text = uid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            this.richTextBox.Text = "";
            fileNameText.Text = "";
            _count = 1;
            _dirName = "";
        }

    }



}
