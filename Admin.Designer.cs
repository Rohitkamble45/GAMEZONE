namespace GAMEZONE
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDMODEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDTYPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDDURATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.aLLToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDMODEToolStripMenuItem,
            this.aDDTYPEToolStripMenuItem,
            this.aDDGAMEToolStripMenuItem,
            this.aDDDURATIONToolStripMenuItem});
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aDDToolStripMenuItem.Text = "ADD";
            // 
            // aDDMODEToolStripMenuItem
            // 
            this.aDDMODEToolStripMenuItem.Name = "aDDMODEToolStripMenuItem";
            this.aDDMODEToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.aDDMODEToolStripMenuItem.Text = "ADD MODE";
            this.aDDMODEToolStripMenuItem.Click += new System.EventHandler(this.aDDMODEToolStripMenuItem_Click);
            // 
            // aDDTYPEToolStripMenuItem
            // 
            this.aDDTYPEToolStripMenuItem.Name = "aDDTYPEToolStripMenuItem";
            this.aDDTYPEToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.aDDTYPEToolStripMenuItem.Text = "ADD TYPE";
            this.aDDTYPEToolStripMenuItem.Click += new System.EventHandler(this.aDDTYPEToolStripMenuItem_Click);
            // 
            // aDDGAMEToolStripMenuItem
            // 
            this.aDDGAMEToolStripMenuItem.Name = "aDDGAMEToolStripMenuItem";
            this.aDDGAMEToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.aDDGAMEToolStripMenuItem.Text = "ADD GAME";
            this.aDDGAMEToolStripMenuItem.Click += new System.EventHandler(this.aDDGAMEToolStripMenuItem_Click);
            // 
            // aLLToolStripMenuItem
            // 
            this.aLLToolStripMenuItem.Name = "aLLToolStripMenuItem";
            this.aLLToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.aLLToolStripMenuItem.Text = "ALL RECORDS";
            this.aLLToolStripMenuItem.Click += new System.EventHandler(this.aLLToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // aDDDURATIONToolStripMenuItem
            // 
            this.aDDDURATIONToolStripMenuItem.Name = "aDDDURATIONToolStripMenuItem";
            this.aDDDURATIONToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aDDDURATIONToolStripMenuItem.Text = "ADD DURATION";
            this.aDDDURATIONToolStripMenuItem.Click += new System.EventHandler(this.aDDDURATIONToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDMODEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDTYPEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDGAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDDURATIONToolStripMenuItem;
    }
}