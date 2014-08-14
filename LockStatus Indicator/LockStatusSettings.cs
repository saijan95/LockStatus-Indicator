using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LockStatus_Indicator
{
    public partial class frmLockStatusSettings : Form
    {
        public LockStatusListener gkl;
        public Thread gklThread;

        public frmLockStatusSettings(String cmd)
        {
            InitializeComponent();

            if(cmd != null)
            {
                if (cmd.Equals("/Startup"))
                {
                    startListening();
                    StartPanel.Visible = false;
                    SettingsPanel.Visible = true;
                    importSettings();
                }
            }
            else
            {
                StartPanel.Visible = true;
                SettingsPanel.Visible = false;
            }

        }
        private void importSettings()
        {
            chkRunStartup.Checked = Properties.Settings.Default.RunStartup;
            chkCapsLock.Checked = Properties.Settings.Default.CapsLock;
            chkNumLock.Checked = Properties.Settings.Default.NumLock;
            chkScrollLock.Checked = Properties.Settings.Default.ScrollLock;
            txtTime.Text = Properties.Settings.Default.Time.ToString();
            setStartUp(Properties.Settings.Default.RunStartup);
        }

        private void startListening()
        {
            gkl = new LockStatusListener();
            gklThread = new Thread(new ThreadStart(gkl.startListening));
            gklThread.Start();
        }

        private void stopListening()
        {
            gkl.stopListening();
            gklThread.Abort();
            gkl = null;
            gklThread = null;
            GC.Collect();
        }

        private void changesOccured()
        {
            if (chkRunStartup.Checked != Properties.Settings.Default.RunStartup ||
                chkCapsLock.Checked != Properties.Settings.Default.CapsLock ||
                chkNumLock.Checked != Properties.Settings.Default.NumLock ||
                chkScrollLock.Checked != Properties.Settings.Default.ScrollLock ||
                !txtTime.Text.Equals(Properties.Settings.Default.Time.ToString()))
                cmdApply.Enabled = true;
            else
                cmdApply.Enabled = false;
        }

        private void setStartUp(bool set)
        {
            if (set)
            {
                string cmd = Application.ExecutablePath.ToString() + " /Startup";
                Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey
                        ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rk.SetValue("LockStatus Indicator", cmd);
            }
            else
            {
                Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.CurrentUser.OpenSubKey
                       ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rk.DeleteValue("LockStatus Indicator", false);
            }
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            startListening();

            importSettings();

            StartPanel.Visible = false;
            SettingsPanel.Visible = true;
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            stopListening();
        
            StartPanel.Visible = true;
            SettingsPanel.Visible = false;
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RunStartup = chkRunStartup.Checked;
            Properties.Settings.Default.CapsLock = chkCapsLock.Checked;
            Properties.Settings.Default.NumLock = chkNumLock.Checked;
            Properties.Settings.Default.ScrollLock = chkScrollLock.Checked;
            Properties.Settings.Default.Time = Convert.ToInt32(txtTime.Text);

            Properties.Settings.Default.Save();

            stopListening();
            startListening();
            setStartUp(Properties.Settings.Default.RunStartup);
            cmdApply.Enabled = false;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chkRunStartup_CheckedChanged(object sender, EventArgs e)
        {
            changesOccured();       
        }

        private void chkCapsLock_CheckedChanged(object sender, EventArgs e)
        {
            changesOccured();
        }

        private void chkNumLock_CheckedChanged(object sender, EventArgs e)
        {
            changesOccured();
        }

        private void chkScrollLock_CheckedChanged(object sender, EventArgs e)
        {
            changesOccured();
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            changesOccured();
        }
    }
}
