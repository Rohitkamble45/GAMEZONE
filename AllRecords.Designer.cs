namespace GAMEZONE
{
    partial class AllRecords
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
            this.dtGridallgames = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridallgames)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridallgames
            // 
            this.dtGridallgames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridallgames.Location = new System.Drawing.Point(179, 110);
            this.dtGridallgames.Name = "dtGridallgames";
            this.dtGridallgames.RowHeadersWidth = 51;
            this.dtGridallgames.Size = new System.Drawing.Size(512, 272);
            this.dtGridallgames.TabIndex = 0;
            this.dtGridallgames.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AllRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGridallgames);
            this.Name = "AllRecords";
            this.Text = "AllRecords";
            this.Load += new System.EventHandler(this.AllRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridallgames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridallgames;
    }
}