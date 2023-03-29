using System;

using System.Collections.Generic;

using System.Linq;

using System.Runtime.InteropServices;

using System.Text;

using System.Threading.Tasks;



namespace SpDll_P05

{

    internal static class WinApiFunctions

    {

        [DllImport("User32.dll")]

        public static extern int MessageBox(IntPtr hWnd, string msg, string caption, int type);

        [DllImport("User32.dll")]

        public static extern int SetWindowText(IntPtr hWnd, string text);

        [DllImport("User32.dll")]

        public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int capacity);

        [DllImport("User32.dll")]

        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);



        [DllImport("User32.dll")]

        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, string lParam);

        [DllImport("User32.dll")]

        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);



        [DllImport("kernel32.dll")]

        public static extern bool Beep(int dwFreq, int dwDuration);



    }

}

