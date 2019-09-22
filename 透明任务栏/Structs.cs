using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using 透明任务栏.Enums;

namespace 透明任务栏.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct AccentPolicy
    {
        public AccentState AccentState;
        public int AccentFlags;
        public int GradientColor;
        public int AnimationId;

        public AccentPolicy(AccentState accentState, int accentFlags, int gradientColor, int animationId)
        {
            AccentState = accentState;
            AccentFlags = accentFlags;
            GradientColor = gradientColor;
            AnimationId = animationId;
        }
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct WinCompatTrData
    {
        public WindowCompositionAttribute Attribute;
        public IntPtr Data;
        public int SizeOfData;

        public WinCompatTrData(WindowCompositionAttribute attribute, IntPtr data, int sizeOfData)
        {
            Attribute = attribute;
            Data = data;
            SizeOfData = sizeOfData;
        }
    }
}
