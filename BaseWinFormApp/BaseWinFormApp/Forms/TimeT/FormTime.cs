using System;
using System.Drawing;

namespace FileUploadApp.Forms.TimeT
{
    public partial class FormTime : System.Windows.Forms.Form
    {
        private int currentTime = 0;
        public FormTime()
        {
            InitializeComponent();
            this.timeLabel.Text= currentTime.ToString();
            timeLabel.TextAlign= System.Drawing.ContentAlignment.MiddleCenter;
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
