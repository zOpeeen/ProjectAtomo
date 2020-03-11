using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triforce_Login.Properties;
using static Triforce_Login.Authentication;

namespace Triforce_Login
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
            Check1(); // Apex
            Check2(); // Pubg Lite
            Check3(); // Pubg Mobile
            Check4(); // Squad
            Check5(); // Warface

            // Check botoões
            injectapex.Enabled = false;
            injectlite.Enabled = false;
            injectmobile.Enabled = false;
            injectsquad.Enabled = false;
            injectwf.Enabled = false;
        }

        private void Check1()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://atomoproject.000webhostapp.com/Triforce/Status/apex"))
                    {
                        apexstatus.ForeColor = Color.Green;
                        apexstatus.Text = ("Undetected");
                    }
                }
            }
            catch
            {
                apexstatus.ForeColor = Color.Orange;
                apexstatus.Text = ("Maintenance");
                injectapex.Enabled = false;
            }
        }

        private void Check2()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://atomoproject.000webhostapp.com/Triforce/Status/pubglite"))
                    {
                        litestatus.ForeColor = Color.Green;
                        litestatus.Text = ("Undetected");
                    }
                }
            }
            catch
            {
                litestatus.ForeColor = Color.Orange;
                litestatus.Text = ("Maintenance");
                injectlite.Enabled = false;
            }
        }

        private void Check3()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://atomoproject.000webhostapp.com/Triforce/Status/pubgmobile"))
                    {
                        mobilestatus.ForeColor = Color.Green;
                        mobilestatus.Text = ("Undetected");
                    }
                }
            }
            catch
            {
                mobilestatus.ForeColor = Color.Orange;
                mobilestatus.Text = ("Maintenance");
                injectmobile.Enabled = false;
            }
        }

        private void Check4()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://atomoproject.000webhostapp.com/Triforce/Status/squad"))
                    {
                        squadstatus.ForeColor = Color.Green;
                        squadstatus.Text = ("Undetected");
                    }
                }
            }
            catch
            {
                squadstatus.ForeColor = Color.Orange;
                squadstatus.Text = ("Maintenance");
                injectsquad.Enabled = false;
            }
        }

        private void Check5()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://atomoproject.000webhostapp.com/Triforce/Status/warface"))
                    {
                        wfstatus.ForeColor = Color.Green;
                        wfstatus.Text = ("Undetected");
                    }
                }
            }
            catch
            {
                wfstatus.ForeColor = Color.Orange;
                wfstatus.Text = ("Maintenance");
                injectwf.Enabled = false;
            }
        }

        private void Games_Load(object sender, EventArgs e)
        {
            namescheats.Text = "Premium Cheats";

            WebClient Wc = new WebClient { Proxy = null };
            string admin = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/admin/key");

            if (admin.Contains(GTHW.Value()))
            {
                injectapex.Enabled = true;
                injectmobile.Enabled = true;
                injectsquad.Enabled = true;
                injectwf.Enabled = true;
                injectlite.Enabled = true;
                checkuser.Text = "Owner";
                checkuser.ForeColor = Color.BlueViolet;

                textwarface.ForeColor = Color.BlueViolet;
                textapex.ForeColor = Color.BlueViolet;
                textlite.ForeColor = Color.BlueViolet;
                textmobile.ForeColor = Color.BlueViolet;
                textsquad.ForeColor = Color.BlueViolet;
            }
            else
            {
                string users = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/keys/Key%20Apex");
                if (users.Contains(GTHW.Value()))
                {
                    injectapex.Enabled = true;
                    checkuser.Text = "Vip";
                    textapex.ForeColor = Color.BlueViolet;
                }
                else
                {
                    injectapex.Enabled = false;
                    injectapex.Text = "Not have";
                }

                string users1 = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/keys/Key%20Lite");
                if (users1.Contains(GTHW.Value()))
                {
                    injectlite.Enabled = true;
                    checkuser.Text = "Vip";
                    textlite.ForeColor = Color.BlueViolet;
                }
                else
                {
                    injectlite.Enabled = false;
                    injectlite.Text = "Not have";
                }

                string users2 = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/keys/Key%20Mobile");
                if (users2.Contains(GTHW.Value()))
                {
                    injectmobile.Enabled = true;
                    checkuser.Text = "Vip";
                    textmobile.ForeColor = Color.BlueViolet;
                }
                else
                {
                    injectmobile.Enabled = false;
                    injectmobile.Text = "Not have";
                }

                string users3 = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/keys/Key%20Squad");
                if (users3.Contains(GTHW.Value()))
                {
                    injectsquad.Enabled = true;
                    checkuser.Text = "Vip";
                    textsquad.ForeColor = Color.BlueViolet;
                }
                else
                {
                    injectsquad.Enabled = false;
                    injectsquad.Text = "Not have";
                }

                string users4 = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/keys/Key%20WF");
                if (users4.Contains(GTHW.Value()))
                {
                    injectwf.Enabled = true;
                    checkuser.Text = "Vip";
                    textwarface.ForeColor = Color.BlueViolet;
                }
                else
                {
                    injectwf.Enabled = false;
                    injectwf.Text = "Not have";
                }

            }
        }

        private void checkstatus_Click(object sender, EventArgs e)
        {
            namescheats.Text = "Check Status";

            pstatus.Visible = true;
            ppremiumcheats.Visible = false;
            pprofile.Visible = false;
            pwoner.Visible = false;
        }

        private void profile_Click(object sender, EventArgs e)
        {
            namescheats.Text = "Profile";

            pprofile.Visible = true;
            ppremiumcheats.Visible = false;
            pstatus.Visible = false;
            pwoner.Visible = false;
        }

        private void owner_Click(object sender, EventArgs e)
        {
            namescheats.Text = "Owners";

            pwoner.Visible = true;
            ppremiumcheats.Visible = false;
            pprofile.Visible = false;
            pstatus.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
            Form B = new Authentication();
            B.Closed += (s, args) => Close();
            B.Show();
        }

        private void injectwf_Click_1(object sender, EventArgs e)
        {
            string DLL = @"C:\Windows\SysWOW64\ddraw.dll";

            string Processo = "Game";

            if (Process.GetProcessesByName(Processo).Length > 0)
            {

                Process[] processes = Process.GetProcessesByName("Game");

                foreach (Process process in processes)
                {
                    process.Kill();
                    MessageBox.Show("You can't run while you're in the game ", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
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

                    Hide();
                    Form b = new inwf();
                    b.Closed += (s, args) => Close();
                    b.Show();
                }
                catch
                {
                    MessageBox.Show("Error 342");
                    Application.Exit();
                }
            }
        }

        private void injectapex_Click_1(object sender, EventArgs e)
        {

        }

        private void injectlite_Click_1(object sender, EventArgs e)
        {

            string Processo = "PUBGLite-Win64-Shipping";

            if (Process.GetProcessesByName(Processo).Length > 0)
            {

                Process[] processes = Process.GetProcessesByName("PUBGLite-Win64-Shipping");

                foreach (Process process in processes)
                {
                    process.Kill();
                    MessageBox.Show("The game must be in the first Lobby to run.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                Task.Run(() =>
                {

                    try
                    {
                        new Process
                        {
                            StartInfo =
                            {
                                FileName = "C:\\Program Files (x86)\\PUBGLite\\Client\\PUBGLite.exe",
                                Arguments = "litepclobby -LobbyUrl=https://lpcprod-live-front.playbattlegrounds.com/index.html -NOSPLASH -nothreadtimeout"
                            }
                        }.Start();
                        Console.WriteLine("Bypass active");
                        Console.Beep(800, 500);

                        Thread.Sleep(35000);


                        {
                            string folder = @"C:\\Triforce";

                            if (!Directory.Exists(folder))
                            {
                                Directory.CreateDirectory(folder);
                            }
                            else
                            {
                                DirectorySecurity ds1 = Directory.GetAccessControl(folder);
                                FileSystemAccessRule fsa1 = new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny);
                                ds1.RemoveAccessRule(fsa1);
                                Directory.SetAccessControl(folder, ds1);
                            }

                            File.WriteAllBytes(@"C:\Triforce\x372hLite.exe", Resources.x372hLite);

                            Process.Start(@"C:\Triforce\x372hLite.exe");

                            File.SetAttributes(folder, File.GetAttributes(folder) | FileAttributes.System | FileAttributes.Hidden);

                            Thread.Sleep(1000);

                            DirectorySecurity ds = Directory.GetAccessControl(folder);
                            FileSystemAccessRule fsa = new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny);
                            ds.AddAccessRule(fsa);
                            Directory.SetAccessControl(folder, ds);

                            Thread.Sleep(10000);

                            Application.Exit();
                        }
                    }

                    catch

                    {
                        MessageBox.Show("Error 342");
                        Application.Exit();
                    }
                });
            }
        }

        private void injectmobile_Click_1(object sender, EventArgs e)
        {

            string folder = @"C:\\Triforce";

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            else
            {
                DirectorySecurity ds1 = Directory.GetAccessControl(folder);
                FileSystemAccessRule fsa1 = new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny);
                ds1.RemoveAccessRule(fsa1);
                Directory.SetAccessControl(folder, ds1);
            }

            File.WriteAllBytes(@"C:\Triforce\host23mobile.exe", Resources.host23mobile);

            Process.Start(@"C:\Triforce\host23mobile.exe");

            File.SetAttributes(folder, File.GetAttributes(folder) | FileAttributes.System | FileAttributes.Hidden);

            Thread.Sleep(1000);

            DirectorySecurity ds = Directory.GetAccessControl(folder);
            FileSystemAccessRule fsa = new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny);
            ds.AddAccessRule(fsa);
            Directory.SetAccessControl(folder, ds);

            Application.Exit();
        }

        private void premiumcheats_Click(object sender, EventArgs e)
        {
            namescheats.Text = "Premium Cheats";

            ppremiumcheats.Visible = true;
            pstatus.Visible = false;
            pprofile.Visible = false;
            pwoner.Visible = false;
        }
    }
}
