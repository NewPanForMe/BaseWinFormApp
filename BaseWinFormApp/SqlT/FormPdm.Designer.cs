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
            this.pdmPathLabel.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pdmPathLabel.Location = new System.Drawing.Point(159, 20);
            this.pdmPathLabel.Name = "pdmPathLabel";
            this.pdmPathLabel.Size = new System.Drawing.Size(96, 27);
            this.pdmPathLabel.TabIndex = 1;
            this.pdmPathLabel.Text = "label1";
            this.pdmPathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}