using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rm_idle
{
    public partial class optionsWindow : Form
    {
        public optionsWindow()
        {
            InitializeComponent();
        }

        private void optionsWindow_Load(object sender, EventArgs e)
        {

        }

        private void optionsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void checkUpdate_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                try
                {
                    onlineVer.Visible = true;
                    onlineVer.Text = client.DownloadString("https://raw.githubusercontent.com/remona-minett/rm-Clicker/master/ver.txt");
                }
                catch (Exception)
                {
                    onlineVer.Visible = true;
                    onlineVer.Text = "Unable to connect...";
                }
                try
                {
                    betaVer.Visible = true;
                    betaVer.Text = client.DownloadString("https://raw.githubusercontent.com/remona-minett/rm-Clicker/beta/ver.txt");
                }
                catch (Exception)
                {
                    betaVer.Visible = true;
                    betaVer.Text = "Unable to connect...";
                }
            }
        }

        private void openRelease_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/remona-minett/rm-Clicker/releases");
        }

        private void currentVer_Click(object sender, EventArgs e) // egg
        {
            MessageBox.Show("Originally created by Remona Minett, Nov. 10 2020\r\nWindows Forms Application (WFA)\r\n.NET Framework 4.7.2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/remona-minett/rm-Clicker/tree/beta");
        }
    }
}