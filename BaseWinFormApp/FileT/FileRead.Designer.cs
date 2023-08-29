namespace FileT
{
    partial class FileRead
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
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.fileLbl = new System.Windows.Forms.Label();
            this.contentRichTb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(16, 15);
            this.selectFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(176, 102);
            this.selectFileBtn.TabIndex = 0;
            this.selectFileBtn.Text = "选择文件";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Location = new System.Drawing.Point(200, 59);
            this.fileLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(55, 15);
            this.fileLbl.TabIndex = 1;
            this.fileLbl.Text = "label1";
            // 
            // contentRichTb
            // 
            this.contentRichTb.Location = new System.Drawing.Point(13, 125);
            this.contentRichTb.Name = "contentRichTb";
            this.contentRichTb.Size = new System.Drawing.Size(524, 425);
            this.contentRichTb.TabIndex = 2;
            this.contentRichTb.Text = "";
            // 
            // FileRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.contentRichTb);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.selectFileBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FileRead";
            this.Text = "FileRead";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Label fileLbl;
        private System.Windows.Forms.RichTextBox contentRichTb;
    }
}