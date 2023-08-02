using System;
using System.Windows.Forms;

namespace TimerT
{
    public partial class FormTime : Form
    {
        private int _currentTime = 0;
        private int _currentMin = 0;
        private int _currentHour = 0;
        private int _currentDay = 0;

        public FormTime()
        {
            InitializeComponent();
            InitTime();
            timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _currentTime++;

            if (_currentTime == 60)
            {
                _currentTime = 0;
                _currentMin++;
                if (_currentMin == 60)
                {
                    _currentHour++;
                    if (_currentHour == 23)
                    {
                        _currentDay++;
                    }
                }
            }


            InitTime();
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
            ResetTime();
            InitTime();
        }

        private void InitTime()
        {
            this.timeLabel.Text = _currentTime.ToString("D2");
            minLabel.Text = _currentMin.ToString("D2");
            hourLabel.Text = _currentHour.ToString("D2");
            dayLabel.Text = _currentDay.ToString("D2");
        }

        private void ResetTime()
        {
            _currentTime = 0;
            _currentMin = 0;
            _currentHour = 0;
            _currentDay = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            yyLabel.Text = DateTime.Now.Year.ToString();
            mouLabel.Text = DateTime.Now.Month.ToString("D2");
            ddLabel.Text = DateTime.Now.Day.ToString("D2");
            hhLabel.Text = DateTime.Now.Hour.ToString("D2");
            MinMinLabel.Text= DateTime.Now.Minute.ToString("D2");
            ssLabel.Text = DateTime.Now.Second.ToString("D2");
        }
    }
}
