namespace Shared_Network_Tools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.运行原理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wifi_start = new System.Windows.Forms.Button();
            this.wifi_ssid = new System.Windows.Forms.TextBox();
            this.wifi_password = new System.Windows.Forms.TextBox();
            this.button_ifpwhid = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入IToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            resources.ApplyResources(this.文件FToolStripMenuItem, "文件FToolStripMenuItem");
            // 
            // 导入IToolStripMenuItem
            // 
            this.导入IToolStripMenuItem.Name = "导入IToolStripMenuItem";
            resources.ApplyResources(this.导入IToolStripMenuItem, "导入IToolStripMenuItem");
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.运行原理SToolStripMenuItem,
            this.toolStripSeparator1,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            resources.ApplyResources(this.帮助HToolStripMenuItem, "帮助HToolStripMenuItem");
            // 
            // 运行原理SToolStripMenuItem
            // 
            this.运行原理SToolStripMenuItem.Name = "运行原理SToolStripMenuItem";
            resources.ApplyResources(this.运行原理SToolStripMenuItem, "运行原理SToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            resources.ApplyResources(this.关于AToolStripMenuItem, "关于AToolStripMenuItem");
            // 
            // wifi_start
            // 
            resources.ApplyResources(this.wifi_start, "wifi_start");
            this.wifi_start.Name = "wifi_start";
            this.wifi_start.UseVisualStyleBackColor = true;
            // 
            // wifi_ssid
            // 
            resources.ApplyResources(this.wifi_ssid, "wifi_ssid");
            this.wifi_ssid.Name = "wifi_ssid";
            // 
            // wifi_password
            // 
            resources.ApplyResources(this.wifi_password, "wifi_password");
            this.wifi_password.Name = "wifi_password";
            // 
            // button_ifpwhid
            // 
            resources.ApplyResources(this.button_ifpwhid, "button_ifpwhid");
            this.button_ifpwhid.Name = "button_ifpwhid";
            this.button_ifpwhid.UseVisualStyleBackColor = true;
            this.button_ifpwhid.Click += new System.EventHandler(this.button_ifpwhid_Click);
            // 
            // label_name
            // 
            resources.ApplyResources(this.label_name, "label_name");
            this.label_name.Name = "label_name";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_ifpwhid);
            this.Controls.Add(this.wifi_password);
            this.Controls.Add(this.wifi_ssid);
            this.Controls.Add(this.wifi_start);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入IToolStripMenuItem;
        private System.Windows.Forms.Button wifi_start;
        private System.Windows.Forms.TextBox wifi_ssid;
        private System.Windows.Forms.TextBox wifi_password;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行原理SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.Button button_ifpwhid;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

