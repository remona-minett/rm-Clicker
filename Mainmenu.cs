using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace rm_idle
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Program.convsavedata = null;
            var tutorial = new newTutorial();
            tutorial.Show();
            this.Visible = false;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            bool success = saveLoad.loadData();
            if (success == false) return;
            var game = new mainWindow();
            game.Show();
            this.Visible = false;
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            // nothing yet
        }
    }
}

/*
 *
 * Originally created by Remona Minett, Nov. 10 2020
 * Windows Forms Application (WFA)
 * .NET Framework 4.7.2
 * Internal version 63
 * External version 2.1.2
 *
 */
