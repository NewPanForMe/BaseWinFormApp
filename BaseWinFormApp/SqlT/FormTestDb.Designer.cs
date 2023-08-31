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
            this.SuspendLayout();
            // 
            // testConnBtn
            // 
            this.testConnBtn.Location = new System.Drawing.Point(475, 130);
            this.testConnBtn.Name = "testConnBtn";
            this.testConnBtn.Size = new System.Drawing.Size(62, 94);
            this.testConnBtn.TabIndex = 33;
            this.testConnBtn.Text = "测试链接";
            this.testConnBtn.UseVisualStyleBackColor = true;
            this.testConnBtn.Click += new System.EventHandler(this.testConnBtn_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(279, 179);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(189, 21);
            this.passwordTb.TabIndex = 32;
            // 
            // dbNameTb
            // 
            this.dbNameTb.Location = new System.Drawing.Point(279, 203);
            this.dbNameTb.Name = "dbNameTb";
            this.dbNameTb.Size = new System.Drawing.Size(189, 21);
            this.dbNameTb.TabIndex = 31;
            // 
            // userNameTb
            // 
            this.userNameTb.Location = new System.Drawing.Point(279, 152);
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.Size = new System.Drawing.Size(189, 21);
            this.userNameTb.TabIndex = 30;
            // 
            // dbIpTb
            // 
            this.dbIpTb.Location = new System.Drawing.Point(279, 127);
            this.dbIpTb.Name = "dbIpTb";
            this.dbIpTb.Size = new System.Drawing.Size(189, 21);
            this.dbIpTb.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(228, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(240, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(204, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "数据库名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(216, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "数据库IP";
            // 
            // sqlConnComBx
            // 
            this.sqlConnComBx.FormattingEnabled = true;
            this.sqlConnComBx.Location = new System.Drawing.Point(149, 78);
            this.sqlConnComBx.Name = "sqlConnComBx";
            this.sqlConnComBx.Size = new System.Drawing.Size(503, 20);
            this.sqlConnComBx.TabIndex = 34;
            this.sqlConnComBx.SelectedIndexChanged += new System.EventHandler(this.sqlConnComBx_SelectedIndexChanged);
            // 
            // FormTestDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sqlConnComBx);
            this.Controls.Add(this.testConnBtn);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.dbNameTb);
            this.Controls.Add(this.userNameTb);
            this.Controls.Add(this.dbIpTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormTestDb";
            this.Text = "FormTestDb";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}