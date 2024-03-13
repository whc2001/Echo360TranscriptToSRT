namespace Echo360TranscriptToSRT
{
    partial class frmMain
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
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkShowSpeaker = new System.Windows.Forms.CheckBox();
            this.chkIgnoreSpeaker0 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 12;
            this.lstFiles.Location = new System.Drawing.Point(12, 51);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(310, 376);
            this.lstFiles.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(328, 51);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(506, 376);
            this.txtLog.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 7);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 33);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(93, 7);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 33);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "运行";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JSON 响应体或 HAR 包|*.json;*.har";
            this.openFileDialog1.Multiselect = true;
            // 
            // chkShowSpeaker
            // 
            this.chkShowSpeaker.AutoSize = true;
            this.chkShowSpeaker.Location = new System.Drawing.Point(186, 16);
            this.chkShowSpeaker.Name = "chkShowSpeaker";
            this.chkShowSpeaker.Size = new System.Drawing.Size(84, 16);
            this.chkShowSpeaker.TabIndex = 3;
            this.chkShowSpeaker.Text = "显示发言人";
            this.chkShowSpeaker.UseVisualStyleBackColor = true;
            this.chkShowSpeaker.CheckedChanged += new System.EventHandler(this.chkShowSpeaker_CheckedChanged);
            // 
            // chkIgnoreSpeaker0
            // 
            this.chkIgnoreSpeaker0.AutoSize = true;
            this.chkIgnoreSpeaker0.Enabled = false;
            this.chkIgnoreSpeaker0.Location = new System.Drawing.Point(276, 16);
            this.chkIgnoreSpeaker0.Name = "chkIgnoreSpeaker0";
            this.chkIgnoreSpeaker0.Size = new System.Drawing.Size(108, 16);
            this.chkIgnoreSpeaker0.TabIndex = 3;
            this.chkIgnoreSpeaker0.Text = "忽略首个发言人";
            this.chkIgnoreSpeaker0.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 436);
            this.Controls.Add(this.chkIgnoreSpeaker0);
            this.Controls.Add(this.chkShowSpeaker);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lstFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Echo360TranscriptToSRT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkShowSpeaker;
        private System.Windows.Forms.CheckBox chkIgnoreSpeaker0;
    }
}

