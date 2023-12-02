namespace SqlT
{
    partial class FormTestDb
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
            this.testConnBtn = new System.Windows.Forms.Button();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.dbNameTb = new System.Windows.Forms.TextBox();
            this.userNameTb = new System.Windows.Forms.TextBox();
            this.dbIpTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlConnComBx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PgTestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PgPasswordTb = new System.Windows.Forms.TextBox();
            this.PgIpText = new System.Windows.Forms.TextBox();
            this.PgDbNameTb = new System.Windows.Forms.TextBox();
            this.PgUsernameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PgPortTb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // testConnBtn
            // 
            this.testConnBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.testConnBtn.Location = new System.Drawing.Point(278, 52);
            this.testConnBtn.Name = "testConnBtn";
            this.testConnBtn.Size = new System.Drawing.Size(62, 94);
            this.testConnBtn.TabIndex = 33;
            this.testConnBtn.Text = "测试链接";
            this.testConnBtn.UseVisualStyleBackColor = true;
            this.testConnBtn.Click += new System.EventHandler(this.testConnBtn_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTb.Location = new System.Drawing.Point(83, 125);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(189, 21);
            this.passwordTb.TabIndex = 32;
            // 
            // dbNameTb
            // 
            this.dbNameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dbNameTb.Location = new System.Drawing.Point(83, 101);
            this.dbNameTb.Name = "dbNameTb";
            this.dbNameTb.Size = new System.Drawing.Size(189, 21);
            this.dbNameTb.TabIndex = 31;
            // 
            // userNameTb
            // 
            this.userNameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userNameTb.Location = new System.Drawing.Point(82, 74);
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.Size = new System.Drawing.Size(189, 21);
            this.userNameTb.TabIndex = 30;
            // 
            // dbIpTb
            // 
            this.dbIpTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dbIpTb.Location = new System.Drawing.Point(82, 49);
            this.dbIpTb.Name = "dbIpTb";
            this.dbIpTb.Size = new System.Drawing.Size(189, 21);
            this.dbIpTb.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "用户名";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(10, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "密码";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "数据库名称";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "数据库IP";
            // 
            // sqlConnComBx
            // 
            this.sqlConnComBx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sqlConnComBx.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlConnComBx.FormattingEnabled = true;
            this.sqlConnComBx.Location = new System.Drawing.Point(12, 11);
            this.sqlConnComBx.Name = "sqlConnComBx";
            this.sqlConnComBx.Size = new System.Drawing.Size(788, 27);
            this.sqlConnComBx.TabIndex = 34;
            this.sqlConnComBx.SelectedIndexChanged += new System.EventHandler(this.sqlConnComBx_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testConnBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.passwordTb);
            this.groupBox1.Controls.Add(this.dbIpTb);
            this.groupBox1.Controls.Add(this.dbNameTb);
            this.groupBox1.Controls.Add(this.userNameTb);
            this.groupBox1.Location = new System.Drawing.Point(15, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 159);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.PgPortTb);
            this.groupBox2.Controls.Add(this.PgTestBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.PgPasswordTb);
            this.groupBox2.Controls.Add(this.PgIpText);
            this.groupBox2.Controls.Add(this.PgDbNameTb);
            this.groupBox2.Controls.Add(this.PgUsernameTb);
            this.groupBox2.Location = new System.Drawing.Point(420, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 159);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PgSQL";
            // 
            // PgTestBtn
            // 
            this.PgTestBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PgTestBtn.Location = new System.Drawing.Point(280, 30);
            this.PgTestBtn.Name = "PgTestBtn";
            this.PgTestBtn.Size = new System.Drawing.Size(62, 110);
            this.PgTestBtn.TabIndex = 42;
            this.PgTestBtn.Text = "测试链接";
            this.PgTestBtn.UseVisualStyleBackColor = true;
            this.PgTestBtn.Click += new System.EventHandler(this.PgTestBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "数据库IP";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "数据库名称";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "密码";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(13, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 37;
            this.label8.Text = "用户名";
            // 
            // PgPasswordTb
            // 
            this.PgPasswordTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PgPasswordTb.Location = new System.Drawing.Point(85, 119);
            this.PgPasswordTb.Name = "PgPasswordTb";
            this.PgPasswordTb.Size = new System.Drawing.Size(189, 21);
            this.PgPasswordTb.TabIndex = 41;
            // 
            // PgIpText
            // 
            this.PgIpText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PgIpText.Location = new System.Drawing.Point(85, 27);
            this.PgIpText.Name = "PgIpText";
            this.PgIpText.Size = new System.Drawing.Size(189, 21);
            this.PgIpText.TabIndex = 38;
            // 
            // PgDbNameTb
            // 
            this.PgDbNameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PgDbNameTb.Location = new System.Drawing.Point(85, 95);
            this.PgDbNameTb.Name = "PgDbNameTb";
            this.PgDbNameTb.Size = new System.Drawing.Size(189, 21);
            this.PgDbNameTb.TabIndex = 40;
            // 
            // PgUsernameTb
            // 
            this.PgUsernameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PgUsernameTb.Location = new System.Drawing.Point(85, 52);
            this.PgUsernameTb.Name = "PgUsernameTb";
            this.PgUsernameTb.Size = new System.Drawing.Size(189, 21);
            this.PgUsernameTb.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(13, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 43;
            this.label9.Text = "端口";
            // 
            // PgPortTb
            // 
            this.PgPortTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PgPortTb.Location = new System.Drawing.Point(85, 74);
            this.PgPortTb.Name = "PgPortTb";
            this.PgPortTb.Size = new System.Drawing.Size(189, 21);
            this.PgPortTb.TabIndex = 44;
            // 
            // FormTestDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sqlConnComBx);
            this.Name = "FormTestDb";
            this.Text = "FormTestDb";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testConnBtn;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox dbNameTb;
        private System.Windows.Forms.TextBox userNameTb;
        private System.Windows.Forms.TextBox dbIpTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sqlConnComBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PgTestBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PgPasswordTb;
        private System.Windows.Forms.TextBox PgIpText;
        private System.Windows.Forms.TextBox PgDbNameTb;
        private System.Windows.Forms.TextBox PgUsernameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PgPortTb;
    }
}