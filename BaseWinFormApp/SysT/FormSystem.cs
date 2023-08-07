using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SysT
{
    public partial class FormSystem : Form
    {
        private readonly ManagementClass _management = new ManagementClass();

        public FormSystem()
        {
            InitializeComponent();
            InitBaseInfo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitBaseInfo();
        }


        private void InitBaseInfo()
        {
            this.Is64SysLabel.Text = Environment.Is64BitOperatingSystem ? "是" : "否";
            this.UserNameLabel.Text = Environment.UserName;
            this.VersionLabel.Text = Environment.Version.ToString();



        }


    }
}
