using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                try
                {
                    onlineVer.Visible = true;
                    onlineVer.Text = client.DownloadString("www.change-me.com");
                }
                catch (Exception)
                {
                    onlineVer.Visible = true;
                    onlineVer.Text = "Unable to connect...";
                }
            }
        }
    }
}