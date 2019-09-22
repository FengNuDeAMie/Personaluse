using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static 透明任务栏.Constants;
using 透明任务栏.Structs;
using System.Runtime.InteropServices;
using 透明任务栏.Enums;

namespace 透明任务栏
{
    public static class Taskbars
    {
        public static List<Taskbar> Bars { get; set; }
        public static bool MaximizedStateChanged { get; set; }
        private static string tbType;

        static Taskbars()
        {
            Bars = new List<Taskbar>();
            MaximizedStateChanged = true;
        }

        public static void ApplyStyles(Taskbar taskbar)
        {
            int sizeOfPolicy = Marshal.SizeOf(taskbar.AccentPolicy);
            IntPtr policyPtr = Marshal.AllocHGlobal(sizeOfPolicy);
            Marshal.StructureToPtr(taskbar.AccentPolicy, policyPtr, false);

            WinCompatTrData data = new WinCompatTrData(WindowCompositionAttribute.WCA_ACCENT_POLICY, policyPtr, sizeOfPolicy);

            Externals.SetWindowCompositionAttribute(taskbar.HWND, ref data);

            Marshal.FreeHGlobal(policyPtr);
        }
        public static void UpdateAllSettings()
        {
            foreach (Taskbar tb in Bars)
            {
                if (tb.HasMaximizedWindow && TT.Options.Settings.UseDifferentSettingsWhenMaximized) { tbType = "Maximized"; }
                else { tbType = "Main"; }

                tb.AccentPolicy.AccentState = Globals.GetAccentState(tbType);
                tb.AccentPolicy.AccentFlags = Globals.GetAccentFlags(tbType);
                tb.AccentPolicy.GradientColor = Globals.GetTaskbarColor(tbType);
            }
        }
    }
    public class Taskbar
    {
        public IntPtr HWND { get; set; }
        public IntPtr Monitor { get; set; }
        public bool HasMaximizedWindow { get; set; }
        public AccentPolicy AccentPolicy;

        public Taskbar(IntPtr hwnd)
        {
            HWND = hwnd;
            Monitor = Externals.MonitorFromWindow(hwnd, MONITOR_DEFAULTTONEAREST);
            AccentPolicy = new AccentPolicy();


            FindMaximizedWindowsHere();
        }

        public void FindMaximizedWindowsHere()
        {
            bool isInThisScreen = false;
            IntPtr thisAppMonitor;

            foreach (IntPtr hwnd in Globals.MaximizedWindows)
            {
                thisAppMonitor = Externals.MonitorFromWindow(hwnd, MONITOR_DEFAULTTONEAREST);
                if (Monitor == thisAppMonitor) { isInThisScreen = true; }
            }

            HasMaximizedWindow = isInThisScreen;
            return;
        }
    }
}
