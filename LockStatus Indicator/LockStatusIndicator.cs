using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LockStatus_Indicator
{
    class LockStatusIndicator
    {
        private static Mutex mut;

        [STAThread]
        public static void Main(String[] args)
        {
            mut = new Mutex();

            if (mut.WaitOne(1000))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (args.Length > 0)
                    Application.Run(new frmLockStatusSettings(args[0]));
                else
                    Application.Run(new frmLockStatusSettings(null));

                Application.Exit();
            }
            else
            {
                MessageBox.Show("LockStatus Indicator is already open.", "Error");
            }
        }
    }
}
