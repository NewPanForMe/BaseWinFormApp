using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerT
{
    public partial class FormTime : Form
    {
        private int currentTime = 0;
        public FormTime()
        {
            InitializeComponent();
            this.timeLabel.Text = currentTime.ToString();
            timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime++;
            this.timeLabel.Text = currentTime.ToString();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            currentTime = 0;
            timeLabel.Text = currentTime.ToString();
        }

    }
}
