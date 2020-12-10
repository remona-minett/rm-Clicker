namespace rm_idle
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.loadButton = new System.Windows.Forms.Button();
            this.optionsButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.verLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            resources.ApplyResources(this.loadButton, "loadButton");
            this.loadButton.Name = "loadButton";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // optionsButton
            // 
            resources.ApplyResources(this.optionsButton, "optionsButton");
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // newButton
            // 
            resources.ApplyResources(this.newButton, "newButton");
            this.newButton.Name = "newButton";
            this.newButton.TabStop = false;
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // verLabel
            // 
            resources.ApplyResources(this.verLabel, "verLabel");
            this.verLabel.Name = "verLabel";
            // 
            // mainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verLabel);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.optionsButton);
            this.Controls.Add(this.loadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label verLabel;
    }
}