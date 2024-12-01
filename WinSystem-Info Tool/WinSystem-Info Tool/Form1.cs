using System.Net.NetworkInformation;
using System.Management;

namespace WinSystem_Info_Tool
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Systeminformationen
            listBoxSystem.Items.Add("Betriebssystem:          " + Environment.OSVersion.ToString());
            listBoxSystem.Items.Add("Architektur:                 " + (Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit"));
            listBoxSystem.Items.Add("Hostname:                  " + Environment.MachineName);
            listBoxSystem.Items.Add("Benutzername:           " + Environment.UserName);
            listBoxSystem.Items.Add("Uptime:                       " + TimeSpan.FromMilliseconds(Environment.TickCount).ToString());
            listBoxSystem.Items.Add("Zeitzone:                     " + TimeZoneInfo.Local.StandardName);

            // Netzwerkinformationen
            foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    var ipProps = nic.GetIPProperties();
                    listBoxNetwork.Items.Add("IP-Adresse:                 " + ipProps.UnicastAddresses
                        .Where(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        .FirstOrDefault()?.Address.ToString());
                    listBoxNetwork.Items.Add("MAC-Adresse:            " + string.Join(":", nic.GetPhysicalAddress().GetAddressBytes().Select(b => b.ToString("X2"))));
                    listBoxNetwork.Items.Add("Subnetzmaske:           " + ipProps.UnicastAddresses
                        .Where(ip => ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        .FirstOrDefault()?.IPv4Mask.ToString());
                    break; // Nur die erste aktive Netzwerkschnittstelle anzeigen
                }
            }

            // Hardwareinformationen
            listBoxHardware.Items.Add("Prozessor:                   " + GetCPUName());
            listBoxHardware.Items.Add("Arbeitsspeicher:         " + (new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / (1024 * 1024 * 1024)) + " GB");
            listBoxHardware.Items.Add("Auflösung:                 " + $"{Screen.PrimaryScreen.Bounds.Width}x{Screen.PrimaryScreen.Bounds.Height}");


            }

        public string GetCPUName()
        {
            string cpuName = "";
            using (var searcher = new ManagementObjectSearcher("select * from Win32_Processor"))
            {
                foreach (var obj in searcher.Get())
                {
                    cpuName = obj["Name"].ToString();
                }
            }
            return cpuName;
        }
    }
}
