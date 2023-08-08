namespace SysT
{
    partial class FormSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.is64BitTb = new System.Windows.Forms.TextBox();
            this.osVersionTb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cpuCoresTb = new System.Windows.Forms.TextBox();
            this.cpuEnableCoresTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CPUTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.leaveBattaryTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.leaveMiniuteTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pullBattaryTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.computerNameTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.netTb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "64位系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "当前系统版本";
            // 
            // is64BitTb
            // 
            this.is64BitTb.Location = new System.Drawing.Point(89, 14);
            this.is64BitTb.Name = "is64BitTb";
            this.is64BitTb.Size = new System.Drawing.Size(292, 21);
            this.is64BitTb.TabIndex = 3;
            // 
            // osVersionTb
            // 
            this.osVersionTb.Location = new System.Drawing.Point(89, 41);
            this.osVersionTb.Name = "osVersionTb";
            this.osVersionTb.Size = new System.Drawing.Size(292, 21);
            this.osVersionTb.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.netTb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.computerNameTb);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.osVersionTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.is64BitTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 132);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cpuCoresTb);
            this.groupBox2.Controls.Add(this.cpuEnableCoresTb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CPUTb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(405, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 96);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU信息";
            // 
            // cpuCoresTb
            // 
            this.cpuCoresTb.Location = new System.Drawing.Point(83, 41);
            this.cpuCoresTb.Name = "cpuCoresTb";
            this.cpuCoresTb.Size = new System.Drawing.Size(294, 21);
            this.cpuCoresTb.TabIndex = 9;
            // 
            // cpuEnableCoresTb
            // 
            this.cpuEnableCoresTb.Location = new System.Drawing.Point(83, 68);
            this.cpuEnableCoresTb.Name = "cpuEnableCoresTb";
            this.cpuEnableCoresTb.Size = new System.Drawing.Size(294, 21);
            this.cpuEnableCoresTb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "CPU启用核心";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPU核心";
            // 
            // CPUTb
            // 
            this.CPUTb.Location = new System.Drawing.Point(83, 14);
            this.CPUTb.Name = "CPUTb";
            this.CPUTb.Size = new System.Drawing.Size(294, 21);
            this.CPUTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPU";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pullBattaryTb);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.leaveMiniuteTb);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.leaveBattaryTb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "电池信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "剩余电量";
            // 
            // leaveBattaryTb
            // 
            this.leaveBattaryTb.Location = new System.Drawing.Point(89, 14);
            this.leaveBattaryTb.Name = "leaveBattaryTb";
            this.leaveBattaryTb.Size = new System.Drawing.Size(292, 21);
            this.leaveBattaryTb.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "可用时间";
            // 
            // leaveMiniuteTb
            // 
            this.leaveMiniuteTb.Location = new System.Drawing.Point(89, 41);
            this.leaveMiniuteTb.Name = "leaveMiniuteTb";
            this.leaveMiniuteTb.Size = new System.Drawing.Size(292, 21);
            this.leaveMiniuteTb.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "充电状态";
            // 
            // pullBattaryTb
            // 
            this.pullBattaryTb.Location = new System.Drawing.Point(89, 69);
            this.pullBattaryTb.Name = "pullBattaryTb";
            this.pullBattaryTb.Size = new System.Drawing.Size(292, 21);
            this.pullBattaryTb.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "计算机名称";
            // 
            // computerNameTb
            // 
            this.computerNameTb.Location = new System.Drawing.Point(89, 68);
            this.computerNameTb.Name = "computerNameTb";
            this.computerNameTb.Size = new System.Drawing.Size(292, 21);
            this.computerNameTb.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "联网状态";
            // 
            // netTb
            // 
            this.netTb.Location = new System.Drawing.Point(89, 95);
            this.netTb.Name = "netTb";
            this.netTb.Size = new System.Drawing.Size(292, 21);
            this.netTb.TabIndex = 8;
            // 
            // FormSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSystem";
            this.Text = "FormSystem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox is64BitTb;
        private System.Windows.Forms.TextBox osVersionTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPUTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpuCoresTb;
        private System.Windows.Forms.TextBox cpuEnableCoresTb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox leaveBattaryTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox leaveMiniuteTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pullBattaryTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox computerNameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox netTb;
    }
}