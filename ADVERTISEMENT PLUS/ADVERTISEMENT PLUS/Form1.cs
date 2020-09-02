using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Net;

namespace ADVERTISEMENT_PLUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        Process[] prg;

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = 55;

            while (sayi < 100)

            {


                Process cmd = new Process();
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.FileName = " cmd.exe";
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                cmd.StandardInput.WriteLine("ipconfig /flushdns");
                cmd.StandardInput.WriteLine("ipconfig /release");
                cmd.StandardInput.WriteLine("ipconfig /renew");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                cmd.Close();

                System.Threading.Thread.Sleep(5000);

                System.Diagnostics.Process.Start("http://www.pakistankonsoloslugu.com/istanbul-baskonsoloslugu/");

                System.Threading.Thread.Sleep(8000);

                mouse_event(MOUSEEVENTF_LEFTDOWN, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, Control.MousePosition.X, Control.MousePosition.Y, 0, 0);


                                
                System.Threading.Thread.Sleep(5000);

                prg = Process.GetProcessesByName("chrome");

                if (prg.Length > 0)
                    prg[0].Kill();

                if (prg.Length > 1)
                    prg[1].Kill();

                if (prg.Length > 2)
                    prg[2].Kill();

                if (prg.Length > 3)
                    prg[3].Kill();

                if (prg.Length > 4)
                    prg[4].Kill();

                System.Threading.Thread.Sleep(3000);



            }


        }
    }
}
