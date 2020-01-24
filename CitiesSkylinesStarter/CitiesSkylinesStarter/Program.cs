using System;
using WindowsInput;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace CitiesSkylinesStarter
{
    class Program
    {
        const Int32 SW_MINIMIZE = 6;

        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow([In] IntPtr hWnd, [In] Int32 nCmdShow);

        private static void MinimizeConsoleWindow()
        {
            IntPtr hWndConsole = GetConsoleWindow();
            ShowWindow(hWndConsole, SW_MINIMIZE);
        }

        static void Main(string[] args)
        {
            MinimizeConsoleWindow();

            ProcessStartInfo cities = new ProcessStartInfo();
            cities.FileName = args[2];
            Process.Start(cities);
            System.Threading.Thread.Sleep(10000);

            string offsetX;
            string offsetY;

            try
            {
                offsetX = args[3];
            }
            catch
            {
                offsetX = "0";
            }
            
            try
            {
                offsetY = args[4];
            }
            catch
            {
                offsetY = "0";
            }

            Mouse mouse = new Mouse(Int16.Parse(args[0]), Int16.Parse(args[1]));
            mouse.MouseClick(Int16.Parse(offsetX), Int16.Parse(offsetY));
        }

    }

    class Mouse
    {
        int screenX;
        int screenY;

        public Mouse(int screenX, int screenY)
        {
            this.screenX = screenX;
            this.screenY = screenY;
        }

        public void MouseClick(int offsetX, int offsetY)
        {
            InputSimulator input = new InputSimulator();
            
            var X = (( (this.screenX * 0.5) + offsetX) * 65535 / this.screenX);
            var Y = (( (this.screenY * 0.4) + offsetY) * 65535 / this.screenY);

            input.Mouse.MoveMouseTo(Convert.ToDouble(X), Convert.ToDouble(Y));
            input.Mouse.LeftButtonClick();
        }
    }
}
