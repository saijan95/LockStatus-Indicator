using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LockStatus_Indicator
{
    public class LockStatusIndicator
    {
        private String keyType;
        private bool keyStatus;
        private Thread displayThread;
        public LockStatusIndicator(String key, bool status)
        {
            keyType = key;
            keyStatus = status;
            displayThread = new Thread(startDisplay);
            displayThread.Start();
        }

        private void startDisplay()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLockStatusDisplay(keyType, keyStatus));
            displayThread = null;
            GC.Collect();
        }

       
    }
}
