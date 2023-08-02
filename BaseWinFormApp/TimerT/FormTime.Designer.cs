namespace TimerT
{
    partial class FormTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yyLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mouLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ddLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hhLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MinMinLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ssLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(154, 296);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(89, 38);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "开始";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(514, 296);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(89, 38);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "重置";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(344, 297);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(89, 38);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "暂停";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(500, 172);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(114, 80);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "秒";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minLabel.Location = new System.Drawing.Point(380, 172);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(114, 80);
            this.minLabel.TabIndex = 5;
            this.minLabel.Text = "分";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hourLabel.Location = new System.Drawing.Point(260, 172);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(114, 80);
            this.hourLabel.TabIndex = 6;
            this.hourLabel.Text = "时";
            this.hourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dayLabel.Location = new System.Drawing.Point(140, 172);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(114, 80);
            this.dayLabel.TabIndex = 7;
            this.dayLabel.Text = "天";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(233, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "天";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(473, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "分";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(593, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "秒";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(353, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "时";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yyLabel
            // 
            this.yyLabel.AutoSize = true;
            this.yyLabel.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yyLabel.Location = new System.Drawing.Point(12, 29);
            this.yyLabel.Name = "yyLabel";
            this.yyLabel.Size = new System.Drawing.Size(77, 54);
            this.yyLabel.TabIndex = 12;
            this.yyLabel.Text = "年";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "年";
            // 
            // mouLabel
            // 
            this.mouLabel.AutoSize = true;
            this.mouLabel.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mouLabel.Location = new System.Drawing.Point(166, 29);
            this.mouLabel.Name = "mouLabel";
            this.mouLabel.Size = new System.Drawing.Size(77, 54);
            this.mouLabel.TabIndex = 14;
            this.mouLabel.Text = "月";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "月";
            // 
            // ddLabel
            // 
            this.ddLabel.AutoSize = true;
            this.ddLabel.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ddLabel.Location = new System.Drawing.Point(284, 29);
            this.ddLabel.Name = "ddLabel";
            this.ddLabel.Size = new System.Drawing.Size(77, 54);
            this.ddLabel.TabIndex = 16;
            this.ddLabel.Text = "日";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "日";
            // 
            // hhLabel
            // 
            this.hhLabel.AutoSize = true;
            this.hhLabel.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hhLabel.Location = new System.Drawing.Point(441, 29);
            this.hhLabel.Name = "hhLabel";
            this.hhLabel.Size = new System.Drawing.Size(77, 54);
            this.hhLabel.TabIndex = 18;
            this.hhLabel.Text = "时";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(524, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "时";
            // 
            // MinMinLabel
            // 
            this.MinMinLabel.AutoSize = true;
            this.MinMinLabel.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinMinLabel.Location = new System.Drawing.Point(555, 29);
            this.MinMinLabel.Name = "MinMinLabel";
            this.MinMinLabel.Size = new System.Drawing.Size(77, 54);
            this.MinMinLabel.TabIndex = 20;
            this.MinMinLabel.Text = "分";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(638, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "分";
            // 
            // ssLabel
            // 
            this.ssLabel.AutoSize = true;
            this.ssLabel.Font = new System.Drawing.Font("宋体", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ssLabel.Location = new System.Drawing.Point(662, 29);
            this.ssLabel.Name = "ssLabel";
            this.ssLabel.Size = new System.Drawing.Size(77, 54);
            this.ssLabel.TabIndex = 22;
            this.ssLabel.Text = "秒";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(745, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "秒";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ssLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.MinMinLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.hhLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ddLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mouLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yyLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.startBtn);
            this.Name = "FormTime";
            this.Text = "FormTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label yyLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mouLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ddLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label hhLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label MinMinLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label ssLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer2;
    }
}