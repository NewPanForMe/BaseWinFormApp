using System;
using System.IO;
using System.Windows.Forms;

namespace FileUploadApp.Form.FileT
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private string dirname = "";
        private int count = 1;

        public Form1()
        {
            InitializeComponent();
            richTextBox.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            string path = "";
            folderBrowserDialog.Description = "请选择文件夹";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;//将选择页面控制在桌面
            folderBrowserDialog.ShowNewFolderButton = false;//设置是否展示新建文件俺家
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
            }
            fileNameText.Text = path;
            fileNameText.ReadOnly = true;
            this.richTextBox.Text = "";
            GetDic(path);
        }

        private void GetDic(string path)
        {
        
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    DirectoryInfo dir = new DirectoryInfo(path);
                    FileInfo[] fileSystemInfo = dir.GetFiles();
                    DirectoryInfo[] dicInfos = dir.GetDirectories();
                    Write(fileSystemInfo);
                    ReadAndWrite(dicInfos);
                }
                count = 1;
                dirname = "";
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
                richTextBox.Text += count + @"、" + dirname + @"/" + item.Name + @"\r\n";
                count++;
            }
        }
        private void ReadAndWrite(DirectoryInfo[] dicInfos)
        {
            foreach (DirectoryInfo dd in dicInfos)
            {
                    if (!string.IsNullOrEmpty(dirname)) dirname += "/" + dd.Name;
                    else dirname += dd.Name;
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
            count = 1;
            dirname = "";
        }


    }

}
