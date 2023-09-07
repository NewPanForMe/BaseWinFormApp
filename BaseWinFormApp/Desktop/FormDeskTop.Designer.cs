namespace Desktop
{
    partial class FormDeskTop
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
            this.shutDownBtn = new System.Windows.Forms.Button();
            this.rebootBtn = new System.Windows.Forms.Button();
            this.versionBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shutDownBtn
            // 
            this.shutDownBtn.Location = new System.Drawing.Point(13, 13);
            this.shutDownBtn.Name = "shutDownBtn";
            this.shutDownBtn.Size = new System.Drawing.Size(72, 62);
            this.shutDownBtn.TabIndex = 0;
            this.shutDownBtn.Text = "关机";
            this.shutDownBtn.UseVisualStyleBackColor = true;
            this.shutDownBtn.Click += new System.EventHandler(this.shutDownBtn_Click);
            // 
            // rebootBtn
            // 
            this.rebootBtn.Location = new System.Drawing.Point(91, 13);
            this.rebootBtn.Name = "rebootBtn";
            this.rebootBtn.Size = new System.Drawing.Size(72, 62);
            this.rebootBtn.TabIndex = 1;
            this.rebootBtn.Text = "重启";
            this.rebootBtn.UseVisualStyleBackColor = true;
            this.rebootBtn.Click += new System.EventHandler(this.rebootBtn_Click);
            // 
            // versionBtn
            // 
            this.versionBtn.Location = new System.Drawing.Point(13, 81);
            this.versionBtn.Name = "versionBtn";
            this.versionBtn.Size = new System.Drawing.Size(72, 62);
            this.versionBtn.TabIndex = 2;
            this.versionBtn.Text = "查看版本";
            this.versionBtn.UseVisualStyleBackColor = true;
            this.versionBtn.Click += new System.EventHandler(this.versionBtn_Click);
            // 
            // FormDeskTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.versionBtn);
            this.Controls.Add(this.rebootBtn);
            this.Controls.Add(this.shutDownBtn);
            this.Name = "FormDeskTop";
            this.Text = "FormDeskTop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shutDownBtn;
        private System.Windows.Forms.Button rebootBtn;
        private System.Windows.Forms.Button versionBtn;
    }
}