using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace _3D_Custom_Window
{


    public static class Window
    {

        // Import user32.dll (containing the function we need) and define
        // the method corresponding to the native function.
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int CreateWindowEx(UInt32 dwExStyle, string lpClassName, string lpWindowName,
                                                 UInt32 dwStyle, int X, int Y,
                                                 int nWidth, int nHeight, IntPtr hWndParent,
                                                 IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

        // Define the implementation of the delegate; here, we simply output the window handle.
        private static bool OutputWindow(IntPtr hwnd, IntPtr lParam)
        {
            Console.WriteLine(hwnd.ToInt64());
            return true;
        }

        public static void Run(String[] args)
        {
            UInt32 windowBehavior = 0;
            UInt32 windowStyle = 800000;
            int x = 0;
            int y = 0;
            int nWidth = 0;
            int nHeight = 0;
            IntPtr hWndParent = IntPtr(0);
            IntPtr hMenu = 0;

            CreateWindowEx(windowBehavior, "3dWindow", "3D Custom Window", windowStyle, x, y, nWidth, nHeight, hWndParent, hMenu, );
        }
    }
}
