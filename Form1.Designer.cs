namespace CIS_424_Final
{
    partial class mainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            introPageToolStripMenuItem = new ToolStripMenuItem();
            registerationToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            plantsToolStripMenuItem = new ToolStripMenuItem();
            regionsToolStripMenuItem = new ToolStripMenuItem();
            statesToolStripMenuItem = new ToolStripMenuItem();
            southDakotaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, plantsToolStripMenuItem, regionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1486, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { introPageToolStripMenuItem, registerationToolStripMenuItem, logoutToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(97, 36);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // introPageToolStripMenuItem
            // 
            introPageToolStripMenuItem.Name = "introPageToolStripMenuItem";
            introPageToolStripMenuItem.Size = new Size(359, 44);
            introPageToolStripMenuItem.Text = "IntroPage";
            introPageToolStripMenuItem.Click += introPageToolStripMenuItem_Click;
            // 
            // registerationToolStripMenuItem
            // 
            registerationToolStripMenuItem.Name = "registerationToolStripMenuItem";
            registerationToolStripMenuItem.Size = new Size(359, 44);
            registerationToolStripMenuItem.Text = "Registeration";
            registerationToolStripMenuItem.Click += registerationToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(359, 44);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // plantsToolStripMenuItem
            // 
            plantsToolStripMenuItem.Name = "plantsToolStripMenuItem";
            plantsToolStripMenuItem.Size = new Size(97, 36);
            plantsToolStripMenuItem.Text = "Plants";
            // 
            // regionsToolStripMenuItem
            // 
            regionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statesToolStripMenuItem });
            regionsToolStripMenuItem.Name = "regionsToolStripMenuItem";
            regionsToolStripMenuItem.Size = new Size(118, 36);
            regionsToolStripMenuItem.Text = "Regions";
            // 
            // statesToolStripMenuItem
            // 
            statesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { southDakotaToolStripMenuItem });
            statesToolStripMenuItem.Name = "statesToolStripMenuItem";
            statesToolStripMenuItem.Size = new Size(210, 44);
            statesToolStripMenuItem.Text = "States";
            // 
            // southDakotaToolStripMenuItem
            // 
            southDakotaToolStripMenuItem.Name = "southDakotaToolStripMenuItem";
            southDakotaToolStripMenuItem.Size = new Size(292, 44);
            southDakotaToolStripMenuItem.Text = "South Dakota";
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6);
            Name = "mainPage";
            Text = "mainPage";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem introPageToolStripMenuItem;
        private ToolStripMenuItem registerationToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem plantsToolStripMenuItem;
        private ToolStripMenuItem regionsToolStripMenuItem;
        private ToolStripMenuItem statesToolStripMenuItem;
        private ToolStripMenuItem southDakotaToolStripMenuItem;
    }
}