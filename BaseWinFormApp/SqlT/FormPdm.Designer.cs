namespace SqlT
{
    partial class FormPdm
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
            this.selectPdmBtn = new System.Windows.Forms.Button();
            this.pdmPathLabel = new System.Windows.Forms.Label();
            this.genSqlBtn = new System.Windows.Forms.Button();
            this.sqlTypeComb = new System.Windows.Forms.ComboBox();
            this.pdmResRichBx = new System.Windows.Forms.RichTextBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.genClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameSpaceTbx = new System.Windows.Forms.TextBox();
            this.selectGenClassBtn = new System.Windows.Forms.Button();
            this.genClassPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.execSqlBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPdmBtn
            // 
            this.selectPdmBtn.Location = new System.Drawing.Point(0, 12);
            this.selectPdmBtn.Name = "selectPdmBtn";
            this.selectPdmBtn.Size = new System.Drawing.Size(158, 43);
            this.selectPdmBtn.TabIndex = 0;
            this.selectPdmBtn.Text = "选择PDM文件";
            this.selectPdmBtn.UseVisualStyleBackColor = true;
            this.selectPdmBtn.Click += new System.EventHandler(this.selectPdmBtn_Click);
            // 
            // pdmPathLabel
            // 
            this.pdmPathLabel.AutoSize = true;
            this.pdmPathLabel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pdmPathLabel.Location = new System.Drawing.Point(170, 25);
            this.pdmPathLabel.Name = "pdmPathLabel";
            this.pdmPathLabel.Size = new System.Drawing.Size(98, 14);
            this.pdmPathLabel.TabIndex = 1;
            this.pdmPathLabel.Text = "请选择PDM文件";
            this.pdmPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genSqlBtn
            // 
            this.genSqlBtn.Location = new System.Drawing.Point(6, 15);
            this.genSqlBtn.Name = "genSqlBtn";
            this.genSqlBtn.Size = new System.Drawing.Size(152, 39);
            this.genSqlBtn.TabIndex = 2;
            this.genSqlBtn.Text = "生成SQL";
            this.genSqlBtn.UseVisualStyleBackColor = true;
            this.genSqlBtn.Click += new System.EventHandler(this.genSqlBtn_Click);
            // 
            // sqlTypeComb
            // 
            this.sqlTypeComb.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlTypeComb.FormattingEnabled = true;
            this.sqlTypeComb.Location = new System.Drawing.Point(167, 17);
            this.sqlTypeComb.Name = "sqlTypeComb";
            this.sqlTypeComb.Size = new System.Drawing.Size(170, 37);
            this.sqlTypeComb.TabIndex = 3;
            // 
            // pdmResRichBx
            // 
            this.pdmResRichBx.Location = new System.Drawing.Point(6, 105);
            this.pdmResRichBx.Name = "pdmResRichBx";
            this.pdmResRichBx.Size = new System.Drawing.Size(331, 106);
            this.pdmResRichBx.TabIndex = 4;
            this.pdmResRichBx.Text = "";
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(6, 60);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(152, 39);
            this.copyBtn.TabIndex = 5;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // genClass
            // 
            this.genClass.Location = new System.Drawing.Point(4, 114);
            this.genClass.Name = "genClass";
            this.genClass.Size = new System.Drawing.Size(366, 39);
            this.genClass.TabIndex = 6;
            this.genClass.Text = "生成Class";
            this.genClass.UseVisualStyleBackColor = true;
            this.genClass.Click += new System.EventHandler(this.genClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "命名空间：";
            // 
            // nameSpaceTbx
            // 
            this.nameSpaceTbx.BackColor = System.Drawing.SystemColors.Window;
            this.nameSpaceTbx.Location = new System.Drawing.Point(99, 20);
            this.nameSpaceTbx.Multiline = true;
            this.nameSpaceTbx.Name = "nameSpaceTbx";
            this.nameSpaceTbx.Size = new System.Drawing.Size(271, 43);
            this.nameSpaceTbx.TabIndex = 9;
            // 
            // selectGenClassBtn
            // 
            this.selectGenClassBtn.Location = new System.Drawing.Point(4, 69);
            this.selectGenClassBtn.Name = "selectGenClassBtn";
            this.selectGenClassBtn.Size = new System.Drawing.Size(89, 39);
            this.selectGenClassBtn.TabIndex = 10;
            this.selectGenClassBtn.Text = "文件位置";
            this.selectGenClassBtn.UseVisualStyleBackColor = true;
            this.selectGenClassBtn.Click += new System.EventHandler(this.selectGenClassBtn_Click);
            // 
            // genClassPath
            // 
            this.genClassPath.BackColor = System.Drawing.SystemColors.Window;
            this.genClassPath.Location = new System.Drawing.Point(99, 71);
            this.genClassPath.Multiline = true;
            this.genClassPath.Name = "genClassPath";
            this.genClassPath.Size = new System.Drawing.Size(271, 37);
            this.genClassPath.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameSpaceTbx);
            this.groupBox1.Controls.Add(this.genClassPath);
            this.groupBox1.Controls.Add(this.genClass);
            this.groupBox1.Controls.Add(this.selectGenClassBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(366, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 166);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类文件生成";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectPdmBtn);
            this.groupBox2.Controls.Add(this.pdmPathLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 63);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PDM选择";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.execSqlBtn);
            this.groupBox3.Controls.Add(this.pdmResRichBx);
            this.groupBox3.Controls.Add(this.genSqlBtn);
            this.groupBox3.Controls.Add(this.sqlTypeComb);
            this.groupBox3.Controls.Add(this.copyBtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 222);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SQL生成区";
            // 
            // execSqlBtn
            // 
            this.execSqlBtn.Location = new System.Drawing.Point(167, 61);
            this.execSqlBtn.Name = "execSqlBtn";
            this.execSqlBtn.Size = new System.Drawing.Size(169, 38);
            this.execSqlBtn.TabIndex = 6;
            this.execSqlBtn.Text = "执行建表SQL";
            this.execSqlBtn.UseVisualStyleBackColor = true;
            this.execSqlBtn.Click += new System.EventHandler(this.execSqlBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.testConnBtn);
            this.groupBox4.Controls.Add(this.passwordTb);
            this.groupBox4.Controls.Add(this.dbNameTb);
            this.groupBox4.Controls.Add(this.userNameTb);
            this.groupBox4.Controls.Add(this.dbIpTb);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 309);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 117);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据库信息记录";
            // 
            // testConnBtn
            // 
            this.testConnBtn.Location = new System.Drawing.Point(273, 17);
            this.testConnBtn.Name = "testConnBtn";
            this.testConnBtn.Size = new System.Drawing.Size(62, 94);
            this.testConnBtn.TabIndex = 34;
            this.testConnBtn.Text = "测试链接";
            this.testConnBtn.UseVisualStyleBackColor = true;
            this.testConnBtn.Click += new System.EventHandler(this.testConnBtn_Click);
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(78, 66);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(189, 21);
            this.passwordTb.TabIndex = 23;
            // 
            // dbNameTb
            // 
            this.dbNameTb.Location = new System.Drawing.Point(78, 90);
            this.dbNameTb.Name = "dbNameTb";
            this.dbNameTb.Size = new System.Drawing.Size(189, 21);
            this.dbNameTb.TabIndex = 22;
            // 
            // userNameTb
            // 
            this.userNameTb.Location = new System.Drawing.Point(78, 39);
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.Size = new System.Drawing.Size(190, 21);
            this.userNameTb.TabIndex = 21;
            // 
            // dbIpTb
            // 
            this.dbIpTb.Location = new System.Drawing.Point(78, 14);
            this.dbIpTb.Name = "dbIpTb";
            this.dbIpTb.Size = new System.Drawing.Size(190, 21);
            this.dbIpTb.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(27, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(39, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "数据库名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "数据库IP";
            // 
            // sqlConnComBx
            // 
            this.sqlConnComBx.FormattingEnabled = true;
            this.sqlConnComBx.Location = new System.Drawing.Point(370, 184);
            this.sqlConnComBx.Name = "sqlConnComBx";
            this.sqlConnComBx.Size = new System.Drawing.Size(366, 20);
            this.sqlConnComBx.TabIndex = 16;
            this.sqlConnComBx.SelectedIndexChanged += new System.EventHandler(this.sqlConnComBx_Change);
            // 
            // FormPdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 437);
            this.Controls.Add(this.sqlConnComBx);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPdm";
            this.Text = "     ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectPdmBtn;
        private System.Windows.Forms.Label pdmPathLabel;
        private System.Windows.Forms.Button genSqlBtn;
        private System.Windows.Forms.ComboBox sqlTypeComb;
        private System.Windows.Forms.RichTextBox pdmResRichBx;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button genClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameSpaceTbx;
        private System.Windows.Forms.Button selectGenClassBtn;
        private System.Windows.Forms.TextBox genClassPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button execSqlBtn;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox dbNameTb;
        private System.Windows.Forms.TextBox userNameTb;
        private System.Windows.Forms.TextBox dbIpTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button testConnBtn;
        private System.Windows.Forms.ComboBox sqlConnComBx;
    }
}