using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace Triforce_Login
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
            serial.Visible = false;
            key.Visible = false;
            sleep.Visible = false;

        }

        private void Atualizador()
        {
            HWID = GTHW.Value();
            try
            {
                WebClient VersaoHost = new WebClient();
                VersaoHost.Proxy = null;
                VersaoHost.Headers.Add("User-Agent", "Triforce");
                String Versao = VersaoHost.DownloadString("https://atomoproject.000webhostapp.com/Triforce/Version");
                if (Versao == Application.ProductVersion)
                {

                }
                else
                {
                    MessageBox.Show("The new version is available.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    System.Diagnostics.Process pStart = new System.Diagnostics.Process();
                    VersaoHost.Proxy = null;
                    pStart.StartInfo = new System.Diagnostics.ProcessStartInfo(@"https://atomoproject.000webhostapp.com/Triforce/Loader.zip");
                    pStart.Start();
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("Server is broken.", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string HWID = String.Empty;

        private void Authentication_Load_1(object sender, EventArgs e)
        {
            Atualizador();
            key.Text = GTHW.Value();
            serial.Text = GetHDDSerial();
        }

        public string GetHDDSerial()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM win32_logicaldisk");
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                if (wmi_HD["VolumeSerialNumber"] != null)
                    return wmi_HD["VolumeSerialNumber"].ToString();
            }
            return string.Empty;
        }

        public class GTHW
        {
            private static string hwgt = string.Empty;

            public static string Value()
            {
                if (string.IsNullOrEmpty(hwgt))
                {
                    hwgt = GetHash("CPU >> " + cpuId() + "\nBIOS >> " +
                biosId() + "\nBASE >> " + baseId()
                                + "\nVIDEO >> " +
                videoId() + "\nMAC >> " + macId()
                                         );
                }
                return hwgt;
            }

            private static string GetHash(string s)
            {
                MD5 sec = new MD5CryptoServiceProvider();
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] bt = enc.GetBytes(s);
                return GetHexString(sec.ComputeHash(bt));
            }

            private static string GetHexString(byte[] bt)
            {
                string s = string.Empty;
                for (int i = 0; i < bt.Length; i++)
                {
                    byte b = bt[i];
                    int n, n1, n2;
                    n = (int)b;
                    n1 = n & 15;
                    n2 = (n >> 4) & 15;
                    if (n2 > 9)
                        s += ((char)(n2 - 10 + (int)'A')).ToString();
                    else
                        s += n2.ToString();
                    if (n1 > 9)
                        s += ((char)(n1 - 10 + (int)'A')).ToString();
                    else
                        s += n1.ToString();
                    if ((i + 1) != bt.Length && (i + 1) % 2 == 0) s += "-";
                }
                return s;
            }
            #region Original Device ID Getting Code

            private static string identifier
            (string wmiClass, string wmiProperty, string wmiMustBeTrue)
            {
                string result = "";
                System.Management.ManagementClass mc =
            new System.Management.ManagementClass(wmiClass);
                System.Management.ManagementObjectCollection moc = mc.GetInstances();
                foreach (System.Management.ManagementObject mo in moc)
                {
                    if (mo[wmiMustBeTrue].ToString() == "True")
                    {
                        if (result == "")
                        {
                            try
                            {
                                result = mo[wmiProperty].ToString();
                                break;
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                return result;
            }

            private static string identifier(string wmiClass, string wmiProperty)
            {
                string result = "";
                System.Management.ManagementClass mc =
            new System.Management.ManagementClass(wmiClass);
                System.Management.ManagementObjectCollection moc = mc.GetInstances();
                foreach (System.Management.ManagementObject mo in moc)
                {
                    if (result == "")
                    {
                        try
                        {
                            result = mo[wmiProperty].ToString();
                            break;
                        }
                        catch
                        {
                        }
                    }
                }
                return result;
            }
            private static string cpuId()
            {
                string retVal = identifier("Win32_Processor", "UniqueId");
                if (retVal == "")
                {
                    retVal = identifier("Win32_Processor", "ProcessorId");
                    if (retVal == "")
                    {
                        retVal = identifier("Win32_Processor", "Name");
                        if (retVal == "")
                        {
                            retVal = identifier("Win32_Processor", "Manufacturer");
                        }

                        retVal += identifier("Win32_Processor", "MaxClockSpeed");
                    }
                }
                return retVal;
            }

            private static string biosId()
            {
                return identifier("Win32_BIOS", "Manufacturer")
                + identifier("Win32_BIOS", "SMBIOSBIOSVersion")
                + identifier("Win32_BIOS", "IdentificationCode")
                + identifier("Win32_BIOS", "SerialNumber")
                + identifier("Win32_BIOS", "ReleaseDate")
                + identifier("Win32_BIOS", "Version");
            }

            private static string diskId()
            {
                return identifier("Win32_DiskDrive", "Model")
                + identifier("Win32_DiskDrive", "Manufacturer")
                + identifier("Win32_DiskDrive", "Signature")
                + identifier("Win32_DiskDrive", "TotalHeads");
            }

            private static string baseId()
            {
                return identifier("Win32_BaseBoard", "Model")
                + identifier("Win32_BaseBoard", "Manufacturer")
                + identifier("Win32_BaseBoard", "Name")
                + identifier("Win32_BaseBoard", "SerialNumber");
            }

            private static string videoId()
            {
                return identifier("Win32_VideoController", "DriverVersion")
                + identifier("Win32_VideoController", "Name");
            }

            private static string macId()
            {
                return identifier("Win32_NetworkAdapterConfiguration",
                    "MACAddress", "IPEnabled");
            }
            #endregion
        }

        private void buy_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form B = new Buy();
            B.Closed += (s, args) => Close();
            B.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            sleep.Visible = true;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            progressBar1.PerformStep();
            if (progressBar1.Maximum == 100)
            {
                try
                {
                    string DLL = @"C:\Windows\SysWOW64\ddraw.dll";

                    if (File.Exists(DLL))
                    {
                        File.Delete(DLL);

                    }
                    else
                    {
                        // Nada
                    }
                }
                catch
                {
                    timer1.Stop();
                    MessageBox.Show("Logs blocked, Contact one admin in discord.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                try
                {
                    WebClient Wc = new WebClient { Proxy = null };
                    string users = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/keys/Key%20Apex");
                    if (users.Contains(GTHW.Value()))
                    {
                        timer1.Stop();
                        Hide();
                        Form b = new Games();
                        b.Closed += (s, args) => Close();
                        b.Show();
                    }
                    else
                    {
                        timer1.Stop();
                        sleep.Visible = false;
                    }

                    string users1 = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/keys/Key%20Lite");
                    if (users1.Contains(GTHW.Value()))
                    {
                        timer1.Stop();
                        Hide();
                        Form b = new Games();
                        b.Closed += (s, args) => Close();
                        b.Show();
                    }
                    else
                    {
                        timer1.Stop();
                        sleep.Visible = false;
                    }

                    string users2 = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/keys/Key%20Mobile");
                    if (users2.Contains(GTHW.Value()))
                    {
                        timer1.Stop();
                        Hide();
                        Form b = new Games();
                        b.Closed += (s, args) => Close();
                        b.Show();
                    }
                    else
                    {
                        timer1.Stop();
                        sleep.Visible = false;
                    }

                    string users3 = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/keys/Key%20Squad");
                    if (users3.Contains(GTHW.Value()))
                    {
                        timer1.Stop();
                        Hide();
                        Form b = new Games();
                        b.Closed += (s, args) => Close();
                        b.Show();
                    }
                    else
                    {
                        timer1.Stop();
                        sleep.Visible = false;
                    }

                    string users4 = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/keys/Key%20WF");
                    if (users4.Contains(GTHW.Value()))
                    {
                        timer1.Stop();
                        Hide();
                        Form b = new Games();
                        b.Closed += (s, args) => Close();
                        b.Show();
                    }
                    else
                    {
                        timer1.Stop();
                        sleep.Visible = false;
                        MessageBox.Show("Your key not registred, Buy your access!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {

                }
            }
        }

            private void viewserial_Click(object sender, EventArgs e)
        {
            viewserial.Visible = false;
            serial.Visible = true;
        }

        private void viewkey_Click(object sender, EventArgs e)
        {
            viewkey.Visible = false;
            key.Visible = true;
        }

        private void serial_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(GetHDDSerial());
            MessageBox.Show("Serial copied, make the purchase and send your key to an owner", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void key_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GTHW.Value());
            MessageBox.Show("Key copied, make the purchase and send your key to an owner", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void admin_Click(object sender, EventArgs e)
        {
            WebClient Wc = new WebClient { Proxy = null };
            string admin = Wc.DownloadString("https://atomoproject.000webhostapp.com/Triforce/admin/key");

            if (admin.Contains(GTHW.Value()))
            {
                MessageBox.Show("Hallo, Welcome back :)", "System", MessageBoxButtons.OK);
                Hide();
                Form b = new Games();
                b.Closed += (s, args) => Close();
                b.Show();
            }
            else
            {
                MessageBox.Show("You don't have owner access", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
        
                    
