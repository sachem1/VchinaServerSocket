namespace VchinaServerSocket
{
    partial class ServerForm
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
            this.settingGroup = new System.Windows.Forms.GroupBox();
            this.groupRunLogger = new System.Windows.Forms.GroupBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.cbbIP = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.settingGroup.SuspendLayout();
            this.groupRunLogger.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingGroup
            // 
            this.settingGroup.Controls.Add(this.btnStopServer);
            this.settingGroup.Controls.Add(this.btnStartServer);
            this.settingGroup.Controls.Add(this.txtPort);
            this.settingGroup.Controls.Add(this.cbbIP);
            this.settingGroup.Controls.Add(this.lblPort);
            this.settingGroup.Controls.Add(this.lblIp);
            this.settingGroup.Location = new System.Drawing.Point(12, 30);
            this.settingGroup.Name = "settingGroup";
            this.settingGroup.Size = new System.Drawing.Size(610, 109);
            this.settingGroup.TabIndex = 0;
            this.settingGroup.TabStop = false;
            this.settingGroup.Text = "配置";
            // 
            // groupRunLogger
            // 
            this.groupRunLogger.Controls.Add(this.richTextBox1);
            this.groupRunLogger.Location = new System.Drawing.Point(12, 171);
            this.groupRunLogger.Name = "groupRunLogger";
            this.groupRunLogger.Size = new System.Drawing.Size(610, 246);
            this.groupRunLogger.TabIndex = 1;
            this.groupRunLogger.TabStop = false;
            this.groupRunLogger.Text = "服务器日志";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(18, 50);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(23, 12);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "IP:";
            // 
            // cbbIP
            // 
            this.cbbIP.FormattingEnabled = true;
            this.cbbIP.Location = new System.Drawing.Point(48, 47);
            this.cbbIP.Name = "cbbIP";
            this.cbbIP.Size = new System.Drawing.Size(158, 20);
            this.cbbIP.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(214, 50);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 12);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(257, 46);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(56, 21);
            this.txtPort.TabIndex = 2;
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(389, 44);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(85, 25);
            this.btnStartServer.TabIndex = 3;
            this.btnStartServer.Text = "StartServer";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(496, 44);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(85, 25);
            this.btnStopServer.TabIndex = 3;
            this.btnStopServer.Text = "StopServer";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(610, 226);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 429);
            this.Controls.Add(this.groupRunLogger);
            this.Controls.Add(this.settingGroup);
            this.Name = "ServerForm";
            this.Text = "服务端";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.settingGroup.ResumeLayout(false);
            this.settingGroup.PerformLayout();
            this.groupRunLogger.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingGroup;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ComboBox cbbIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.GroupBox groupRunLogger;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

