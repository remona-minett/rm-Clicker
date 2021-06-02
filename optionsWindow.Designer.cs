namespace rm_idle
{
    partial class optionsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(optionsWindow));
            this.checkUpdate = new System.Windows.Forms.Button();
            this.openRelease = new System.Windows.Forms.Button();
            this.currentVer = new System.Windows.Forms.Label();
            this.onlineVer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkUpdate
            // 
            this.checkUpdate.Location = new System.Drawing.Point(236, 11);
            this.checkUpdate.Name = "checkUpdate";
            this.checkUpdate.Size = new System.Drawing.Size(99, 23);
            this.checkUpdate.TabIndex = 0;
            this.checkUpdate.Text = "Check for Update";
            this.checkUpdate.UseVisualStyleBackColor = true;
            this.checkUpdate.Click += new System.EventHandler(this.checkUpdate_Click);
            // 
            // openRelease
            // 
            this.openRelease.Location = new System.Drawing.Point(236, 40);
            this.openRelease.Name = "openRelease";
            this.openRelease.Size = new System.Drawing.Size(99, 23);
            this.openRelease.TabIndex = 1;
            this.openRelease.Text = "Go to GitHub";
            this.openRelease.UseVisualStyleBackColor = true;
            this.openRelease.Click += new System.EventHandler(this.openRelease_Click);
            // 
            // currentVer
            // 
            this.currentVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentVer.Location = new System.Drawing.Point(100, 17);
            this.currentVer.Name = "currentVer";
            this.currentVer.Size = new System.Drawing.Size(130, 23);
            this.currentVer.TabIndex = 2;
            this.currentVer.Text = "2.1.3";
            // 
            // onlineVer
            // 
            this.onlineVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onlineVer.Location = new System.Drawing.Point(100, 46);
            this.onlineVer.Name = "onlineVer";
            this.onlineVer.Size = new System.Drawing.Size(130, 23);
            this.onlineVer.TabIndex = 3;
            this.onlineVer.Text = "onlineVer";
            this.onlineVer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Online Version:";
            // 
            // optionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 75);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onlineVer);
            this.Controls.Add(this.currentVer);
            this.Controls.Add(this.openRelease);
            this.Controls.Add(this.checkUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "optionsWindow";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.optionsWindow_FormClosing);
            this.Load += new System.EventHandler(this.optionsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkUpdate;
        private System.Windows.Forms.Button openRelease;
        private System.Windows.Forms.Label currentVer;
        private System.Windows.Forms.Label onlineVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}