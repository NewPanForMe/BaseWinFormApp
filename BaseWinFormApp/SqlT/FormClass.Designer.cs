namespace SqlT
{
    partial class FormClass
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PDMPathTbx = new System.Windows.Forms.TextBox();
            this.selectPdmBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameSpaceTbx = new System.Windows.Forms.TextBox();
            this.genClassPath = new System.Windows.Forms.TextBox();
            this.genClass = new System.Windows.Forms.Button();
            this.selectGenClassBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.PDMPathTbx);
            this.groupBox2.Controls.Add(this.selectPdmBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 121);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PDM选择";
            // 
            // PDMPathTbx
            // 
            this.PDMPathTbx.Location = new System.Drawing.Point(6, 69);
            this.PDMPathTbx.Multiline = true;
            this.PDMPathTbx.Name = "PDMPathTbx";
            this.PDMPathTbx.ReadOnly = true;
            this.PDMPathTbx.Size = new System.Drawing.Size(372, 36);
            this.PDMPathTbx.TabIndex = 2;
            // 
            // selectPdmBtn
            // 
            this.selectPdmBtn.Location = new System.Drawing.Point(8, 20);
            this.selectPdmBtn.Name = "selectPdmBtn";
            this.selectPdmBtn.Size = new System.Drawing.Size(370, 43);
            this.selectPdmBtn.TabIndex = 0;
            this.selectPdmBtn.Text = "选择PDM文件";
            this.selectPdmBtn.UseVisualStyleBackColor = true;
            this.selectPdmBtn.Click += new System.EventHandler(this.selectPdmBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.nameSpaceTbx);
            this.groupBox1.Controls.Add(this.genClassPath);
            this.groupBox1.Controls.Add(this.genClass);
            this.groupBox1.Controls.Add(this.selectGenClassBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 166);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类文件生成";
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
            // genClassPath
            // 
            this.genClassPath.BackColor = System.Drawing.SystemColors.Window;
            this.genClassPath.Location = new System.Drawing.Point(99, 71);
            this.genClassPath.Multiline = true;
            this.genClassPath.Name = "genClassPath";
            this.genClassPath.Size = new System.Drawing.Size(271, 37);
            this.genClassPath.TabIndex = 11;
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
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormClass";
            this.Text = "FormClass";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PDMPathTbx;
        private System.Windows.Forms.Button selectPdmBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nameSpaceTbx;
        private System.Windows.Forms.TextBox genClassPath;
        private System.Windows.Forms.Button genClass;
        private System.Windows.Forms.Button selectGenClassBtn;
        private System.Windows.Forms.Label label1;
    }
}