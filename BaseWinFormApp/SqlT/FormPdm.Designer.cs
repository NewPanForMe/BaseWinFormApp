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
            this.button1 = new System.Windows.Forms.Button();
            this.genClassPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectPdmBtn
            // 
            this.selectPdmBtn.Location = new System.Drawing.Point(12, 12);
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
            this.pdmPathLabel.Location = new System.Drawing.Point(176, 25);
            this.pdmPathLabel.Name = "pdmPathLabel";
            this.pdmPathLabel.Size = new System.Drawing.Size(98, 14);
            this.pdmPathLabel.TabIndex = 1;
            this.pdmPathLabel.Text = "请选择PDM文件";
            this.pdmPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genSqlBtn
            // 
            this.genSqlBtn.Location = new System.Drawing.Point(12, 61);
            this.genSqlBtn.Name = "genSqlBtn";
            this.genSqlBtn.Size = new System.Drawing.Size(158, 39);
            this.genSqlBtn.TabIndex = 2;
            this.genSqlBtn.Text = "生成SQL";
            this.genSqlBtn.UseVisualStyleBackColor = true;
            this.genSqlBtn.Click += new System.EventHandler(this.genSqlBtn_Click);
            // 
            // sqlTypeComb
            // 
            this.sqlTypeComb.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlTypeComb.FormattingEnabled = true;
            this.sqlTypeComb.Location = new System.Drawing.Point(179, 63);
            this.sqlTypeComb.Name = "sqlTypeComb";
            this.sqlTypeComb.Size = new System.Drawing.Size(176, 37);
            this.sqlTypeComb.TabIndex = 3;
            // 
            // pdmResRichBx
            // 
            this.pdmResRichBx.Location = new System.Drawing.Point(12, 151);
            this.pdmResRichBx.Name = "pdmResRichBx";
            this.pdmResRichBx.Size = new System.Drawing.Size(343, 283);
            this.pdmResRichBx.TabIndex = 4;
            this.pdmResRichBx.Text = "";
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(12, 106);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(343, 39);
            this.copyBtn.TabIndex = 5;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // genClass
            // 
            this.genClass.Location = new System.Drawing.Point(361, 45);
            this.genClass.Name = "genClass";
            this.genClass.Size = new System.Drawing.Size(381, 39);
            this.genClass.TabIndex = 6;
            this.genClass.Text = "生成Class";
            this.genClass.UseVisualStyleBackColor = true;
            this.genClass.Click += new System.EventHandler(this.genClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "命名空间：";
            // 
            // nameSpaceTbx
            // 
            this.nameSpaceTbx.BackColor = System.Drawing.SystemColors.Window;
            this.nameSpaceTbx.Location = new System.Drawing.Point(430, 12);
            this.nameSpaceTbx.Multiline = true;
            this.nameSpaceTbx.Name = "nameSpaceTbx";
            this.nameSpaceTbx.Size = new System.Drawing.Size(113, 27);
            this.nameSpaceTbx.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "文件位置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // genClassPath
            // 
            this.genClassPath.BackColor = System.Drawing.SystemColors.Window;
            this.genClassPath.Location = new System.Drawing.Point(629, 12);
            this.genClassPath.Multiline = true;
            this.genClassPath.Name = "genClassPath";
            this.genClassPath.Size = new System.Drawing.Size(113, 27);
            this.genClassPath.TabIndex = 11;
            // 
            // FormPdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 446);
            this.Controls.Add(this.genClassPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameSpaceTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genClass);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.pdmResRichBx);
            this.Controls.Add(this.sqlTypeComb);
            this.Controls.Add(this.genSqlBtn);
            this.Controls.Add(this.pdmPathLabel);
            this.Controls.Add(this.selectPdmBtn);
            this.Name = "FormPdm";
            this.Text = "     ";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox genClassPath;
    }
}