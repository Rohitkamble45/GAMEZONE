namespace GAMEZONE
{
    partial class AddType
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
            this.lblGamingmpdetype = new System.Windows.Forms.Label();
            this.btnAddtype = new System.Windows.Forms.Button();
            this.txtbxGamingType = new System.Windows.Forms.TextBox();
            this.cmbbxGamingModeType = new System.Windows.Forms.ComboBox();
            this.lblGameType = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGamingmpdetype
            // 
            this.lblGamingmpdetype.AutoSize = true;
            this.lblGamingmpdetype.Location = new System.Drawing.Point(316, 154);
            this.lblGamingmpdetype.Name = "lblGamingmpdetype";
            this.lblGamingmpdetype.Size = new System.Drawing.Size(89, 16);
            this.lblGamingmpdetype.TabIndex = 0;
            this.lblGamingmpdetype.Text = "GAME MODE";
            // 
            // btnAddtype
            // 
            this.btnAddtype.Location = new System.Drawing.Point(319, 261);
            this.btnAddtype.Name = "btnAddtype";
            this.btnAddtype.Size = new System.Drawing.Size(75, 23);
            this.btnAddtype.TabIndex = 1;
            this.btnAddtype.Text = "ADD";
            this.btnAddtype.UseVisualStyleBackColor = true;
            this.btnAddtype.Click += new System.EventHandler(this.btnAddtype_Click);
            // 
            // txtbxGamingType
            // 
            this.txtbxGamingType.Location = new System.Drawing.Point(435, 209);
            this.txtbxGamingType.Name = "txtbxGamingType";
            this.txtbxGamingType.Size = new System.Drawing.Size(100, 22);
            this.txtbxGamingType.TabIndex = 2;
            this.txtbxGamingType.TextChanged += new System.EventHandler(this.txtbxGamingType_TextChanged);
            // 
            // cmbbxGamingModeType
            // 
            this.cmbbxGamingModeType.FormattingEnabled = true;
            this.cmbbxGamingModeType.Location = new System.Drawing.Point(435, 146);
            this.cmbbxGamingModeType.Name = "cmbbxGamingModeType";
            this.cmbbxGamingModeType.Size = new System.Drawing.Size(121, 24);
            this.cmbbxGamingModeType.TabIndex = 3;
            this.cmbbxGamingModeType.SelectedIndexChanged += new System.EventHandler(this.cmbbxGamingModeType_SelectedIndexChanged);
            // 
            // lblGameType
            // 
            this.lblGameType.AutoSize = true;
            this.lblGameType.Location = new System.Drawing.Point(326, 215);
            this.lblGameType.Name = "lblGameType";
            this.lblGameType.Size = new System.Drawing.Size(85, 16);
            this.lblGameType.TabIndex = 4;
            this.lblGameType.Text = "GAME TYPE";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(415, 261);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblGameType);
            this.Controls.Add(this.cmbbxGamingModeType);
            this.Controls.Add(this.txtbxGamingType);
            this.Controls.Add(this.btnAddtype);
            this.Controls.Add(this.lblGamingmpdetype);
            this.Name = "AddType";
            this.Text = "AddType";
            this.Load += new System.EventHandler(this.AddType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGamingmpdetype;
        private System.Windows.Forms.Button btnAddtype;
        private System.Windows.Forms.TextBox txtbxGamingType;
        private System.Windows.Forms.ComboBox cmbbxGamingModeType;
        private System.Windows.Forms.Label lblGameType;
        private System.Windows.Forms.Button btnClear;
    }
}