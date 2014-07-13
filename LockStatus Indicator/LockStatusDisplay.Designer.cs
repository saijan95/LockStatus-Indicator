namespace LockStatus_Indicator
{
    partial class frmLockStatusDisplay
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
            this.components = new System.ComponentModel.Container();
            this.picLockStatus = new System.Windows.Forms.PictureBox();
            this.killTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLockStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // picLockStatus
            // 
            this.picLockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLockStatus.Location = new System.Drawing.Point(0, 0);
            this.picLockStatus.Name = "picLockStatus";
            this.picLockStatus.Size = new System.Drawing.Size(250, 250);
            this.picLockStatus.TabIndex = 0;
            this.picLockStatus.TabStop = false;
            // 
            // killTimer
            // 
            this.killTimer.Interval = 5000;
            this.killTimer.Tick += new System.EventHandler(this.killTimer_Tick);
            // 
            // frmLockStatusDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.picLockStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLockStatusDisplay";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockStatus Indicator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLockStatusDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLockStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLockStatus;
        private System.Windows.Forms.Timer killTimer;
    }
}

