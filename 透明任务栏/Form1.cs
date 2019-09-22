using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 透明任务栏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SystemInitialization();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            TT.InitializeOptions(true);
            
            FindTaskBar();

        }

        private void SystemInitialization()
        {
            string ShortFileName = Application.ProductName;
            if (getReg().GetValue(ShortFileName)!=null)
            {
              
                checkBox1.Checked = true;
                TT.InitializeOptions(true);
                FindTaskBar();
            }
            else
            {
                
                checkBox1.Checked = false;
            }
        }

        void FindTaskBar() {
            Taskbars.Bars = new List<Taskbar>();
            Taskbars.Bars.Add(new Taskbar(Externals.FindWindow("Shell_TrayWnd", null)));
            IntPtr otherBars = IntPtr.Zero;
            while (true)
            {
                otherBars = Externals.FindWindowEx(IntPtr.Zero, otherBars, "Shell_SecondaryTrayWnd", "");
                if (otherBars == IntPtr.Zero) { break; }
                else { Taskbars.Bars.Add(new Taskbar(otherBars)); }
                
            }
            Taskbars.UpdateAllSettings();
            foreach (Taskbar taskbar in Taskbars.Bars)
            {
                Taskbars.ApplyStyles(taskbar);
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string ShortFileName = Application.ProductName;
            if (checkBox1.Checked)
            {
                try
                {
                    if (getReg().GetValue(ShortFileName) != null)
                    {
                        return;
                    }
                    getReg().SetValue(ShortFileName, Application.ExecutablePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    if (getReg().GetValue(ShortFileName) == null)
                    {
                        return;
                    }
                    getReg().DeleteValue(ShortFileName, false);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TT.InitializeOptions(false);

            FindTaskBar();
        }
        private Microsoft.Win32.RegistryKey getReg() {
            Microsoft.Win32.RegistryKey Reg;

            Reg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (Reg == null)
            {
                Reg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
            }
            return Reg;
        }
    }
}
