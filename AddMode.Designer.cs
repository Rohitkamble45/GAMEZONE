namespace GAMEZONE
{
    partial class AddMode
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblGamingMode = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtGamingMode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(258, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblGamingMode
            // 
            this.lblGamingMode.AutoSize = true;
            this.lblGamingMode.Location = new System.Drawing.Point(243, 154);
            this.lblGamingMode.Name = "lblGamingMode";
            this.lblGamingMode.Size = new System.Drawing.Size(103, 16);
            this.lblGamingMode.TabIndex = 1;
            this.lblGamingMode.Text = "GAMING MODE";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(405, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtGamingMode
            // 
            this.txtGamingMode.Location = new System.Drawing.Point(405, 148);
            this.txtGamingMode.Name = "txtGamingMode";
            this.txtGamingMode.Size = new System.Drawing.Size(100, 22);
            this.txtGamingMode.TabIndex = 4;
            this.txtGamingMode.TextChanged += new System.EventHandler(this.txtGamingMode_TextChanged);
            // 
            // AddMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGamingMode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblGamingMode);
            this.Controls.Add(this.btnSave);
            this.Name = "AddMode";
            this.Text = "AddMode";
            this.Load += new System.EventHandler(this.AddMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGamingMode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtGamingMode;
    }
}