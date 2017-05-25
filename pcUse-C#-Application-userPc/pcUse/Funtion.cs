using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcUse
{
    class Funtion
    {

        public void closeExplorer()
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.FileName = "66.bat";
                proc.WorkingDirectory = @"D:\Ashen_Cafe_Game-Zone\bat\bat_file\";
                proc.Verb = "runas";


                Process.Start(proc);
            }
            catch
            {
            }

        }

        public void disbleUsb1()
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.FileName = "disable.bat";
                proc.WorkingDirectory = @"D:\app\DevManView\";
                proc.Verb = "runas";


                Process.Start(proc);
            }
            catch
            {
            }

        }

        public void enableUsb1()
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.FileName = "enable.bat";
                proc.WorkingDirectory = @"D:\app\DevManView\";
                proc.Verb = "runas";


                Process.Start(proc);
            }
            catch
            {
            }

        }
        public void openTask()
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.FileName = "Taskmgr.exe";
                proc.WorkingDirectory = @"C:\Windows\System32";
                proc.Verb = "runas";
                Process.Start(proc);
            }
            catch
            {
            }

        }

        public void openGame1()
        {
            try
            {
                ProcessStartInfo proc = new ProcessStartInfo();
                proc.UseShellExecute = true;
                proc.FileName = "motogp.exe";
                proc.WorkingDirectory = @"E:\Software\GAME\moto gp 3\MotoGP URT 3\";
                proc.Verb = "runas";


                Process.Start(proc);
            }
            catch
            {

            }
        }
    }
}
        
