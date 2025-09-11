namespace GAMEZONE
{
    partial class AddGame
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
            this.lblGamingMode = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbbxGAMINGMODE = new System.Windows.Forms.ComboBox();
            this.txtbxGame = new System.Windows.Forms.TextBox();
            this.lblGamingType = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.cmbbxGAMINGTYPE = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGamingMode
            // 
            this.lblGamingMode.AutoSize = true;
            this.lblGamingMode.Location = new System.Drawing.Point(302, 79);
            this.lblGamingMode.Name = "lblGamingMode";
            this.lblGamingMode.Size = new System.Drawing.Size(103, 16);
            this.lblGamingMode.TabIndex = 0;
            this.lblGamingMode.Text = "GAMING MODE";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 357);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbbxGAMINGMODE
            // 
            this.cmbbxGAMINGMODE.FormattingEnabled = true;
            this.cmbbxGAMINGMODE.Location = new System.Drawing.Point(421, 71);
            this.cmbbxGAMINGMODE.Name = "cmbbxGAMINGMODE";
            this.cmbbxGAMINGMODE.Size = new System.Drawing.Size(121, 24);
            this.cmbbxGAMINGMODE.TabIndex = 2;
            this.cmbbxGAMINGMODE.SelectedIndexChanged += new System.EventHandler(this.cmbbxGAMINGMODE_SelectedIndexChanged);
            // 
            // txtbxGame
            // 
            this.txtbxGame.Location = new System.Drawing.Point(421, 166);
            this.txtbxGame.Name = "txtbxGame";
            this.txtbxGame.Size = new System.Drawing.Size(121, 22);
            this.txtbxGame.TabIndex = 3;
            // 
            // lblGamingType
            // 
            this.lblGamingType.AutoSize = true;
            this.lblGamingType.Location = new System.Drawing.Point(302, 119);
            this.lblGamingType.Name = "lblGamingType";
            this.lblGamingType.Size = new System.Drawing.Size(99, 16);
            this.lblGamingType.TabIndex = 4;
            this.lblGamingType.Text = "GAMING TYPE";
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(302, 172);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(46, 16);
            this.lblGame.TabIndex = 5;
            this.lblGame.Text = "GAME";
            // 
            // cmbbxGAMINGTYPE
            // 
            this.cmbbxGAMINGTYPE.FormattingEnabled = true;
            this.cmbbxGAMINGTYPE.Location = new System.Drawing.Point(421, 119);
            this.cmbbxGAMINGTYPE.Name = "cmbbxGAMINGTYPE";
            this.cmbbxGAMINGTYPE.Size = new System.Drawing.Size(121, 24);
            this.cmbbxGAMINGTYPE.TabIndex = 8;
            this.cmbbxGAMINGTYPE.SelectedIndexChanged += new System.EventHandler(this.cmbbxGAMINGTYPE_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(421, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbbxGAMINGTYPE);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.lblGamingType);
            this.Controls.Add(this.txtbxGame);
            this.Controls.Add(this.cmbbxGAMINGMODE);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGamingMode);
            this.Name = "AddGame";
            this.Text = "AddGame";
            this.Load += new System.EventHandler(this.AddGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGamingMode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbbxGAMINGMODE;
        private System.Windows.Forms.TextBox txtbxGame;
        private System.Windows.Forms.Label lblGamingType;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.ComboBox cmbbxGAMINGTYPE;
        private System.Windows.Forms.Button btnClear;
    }
}