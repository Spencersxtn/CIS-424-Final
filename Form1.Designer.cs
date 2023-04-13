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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            changeProfileToolStripMenuItem = new ToolStripMenuItem();
            registerationToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sunlightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plantBindingSource = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plantBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 1, 0, 1);
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeProfileToolStripMenuItem, registerationToolStripMenuItem, logoutToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 22);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // changeProfileToolStripMenuItem
            // 
            changeProfileToolStripMenuItem.Name = "changeProfileToolStripMenuItem";
            changeProfileToolStripMenuItem.Size = new Size(152, 22);
            changeProfileToolStripMenuItem.Text = "Change Profile";
            changeProfileToolStripMenuItem.Click += changeProfileToolStripMenuItem_Click;
            // 
            // registerationToolStripMenuItem
            // 
            registerationToolStripMenuItem.Name = "registerationToolStripMenuItem";
            registerationToolStripMenuItem.Size = new Size(152, 22);
            registerationToolStripMenuItem.Text = "Registration";
            registerationToolStripMenuItem.Click += registerationToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(152, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, sunlightDataGridViewTextBoxColumn, regionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = plantBindingSource;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(762, 394);
            dataGridView1.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sunlightDataGridViewTextBoxColumn
            // 
            sunlightDataGridViewTextBoxColumn.DataPropertyName = "Sunlight";
            sunlightDataGridViewTextBoxColumn.HeaderText = "Sunlight";
            sunlightDataGridViewTextBoxColumn.Name = "sunlightDataGridViewTextBoxColumn";
            sunlightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            regionDataGridViewTextBoxColumn.HeaderText = "Region";
            regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            regionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plantBindingSource
            // 
            plantBindingSource.DataSource = typeof(Plant);
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainPage";
            Text = "mainPage";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)plantBindingSource).EndInit();
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
        private DataGridView dataGridView1;
        private ToolStripMenuItem changeProfileToolStripMenuItem;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sunlightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private BindingSource plantBindingSource;
    }
}