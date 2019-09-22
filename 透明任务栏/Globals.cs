using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using 透明任务栏.Enums;

namespace 透明任务栏
{
    public static class Globals
    {
        public static List<IntPtr> MaximizedWindows = new List<IntPtr>();
        private static Int32 ColorToInt32(string color)
        {
            Color thisColor = (Color)ColorConverter.ConvertFromString(color);
            
            return ColorToInt32(thisColor);
        }
        private static Int32 ColorToInt32(Color color)
        {
            return (Int32)BitConverter.ToInt32(new byte[] { color.R, color.G, color.B, color.A }, 0);
        }
        public static Int32 GetTaskbarColor(string taskbar)
        {
            return ColorToInt32(TT.Options.Settings.MaximizedTaskbarStyle.GradientColor);
        }
        public static AccentState GetAccentState(string taskbar)
        {
            if (taskbar == "Main")
            {
                return (AccentState)TT.Options.Settings.MainTaskbarStyle.AccentState;
            }
            else
            {
                return (AccentState)TT.Options.Settings.MaximizedTaskbarStyle.AccentState;
            }
        }
        public static int GetAccentFlags(string taskbar)
        {
            if (taskbar == "Main")
            {
                if (TT.Options.Settings.MainTaskbarStyle.Colorize) { return 2; }
                else { return 0; }
            }
            else
            {
                if (TT.Options.Settings.MaximizedTaskbarStyle.Colorize) { return 2; }
                else { return 0; }
            }
        }
    }
}
