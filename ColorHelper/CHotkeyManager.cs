using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ColorHelper
{
    class CHotKeyManager
    {
        public delegate void HotKeyEvent();
        HotKeyEvent DoHotKeyEvent = null;
        private delegate int Win32WndProc(IntPtr hWnd, int Msg, int wParam, int lParam);
        // program variables
        private IntPtr oldWndProc = IntPtr.Zero;
        private Win32WndProc newWndProc = null;
        const int GWL_WNDPROC = -4;
        public const int MOD_ALT = 0x0001;
        public const int MOD_CONTROL = 0x0002;
        public const int MOD_SHIFT = 0x0004;
        public const int MOD_WIN = 0x0008;
        const int WM_HOTKEY = 0x0312;
        IntPtr WindowHandle;
        [DllImport("user32")]
        private static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr newProc);
        [DllImport("user32")]
        private static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, Win32WndProc newProc);
        [DllImport("user32")]
        private static extern int CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        public CHotKeyManager(IntPtr WindowHandle)
        {
            this.WindowHandle = WindowHandle;
            newWndProc = new Win32WndProc(MyWndProc);
            // subclass
            oldWndProc = SetWindowLong(WindowHandle, GWL_WNDPROC, newWndProc);
        }
        bool isRegistered = false;
        public bool IsRegistered { get { return isRegistered; } }
        public bool Register(Keys Key, int Modifier, HotKeyEvent OnHotKeyEvent)
        {
            DoHotKeyEvent = OnHotKeyEvent;
            isRegistered = RegisterHotKey(WindowHandle, 1, Modifier, (int)Key);
            return isRegistered;
        }
        public bool UnRegister()
        {
            if (!isRegistered)
                return false;
            isRegistered = false;
            return UnregisterHotKey(WindowHandle, 1);
        }
        private int MyWndProc(IntPtr hWnd, int Msg, int wParam, int lParam)
        {
            if (Msg == WM_HOTKEY)
            {
                int id = wParam;
                switch (id)
                {
                    case 1:
                        DoHotKeyEvent?.Invoke();
                        break;
                }
            }
            return CallWindowProc(oldWndProc, hWnd, Msg, wParam, lParam);
        }
        ~CHotKeyManager()
        {
            SetWindowLong(WindowHandle, GWL_WNDPROC, oldWndProc);
        }
    }
}
