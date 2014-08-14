/***********************************************************************
 * Note: This code has been adopted and modified from an example poseted
 * by Stephen Toub. 
 * Refer to http://blogs.msdn.com/b/toub/archive/2006/05/03/589423.aspx
 * *********************************************************************/

using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms; 
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace LockStatus_Indicator
{
    public class LockStatusListener
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int VK_CAPITAL = 0x14;
        private const int VK_NUMLOCK = 0x90;
        private const int VK_SCROLL = 0x91;
        private KeyboardProc keyboardProc;
        private IntPtr hhk;
        private bool capsLock, numLock, scrollLock;
        private bool chkCapsLock, chkNumLock, chkScrollLock;

        public void startListening()
        {
            calibrate();
            setSettings();

            keyboardProc = callNextHook;
            hhk = setHook(keyboardProc);
            Application.Run();
        }

        public void stopListening()
        {
            UnhookWindowsHookEx(hhk);
        }

        private IntPtr setHook(KeyboardProc proc)
        {
            IntPtr hInstance = LoadLibrary("User32.dll");
            return SetWindowsHookEx(WH_KEYBOARD_LL, proc, hInstance, 0);
        }

        private delegate IntPtr KeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr callNextHook(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                frmLockStatusDisplay lockStatusIndicator = null;

                if (vkCode == VK_CAPITAL) 
                {
                    if (chkCapsLock)
                    {
                        capsLock = !capsLock;
                        lockStatusIndicator = new frmLockStatusDisplay("Caps", capsLock);
                        lockStatusIndicator.Show();
                    }
                }
                    
                else if(vkCode == VK_NUMLOCK) 
                {
                    if (chkNumLock)
                    {
                        numLock = !numLock;
                        lockStatusIndicator = new frmLockStatusDisplay("Num", numLock);
                        lockStatusIndicator.Show();
                    }
                }
                    
                else if(vkCode == VK_SCROLL)
                {
                    if (chkScrollLock)
                    {
                        scrollLock = !scrollLock;
                        lockStatusIndicator = new frmLockStatusDisplay("Scroll", scrollLock);
                        lockStatusIndicator.Show();
                    }
                }

                
                lockStatusIndicator = null;
                GC.Collect();
            }
            return CallNextHookEx(hhk, nCode, wParam, lParam);
        }

        private void calibrate()
        {
            capsLock = (GetKeyState(VK_CAPITAL) & 1) == 1;
            numLock = (GetKeyState(VK_NUMLOCK) & 1) == 1;
            scrollLock = (GetKeyState(VK_SCROLL) & 1) == 1;
        }

        private void setSettings()
        {
            chkCapsLock = Properties.Settings.Default.CapsLock;
            chkNumLock = Properties.Settings.Default.NumLock;
            chkScrollLock = Properties.Settings.Default.ScrollLock;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            KeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern short GetKeyState(int keyCode);
    }
}
