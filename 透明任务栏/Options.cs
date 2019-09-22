using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace 透明任务栏
{


    #region XML Classes

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Options
    {
      

        private OptionsSettings settingsField;



        /// <remarks/>
        public OptionsSettings Settings
        {
            get
            {
                return this.settingsField;
            }
            set
            {
                this.settingsField = value;
            }
        }

        /// <remarks/>

    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OptionsSettings
    {
        private byte accentStateField;
        private bool startMinimizedField;

        private bool startWhenLaunchedField;

        private bool startWithWindowsField;

        private bool useDifferentSettingsWhenMaximizedField;

        private OptionsSettingsMainTaskbarStyle mainTaskbarStyleField;

        private OptionsSettingsMaximizedTaskbarStyle maximizedTaskbarStyleField;

        /// <remarks/>
        /// 
        public byte AccentState
        {
            get
            {
                return this.accentStateField;
            }
            set
            {
                this.accentStateField = value;

            }
        }
        public bool StartMinimized
        {
            get
            {
                return this.startMinimizedField;
            }
            set
            {
                this.startMinimizedField = false;
            }
        }

        /// <remarks/>
        public bool StartWhenLaunched
        {
            get
            {
                return this.startWhenLaunchedField;
            }
            set
            {
                this.startWhenLaunchedField = true;
            }
        }

        /// <remarks/>
        public bool StartWithWindows
        {
            get
            {
                return this.startWithWindowsField;
            }
            set
            {
                this.startWithWindowsField = false;
            }
        }

        /// <remarks/>
        public bool UseDifferentSettingsWhenMaximized
        {
            get
            {
                return this.useDifferentSettingsWhenMaximizedField;
            }
            set
            {
                this.useDifferentSettingsWhenMaximizedField = true;
            }
        }

        /// <remarks/>
        public OptionsSettingsMainTaskbarStyle MainTaskbarStyle
        {
            get
            {
                return this.mainTaskbarStyleField;
            }
            set
            {
                this.mainTaskbarStyleField = value;
            }
        }

        /// <remarks/>
        public OptionsSettingsMaximizedTaskbarStyle MaximizedTaskbarStyle

        {
            get
            {
                return this.maximizedTaskbarStyleField;
            }
            set
            {
                this.maximizedTaskbarStyleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OptionsSettingsMainTaskbarStyle
    {

        private byte accentStateField;

        private string gradientColorField;

        private bool colorizeField;

        private bool useWindowsAccentColorField;

        private byte windowsAccentAlphaField;

        //public OptionsSettingsMainTaskbarStyle()
        //{
        //    //this.accentStateField = 2;
        //    //this.gradientColorField = "#00FFFFFF";
        //    this.colorizeField = false;
        //    this.useWindowsAccentColorField = false;
        //    this.windowsAccentAlphaField = 0;
        //}
        /// <remarks/>
        public byte AccentState
        {
            get
            {
                return this.accentStateField;
            }
            set {
                this.accentStateField = value;
            }

        }

        /// <remarks/>
        public string GradientColor
        {
            get
            {
                return this.gradientColorField;
            }
            set {
                this.gradientColorField = value;
            }

        }

        /// <remarks/>
        public bool Colorize
        {
            get
            {
                return this.colorizeField;
            }
            set {
                this.colorizeField = value;
            }

        }

        /// <remarks/>
        public bool UseWindowsAccentColor
        {
            get
            {
                return this.useWindowsAccentColorField;
            }
            set {
                this.useWindowsAccentColorField = value;
            }

        }

        /// <remarks/>
        public byte WindowsAccentAlpha
        {
            get
            {
                return this.windowsAccentAlphaField;
            }
            set {
                this.windowsAccentAlphaField = value;
            }

        }
    }
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OptionsSettingsMaximizedTaskbarStyle
    {

        private byte accentStateField;

        private string gradientColorField;

        private bool colorizeField;

        private bool useWindowsAccentColorField;

        private byte windowsAccentAlphaField;
        public OptionsSettingsMaximizedTaskbarStyle()
        {
            this.accentStateField = 2;
            this.gradientColorField = "#00FFFFFF";
            this.colorizeField = false;
            this.useWindowsAccentColorField = false;
            this.windowsAccentAlphaField = 0;

        }
        /// <remarks/>
        public byte AccentState
        {
            get
            {
                return this.accentStateField;
            }
            set {
                this.accentStateField = value;
            }

        }

        /// <remarks/>
        public string GradientColor
        {
            get
            {
                return this.gradientColorField;
            }
            set
            {
                this.gradientColorField = value;

            }

        }

        /// <remarks/>
        public bool Colorize
        {
            get
            {
                return this.colorizeField;
            }
            set
            {
                this.colorizeField = value;

            }

        }

        /// <remarks/>
        public bool UseWindowsAccentColor
        {
            get
            {
                return this.useWindowsAccentColorField;
            }
            set
            {
                this.useWindowsAccentColorField = value;

            }

        }

        /// <remarks/>
        public byte WindowsAccentAlpha
        {
            get
            {
                return this.windowsAccentAlphaField;
            }
            set
            {
                this.windowsAccentAlphaField = value;
            }

        }


        #endregion XML Classes
    }
}

