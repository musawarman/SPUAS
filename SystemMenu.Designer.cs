namespace SPUAS
{
    partial class SystemMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.referensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entriDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAPORANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTILITYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kELUARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referensiToolStripMenuItem,
            this.entriDataToolStripMenuItem,
            this.lAPORANToolStripMenuItem,
            this.uTILITYToolStripMenuItem,
            this.kELUARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // referensiToolStripMenuItem
            // 
            this.referensiToolStripMenuItem.Name = "referensiToolStripMenuItem";
            this.referensiToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.referensiToolStripMenuItem.Text = "&REFERENSI";
            this.referensiToolStripMenuItem.Click += new System.EventHandler(this.referensiToolStripMenuItem_Click);
            // 
            // entriDataToolStripMenuItem
            // 
            this.entriDataToolStripMenuItem.Name = "entriDataToolStripMenuItem";
            this.entriDataToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.entriDataToolStripMenuItem.Text = "&ENTRI DATA";
            this.entriDataToolStripMenuItem.Click += new System.EventHandler(this.entriDataToolStripMenuItem_Click);
            // 
            // lAPORANToolStripMenuItem
            // 
            this.lAPORANToolStripMenuItem.Name = "lAPORANToolStripMenuItem";
            this.lAPORANToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.lAPORANToolStripMenuItem.Text = "&LAPORAN";
            this.lAPORANToolStripMenuItem.Click += new System.EventHandler(this.lAPORANToolStripMenuItem_Click);
            // 
            // uTILITYToolStripMenuItem
            // 
            this.uTILITYToolStripMenuItem.Name = "uTILITYToolStripMenuItem";
            this.uTILITYToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.uTILITYToolStripMenuItem.Text = "&UTILITY";
            this.uTILITYToolStripMenuItem.Click += new System.EventHandler(this.uTILITYToolStripMenuItem_Click);
            // 
            // kELUARToolStripMenuItem
            // 
            this.kELUARToolStripMenuItem.Name = "kELUARToolStripMenuItem";
            this.kELUARToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.kELUARToolStripMenuItem.Text = "&KELUAR";
            this.kELUARToolStripMenuItem.Click += new System.EventHandler(this.kELUARToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 152);
            this.panel1.TabIndex = 2;
            // 
            // SystemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SystemMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referensiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entriDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lAPORANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uTILITYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kELUARToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}