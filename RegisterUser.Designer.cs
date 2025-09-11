namespace GAMEZONE
{
    partial class RegisterUser
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
            this.lblUserRegister = new System.Windows.Forms.Label();
            this.cmbbxUserType = new System.Windows.Forms.ComboBox();
            this.txtbxUserName = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxUserEmail = new System.Windows.Forms.TextBox();
            this.txtbxUserPhone = new System.Windows.Forms.TextBox();
            this.cmbbxUserState = new System.Windows.Forms.ComboBox();
            this.cmbbxUserCity = new System.Windows.Forms.ComboBox();
            this.txtbxUserPassword = new System.Windows.Forms.TextBox();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserClear = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbbxUserGender = new System.Windows.Forms.ComboBox();
            this.txtbxUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserRegister
            // 
            this.lblUserRegister.AutoSize = true;
            this.lblUserRegister.Location = new System.Drawing.Point(418, 79);
            this.lblUserRegister.Name = "lblUserRegister";
            this.lblUserRegister.Size = new System.Drawing.Size(58, 16);
            this.lblUserRegister.TabIndex = 0;
            this.lblUserRegister.Text = "Register";
            // 
            // cmbbxUserType
            // 
            this.cmbbxUserType.FormattingEnabled = true;
            this.cmbbxUserType.Location = new System.Drawing.Point(470, 150);
            this.cmbbxUserType.Name = "cmbbxUserType";
            this.cmbbxUserType.Size = new System.Drawing.Size(121, 24);
            this.cmbbxUserType.TabIndex = 1;
            this.cmbbxUserType.SelectedIndexChanged += new System.EventHandler(this.cmbbxUserType_SelectedIndexChanged);
            // 
            // txtbxUserName
            // 
            this.txtbxUserName.Location = new System.Drawing.Point(470, 200);
            this.txtbxUserName.Name = "txtbxUserName";
            this.txtbxUserName.Size = new System.Drawing.Size(121, 22);
            this.txtbxUserName.TabIndex = 2;
            this.txtbxUserName.TextChanged += new System.EventHandler(this.txtbxUserName_TextChanged);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(338, 153);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(43, 16);
            this.lblUserType.TabIndex = 3;
            this.lblUserType.Text = "TYPE";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(338, 206);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "NAME";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(338, 255);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(338, 297);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 16);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "PHONE";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(338, 346);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 16);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "GENDER";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(338, 439);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(37, 16);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "CITY";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(338, 390);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(52, 16);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "STATE";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(338, 487);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 16);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txtbxUserEmail
            // 
            this.txtbxUserEmail.Location = new System.Drawing.Point(470, 249);
            this.txtbxUserEmail.Name = "txtbxUserEmail";
            this.txtbxUserEmail.Size = new System.Drawing.Size(121, 22);
            this.txtbxUserEmail.TabIndex = 11;
            // 
            // txtbxUserPhone
            // 
            this.txtbxUserPhone.Location = new System.Drawing.Point(470, 297);
            this.txtbxUserPhone.Name = "txtbxUserPhone";
            this.txtbxUserPhone.Size = new System.Drawing.Size(121, 22);
            this.txtbxUserPhone.TabIndex = 12;
            // 
            // cmbbxUserState
            // 
            this.cmbbxUserState.FormattingEnabled = true;
            this.cmbbxUserState.Location = new System.Drawing.Point(470, 390);
            this.cmbbxUserState.Name = "cmbbxUserState";
            this.cmbbxUserState.Size = new System.Drawing.Size(121, 24);
            this.cmbbxUserState.TabIndex = 14;
            this.cmbbxUserState.SelectedIndexChanged += new System.EventHandler(this.cmbbxUserState_SelectedIndexChanged);
            // 
            // cmbbxUserCity
            // 
            this.cmbbxUserCity.FormattingEnabled = true;
            this.cmbbxUserCity.Location = new System.Drawing.Point(470, 431);
            this.cmbbxUserCity.Name = "cmbbxUserCity";
            this.cmbbxUserCity.Size = new System.Drawing.Size(121, 24);
            this.cmbbxUserCity.TabIndex = 15;
            // 
            // txtbxUserPassword
            // 
            this.txtbxUserPassword.Location = new System.Drawing.Point(470, 481);
            this.txtbxUserPassword.Name = "txtbxUserPassword";
            this.txtbxUserPassword.Size = new System.Drawing.Size(121, 22);
            this.txtbxUserPassword.TabIndex = 16;
            // 
            // btnUserSave
            // 
            this.btnUserSave.Location = new System.Drawing.Point(341, 570);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(110, 23);
            this.btnUserSave.TabIndex = 19;
            this.btnUserSave.Text = "SAVE";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // btnUserClear
            // 
            this.btnUserClear.Location = new System.Drawing.Point(481, 570);
            this.btnUserClear.Name = "btnUserClear";
            this.btnUserClear.Size = new System.Drawing.Size(110, 23);
            this.btnUserClear.TabIndex = 20;
            this.btnUserClear.Text = "CLEAR";
            this.btnUserClear.UseVisualStyleBackColor = true;
            this.btnUserClear.Click += new System.EventHandler(this.btnUserClear_Click);
            // 
            // cmbbxUserGender
            // 
            this.cmbbxUserGender.FormattingEnabled = true;
            this.cmbbxUserGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "OTHER"});
            this.cmbbxUserGender.Location = new System.Drawing.Point(470, 343);
            this.cmbbxUserGender.Name = "cmbbxUserGender";
            this.cmbbxUserGender.Size = new System.Drawing.Size(121, 24);
            this.cmbbxUserGender.TabIndex = 21;
            this.cmbbxUserGender.SelectedIndexChanged += new System.EventHandler(this.cmbbxUserGender_SelectedIndexChanged);
            // 
            // txtbxUserId
            // 
            this.txtbxUserId.Location = new System.Drawing.Point(470, 110);
            this.txtbxUserId.Name = "txtbxUserId";
            this.txtbxUserId.Size = new System.Drawing.Size(121, 22);
            this.txtbxUserId.TabIndex = 23;
            this.txtbxUserId.TextChanged += new System.EventHandler(this.txtbxUserId_TextChanged);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(347, 116);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(20, 16);
            this.lblUserId.TabIndex = 24;
            this.lblUserId.Text = "ID";
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 819);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtbxUserId);
            this.Controls.Add(this.cmbbxUserGender);
            this.Controls.Add(this.btnUserClear);
            this.Controls.Add(this.btnUserSave);
            this.Controls.Add(this.txtbxUserPassword);
            this.Controls.Add(this.cmbbxUserCity);
            this.Controls.Add(this.cmbbxUserState);
            this.Controls.Add(this.txtbxUserPhone);
            this.Controls.Add(this.txtbxUserEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.txtbxUserName);
            this.Controls.Add(this.cmbbxUserType);
            this.Controls.Add(this.lblUserRegister);
            this.Name = "RegisterUser";
            this.Text = "RegisterUser";
            this.Load += new System.EventHandler(this.RegisterUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserRegister;
        private System.Windows.Forms.ComboBox cmbbxUserType;
        private System.Windows.Forms.TextBox txtbxUserName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxUserEmail;
        private System.Windows.Forms.TextBox txtbxUserPhone;
        private System.Windows.Forms.ComboBox cmbbxUserState;
        private System.Windows.Forms.ComboBox cmbbxUserCity;
        private System.Windows.Forms.TextBox txtbxUserPassword;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Button btnUserClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbbxUserGender;
        private System.Windows.Forms.TextBox txtbxUserId;
        private System.Windows.Forms.Label lblUserId;
    }
}