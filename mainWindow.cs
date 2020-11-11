using System;
using System.Threading;
using System.Windows.Forms;

namespace rm_idle
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        int buy1ct = 1; int buy2ct = 1; int buy3ct = 1; int buy4ct = 1; int buy5ct = 1; int buy6ct = 1;
        int b1prce = 10; int b2prce = 25; int b3prce = 10; int b4prce = 100; int b5prce = 50; int b6prce = 20;
        int gath0afill = 0; int gath1decay = 1; int gath2decay = 1;

        public void mainWindow_Load(object sender, EventArgs e)
        {
            
            var g0 = new Thread(Gatherer0logic);
            var g1 = new Thread(Gatherer1logic);
            var g2 = new Thread(Gatherer2logic);
            var shop = new Thread(Shoplogic);
            var tickbar = new Thread(GameTick);
            g0.Start(); g1.Start(); g2.Start(); shop.Start(); tickbar.Start();
            gath0afilllabel.Text = "Autofill: " + gath0afill;
            gath0maxlabel.Text = "Maximum: " + gatherer0.Maximum;
            gath1maxlabel.Text = "Maximum: " + gatherer1.Maximum;
            gath2maxlabel.Text = "Maximum: " + gatherer2.Maximum;
            buy1label.Text = "Max Capacity +10";
            buy2label.Text = "Charge Bar | 1 Click Power +1";
            buy3label.Text = "Charge Bar | 1 Max capacity +5";
            buy4label.Text = "Capacity Autofill +1";
            buy5label.Text = "Charge Bar | 2 Click Power +1";
            buy6label.Text = "Charge Bar | 2 Max Capacity +5";
        }

        void GameTick()
        {
            for ( ; ;)
            {
                Invoke((MethodInvoker)delegate
                {
                    tickprogbar.PerformStep();
                    if (tickprogbar.Value == 100) tickprogbar.Value = 0;
                });
                Thread.Sleep(10);
            }
        }

        void Gatherer0logic()
        {
            for ( ; ;)
            {
                var v = 0;
                if (gatherer1.Value != 0) v++;
                if (gatherer2.Value != 0) v++;
                v += gath0afill;
                Invoke((MethodInvoker)delegate
                {
                    gatherer0.Step = v;
                    gatherer0.PerformStep();
                    gatherer0text.Text = gatherer0.Value.ToString();
                });
                Thread.Sleep(1000);
            }
        }

        void Gatherer1logic()
        {
            for ( ; ;)
            {
                Invoke((MethodInvoker)delegate
                {
                    if (gatherer1.Value != 0)
                    {
                        gatherer1.Step = -1;
                        gatherer1.PerformStep();
                    }
                });
                Thread.Sleep(1000);
            }
        }

        void Gatherer2logic()
        {
            for ( ; ;)
            {
                Invoke((MethodInvoker)delegate
                {
                    if (gatherer2.Value != 0)
                    {
                        gatherer2.Step = -1;
                        gatherer2.PerformStep();
                    }
                });
                Thread.Sleep(1000);
            }
        }

        void Shoplogic()
        {
            for ( ; ;)
            {
                Invoke((MethodInvoker) delegate
                {
                    buy1button.Text = "" + b1prce * buy1ct;
                    buy2button.Text = "" + b2prce * buy2ct;
                    buy3button.Text = "" + b3prce * buy3ct;
                    buy4button.Text = "" + b4prce * buy4ct;
                    buy5button.Text = "" + b5prce * buy5ct;
                    buy6button.Text = "" + b6prce * buy6ct;
                    buy1button.Enabled = b1prce * buy1ct <= gatherer0.Value;
                    buy2button.Enabled = b2prce * buy2ct <= gatherer0.Value;
                    buy3button.Enabled = b3prce * buy3ct <= gatherer0.Value;
                    buy4button.Enabled = b4prce * buy4ct <= gatherer0.Value;
                    buy5button.Enabled = b5prce * buy5ct <= gatherer0.Value;
                    buy6button.Enabled = b6prce * buy6ct <= gatherer0.Value;
                });
                Thread.Sleep(250);
            }

        }

        private void gatherer1_Click(object sender, EventArgs e)
        {
            gatherer1.Step = gath1decay; // deprecated int, used in lieu of renaming...
            gatherer1.PerformStep();
        }

        private void gatherer2_Click(object sender, EventArgs e)
        {
            gatherer2.Step = gath2decay;
            gatherer2.PerformStep();
        }

        private void buy1button_Click(object sender, EventArgs e)
        {
            buy1button.Enabled = false;
            gatherer0.Maximum += 10;
            gatherer0.Value -= b1prce * buy1ct;
            buy1ct++;
            gath0maxlabel.Text = "Maximum: " + gatherer0.Maximum;
        }

        private void buy2button_Click(object sender, EventArgs e)
        {
            buy2button.Enabled = false;
            gath1decay++;
            gatherer0.Value -= b2prce * buy2ct;
            buy2ct++;
        }

        private void buy3button_Click(object sender, EventArgs e)
        {

            buy3button.Enabled = false;
            gatherer1.Maximum += 5;
            gatherer0.Value -= b3prce * buy3ct;
            buy3ct++;
            gath1maxlabel.Text = "Maximum: " + gatherer1.Maximum;
        }

        private void buy4button_Click(object sender, EventArgs e)
        {
            buy4button.Enabled = false;
            gath0afill++;
            gatherer0.Value -= b4prce * buy4ct;
            buy4ct++;
            gath0afilllabel.Text = "Autofill: " + gath0afill;
        }

        private void buy5button_Click(object sender, EventArgs e)
        {
            buy5button.Enabled = false;
            gath2decay++;
            gatherer0.Value -= b5prce * buy5ct;
            buy5ct++;
        }

        private void buy6button_Click(object sender, EventArgs e)
        {
            buy6button.Enabled = false;
            gatherer2.Maximum += 5;
            gatherer0.Value -= b6prce * buy6ct;
            buy2ct++;
            gath2maxlabel.Text = "Maximum: " + gatherer2.Maximum;
        }

        private void gatherer0label_Click(object sender, EventArgs e) // debug cheat code
        {
            /* gatherer0.Maximum += 100;
            gatherer0.Value += 100; */
        }
    }
}

/*
 *
 * Originally created by Remona Minett, Nov. 10 2020
 * Windows Forms Application (WFA)
 * .NET Framework 4.7.2
 * Internal Revision 41
 * Release version 1.0
 *
 */