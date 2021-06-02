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

        int tickcount = 0;

        public void mainWindow_Load(object sender, EventArgs e)
        {
            var shopvisible = false;
            //init gatherer logic and fillables
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
            if (Program.convsavedata != null)
            {
                buy1ct = Program.convsavedata[0];
                buy2ct = Program.convsavedata[1];
                buy3ct = Program.convsavedata[2];
                buy4ct = Program.convsavedata[3];
                buy5ct = Program.convsavedata[4];
                buy6ct = Program.convsavedata[5];
                b1prce = Program.convsavedata[6];
                b2prce = Program.convsavedata[7];
                b3prce = Program.convsavedata[8];
                b4prce = Program.convsavedata[9];
                b5prce = Program.convsavedata[10];
                b6prce = Program.convsavedata[11];
                gath0afill = Program.convsavedata[12];
                gath0afilllabel.Text = "Autofill: " + gath0afill;
                gath1decay = Program.convsavedata[13];
                gath2decay = Program.convsavedata[14];
                gatherer0.Maximum = Program.convsavedata[15];
                gath0maxlabel.Text = "Maximum: " + gatherer0.Maximum;
                gatherer1.Maximum = Program.convsavedata[16];
                gath1maxlabel.Text = "Maximum: " + gatherer1.Maximum;
                gatherer2.Maximum = Program.convsavedata[17];
                gath2maxlabel.Text = "Maximum: " + gatherer2.Maximum;
                gatherer0.Value = Program.convsavedata[18];
                gatherer1.Value = Program.convsavedata[19];
                gatherer2.Value = Program.convsavedata[20];
            }
        }

        void GameTick()
        {
            for ( ; ;)
            {
                Invoke((MethodInvoker) delegate
                {
                    tickprogbar.PerformStep();
                    if (tickprogbar.Value == 100)
                    {
                        tickprogbar.Value = 0;
                        tickcount++;
                    }
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
                        if (gatherer0.Value != gatherer0.Maximum)
                        {
                            gatherer1.Step = -1;
                            gatherer1.PerformStep();
                        }
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
                        if (gatherer0.Value != gatherer0.Maximum)
                        {
                            gatherer2.Step = -1;
                            gatherer2.PerformStep();
                        }
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

        void saveConfirm()
        {
            Thread.Sleep(3000);
            Invoke((MethodInvoker) delegate
            {
                game_saveButton.Enabled = true;
                saveConfirmText.Visible = false;

            });
        }

        private void gatherer1_Click(object sender, EventArgs e)
        {
            gatherer1.Step = gath1decay; // name deprecation
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
            buy6ct++;
            gath2maxlabel.Text = "Maximum: " + gatherer2.Maximum;
        }

        private void gatherer0label_Click(object sender, EventArgs e) // debug cheat code
        {
            // gatherer0.Maximum += 100;
            // gatherer0.Value += 100;
        }

        private void game_saveButton_Click(object sender, EventArgs e)
        {
            Program.dirtysavedata = new int[21]; // create pre-save storage
            Program.dirtysavedata[0] = buy1ct;
            Program.dirtysavedata[1] = buy2ct;
            Program.dirtysavedata[2] = buy3ct;
            Program.dirtysavedata[3] = buy4ct;
            Program.dirtysavedata[4] = buy5ct;
            Program.dirtysavedata[5] = buy6ct;
            Program.dirtysavedata[6] = b1prce;
            Program.dirtysavedata[7] = b2prce;
            Program.dirtysavedata[8] = b3prce;
            Program.dirtysavedata[9] = b4prce;
            Program.dirtysavedata[10] = b5prce;
            Program.dirtysavedata[11] = b6prce;
            Program.dirtysavedata[12] = gath0afill;
            Program.dirtysavedata[13] = gath1decay;
            Program.dirtysavedata[14] = gath2decay;
            Program.dirtysavedata[15] = gatherer0.Maximum;
            Program.dirtysavedata[16] = gatherer1.Maximum;
            Program.dirtysavedata[17] = gatherer2.Maximum;
            Program.dirtysavedata[18] = gatherer0.Value;
            Program.dirtysavedata[19] = gatherer1.Value;
            Program.dirtysavedata[20] = gatherer2.Value;
            bool success = saveLoad.saveData();
            if (success == false)
            {
                MessageBox.Show("Something went wrong. Check folder access and try again. (E03)", "Save File Error");
            }
            else if (success)
            {
                game_saveButton.Enabled = false;
                saveConfirmText.Visible = true;
                var confirmed = new Thread(saveConfirm); confirmed.Start();
            }
        }

        private void showhideshop_Click(object sender, EventArgs e)
        {
            
        }
    }
}