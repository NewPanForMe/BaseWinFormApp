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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.osVersionTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.is64BitTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 96);
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
            // FormSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSystem";
            this.Text = "FormSystem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}