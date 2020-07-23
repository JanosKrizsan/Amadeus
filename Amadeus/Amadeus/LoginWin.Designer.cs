using Amadeus.Presenters;
using System.Windows.Forms;

namespace Amadeus
{
    partial class LoginWin
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
        void InitializeComponent()
        {

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWin));
            this.stayLoggedInChck = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.usersSavedBox = new System.Windows.Forms.ComboBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.loginBottomPanel = new System.Windows.Forms.Panel();
            this.loginTopPanel = new System.Windows.Forms.Panel();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.loginBottomPanel.SuspendLayout();
            this.loginTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stayLoggedInChck
            // 
            resources.ApplyResources(this.stayLoggedInChck, "stayLoggedInChck");
            this.stayLoggedInChck.Cursor = System.Windows.Forms.Cursors.Default;
            this.stayLoggedInChck.Name = "stayLoggedInChck";
            this.stayLoggedInChck.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.YellowGreen;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.registerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.registerButton, "registerButton");
            this.registerButton.Name = "registerButton";
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // usersSavedBox
            // 
            this.usersSavedBox.FormattingEnabled = true;
            resources.ApplyResources(this.usersSavedBox, "usersSavedBox");
            this.usersSavedBox.Name = "usersSavedBox";
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Violet;
            this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.quitButton, "quitButton");
            this.quitButton.Name = "quitButton";
            this.quitButton.UseVisualStyleBackColor = false;
            // 
            // loginBottomPanel
            // 
            this.loginBottomPanel.Controls.Add(this.loginButton);
            this.loginBottomPanel.Controls.Add(this.quitButton);
            this.loginBottomPanel.Controls.Add(this.registerButton);
            resources.ApplyResources(this.loginBottomPanel, "loginBottomPanel");
            this.loginBottomPanel.Name = "loginBottomPanel";
            // 
            // loginTopPanel
            // 
            this.loginTopPanel.Controls.Add(this.passwordTxtBox);
            this.loginTopPanel.Controls.Add(this.usernameTxtBox);
            this.loginTopPanel.Controls.Add(this.stayLoggedInChck);
            this.loginTopPanel.Controls.Add(this.usersSavedBox);
            resources.ApplyResources(this.loginTopPanel, "loginTopPanel");
            this.loginTopPanel.Name = "loginTopPanel";
            // 
            // passwordTxtBox
            // 
            resources.ApplyResources(this.passwordTxtBox, "passwordTxtBox");
            this.passwordTxtBox.Name = "passwordTxtBox";
            // 
            // usernameTxtBox
            // 
            resources.ApplyResources(this.usernameTxtBox, "usernameTxtBox");
            this.usernameTxtBox.Name = "usernameTxtBox";
            // 
            // LoginWin
            // 
            this.AcceptButton = this.loginButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.quitButton;
            this.ControlBox = false;
            this.Controls.Add(this.loginTopPanel);
            this.Controls.Add(this.loginBottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginWin";
            this.ShowIcon = false;
            this.loginBottomPanel.ResumeLayout(false);
            this.loginTopPanel.ResumeLayout(false);
            this.loginTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox stayLoggedInChck;
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

