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
            this.SuspendLayout();
            // 
            // selectPdmBtn
            // 
            this.selectPdmBtn.Location = new System.Drawing.Point(12, 12);
            this.selectPdmBtn.Name = "selectPdmBtn";
            this.selectPdmBtn.Size = new System.Drawing.Size(141, 43);
            this.selectPdmBtn.TabIndex = 0;
            this.selectPdmBtn.Text = "选择PDM文件";
            this.selectPdmBtn.UseVisualStyleBackColor = true;
            this.selectPdmBtn.Click += new System.EventHandler(this.selectPdmBtn_Click);
            // 
            // pdmPathLabel
            // 
            this.pdmPathLabel.AutoSize = true;
            this.pdmPathLabel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pdmPathLabel.Location = new System.Drawing.Point(156, 25);
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
            this.genSqlBtn.Size = new System.Drawing.Size(141, 39);
            this.genSqlBtn.TabIndex = 2;
            this.genSqlBtn.Text = "生成SQL";
            this.genSqlBtn.UseVisualStyleBackColor = true;
            this.genSqlBtn.Click += new System.EventHandler(this.genSqlBtn_Click);
            // 
            // sqlTypeComb
            // 
            this.sqlTypeComb.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sqlTypeComb.FormattingEnabled = true;
            this.sqlTypeComb.Location = new System.Drawing.Point(159, 64);
            this.sqlTypeComb.Name = "sqlTypeComb";
            this.sqlTypeComb.Size = new System.Drawing.Size(224, 37);
            this.sqlTypeComb.TabIndex = 3;
            // 
            // pdmResRichBx
            // 
            this.pdmResRichBx.Location = new System.Drawing.Point(12, 151);
            this.pdmResRichBx.Name = "pdmResRichBx";
            this.pdmResRichBx.Size = new System.Drawing.Size(371, 283);
            this.pdmResRichBx.TabIndex = 4;
            this.pdmResRichBx.Text = "";
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(12, 106);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(141, 39);
            this.copyBtn.TabIndex = 5;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // FormPdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 446);
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
    }
}