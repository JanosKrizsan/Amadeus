using Amadeus.CustomControls;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus
{
    partial class LoginWin
    {
        private readonly ComponentResourceManager _res = new ComponentResourceManager(typeof(LoginWin));
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

        #region Controller Initialization

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
        {
            #region Controls
            loginButton = new BaseButton(_res, "loginButton", backColor: Color.YellowGreen);
            registerButton = new BaseButton(_res, "registerButton", backColor: Color.DarkTurquoise);
            quitButton = new BaseButton(_res, "quitButton", backColor: Color.Violet);
            saveUserInfoChckBox = new BaseCheckBox(_res, "saveUserInfoChkBox", visStyleBackColor: true, text: "Save User Info", alignText: ContentAlignment.MiddleCenter, alignBox: ContentAlignment.MiddleLeft);
            usersSavedBox = new BaseComboBox(_res, "usersSavedBox");
            passwordTxtBox = new BaseTextBox(_res, "passwordTxtBox");
            usernameTxtBox = new BaseTextBox(_res, "usernameTxtBox");
            #endregion

            #region Panels
            loginBottomPanel = new BasePanel(_res, "loginBottomPanel", controls: new Control[] { loginButton, quitButton, registerButton });
            loginTopPanel = new BasePanel(_res, "loginTopPanel", controls: new Control[] { saveUserInfoChckBox, passwordTxtBox, usernameTxtBox, usersSavedBox });
            #endregion

            InitLoginWin();
        }

        private void InitLoginWin()
        {
            SuspendLayout();
            AcceptButton = loginButton;
            _res.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            CancelButton = quitButton;
            ControlBox = false;
            Controls.Add(loginTopPanel);
            Controls.Add(loginBottomPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "LoginWin";
            ShowIcon = false;
            loginBottomPanel.ResumeLayout(false);
            loginTopPanel.ResumeLayout(false);
            loginTopPanel.PerformLayout();
            ResumeLayout(true);
        }

        #endregion

        private System.Windows.Forms.CheckBox saveUserInfoChckBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ComboBox usersSavedBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Panel loginBottomPanel;
        private System.Windows.Forms.Panel loginTopPanel;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
    }
}

