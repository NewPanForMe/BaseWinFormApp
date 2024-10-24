﻿namespace GitT
{
    partial class Git
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
            this.TBGitFolder = new System.Windows.Forms.TextBox();
            this.BtnSelectDic = new System.Windows.Forms.Button();
            this.BtnClone = new System.Windows.Forms.Button();
            this.TbCloneGit = new System.Windows.Forms.TextBox();
            this.BtnPull = new System.Windows.Forms.Button();
            this.BtnCommit = new System.Windows.Forms.Button();
            this.TbCommit = new System.Windows.Forms.TextBox();
            this.BtnPush = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBGitFolder
            // 
            this.TBGitFolder.Location = new System.Drawing.Point(12, 12);
            this.TBGitFolder.Multiline = true;
            this.TBGitFolder.Name = "TBGitFolder";
            this.TBGitFolder.Size = new System.Drawing.Size(315, 26);
            this.TBGitFolder.TabIndex = 0;
            // 
            // BtnSelectDic
            // 
            this.BtnSelectDic.Location = new System.Drawing.Point(333, 12);
            this.BtnSelectDic.Name = "BtnSelectDic";
            this.BtnSelectDic.Size = new System.Drawing.Size(177, 49);
            this.BtnSelectDic.TabIndex = 1;
            this.BtnSelectDic.Text = "选择Git文件夹";
            this.BtnSelectDic.UseVisualStyleBackColor = true;
            this.BtnSelectDic.Click += new System.EventHandler(this.BtnSelectDic_Click);
            // 
            // BtnClone
            // 
            this.BtnClone.Location = new System.Drawing.Point(12, 154);
            this.BtnClone.Name = "BtnClone";
            this.BtnClone.Size = new System.Drawing.Size(81, 79);
            this.BtnClone.TabIndex = 2;
            this.BtnClone.Text = "克隆(Clone)";
            this.BtnClone.UseVisualStyleBackColor = true;
            this.BtnClone.Click += new System.EventHandler(this.BtnClone_Click);
            // 
            // TbCloneGit
            // 
            this.TbCloneGit.Location = new System.Drawing.Point(12, 79);
            this.TbCloneGit.Multiline = true;
            this.TbCloneGit.Name = "TbCloneGit";
            this.TbCloneGit.Size = new System.Drawing.Size(498, 26);
            this.TbCloneGit.TabIndex = 3;
            // 
            // BtnPull
            // 
            this.BtnPull.Location = new System.Drawing.Point(137, 154);
            this.BtnPull.Name = "BtnPull";
            this.BtnPull.Size = new System.Drawing.Size(81, 79);
            this.BtnPull.TabIndex = 4;
            this.BtnPull.Text = "推送(Pull)";
            this.BtnPull.UseVisualStyleBackColor = true;
            this.BtnPull.Click += new System.EventHandler(this.BtnPull_Click);
            // 
            // BtnCommit
            // 
            this.BtnCommit.Location = new System.Drawing.Point(268, 154);
            this.BtnCommit.Name = "BtnCommit";
            this.BtnCommit.Size = new System.Drawing.Size(81, 79);
            this.BtnCommit.TabIndex = 5;
            this.BtnCommit.Text = "提交(Commit)";
            this.BtnCommit.UseVisualStyleBackColor = true;
            this.BtnCommit.Click += new System.EventHandler(this.BtnCommit_Click);
            // 
            // TbCommit
            // 
            this.TbCommit.Location = new System.Drawing.Point(112, 122);
            this.TbCommit.Multiline = true;
            this.TbCommit.Name = "TbCommit";
            this.TbCommit.Size = new System.Drawing.Size(398, 26);
            this.TbCommit.TabIndex = 6;
            // 
            // BtnPush
            // 
            this.BtnPush.Location = new System.Drawing.Point(391, 154);
            this.BtnPush.Name = "BtnPush";
            this.BtnPush.Size = new System.Drawing.Size(81, 79);
            this.BtnPush.TabIndex = 7;
            this.BtnPush.Text = "推送(Push)";
            this.BtnPush.UseVisualStyleBackColor = true;
            this.BtnPush.Click += new System.EventHandler(this.BtnPush_Click);
            // 
            // Git
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 296);
            this.Controls.Add(this.BtnPush);
            this.Controls.Add(this.TbCommit);
            this.Controls.Add(this.BtnCommit);
            this.Controls.Add(this.BtnPull);
            this.Controls.Add(this.TbCloneGit);
            this.Controls.Add(this.BtnClone);
            this.Controls.Add(this.BtnSelectDic);
            this.Controls.Add(this.TBGitFolder);
            this.Name = "Git";
            this.Text = "Git";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBGitFolder;
        private System.Windows.Forms.Button BtnSelectDic;
        private System.Windows.Forms.Button BtnClone;
        private System.Windows.Forms.TextBox TbCloneGit;
        private System.Windows.Forms.Button BtnPull;
        private System.Windows.Forms.Button BtnCommit;
        private System.Windows.Forms.TextBox TbCommit;
        private System.Windows.Forms.Button BtnPush;
    }
}