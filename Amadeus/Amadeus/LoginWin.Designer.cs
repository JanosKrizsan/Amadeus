using Amadeus.CustomControls;
using System.ComponentModel;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using ContAlign = System.Drawing.ContentAlignment;

namespace Amadeus
{
    partial class LoginWin
    {
        private readonly ComponentResourceManager Resources = new ComponentResourceManager(typeof(LoginWin));
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
        void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager res = new System.ComponentModel.ComponentResourceManager(typeof(LoginWin));
            loginButton = new BaseButton(res, Color.YellowGreen, DialogResult.Cancel, 0, "loginButton", false);
            registerButton = new BaseButton(res, Color.DarkTurquoise, DialogResult.Cancel, 0, "registerButton", false);
            quitButton = new BaseButton(res, Color.Violet, DialogResult.Cancel, 0, "quitButton", false);
            saveUserInfoChckBox = new BaseCheckBox(res, "saveUserInfoChkBox", true, "Save User Info", ContAlign.MiddleCenter, ContAlign.MiddleLeft);
            usersSavedBox = new BaseComboBox(res, "usersSavedBox");
            passwordTxtBox = new BaseTextBox(res, "passwordTxtBox");
            usernameTxtBox = new BaseTextBox(res, "usernameTxtBox");

            loginBottomPanel = new BasePanel(res, "loginBottomPanel", new[] { loginButton, quitButton, registerButton });
            loginTopPanel = new BasePanel(res, "loginTopPanel", new Control[] { saveUserInfoChckBox, passwordTxtBox, usernameTxtBox, usersSavedBox });

            loginBottomPanel.SuspendLayout();
            loginTopPanel.SuspendLayout();
            SuspendLayout();

            InitLoginWin(Resources);
        }

        private void InitLoginWin(System.ComponentModel.ComponentResourceManager resources)
        {
            AcceptButton = loginButton;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
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
            ResumeLayout(false);
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

