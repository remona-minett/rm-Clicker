namespace rm_idle
{
    partial class newTutorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newTutorial));
            this.label1 = new System.Windows.Forms.Label();
            this.dismissTutorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to rm-Clicker!\r\nClick the bars labelled \"Charge Bar\" to fill your\r\ncapaci" +
    "ty, and buy upgrades!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dismissTutorial
            // 
            this.dismissTutorial.Location = new System.Drawing.Point(160, 56);
            this.dismissTutorial.Name = "dismissTutorial";
            this.dismissTutorial.Size = new System.Drawing.Size(75, 23);
            this.dismissTutorial.TabIndex = 1;
            this.dismissTutorial.Text = "OK!";
            this.dismissTutorial.UseVisualStyleBackColor = true;
            this.dismissTutorial.Click += new System.EventHandler(this.dismissTutorial_Click);
            // 
            // newTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 91);
            this.Controls.Add(this.dismissTutorial);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newTutorial";
            this.Text = "Welcome!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dismissTutorial;
    }
}