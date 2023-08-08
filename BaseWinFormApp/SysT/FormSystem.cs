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
        private Dictionary<string, string> _lDictionary = new Dictionary<string, string>();
        private const string CpuPath = "Win32_Processor";   // cpu信息
        private const string DiskPath = "Win32_DiskPartition";//磁盘信息  Win32_DiskDrive Win32_DiskDriveToDiskPartition  Win32_DiskPartition 
        private const string MemoryPath = "Win32_PhysicalMemory";//内存信息  

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
            // GetDisk();
            GetMemory();
        }

        private void ReadOnly()
        {
            is64BitTb.ReadOnly = true;
            osVersionTb.ReadOnly = true;
            CPUTb.ReadOnly = true;
            cpuCoresTb.ReadOnly = true;
            cpuEnableCoresTb.ReadOnly = true;

            leaveBattaryTb.ReadOnly = true;
            leaveMiniuteTb.ReadOnly = true;
            pullBattaryTb.ReadOnly = true;
            computerNameTb.ReadOnly= true;
            netTb.ReadOnly= true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitBattery();
        }
        /// <summary>
        /// 电池信息
        /// </summary>
        private void InitBattery()
        {
            leaveBattaryTb.Text = SystemInformation.PowerStatus.BatteryLifePercent * 100 + @" %";
            leaveMiniuteTb.Text = SystemInformation.PowerStatus.BatteryLifeRemaining / 60 + @" 分";
            pullBattaryTb.Text = SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline ? "未在充电" : "充电中";

        }


        /// <summary>
        /// 加载基础信息
        /// </summary>
        private void InitSystemInfo()
        {
            is64BitTb.Text = Environment.Is64BitOperatingSystem ? "是" : "否";
            osVersionTb.Text = RuntimeInformation.OSDescription;
            computerNameTb.Text = SystemInformation.ComputerName;
            netTb.Text = SystemInformation.Network ? "已联网" : "未联网";
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
            int x = 0;
            foreach (var mo in moc)
            {
                _lDictionary.Add("分隔符=================="+x, "分隔符==================");
                foreach (var item in mo.Properties)
                {
                        _lDictionary.Add(item.Name+x, item.Value == null ? "" : item.Value.ToString());
                        x++;
                }
            }
        }


        /// <summary>
        /// 获取内存信息
        /// </summary>
        private void GetMemory()
        {

            var moc = new ManagementClass(MemoryPath).GetInstances();
            int x = 0;
            foreach (var mo in moc)
            {
                _lDictionary.Add("分隔符==================" + x, "分隔符==================");
                foreach (var item in mo.Properties)
                {
                    _lDictionary.Add(item.Name + x, item.Value == null ? "" : item.Value.ToString());
                    x++;
                }
            }
        }




    }


}
