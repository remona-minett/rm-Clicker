using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rm_idle
{
    public partial class newTutorial : Form
    {
        public newTutorial()
        {
            InitializeComponent();
        }

        private void dismissTutorial_Click(object sender, EventArgs e)
        {
            var game = new mainWindow();
            game.Show();
            this.Visible = false;
        }
    }
}
