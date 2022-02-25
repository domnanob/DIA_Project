using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_Project.Lib
{
    public class CheatDetector
    {
        public static bool DetectBrowser() {
            Process[] processes = Process.GetProcesses();
            bool futE = false;
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    if (new string[] { "opera", "chrome", "firefox", "msedge" }.Contains(p.ProcessName))
                    {
                        futE = true;
                    }
                }
            }
            if (futE)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    

