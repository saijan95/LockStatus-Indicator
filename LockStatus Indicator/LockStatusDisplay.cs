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
using System.Runtime.InteropServices;
using System.Diagnostics;


namespace LockStatus_Indicator
{
    public partial class frmLockStatusDisplay : Form
    {
        public frmLockStatusDisplay(String key, bool state)
        {
            InitializeComponent();

            if (key.Equals("Caps"))
            {
                Console.WriteLine(state);
                if (state == false)
                    picLockStatus.Image = LockStatus_Indicator.Properties.Resources.CapsLockOff;
                else if (state == true)
                    picLockStatus.BackgroundImage = LockStatus_Indicator.Properties.Resources.CapsLockOn;
            }
            else if (key.Equals("Num"))
            {
                if (state == false)
                    picLockStatus.BackgroundImage = LockStatus_Indicator.Properties.Resources.NumLockOff;
                else if (state == true)
                    picLockStatus.BackgroundImage = LockStatus_Indicator.Properties.Resources.NumLockOn;
            }
            else if (key.Equals("Scroll"))
            {
                if (state == false)
                    picLockStatus.BackgroundImage = LockStatus_Indicator.Properties.Resources.ScrollLockOff;
                else if (state == true)
                    picLockStatus.BackgroundImage = LockStatus_Indicator.Properties.Resources.ScrollLockOn;
            }

            picLockStatus.Update();
            
            killTimer.Interval = 800;
            killTimer.Start();
            
        }

        private void killTimer_Tick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLockStatusDisplay_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
