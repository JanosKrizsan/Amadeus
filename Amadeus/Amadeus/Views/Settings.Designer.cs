namespace Amadeus.Views
{
    partial class Settings
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
            this.usrnameLbl = new System.Windows.Forms.Label();
            this.reloadStngsBtn = new System.Windows.Forms.Button();
            this.saveStngsBtn = new System.Windows.Forms.Button();
            this.loadStngsBtn = new System.Windows.Forms.Button();
            this.userinfoPnl = new System.Windows.Forms.Panel();
            this.gpgTxtBox = new System.Windows.Forms.TextBox();
            this.gpgLbl = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.settingsBtnsPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.useRecommBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.wipeAllnRemoveBtn = new System.Windows.Forms.Button();
            this.checkBoxLayoutPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.autoLoginCheck = new System.Windows.Forms.CheckBox();
            this.doNotSaveCheck = new System.Windows.Forms.CheckBox();
            this.wipeDataQuitCheck = new System.Windows.Forms.CheckBox();
            this.resetSysDefsCheck = new System.Windows.Forms.CheckBox();
            this.alwaysGPGCheck = new System.Windows.Forms.CheckBox();
            this.sendRepEmailCheck = new System.Windows.Forms.CheckBox();
            this.emailPnl = new System.Windows.Forms.Panel();
            this.emailAddLbl = new System.Windows.Forms.Label();
            this.emailAddTxtBox = new System.Windows.Forms.TextBox();
            this.emailAddConfLbl = new System.Windows.Forms.Label();
            this.emailAddConfTxtBox = new System.Windows.Forms.TextBox();
            this.forcePGPEmailCheck = new System.Windows.Forms.CheckBox();
            this.setEmailBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.setUserinfoBtn = new System.Windows.Forms.Button();
            this.userinfoPnl.SuspendLayout();
            this.settingsBtnsPnl.SuspendLayout();
            this.checkBoxLayoutPnl.SuspendLayout();
            this.emailPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // usrnameLbl
            // 
            this.usrnameLbl.AutoSize = true;
            this.usrnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnameLbl.Location = new System.Drawing.Point(3, 10);
            this.usrnameLbl.Name = "usrnameLbl";
            this.usrnameLbl.Size = new System.Drawing.Size(81, 18);
            this.usrnameLbl.TabIndex = 4;
            this.usrnameLbl.Text = "Username:";
            // 
            // reloadStngsBtn
            // 
            this.reloadStngsBtn.Location = new System.Drawing.Point(3, 90);
            this.reloadStngsBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.reloadStngsBtn.Name = "reloadStngsBtn";
            this.reloadStngsBtn.Size = new System.Drawing.Size(120, 30);
            this.reloadStngsBtn.TabIndex = 5;
            this.reloadStngsBtn.Text = "Reload Settings";
            this.reloadStngsBtn.UseVisualStyleBackColor = true;
            // 
            // saveStngsBtn
            // 
            this.saveStngsBtn.Location = new System.Drawing.Point(3, 50);
            this.saveStngsBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.saveStngsBtn.Name = "saveStngsBtn";
            this.saveStngsBtn.Size = new System.Drawing.Size(120, 30);
            this.saveStngsBtn.TabIndex = 6;
            this.saveStngsBtn.Text = "Save Settings";
            this.saveStngsBtn.UseVisualStyleBackColor = true;
            // 
            // loadStngsBtn
            // 
            this.loadStngsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadStngsBtn.Location = new System.Drawing.Point(3, 10);
            this.loadStngsBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.loadStngsBtn.Name = "loadStngsBtn";
            this.loadStngsBtn.Size = new System.Drawing.Size(120, 30);
            this.loadStngsBtn.TabIndex = 7;
            this.loadStngsBtn.Text = "Load Settings";
            this.loadStngsBtn.UseVisualStyleBackColor = true;
            this.loadStngsBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // userinfoPnl
            // 
            this.userinfoPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userinfoPnl.Controls.Add(this.setUserinfoBtn);
            this.userinfoPnl.Controls.Add(this.gpgTxtBox);
            this.userinfoPnl.Controls.Add(this.gpgLbl);
            this.userinfoPnl.Controls.Add(this.passwordTxtBox);
            this.userinfoPnl.Controls.Add(this.passwordLbl);
            this.userinfoPnl.Controls.Add(this.usernameTxtBox);
            this.userinfoPnl.Controls.Add(this.usrnameLbl);
            this.userinfoPnl.Location = new System.Drawing.Point(225, 12);
            this.userinfoPnl.Name = "userinfoPnl";
            this.userinfoPnl.Size = new System.Drawing.Size(207, 300);
            this.userinfoPnl.TabIndex = 1;
            // 
            // gpgTxtBox
            // 
            this.gpgTxtBox.Location = new System.Drawing.Point(3, 191);
            this.gpgTxtBox.Name = "gpgTxtBox";
            this.gpgTxtBox.Size = new System.Drawing.Size(194, 20);
            this.gpgTxtBox.TabIndex = 9;
            this.gpgTxtBox.Text = "Add your key here";
            // 
            // gpgLbl
            // 
            this.gpgLbl.AutoSize = true;
            this.gpgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpgLbl.Location = new System.Drawing.Point(5, 170);
            this.gpgLbl.Name = "gpgLbl";
            this.gpgLbl.Size = new System.Drawing.Size(73, 18);
            this.gpgLbl.TabIndex = 8;
            this.gpgLbl.Text = "PGP Key:";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(3, 111);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(194, 20);
            this.passwordTxtBox.TabIndex = 7;
            this.passwordTxtBox.Text = "Add your pass here";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(3, 90);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(79, 18);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(3, 31);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(194, 20);
            this.usernameTxtBox.TabIndex = 5;
            this.usernameTxtBox.Text = "Add your username here";
            // 
            // settingsBtnsPnl
            // 
            this.settingsBtnsPnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.settingsBtnsPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.settingsBtnsPnl.Controls.Add(this.loadStngsBtn);
            this.settingsBtnsPnl.Controls.Add(this.saveStngsBtn);
            this.settingsBtnsPnl.Controls.Add(this.reloadStngsBtn);
            this.settingsBtnsPnl.Controls.Add(this.useRecommBtn);
            this.settingsBtnsPnl.Controls.Add(this.addUserBtn);
            this.settingsBtnsPnl.Controls.Add(this.removeUserBtn);
            this.settingsBtnsPnl.Controls.Add(this.wipeAllnRemoveBtn);
            this.settingsBtnsPnl.Location = new System.Drawing.Point(453, 12);
            this.settingsBtnsPnl.Name = "settingsBtnsPnl";
            this.settingsBtnsPnl.Size = new System.Drawing.Size(132, 300);
            this.settingsBtnsPnl.TabIndex = 6;
            // 
            // useRecommBtn
            // 
            this.useRecommBtn.Location = new System.Drawing.Point(3, 130);
            this.useRecommBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.useRecommBtn.Name = "useRecommBtn";
            this.useRecommBtn.Size = new System.Drawing.Size(120, 30);
            this.useRecommBtn.TabIndex = 8;
            this.useRecommBtn.Text = "Use Recommended";
            this.useRecommBtn.UseVisualStyleBackColor = true;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(3, 170);
            this.addUserBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(120, 30);
            this.addUserBtn.TabIndex = 9;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.Location = new System.Drawing.Point(3, 210);
            this.removeUserBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(120, 30);
            this.removeUserBtn.TabIndex = 10;
            this.removeUserBtn.Text = "Remove User";
            this.removeUserBtn.UseVisualStyleBackColor = true;
            // 
            // wipeAllnRemoveBtn
            // 
            this.wipeAllnRemoveBtn.Location = new System.Drawing.Point(3, 250);
            this.wipeAllnRemoveBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.wipeAllnRemoveBtn.Name = "wipeAllnRemoveBtn";
            this.wipeAllnRemoveBtn.Size = new System.Drawing.Size(120, 30);
            this.wipeAllnRemoveBtn.TabIndex = 11;
            this.wipeAllnRemoveBtn.Text = "Wipe Everything";
            this.wipeAllnRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // checkBoxLayoutPnl
            // 
            this.checkBoxLayoutPnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxLayoutPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.checkBoxLayoutPnl.Controls.Add(this.autoLoginCheck);
            this.checkBoxLayoutPnl.Controls.Add(this.doNotSaveCheck);
            this.checkBoxLayoutPnl.Controls.Add(this.wipeDataQuitCheck);
            this.checkBoxLayoutPnl.Controls.Add(this.resetSysDefsCheck);
            this.checkBoxLayoutPnl.Controls.Add(this.alwaysGPGCheck);
            this.checkBoxLayoutPnl.Controls.Add(this.sendRepEmailCheck);
            this.checkBoxLayoutPnl.Location = new System.Drawing.Point(12, 12);
            this.checkBoxLayoutPnl.Name = "checkBoxLayoutPnl";
            this.checkBoxLayoutPnl.Size = new System.Drawing.Size(192, 300);
            this.checkBoxLayoutPnl.TabIndex = 12;
            // 
            // autoLoginCheck
            // 
            this.autoLoginCheck.AutoSize = true;
            this.autoLoginCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLoginCheck.Location = new System.Drawing.Point(5, 25);
            this.autoLoginCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            this.autoLoginCheck.Name = "autoLoginCheck";
            this.autoLoginCheck.Size = new System.Drawing.Size(135, 19);
            this.autoLoginCheck.TabIndex = 1;
            this.autoLoginCheck.Text = "Log In Automatically";
            this.autoLoginCheck.UseVisualStyleBackColor = true;
            // 
            // doNotSaveCheck
            // 
            this.doNotSaveCheck.AutoSize = true;
            this.doNotSaveCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doNotSaveCheck.Location = new System.Drawing.Point(5, 69);
            this.doNotSaveCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            this.doNotSaveCheck.Name = "doNotSaveCheck";
            this.doNotSaveCheck.Size = new System.Drawing.Size(123, 19);
            this.doNotSaveCheck.TabIndex = 2;
            this.doNotSaveCheck.Text = "Do Not Save Data";
            this.doNotSaveCheck.UseVisualStyleBackColor = true;
            // 
            // wipeDataQuitCheck
            // 
            this.wipeDataQuitCheck.AutoSize = true;
            this.wipeDataQuitCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wipeDataQuitCheck.Location = new System.Drawing.Point(5, 113);
            this.wipeDataQuitCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            this.wipeDataQuitCheck.Name = "wipeDataQuitCheck";
            this.wipeDataQuitCheck.Size = new System.Drawing.Size(125, 19);
            this.wipeDataQuitCheck.TabIndex = 0;
            this.wipeDataQuitCheck.Text = "Wipe Data on Quit";
            this.wipeDataQuitCheck.UseVisualStyleBackColor = true;
            // 
            // resetSysDefsCheck
            // 
            this.resetSysDefsCheck.AutoSize = true;
            this.resetSysDefsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetSysDefsCheck.Location = new System.Drawing.Point(5, 157);
            this.resetSysDefsCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            this.resetSysDefsCheck.Name = "resetSysDefsCheck";
            this.resetSysDefsCheck.Size = new System.Drawing.Size(187, 19);
            this.resetSysDefsCheck.TabIndex = 3;
            this.resetSysDefsCheck.Text = "Reset To Sys Defaults on Quit";
            this.resetSysDefsCheck.UseVisualStyleBackColor = true;
            // 
            // alwaysGPGCheck
            // 
            this.alwaysGPGCheck.AutoSize = true;
            this.alwaysGPGCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alwaysGPGCheck.Location = new System.Drawing.Point(5, 201);
            this.alwaysGPGCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            this.alwaysGPGCheck.Name = "alwaysGPGCheck";
            this.alwaysGPGCheck.Size = new System.Drawing.Size(117, 19);
            this.alwaysGPGCheck.TabIndex = 4;
            this.alwaysGPGCheck.Text = "Always Use GPG";
            this.alwaysGPGCheck.UseVisualStyleBackColor = true;
            // 
            // sendRepEmailCheck
            // 
            this.sendRepEmailCheck.AutoSize = true;
            this.sendRepEmailCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendRepEmailCheck.Location = new System.Drawing.Point(5, 245);
            this.sendRepEmailCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            this.sendRepEmailCheck.Name = "sendRepEmailCheck";
            this.sendRepEmailCheck.Size = new System.Drawing.Size(149, 19);
            this.sendRepEmailCheck.TabIndex = 5;
            this.sendRepEmailCheck.Text = "Send Reports to Email";
            this.sendRepEmailCheck.UseVisualStyleBackColor = true;
            // 
            // emailPnl
            // 
            this.emailPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailPnl.Controls.Add(this.helpBtn);
            this.emailPnl.Controls.Add(this.setEmailBtn);
            this.emailPnl.Controls.Add(this.forcePGPEmailCheck);
            this.emailPnl.Controls.Add(this.emailAddConfTxtBox);
            this.emailPnl.Controls.Add(this.emailAddConfLbl);
            this.emailPnl.Controls.Add(this.emailAddTxtBox);
            this.emailPnl.Controls.Add(this.emailAddLbl);
            this.emailPnl.Cursor = System.Windows.Forms.Cursors.Default;
            this.emailPnl.Location = new System.Drawing.Point(12, 342);
            this.emailPnl.Name = "emailPnl";
            this.emailPnl.Size = new System.Drawing.Size(573, 168);
            this.emailPnl.TabIndex = 13;
            // 
            // emailAddLbl
            // 
            this.emailAddLbl.AutoSize = true;
            this.emailAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddLbl.Location = new System.Drawing.Point(3, 12);
            this.emailAddLbl.Name = "emailAddLbl";
            this.emailAddLbl.Size = new System.Drawing.Size(147, 18);
            this.emailAddLbl.TabIndex = 10;
            this.emailAddLbl.Text = "Your E-Mail Address:";
            // 
            // emailAddTxtBox
            // 
            this.emailAddTxtBox.Location = new System.Drawing.Point(6, 33);
            this.emailAddTxtBox.Name = "emailAddTxtBox";
            this.emailAddTxtBox.Size = new System.Drawing.Size(194, 20);
            this.emailAddTxtBox.TabIndex = 10;
            this.emailAddTxtBox.Text = "Add your addy here";
            // 
            // emailAddConfLbl
            // 
            this.emailAddConfLbl.AutoSize = true;
            this.emailAddConfLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddConfLbl.Location = new System.Drawing.Point(2, 92);
            this.emailAddConfLbl.Name = "emailAddConfLbl";
            this.emailAddConfLbl.Size = new System.Drawing.Size(65, 18);
            this.emailAddConfLbl.TabIndex = 11;
            this.emailAddConfLbl.Text = "Confirm:";
            // 
            // emailAddConfTxtBox
            // 
            this.emailAddConfTxtBox.Location = new System.Drawing.Point(3, 113);
            this.emailAddConfTxtBox.Name = "emailAddConfTxtBox";
            this.emailAddConfTxtBox.Size = new System.Drawing.Size(194, 20);
            this.emailAddConfTxtBox.TabIndex = 12;
            this.emailAddConfTxtBox.Text = "Add your addy here agian";
            // 
            // forcePGPEmailCheck
            // 
            this.forcePGPEmailCheck.AutoSize = true;
            this.forcePGPEmailCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcePGPEmailCheck.Location = new System.Drawing.Point(277, 72);
            this.forcePGPEmailCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            this.forcePGPEmailCheck.Name = "forcePGPEmailCheck";
            this.forcePGPEmailCheck.Size = new System.Drawing.Size(133, 19);
            this.forcePGPEmailCheck.TabIndex = 13;
            this.forcePGPEmailCheck.Text = "Force PGP in Email";
            this.forcePGPEmailCheck.UseVisualStyleBackColor = true;
            // 
            // setEmailBtn
            // 
            this.setEmailBtn.Location = new System.Drawing.Point(494, 24);
            this.setEmailBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.setEmailBtn.Name = "setEmailBtn";
            this.setEmailBtn.Size = new System.Drawing.Size(70, 29);
            this.setEmailBtn.TabIndex = 14;
            this.setEmailBtn.Text = "Set Email";
            this.setEmailBtn.UseVisualStyleBackColor = true;
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(494, 113);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(70, 30);
            this.helpBtn.TabIndex = 15;
            this.helpBtn.Text = "Help!";
            this.helpBtn.UseVisualStyleBackColor = true;
            // 
            // setUserinfoBtn
            // 
            this.setUserinfoBtn.Location = new System.Drawing.Point(114, 251);
            this.setUserinfoBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            this.setUserinfoBtn.Name = "setUserinfoBtn";
            this.setUserinfoBtn.Size = new System.Drawing.Size(83, 29);
            this.setUserinfoBtn.TabIndex = 15;
            this.setUserinfoBtn.Text = "Set User Info";
            this.setUserinfoBtn.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 522);
            this.ControlBox = false;
            this.Controls.Add(this.emailPnl);
            this.Controls.Add(this.settingsBtnsPnl);
            this.Controls.Add(this.userinfoPnl);
            this.Controls.Add(this.checkBoxLayoutPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.userinfoPnl.ResumeLayout(false);
            this.userinfoPnl.PerformLayout();
            this.settingsBtnsPnl.ResumeLayout(false);
            this.checkBoxLayoutPnl.ResumeLayout(false);
            this.checkBoxLayoutPnl.PerformLayout();
            this.emailPnl.ResumeLayout(false);
            this.emailPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label usrnameLbl;
        private System.Windows.Forms.Button reloadStngsBtn;
        private System.Windows.Forms.Button saveStngsBtn;
        private System.Windows.Forms.Button loadStngsBtn;
        private System.Windows.Forms.Panel userinfoPnl;
        private System.Windows.Forms.FlowLayoutPanel settingsBtnsPnl;
        private System.Windows.Forms.Button useRecommBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button removeUserBtn;
        private System.Windows.Forms.TextBox gpgTxtBox;
        private System.Windows.Forms.Label gpgLbl;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Button wipeAllnRemoveBtn;
        private System.Windows.Forms.FlowLayoutPanel checkBoxLayoutPnl;
        private System.Windows.Forms.CheckBox wipeDataQuitCheck;
        private System.Windows.Forms.CheckBox autoLoginCheck;
        private System.Windows.Forms.CheckBox doNotSaveCheck;
        private System.Windows.Forms.CheckBox resetSysDefsCheck;
        private System.Windows.Forms.CheckBox alwaysGPGCheck;
        private System.Windows.Forms.CheckBox sendRepEmailCheck;
        private System.Windows.Forms.Button setUserinfoBtn;
        private System.Windows.Forms.Panel emailPnl;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Button setEmailBtn;
        private System.Windows.Forms.CheckBox forcePGPEmailCheck;
        private System.Windows.Forms.TextBox emailAddConfTxtBox;
        private System.Windows.Forms.Label emailAddConfLbl;
        private System.Windows.Forms.TextBox emailAddTxtBox;
        private System.Windows.Forms.Label emailAddLbl;
    }
}