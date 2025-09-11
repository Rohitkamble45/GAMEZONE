namespace GAMEZONE
{
    partial class loginUser
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
            this.txtbxUserEmail = new System.Windows.Forms.TextBox();
            this.cmbbxUserType = new System.Windows.Forms.ComboBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.lblPasswoed = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxUserEmail
            // 
            this.txtbxUserEmail.Location = new System.Drawing.Point(394, 171);
            this.txtbxUserEmail.Name = "txtbxUserEmail";
            this.txtbxUserEmail.Size = new System.Drawing.Size(121, 22);
            this.txtbxUserEmail.TabIndex = 0;
            this.txtbxUserEmail.TextChanged += new System.EventHandler(this.txtbxUserEmail_TextChanged);
            // 
            // cmbbxUserType
            // 
            this.cmbbxUserType.FormattingEnabled = true;
            this.cmbbxUserType.Location = new System.Drawing.Point(394, 115);
            this.cmbbxUserType.Name = "cmbbxUserType";
            this.cmbbxUserType.Size = new System.Drawing.Size(121, 24);
            this.cmbbxUserType.TabIndex = 1;
            this.cmbbxUserType.SelectedIndexChanged += new System.EventHandler(this.cmbbxUserType_SelectedIndexChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(336, 43);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 16);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "LOGIN";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(260, 123);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 16);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "TYPE";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(260, 177);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(394, 223);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(121, 22);
            this.txtbxPassword.TabIndex = 5;
            this.txtbxPassword.TextChanged += new System.EventHandler(this.txtbxPassword_TextChanged);
            // 
            // lblPasswoed
            // 
            this.lblPasswoed.AutoSize = true;
            this.lblPasswoed.Location = new System.Drawing.Point(260, 229);
            this.lblPasswoed.Name = "lblPasswoed";
            this.lblPasswoed.Size = new System.Drawing.Size(86, 16);
            this.lblPasswoed.TabIndex = 6;
            this.lblPasswoed.Text = "PASSWORD";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(263, 310);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(440, 310);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // loginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPasswoed);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.cmbbxUserType);
            this.Controls.Add(this.txtbxUserEmail);
            this.Name = "loginUser";
            this.Text = "loginUser";
            this.Load += new System.EventHandler(this.loginUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxUserEmail;
        private System.Windows.Forms.ComboBox cmbbxUserType;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Label lblPasswoed;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClear;
    }
}