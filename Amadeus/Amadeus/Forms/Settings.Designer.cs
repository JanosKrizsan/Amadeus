using Amadeus.CustomControls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.Forms
{
    partial class Settings
    {
        private readonly ComponentResourceManager _res = new ComponentResourceManager(typeof(SysLanguage));

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
            var anchorForBtn = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            var defButtonPadding = new Padding(3, 10, 0, 0);
            var defButtonSize = new Size(120, 30);
            var defTextBoxSize = new Size(194, 20);
            var defCheckBoxPadding = new Padding(5, 25, 0, 0);

            passwordTxtBox = new BaseTextBox(_res, "passwordTxtBox", 7, new Point(3, 111), defTextBoxSize);
            usernameTxtBox = new BaseTextBox(_res, "usernameTxtBox", 5, new Point(3, 90), defTextBoxSize);
            emailAddConfTxtBox = new BaseTextBox(_res, "emailAddConfTxtBox", 12, new Point(3, 113), defTextBoxSize);
            emailAddTxtBox = new BaseTextBox(_res, "emailAddTxtBox", 10, new Point(6, 33), defTextBoxSize);
            gpgTxtBox = new BaseTextBox(_res, "gpgTxtBox", 9, new Point(3, 191), new Size(194, 20));
            usernameLbl = new BaseLabel(_res, "usernameLbl", 4, new Point(3, 10), new Size(81, 18), "Username", autoSize: true);
            gpgLbl = new BaseLabel(_res, "gpgLbl", 8, new Point(5, 170), new Size(73, 18), "PGP Key:", autoSize: true);
            passwordLbl = new BaseLabel(_res, "passwordLbl", 6, new Point(3, 90), new Size(79, 18), "Password:", autoSize: true);
            emailAddConfLbl = new BaseLabel(_res, "emailAddConfLbl", 11, new Point(2, 92), new Size(65, 18), "Confirm:", autoSize: true);
            emailAddLbl = new BaseLabel(_res, "emailAddLbl", 10, new Point(3, 12), new Size(147, 18), "Your E-Mail Address:", autoSize: true);
            helpBtn = new BaseButton(_res, "helpBtn", true, 15, new object[] { null, new Point(494, 113), defButtonPadding, new Size(70, 30), "Help!" });
            setEmailBtn = new BaseButton(_res, "setEmailBtn", true, 14, new object[] { null, new Point(494, 24), defButtonPadding, new Size(70, 29), "Set Email" });
            reloadStngsBtn = new BaseButton(_res, "reloadStngsBtn", true, 5, new object[] { null, new Point(3, 90), defButtonPadding, defButtonSize, "Reload Settings" });
            saveStngsBtn = new BaseButton(_res, "saveStngsBtn", true, 6, new object[] { null, new Point(3, 50), defButtonPadding, defButtonSize, "Save Settings" });
            loadStngsBtn = new BaseButton(_res, "loadStngsBtn", true, 7, new object[] { null, new Point(3, 10), defButtonPadding, defButtonSize, "Load Settings", null, anchorForBtn });
            setUserinfoBtn = new BaseButton(_res, "setUserinfoBtn", true, 15, new object[] { null, new Point(114, 251), defButtonPadding, new Size(83, 29), "Set User Info" });
            useRecommBtn = new BaseButton(_res, "useRecommBtn", true, 8, new object[] { null, new Point(3, 130), defButtonPadding, defButtonSize, "Use Recommended" });
            addUserBtn = new BaseButton(_res, "addUserBtn", true, 9, new object[] { null, new Point(3, 170), defButtonPadding, defButtonSize, "Add User" });
            removeUserBtn = new BaseButton(_res, "removeUserBtn", true, 10, new object[] { null, new Point(3, 210), defButtonPadding, defButtonSize, "Remove User" });
            wipeAllnRemoveBtn = new BaseButton(_res, "wipeAllnRemoveBtn", true, 11, new object[] { null, new Point(3, 250), defButtonPadding, defButtonSize, "Wipe Everything" });
            autoLoginCheck = new BaseCheckBox(_res, "autoLoginCheck", true, "Log In Automatically", new Point(5, 25), new Size(135, 19), margin: defCheckBoxPadding, tabIndex: 1);
            doNotSaveCheck = new BaseCheckBox(_res, "doNotSaveCheck", true, "Do Not Save Data", new Point(5, 69), new Size(123, 19), margin: defCheckBoxPadding, tabIndex: 2);
            wipeDataQuitCheck = new BaseCheckBox(_res, "wipeDataQuitCheck", true, "Wipe Data on Quit", new Point(5, 113), new Size(125, 19), margin: defCheckBoxPadding, tabIndex: 0);
            resetSysDefsCheck = new BaseCheckBox(_res, "resetSysDefsCheck", true, "Reset To Sys Defaults on Quit", new Point(5, 157), new Size(187, 19), margin: defCheckBoxPadding, tabIndex: 3);
            alwaysPGPCheck = new BaseCheckBox(_res, "alwaysPGPCheck", true, "Always Use PGP", new Point(5, 201), new Size(116, 19), margin: defCheckBoxPadding, tabIndex: 4);
            sendRepEmailCheck = new BaseCheckBox(_res, "sendRepEmailCheck", true, "Send Reports to Email", new Point(5, 245), new Size(149, 19), margin: defCheckBoxPadding, tabIndex: 5);
            forcePGPEmailCheck = new BaseCheckBox(_res, "forcePGPEmailCheck", true, "Force PGP in Email", new Point(277, 72), new Size(133, 19), margin: defCheckBoxPadding, tabIndex: 13);

            emailPnl = new BasePanel(_res, "emailPnl", new Control[] { helpBtn, setEmailBtn, forcePGPEmailCheck, emailAddConfTxtBox, emailAddConfLbl, emailAddTxtBox, emailAddLbl }, new Point(12, 342), new Size(573, 168), 13);
            userinfoPnl = new BasePanel(_res, "userinfoPnl", new Control[] { setUserinfoBtn, gpgTxtBox, gpgLbl, passwordTxtBox, passwordLbl, usernameTxtBox, usernameLbl }, new Point(255, 12), new Size(207, 300), 1);
            settingsBtnsPnl = new BaseFlowPanel(_res, new Control[] { loadStngsBtn, saveStngsBtn, reloadStngsBtn, useRecommBtn, addUserBtn, removeUserBtn, wipeAllnRemoveBtn }, new Point(453, 12), new Size(132, 300), "settingsBtnsPnl", 6, new object[] { BorderStyle.Fixed3D, null, AnchorStyles.Top });
            checkBoxLayoutPnl = new BaseFlowPanel(_res, new Control[] { autoLoginCheck, doNotSaveCheck, wipeDataQuitCheck, resetSysDefsCheck, alwaysPGPCheck, sendRepEmailCheck }, new Point(12, 12), new Size(192, 300), "checkBoxLayoutPnl", 12, new object[] { BorderStyle.Fixed3D, null, AnchorStyles.Top });

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

        #endregion
        private System.Windows.Forms.Label usernameLbl;
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