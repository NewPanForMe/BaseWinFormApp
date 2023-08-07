namespace BaseWinFormApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件遍历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计时器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PDM处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统当前信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件操作ToolStripMenuItem,
            this.时间操作ToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件操作ToolStripMenuItem
            // 
            this.文件操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件遍历ToolStripMenuItem});
            this.文件操作ToolStripMenuItem.Name = "文件操作ToolStripMenuItem";
            this.文件操作ToolStripMenuItem.ShortcutKeyDisplayString = "F";
            this.文件操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件操作ToolStripMenuItem.Text = "文件";
            // 
            // 文件遍历ToolStripMenuItem
            // 
            this.文件遍历ToolStripMenuItem.Name = "文件遍历ToolStripMenuItem";
            this.文件遍历ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.文件遍历ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.文件遍历ToolStripMenuItem.Text = "文件遍历";
            this.文件遍历ToolStripMenuItem.Click += new System.EventHandler(this.文件遍历ToolStripMenuItem_Click);
            // 
            // 时间操作ToolStripMenuItem
            // 
            this.时间操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计时器ToolStripMenuItem});
            this.时间操作ToolStripMenuItem.Name = "时间操作ToolStripMenuItem";
            this.时间操作ToolStripMenuItem.ShortcutKeyDisplayString = "T";
            this.时间操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.时间操作ToolStripMenuItem.Text = "时间";
            // 
            // 计时器ToolStripMenuItem
            // 
            this.计时器ToolStripMenuItem.Name = "计时器ToolStripMenuItem";
            this.计时器ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.计时器ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.计时器ToolStripMenuItem.Text = "计时器";
            this.计时器ToolStripMenuItem.Click += new System.EventHandler(this.计时器ToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PDM处理ToolStripMenuItem});
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.ShortcutKeyDisplayString = "S";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(43, 21);
            this.sQLToolStripMenuItem.Text = "SQL";
            // 
            // PDM处理ToolStripMenuItem
            // 
            this.PDM处理ToolStripMenuItem.Name = "PDM处理ToolStripMenuItem";
            this.PDM处理ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.PDM处理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PDM处理ToolStripMenuItem.Text = "PDM处理";
            this.PDM处理ToolStripMenuItem.Click += new System.EventHandler(this.PDM处理ToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 385);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 28);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 410);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统当前信息ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 系统当前信息ToolStripMenuItem
            // 
            this.系统当前信息ToolStripMenuItem.Name = "系统当前信息ToolStripMenuItem";
            this.系统当前信息ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.系统当前信息ToolStripMenuItem.Text = "系统当前信息";
            this.系统当前信息ToolStripMenuItem.Click += new System.EventHandler(this.系统当前信息ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "工具";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件遍历ToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem 时间操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计时器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PDM处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统当前信息ToolStripMenuItem;
    }
}