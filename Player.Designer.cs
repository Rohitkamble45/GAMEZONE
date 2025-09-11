namespace GAMEZONE
{
    partial class Player
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNETIMEPLAYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACKAGEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLAYERRECORDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTARTToolStripMenuItem,
            this.pLAYERRECORDSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNETIMEPLAYToolStripMenuItem,
            this.pACKAGEToolStripMenuItem});
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.sTARTToolStripMenuItem.Text = "START";
            // 
            // oNETIMEPLAYToolStripMenuItem
            // 
            this.oNETIMEPLAYToolStripMenuItem.Name = "oNETIMEPLAYToolStripMenuItem";
            this.oNETIMEPLAYToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.oNETIMEPLAYToolStripMenuItem.Text = "ONE TIME PLAY";
            this.oNETIMEPLAYToolStripMenuItem.Click += new System.EventHandler(this.oNETIMEPLAYToolStripMenuItem_Click);
            // 
            // pACKAGEToolStripMenuItem
            // 
            this.pACKAGEToolStripMenuItem.Name = "pACKAGEToolStripMenuItem";
            this.pACKAGEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pACKAGEToolStripMenuItem.Text = "PACKAGE";
            // 
            // pLAYERRECORDSToolStripMenuItem
            // 
            this.pLAYERRECORDSToolStripMenuItem.Name = "pLAYERRECORDSToolStripMenuItem";
            this.pLAYERRECORDSToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.pLAYERRECORDSToolStripMenuItem.Text = "PLAYER RECORDS";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Player";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNETIMEPLAYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pACKAGEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLAYERRECORDSToolStripMenuItem;
    }
}