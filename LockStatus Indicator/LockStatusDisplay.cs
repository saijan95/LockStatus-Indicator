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
                    picLockStatus.Image = Image.FromFile("c:\\users\\saija_000\\documents\\visual studio 2013\\Projects\\LockStatus Indicator\\LockStatus Indicator\\Resources\\CapsLockOff.png");
                else if (state == true)
                    picLockStatus.BackgroundImage = Image.FromFile("c:\\users\\saija_000\\documents\\visual studio 2013\\Projects\\LockStatus Indicator\\LockStatus Indicator\\Resources\\CapsLockOn.png");

                picLockStatus.Update();
            }
            else if (key.Equals("Num"))
            {
                if (state == false)
                    picLockStatus.BackgroundImage = Image.FromFile("c:\\users\\saija_000\\documents\\visual studio 2013\\Projects\\LockStatus Indicator\\LockStatus Indicator\\Resources\\NumLockOff.png");
                else if (state == true)
                    picLockStatus.BackgroundImage = Image.FromFile("c:\\users\\saija_000\\documents\\visual studio 2013\\Projects\\LockStatus Indicator\\LockStatus Indicator\\Resources\\NumLockOn.png");

                picLockStatus.Update();
            }
            else if (key.Equals("Scroll"))
            {
                if (state == false)
                    picLockStatus.BackgroundImage = Image.FromFile("c:\\users\\saija_000\\documents\\visual studio 2013\\Projects\\LockStatus Indicator\\LockStatus Indicator\\Resources\\ScrollLockOff.png");
                else if (state == true)
                    picLockStatus.BackgroundImage = Image.FromFile("c:\\users\\saija_000\\documents\\visual studio 2013\\Projects\\LockStatus Indicator\\LockStatus Indicator\\Resources\\ScrollLockOn.png");

                picLockStatus.Update();
            }

            
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
