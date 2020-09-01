namespace Amadeus.Forms
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
            usrnameLbl = new System.Windows.Forms.Label();
            reloadStngsBtn = new System.Windows.Forms.Button();
            saveStngsBtn = new System.Windows.Forms.Button();
            loadStngsBtn = new System.Windows.Forms.Button();
            userinfoPnl = new System.Windows.Forms.Panel();
            setUserinfoBtn = new System.Windows.Forms.Button();
            gpgTxtBox = new System.Windows.Forms.TextBox();
            gpgLbl = new System.Windows.Forms.Label();
            passwordTxtBox = new System.Windows.Forms.TextBox();
            passwordLbl = new System.Windows.Forms.Label();
            usernameTxtBox = new System.Windows.Forms.TextBox();
            settingsBtnsPnl = new System.Windows.Forms.FlowLayoutPanel();
            useRecommBtn = new System.Windows.Forms.Button();
            addUserBtn = new System.Windows.Forms.Button();
            removeUserBtn = new System.Windows.Forms.Button();
            wipeAllnRemoveBtn = new System.Windows.Forms.Button();
            checkBoxLayoutPnl = new System.Windows.Forms.FlowLayoutPanel();
            autoLoginCheck = new System.Windows.Forms.CheckBox();
            doNotSaveCheck = new System.Windows.Forms.CheckBox();
            wipeDataQuitCheck = new System.Windows.Forms.CheckBox();
            resetSysDefsCheck = new System.Windows.Forms.CheckBox();
            alwaysPGPCheck = new System.Windows.Forms.CheckBox();
            sendRepEmailCheck = new System.Windows.Forms.CheckBox();
            emailPnl = new System.Windows.Forms.Panel();
            helpBtn = new System.Windows.Forms.Button();
            setEmailBtn = new System.Windows.Forms.Button();
            forcePGPEmailCheck = new System.Windows.Forms.CheckBox();
            emailAddConfTxtBox = new System.Windows.Forms.TextBox();
            emailAddConfLbl = new System.Windows.Forms.Label();
            emailAddTxtBox = new System.Windows.Forms.TextBox();
            emailAddLbl = new System.Windows.Forms.Label();

            SuspendLayout();
            InitSettings();

        }

        private void InitSettings()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 522);
            ControlBox = false;
            Controls.Add(emailPnl);
            Controls.Add(settingsBtnsPnl);
            Controls.Add(userinfoPnl);
            Controls.Add(checkBoxLayoutPnl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Settings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Options";
            userinfoPnl.ResumeLayout(false);
            userinfoPnl.PerformLayout();
            settingsBtnsPnl.ResumeLayout(false);
            checkBoxLayoutPnl.ResumeLayout(false);
            checkBoxLayoutPnl.PerformLayout();
            emailPnl.ResumeLayout(false);
            emailPnl.PerformLayout();
            ResumeLayout(false);
        }

        private void InitemailAddLbl()
        {
            emailAddLbl.AutoSize = true;
            emailAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailAddLbl.Location = new System.Drawing.Point(3, 12);
            emailAddLbl.Name = "emailAddLbl";
            emailAddLbl.Size = new System.Drawing.Size(147, 18);
            emailAddLbl.TabIndex = 10;
            emailAddLbl.Text = "Your E-Mail Address:";
        }

        private void InitemailAddTxtBox()
        {
            emailAddTxtBox.Location = new System.Drawing.Point(6, 33);
            emailAddTxtBox.Name = "emailAddTxtBox";
            emailAddTxtBox.Size = new System.Drawing.Size(194, 20);
            emailAddTxtBox.TabIndex = 10;
        }

        private void InitemailAddConfLbl()
        {
            emailAddConfLbl.AutoSize = true;
            emailAddConfLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailAddConfLbl.Location = new System.Drawing.Point(2, 92);
            emailAddConfLbl.Name = "emailAddConfLbl";
            emailAddConfLbl.Size = new System.Drawing.Size(65, 18);
            emailAddConfLbl.TabIndex = 11;
            emailAddConfLbl.Text = "Confirm:";
        }

        private void InitemailAddConfTxtBox()
        {
            emailAddConfTxtBox.Location = new System.Drawing.Point(3, 113);
            emailAddConfTxtBox.Name = "emailAddConfTxtBox";
            emailAddConfTxtBox.Size = new System.Drawing.Size(194, 20);
            emailAddConfTxtBox.TabIndex = 12;
        }

        private void InitforcePGPEmailCheck()
        {
            forcePGPEmailCheck.AutoSize = true;
            forcePGPEmailCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            forcePGPEmailCheck.Location = new System.Drawing.Point(277, 72);
            forcePGPEmailCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            forcePGPEmailCheck.Name = "forcePGPEmailCheck";
            forcePGPEmailCheck.Size = new System.Drawing.Size(133, 19);
            forcePGPEmailCheck.TabIndex = 13;
            forcePGPEmailCheck.Text = "Force PGP in Email";
            forcePGPEmailCheck.UseVisualStyleBackColor = true;
        }

        private void InitsetEmailBtn()
        {
            setEmailBtn.Location = new System.Drawing.Point(494, 24);
            setEmailBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            setEmailBtn.Name = "setEmailBtn";
            setEmailBtn.Size = new System.Drawing.Size(70, 29);
            setEmailBtn.TabIndex = 14;
            setEmailBtn.Text = "Set Email";
            setEmailBtn.UseVisualStyleBackColor = true;
        }

        private void InithelpBtn()
        {
            helpBtn.Location = new System.Drawing.Point(494, 113);
            helpBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            helpBtn.Name = "helpBtn";
            helpBtn.Size = new System.Drawing.Size(70, 30);
            helpBtn.TabIndex = 15;
            helpBtn.Text = "Help!";
            helpBtn.UseVisualStyleBackColor = true;
        }

        private void InitemailPnl()
        {
            emailPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            emailPnl.Controls.Add(helpBtn);
            emailPnl.Controls.Add(setEmailBtn);
            emailPnl.Controls.Add(forcePGPEmailCheck);
            emailPnl.Controls.Add(emailAddConfTxtBox);
            emailPnl.Controls.Add(emailAddConfLbl);
            emailPnl.Controls.Add(emailAddTxtBox);
            emailPnl.Controls.Add(emailAddLbl);
            emailPnl.Cursor = System.Windows.Forms.Cursors.Default;
            emailPnl.Location = new System.Drawing.Point(12, 342);
            emailPnl.Name = "emailPnl";
            emailPnl.Size = new System.Drawing.Size(573, 168);
            emailPnl.TabIndex = 13;
        }

        private void InitsendRepEmailCheck()
        {
            sendRepEmailCheck.AutoSize = true;
            sendRepEmailCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sendRepEmailCheck.Location = new System.Drawing.Point(5, 245);
            sendRepEmailCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            sendRepEmailCheck.Name = "sendRepEmailCheck";
            sendRepEmailCheck.Size = new System.Drawing.Size(149, 19);
            sendRepEmailCheck.TabIndex = 5;
            sendRepEmailCheck.Text = "Send Reports to Email";
            sendRepEmailCheck.UseVisualStyleBackColor = true;
        }

        private void InitalwaysPGPCheck()
        {
            alwaysPGPCheck.AutoSize = true;
            alwaysPGPCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alwaysPGPCheck.Location = new System.Drawing.Point(5, 201);
            alwaysPGPCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            alwaysPGPCheck.Name = "alwaysPGPCheck";
            alwaysPGPCheck.Size = new System.Drawing.Size(116, 19);
            alwaysPGPCheck.TabIndex = 4;
            alwaysPGPCheck.Text = "Always Use PGP";
            alwaysPGPCheck.UseVisualStyleBackColor = true;
        }

        private void InitresetSysDefsCheck()
        {
            resetSysDefsCheck.AutoSize = true;
            resetSysDefsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resetSysDefsCheck.Location = new System.Drawing.Point(5, 157);
            resetSysDefsCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            resetSysDefsCheck.Name = "resetSysDefsCheck";
            resetSysDefsCheck.Size = new System.Drawing.Size(187, 19);
            resetSysDefsCheck.TabIndex = 3;
            resetSysDefsCheck.Text = "Reset To Sys Defaults on Quit";
            resetSysDefsCheck.UseVisualStyleBackColor = true;
        }

        private void InitwipeDataQuitCheck()
        {
            wipeDataQuitCheck.AutoSize = true;
            wipeDataQuitCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            wipeDataQuitCheck.Location = new System.Drawing.Point(5, 113);
            wipeDataQuitCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            wipeDataQuitCheck.Name = "wipeDataQuitCheck";
            wipeDataQuitCheck.Size = new System.Drawing.Size(125, 19);
            wipeDataQuitCheck.TabIndex = 0;
            wipeDataQuitCheck.Text = "Wipe Data on Quit";
            wipeDataQuitCheck.UseVisualStyleBackColor = true;
        }

        private void InitdoNotSaveCheck()
        {
            doNotSaveCheck.AutoSize = true;
            doNotSaveCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doNotSaveCheck.Location = new System.Drawing.Point(5, 69);
            doNotSaveCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            doNotSaveCheck.Name = "doNotSaveCheck";
            doNotSaveCheck.Size = new System.Drawing.Size(123, 19);
            doNotSaveCheck.TabIndex = 2;
            doNotSaveCheck.Text = "Do Not Save Data";
            doNotSaveCheck.UseVisualStyleBackColor = true;
        }

        private void InitautoLoginCheck()
        {
            autoLoginCheck.AutoSize = true;
            autoLoginCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autoLoginCheck.Location = new System.Drawing.Point(5, 25);
            autoLoginCheck.Margin = new System.Windows.Forms.Padding(5, 25, 0, 0);
            autoLoginCheck.Name = "autoLoginCheck";
            autoLoginCheck.Size = new System.Drawing.Size(135, 19);
            autoLoginCheck.TabIndex = 1;
            autoLoginCheck.Text = "Log In Automatically";
            autoLoginCheck.UseVisualStyleBackColor = true;
        }

        private void InitcheckBoxLayoutPnl()
        {
            checkBoxLayoutPnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            checkBoxLayoutPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            checkBoxLayoutPnl.Controls.Add(autoLoginCheck);
            checkBoxLayoutPnl.Controls.Add(doNotSaveCheck);
            checkBoxLayoutPnl.Controls.Add(wipeDataQuitCheck);
            checkBoxLayoutPnl.Controls.Add(resetSysDefsCheck);
            checkBoxLayoutPnl.Controls.Add(alwaysPGPCheck);
            checkBoxLayoutPnl.Controls.Add(sendRepEmailCheck);
            checkBoxLayoutPnl.Location = new System.Drawing.Point(12, 12);
            checkBoxLayoutPnl.Name = "checkBoxLayoutPnl";
            checkBoxLayoutPnl.Size = new System.Drawing.Size(192, 300);
            checkBoxLayoutPnl.TabIndex = 12;
        }

        private void InitwipeAllnRemoveBtn()
        {
            wipeAllnRemoveBtn.Location = new System.Drawing.Point(3, 250);
            wipeAllnRemoveBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            wipeAllnRemoveBtn.Name = "wipeAllnRemoveBtn";
            wipeAllnRemoveBtn.Size = new System.Drawing.Size(120, 30);
            wipeAllnRemoveBtn.TabIndex = 11;
            wipeAllnRemoveBtn.Text = "Wipe Everything";
            wipeAllnRemoveBtn.UseVisualStyleBackColor = true;
        }

        private void InitremoveUserBtn()
        {
            removeUserBtn.Location = new System.Drawing.Point(3, 210);
            removeUserBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            removeUserBtn.Name = "removeUserBtn";
            removeUserBtn.Size = new System.Drawing.Size(120, 30);
            removeUserBtn.TabIndex = 10;
            removeUserBtn.Text = "Remove User";
            removeUserBtn.UseVisualStyleBackColor = true;
        }

        private void InitaddUserBtn()
        {
            addUserBtn.Location = new System.Drawing.Point(3, 170);
            addUserBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new System.Drawing.Size(120, 30);
            addUserBtn.TabIndex = 9;
            addUserBtn.Text = "Add User";
            addUserBtn.UseVisualStyleBackColor = true;
        }

        private void InituseRecommBtn()
        {
            useRecommBtn.Location = new System.Drawing.Point(3, 130);
            useRecommBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            useRecommBtn.Name = "useRecommBtn";
            useRecommBtn.Size = new System.Drawing.Size(120, 30);
            useRecommBtn.TabIndex = 8;
            useRecommBtn.Text = "Use Recommended";
            useRecommBtn.UseVisualStyleBackColor = true;
        }

        private void InitsettingsBtnsPnl()
        {
            settingsBtnsPnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            settingsBtnsPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            settingsBtnsPnl.Controls.Add(loadStngsBtn);
            settingsBtnsPnl.Controls.Add(saveStngsBtn);
            settingsBtnsPnl.Controls.Add(reloadStngsBtn);
            settingsBtnsPnl.Controls.Add(useRecommBtn);
            settingsBtnsPnl.Controls.Add(addUserBtn);
            settingsBtnsPnl.Controls.Add(removeUserBtn);
            settingsBtnsPnl.Controls.Add(wipeAllnRemoveBtn);
            settingsBtnsPnl.Location = new System.Drawing.Point(453, 12);
            settingsBtnsPnl.Name = "settingsBtnsPnl";
            settingsBtnsPnl.Size = new System.Drawing.Size(132, 300);
            settingsBtnsPnl.TabIndex = 6;
        }

        private void InitusernameTxtBox()
        {
            usernameTxtBox.Location = new System.Drawing.Point(3, 31);
            usernameTxtBox.Name = "usernameTxtBox";
            usernameTxtBox.Size = new System.Drawing.Size(194, 20);
            usernameTxtBox.TabIndex = 5;
        }

        private void InitpasswordLbl()
        {
            passwordLbl.AutoSize = true;
            passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLbl.Location = new System.Drawing.Point(3, 90);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new System.Drawing.Size(79, 18);
            passwordLbl.TabIndex = 6;
            passwordLbl.Text = "Password:";
        }

        private void InitpasswordTxtBox()
        {
            passwordTxtBox.Location = new System.Drawing.Point(3, 111);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new System.Drawing.Size(194, 20);
            passwordTxtBox.TabIndex = 7;
        }

        private void InitgpgLbl()
        {
            gpgLbl.AutoSize = true;
            gpgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gpgLbl.Location = new System.Drawing.Point(5, 170);
            gpgLbl.Name = "gpgLbl";
            gpgLbl.Size = new System.Drawing.Size(73, 18);
            gpgLbl.TabIndex = 8;
            gpgLbl.Text = "PGP Key:";
        }

        private void InitgpgTxtBox()
        {
            gpgTxtBox.Location = new System.Drawing.Point(3, 191);
            gpgTxtBox.Name = "gpgTxtBox";
            gpgTxtBox.Size = new System.Drawing.Size(194, 20);
            gpgTxtBox.TabIndex = 9;
        }

        private void InitsetUserinfoBtn()
        {
            setUserinfoBtn.Location = new System.Drawing.Point(114, 251);
            setUserinfoBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            setUserinfoBtn.Name = "setUserinfoBtn";
            setUserinfoBtn.Size = new System.Drawing.Size(83, 29);
            setUserinfoBtn.TabIndex = 15;
            setUserinfoBtn.Text = "Set User Info";
            setUserinfoBtn.UseVisualStyleBackColor = true;
        }

        private void InituserinfoPnl()
        {
            userinfoPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            userinfoPnl.Controls.Add(setUserinfoBtn);
            userinfoPnl.Controls.Add(gpgTxtBox);
            userinfoPnl.Controls.Add(gpgLbl);
            userinfoPnl.Controls.Add(passwordTxtBox);
            userinfoPnl.Controls.Add(passwordLbl);
            userinfoPnl.Controls.Add(usernameTxtBox);
            userinfoPnl.Controls.Add(usrnameLbl);
            userinfoPnl.Location = new System.Drawing.Point(225, 12);
            userinfoPnl.Name = "userinfoPnl";
            userinfoPnl.Size = new System.Drawing.Size(207, 300);
            userinfoPnl.TabIndex = 1;
        }

        private void InitloadStngsBtn()
        {
            loadStngsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
           | System.Windows.Forms.AnchorStyles.Right)));
            loadStngsBtn.Location = new System.Drawing.Point(3, 10);
            loadStngsBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            loadStngsBtn.Name = "loadStngsBtn";
            loadStngsBtn.Size = new System.Drawing.Size(120, 30);
            loadStngsBtn.TabIndex = 7;
            loadStngsBtn.Text = "Load Settings";
            loadStngsBtn.UseVisualStyleBackColor = true;
        }

        private void InitsaveStngsBtn()
        {
            saveStngsBtn.Location = new System.Drawing.Point(3, 50);
            saveStngsBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            saveStngsBtn.Name = "saveStngsBtn";
            saveStngsBtn.Size = new System.Drawing.Size(120, 30);
            saveStngsBtn.TabIndex = 6;
            saveStngsBtn.Text = "Save Settings";
            saveStngsBtn.UseVisualStyleBackColor = true;
        }

        private void InitreloadStngsBtn()
        {
            reloadStngsBtn.Location = new System.Drawing.Point(3, 90);
            reloadStngsBtn.Margin = new System.Windows.Forms.Padding(3, 10, 0, 0);
            reloadStngsBtn.Name = "reloadStngsBtn";
            reloadStngsBtn.Size = new System.Drawing.Size(120, 30);
            reloadStngsBtn.TabIndex = 5;
            reloadStngsBtn.Text = "Reload Settings";
            reloadStngsBtn.UseVisualStyleBackColor = true;
        }

        private void InitusrnameLbl()
        {
            usrnameLbl.AutoSize = true;
            usrnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usrnameLbl.Location = new System.Drawing.Point(3, 10);
            usrnameLbl.Name = "usrnameLbl";
            usrnameLbl.Size = new System.Drawing.Size(81, 18);
            usrnameLbl.TabIndex = 4;
            usrnameLbl.Text = "Username:";
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
        private System.Windows.Forms.CheckBox alwaysPGPCheck;
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