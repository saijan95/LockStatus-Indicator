namespace LockStatus_Indicator
{
    partial class frmLockStatusSettings
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
            if (gkl != null)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            }
            else
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            } 
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLockStatusSettings));
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkScrollLock = new System.Windows.Forms.CheckBox();
            this.chkNumLock = new System.Windows.Forms.CheckBox();
            this.chkCapsLock = new System.Windows.Forms.CheckBox();
            this.chkRunStartup = new System.Windows.Forms.CheckBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdApply = new System.Windows.Forms.Button();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.cmdStart = new System.Windows.Forms.Button();
            this.SettingsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.groupBox1);
            this.SettingsPanel.Controls.Add(this.cmdClose);
            this.SettingsPanel.Controls.Add(this.cmdApply);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(502, 358);
            this.SettingsPanel.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdStop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkScrollLock);
            this.groupBox1.Controls.Add(this.chkNumLock);
            this.groupBox1.Controls.Add(this.chkCapsLock);
            this.groupBox1.Controls.Add(this.chkRunStartup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(6, 235);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(138, 52);
            this.cmdStop.TabIndex = 4;
            this.cmdStop.Text = "Stop LockStatus Indicator";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "millisec";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(20, 97);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 22);
            this.txtTime.TabIndex = 6;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notification display time:";
            // 
            // chkScrollLock
            // 
            this.chkScrollLock.AutoSize = true;
            this.chkScrollLock.Checked = true;
            this.chkScrollLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScrollLock.Location = new System.Drawing.Point(237, 76);
            this.chkScrollLock.Name = "chkScrollLock";
            this.chkScrollLock.Size = new System.Drawing.Size(157, 21);
            this.chkScrollLock.TabIndex = 4;
            this.chkScrollLock.Text = "Listen to Scroll Lock";
            this.chkScrollLock.UseVisualStyleBackColor = true;
            this.chkScrollLock.CheckedChanged += new System.EventHandler(this.chkScrollLock_CheckedChanged);
            // 
            // chkNumLock
            // 
            this.chkNumLock.AutoSize = true;
            this.chkNumLock.Checked = true;
            this.chkNumLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumLock.Location = new System.Drawing.Point(237, 49);
            this.chkNumLock.Name = "chkNumLock";
            this.chkNumLock.Size = new System.Drawing.Size(151, 21);
            this.chkNumLock.TabIndex = 3;
            this.chkNumLock.Text = "Listen to Num Lock";
            this.chkNumLock.UseVisualStyleBackColor = true;
            this.chkNumLock.CheckedChanged += new System.EventHandler(this.chkNumLock_CheckedChanged);
            // 
            // chkCapsLock
            // 
            this.chkCapsLock.AutoSize = true;
            this.chkCapsLock.Checked = true;
            this.chkCapsLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCapsLock.Location = new System.Drawing.Point(237, 22);
            this.chkCapsLock.Name = "chkCapsLock";
            this.chkCapsLock.Size = new System.Drawing.Size(158, 21);
            this.chkCapsLock.TabIndex = 2;
            this.chkCapsLock.Text = "Listen to Caps Lock ";
            this.chkCapsLock.UseVisualStyleBackColor = true;
            this.chkCapsLock.CheckedChanged += new System.EventHandler(this.chkCapsLock_CheckedChanged);
            // 
            // chkRunStartup
            // 
            this.chkRunStartup.AutoSize = true;
            this.chkRunStartup.Checked = true;
            this.chkRunStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRunStartup.Location = new System.Drawing.Point(17, 22);
            this.chkRunStartup.Name = "chkRunStartup";
            this.chkRunStartup.Size = new System.Drawing.Size(192, 38);
            this.chkRunStartup.TabIndex = 1;
            this.chkRunStartup.Text = "Run LockStatus Indicator \r\non startup";
            this.chkRunStartup.UseVisualStyleBackColor = true;
            this.chkRunStartup.CheckedChanged += new System.EventHandler(this.chkRunStartup_CheckedChanged);
            // 
            // cmdClose
            // 
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(416, 311);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 36);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdApply
            // 
            this.cmdApply.Enabled = false;
            this.cmdApply.Location = new System.Drawing.Point(335, 311);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(75, 36);
            this.cmdApply.TabIndex = 1;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = true;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.cmdStart);
            this.StartPanel.Location = new System.Drawing.Point(0, 0);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(502, 358);
            this.StartPanel.TabIndex = 3;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(167, 134);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(164, 67);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start \r\nLockStatus Indicator";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // frmLockStatusSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 358);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.StartPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLockStatusSettings";
            this.Text = "LockStatusSettings";
            this.SettingsPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.StartPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkScrollLock;
        private System.Windows.Forms.CheckBox chkNumLock;
        private System.Windows.Forms.CheckBox chkCapsLock;
        private System.Windows.Forms.CheckBox chkRunStartup;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdApply;
    }
}