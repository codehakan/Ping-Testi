using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Testi
{
    public partial class Form1 : Form
    {
        Ping p = new Ping();
        PingReply r;
        string s;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void localPing()
        {

            try
            {
                s = GetDefaultGateway().ToString();
                r = p.Send(s);

                if (r.Status == IPStatus.Success)
                {
                    lbl_localPING.Text = ": " + r.RoundtripTime.ToString() + " ms";
                }
                modem_sunucu.Text = s;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Modem ile bağlantı kurulamadı. ( " + s + " )", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void speedPing()
        {
            try
            {
                s = "8.8.8.8";
                r = p.Send(s);

                if (r.Status == IPStatus.Success)
                {
                    lbl_internetPING.Text = ": " +r.RoundtripTime.ToString() + " ms";
                }
                hat_sunucu.Text = s;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Google ile bağlantı kurulamadı. ( "+s+" )", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void lolPing()
        {
            try
            {
                s = "104.160.141.3";
                r = p.Send(s);

                if (r.Status == IPStatus.Success)
                {
                    lbl_lolPING.Text = ": " + r.RoundtripTime.ToString() + " ms";
                }
                lol_sunucu.Text = s;
            }
            catch (Exception hata)
            {
                MessageBox.Show("League of Legends ile bağlantı kurulamadı. ( " + s + " )", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void csgoPing()
        {
            try
            {
                s = "23.6.122.178";
                r = p.Send(s);

                if (r.Status == IPStatus.Success)
                {
                    lbl_csgoPING.Text = ": " + r.RoundtripTime.ToString() + " ms";
                }
                csgo_sunucu.Text = s;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Counter Strike: Global Offensive ile bağlantı kurulamadı. ( " + s + " )", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("reload58", "reload58", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        public static IPAddress GetDefaultGateway()
        {
            try
            {
                return NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                .Select(g => g?.Address)
                .Where(a => a != null)
                // .Where(a => a.AddressFamily == AddressFamily.InterNetwork)
                // .Where(a => Array.FindIndex(a.GetAddressBytes(), b => b != 0) >= 0)
                .FirstOrDefault();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Modem arayüz adresi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        


        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            localPing();
            speedPing();
            lolPing();
            csgoPing();
        }

        
    }
}
