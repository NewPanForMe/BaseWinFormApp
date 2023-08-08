using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SysT
{
    public partial class FormSystem : Form
    {
        private Dictionary<string,string > _lDictionary = new Dictionary<string,string>();


        /// <summary>
        /// cpu信息
        /// </summary>
        private const string CpuPath = "Win32_Processor";

        /// <summary>
        /// 磁盘信息
        /// </summary>
        private const string DiskPath = "Win32_DiskDrive";// Win32_PhysicalMedia

        public FormSystem()
        {
            InitializeComponent();
            Init();//基础信息加载
            ReadOnly();//只读加载
            //tick启动
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void Init()
        {
            InitSystemInfo();
            GetCpu();
            GetDisk();
        }

        private void ReadOnly()
        {
            is64BitTb.ReadOnly = true;
            osVersionTb.ReadOnly = true;
            CPUTb.ReadOnly = true;
            cpuCoresTb.ReadOnly= true;
            cpuEnableCoresTb.ReadOnly = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }


        private void InitSystemInfo()
        {
            is64BitTb.Text = Environment.Is64BitOperatingSystem ? "是" : "否";
            osVersionTb.Text = RuntimeInformation.OSDescription;

        }
        /// <summary>
        /// 获得CPU信息
        /// </summary>
        private void GetCpu()
        {
            var moc = new ManagementClass(CpuPath).GetInstances();
            foreach (var mo in moc)
            {
                foreach (var item in mo.Properties)
                {
                    if (item.Name == "Name")
                    {
                        CPUTb.Text = item.Value.ToString();
                    }
                    if (item.Name == "NumberOfCores")
                    {
                        cpuCoresTb.Text = item.Value.ToString();
                    }
                    if (item.Name == "NumberOfEnabledCore")
                    {
                        cpuEnableCoresTb.Text = item.Value.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// 获取磁盘信息
        /// </summary>
        private void GetDisk()
        {
            
            var moc = new ManagementClass(DiskPath).GetInstances();
            foreach (var mo in moc)
            {
                foreach (var item in mo.Properties)
                {
                    if (!_lDictionary.ContainsKey(item.Name))
                    {
                        _lDictionary.Add(item.Name, item.Value == null ? "" : item.Value.ToString());
                    }
                }
            }
        }
    }

 
}
