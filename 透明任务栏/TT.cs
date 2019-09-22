using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 透明任务栏
{
     public static class TT
    {
        
        public static Options Options;

       
        public static void InitializeOptions(bool isAlpha)
        {
           
            Options = new Options();
            AssignDefaults(isAlpha);

        }
        private static void AssignDefaults(bool isAlpha)
        {
            Options.Settings = new OptionsSettings();
            Options.Settings.AccentState = (byte)2;
            Options.Settings.StartMinimized = false;
            Options.Settings.StartWhenLaunched = true;
            Options.Settings.StartWithWindows = false;
            Options.Settings.UseDifferentSettingsWhenMaximized = true;
            Options.Settings.MainTaskbarStyle = new OptionsSettingsMainTaskbarStyle();
            Options.Settings.MaximizedTaskbarStyle = new OptionsSettingsMaximizedTaskbarStyle();
            
            if (isAlpha)
            {
                Options.Settings.MainTaskbarStyle.AccentState = 2;
                Options.Settings.MainTaskbarStyle.GradientColor = "#00FFFFFF";
                Options.Settings.MainTaskbarStyle.Colorize = false;
                Options.Settings.MainTaskbarStyle.UseWindowsAccentColor = false;
                Options.Settings.MainTaskbarStyle.WindowsAccentAlpha = 0;
                Options.Settings.MaximizedTaskbarStyle.AccentState = 2;
                Options.Settings.MaximizedTaskbarStyle.GradientColor = "#00FFFFFF";
                Options.Settings.MaximizedTaskbarStyle.Colorize = false;
                Options.Settings.MaximizedTaskbarStyle.UseWindowsAccentColor = false;
                Options.Settings.MaximizedTaskbarStyle.WindowsAccentAlpha = 0;
            }
            else
            {
                Options.Settings.MainTaskbarStyle.AccentState = 3;
                Options.Settings.MainTaskbarStyle.GradientColor = "#804080FF";
                Options.Settings.MainTaskbarStyle.Colorize = true;
                Options.Settings.MainTaskbarStyle.UseWindowsAccentColor = true;
                Options.Settings.MainTaskbarStyle.WindowsAccentAlpha = 127;
                Options.Settings.MaximizedTaskbarStyle.AccentState = 2;
                Options.Settings.MaximizedTaskbarStyle.GradientColor = "#FF000000";
                Options.Settings.MaximizedTaskbarStyle.Colorize = false;
                Options.Settings.MaximizedTaskbarStyle.UseWindowsAccentColor = true;
                Options.Settings.MaximizedTaskbarStyle.WindowsAccentAlpha = 255;
            }
        }
    }
}
