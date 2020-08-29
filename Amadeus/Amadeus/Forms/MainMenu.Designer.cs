namespace Amadeus.Forms
{
    partial class MainMenu
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
            mainMenuSelectPanel = new System.Windows.Forms.FlowLayoutPanel();
            mainMenuBtn = new System.Windows.Forms.Button();
            settingsBtn = new System.Windows.Forms.Button();
            proxyBtn = new System.Windows.Forms.Button();
            vpnBtn = new System.Windows.Forms.Button();
            rdpBtn = new System.Windows.Forms.Button();
            ipBtn = new System.Windows.Forms.Button();
            macBtn = new System.Windows.Forms.Button();
            syslangBtn = new System.Windows.Forms.Button();
            logoutBtn = new System.Windows.Forms.Button();
            quitBtn = new System.Windows.Forms.Button();
            viewPanel = new System.Windows.Forms.Panel();
            mainMenuSelectPanel.SuspendLayout();

            SuspendLayout();
            InitmainMenuSelectPanel();
            InitmainMenuBtn();
            InitsettingsBtn();
            InitproxyBtn();
            InitvpnBtn();
            InitrdpBtn();
            InitipBtn();
            InitmacBtn();
            InitsyslangBtn();
            InitlogoutBtn();
            InitquitBtn();
            InitviewPanel();
            InitSelectionScreen();

        }

        private void InitSelectionScreen()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 561);
            ControlBox = false;
            Controls.Add(viewPanel);
            Controls.Add(mainMenuSelectPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "SelectionScreen";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SelectionScreen";
            mainMenuSelectPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void InitviewPanel()
        {
            viewPanel.BackColor = System.Drawing.Color.Gainsboro;
            viewPanel.Location = new System.Drawing.Point(153, 0);
            viewPanel.Name = "viewPanel";
            viewPanel.Size = new System.Drawing.Size(632, 561);
            viewPanel.TabIndex = 1;
        }

        private void InitquitBtn()
        {
            quitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            quitBtn.Location = new System.Drawing.Point(0, 530);
            quitBtn.Margin = new System.Windows.Forms.Padding(0);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new System.Drawing.Size(150, 30);
            quitBtn.TabIndex = 9;
            quitBtn.Text = "Quit";
            quitBtn.UseVisualStyleBackColor = true;
        }

        private void InitlogoutBtn()
        {
            logoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            logoutBtn.Location = new System.Drawing.Point(0, 500);
            logoutBtn.Margin = new System.Windows.Forms.Padding(0, 60, 0, 0);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new System.Drawing.Size(150, 30);
            logoutBtn.TabIndex = 8;
            logoutBtn.Text = "Log Out";
            logoutBtn.UseVisualStyleBackColor = true;
        }

        private void InitsyslangBtn()
        {
            syslangBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            syslangBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            syslangBtn.Location = new System.Drawing.Point(0, 410);
            syslangBtn.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            syslangBtn.Name = "syslangBtn";
            syslangBtn.Size = new System.Drawing.Size(150, 30);
            syslangBtn.TabIndex = 7;
            syslangBtn.Text = "System Language";
            syslangBtn.UseVisualStyleBackColor = true;
        }

        private void InitmacBtn()
        {
            macBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            macBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            macBtn.Location = new System.Drawing.Point(0, 355);
            macBtn.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            macBtn.Name = "macBtn";
            macBtn.Size = new System.Drawing.Size(150, 30);
            macBtn.TabIndex = 6;
            macBtn.Text = "MAC Address";
            macBtn.UseVisualStyleBackColor = true;
        }

        private void InitipBtn()
        {
            ipBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ipBtn.Location = new System.Drawing.Point(0, 300);
            ipBtn.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            ipBtn.Name = "ipBtn";
            ipBtn.Size = new System.Drawing.Size(150, 30);
            ipBtn.TabIndex = 5;
            ipBtn.Text = "IP Address";
            ipBtn.UseVisualStyleBackColor = true;
        }

        private void InitrdpBtn()
        {
            rdpBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            rdpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rdpBtn.Location = new System.Drawing.Point(0, 245);
            rdpBtn.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            rdpBtn.Name = "rdpBtn";
            rdpBtn.Size = new System.Drawing.Size(150, 30);
            rdpBtn.TabIndex = 4;
            rdpBtn.Text = "RDP";
            rdpBtn.UseVisualStyleBackColor = true;
        }

        private void InitvpnBtn()
        {
            vpnBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            vpnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            vpnBtn.Location = new System.Drawing.Point(0, 190);
            vpnBtn.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            vpnBtn.Name = "vpnBtn";
            vpnBtn.Size = new System.Drawing.Size(150, 30);
            vpnBtn.TabIndex = 3;
            vpnBtn.Text = "VPN";
            vpnBtn.UseVisualStyleBackColor = true;
        }

        private void InitproxyBtn()
        {
            proxyBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            proxyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            proxyBtn.Location = new System.Drawing.Point(0, 135);
            proxyBtn.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            proxyBtn.Name = "proxyBtn";
            proxyBtn.Size = new System.Drawing.Size(150, 30);
            proxyBtn.TabIndex = 2;
            proxyBtn.Text = "Proxy";
            proxyBtn.UseVisualStyleBackColor = true;
        }

        private void InitsettingsBtn()
        {
            settingsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            settingsBtn.Location = new System.Drawing.Point(0, 80);
            settingsBtn.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new System.Drawing.Size(150, 30);
            settingsBtn.TabIndex = 1;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = true;
        }

        private void InitmainMenuBtn()
        {
            mainMenuBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            mainMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mainMenuBtn.Location = new System.Drawing.Point(0, 25);
            mainMenuBtn.Margin = new System.Windows.Forms.Padding(0, 25, 0, 0);
            mainMenuBtn.Name = "mainMenuBtn";
            mainMenuBtn.Size = new System.Drawing.Size(150, 30);
            mainMenuBtn.TabIndex = 0;
            mainMenuBtn.Text = "Main Menu";
            mainMenuBtn.UseVisualStyleBackColor = true;
        }

        private void InitmainMenuSelectPanel()
        {
            mainMenuSelectPanel.Controls.Add(mainMenuBtn);
            mainMenuSelectPanel.Controls.Add(settingsBtn);
            mainMenuSelectPanel.Controls.Add(proxyBtn);
            mainMenuSelectPanel.Controls.Add(vpnBtn);
            mainMenuSelectPanel.Controls.Add(rdpBtn);
            mainMenuSelectPanel.Controls.Add(ipBtn);
            mainMenuSelectPanel.Controls.Add(macBtn);
            mainMenuSelectPanel.Controls.Add(syslangBtn);
            mainMenuSelectPanel.Controls.Add(logoutBtn);
            mainMenuSelectPanel.Controls.Add(quitBtn);
            mainMenuSelectPanel.Dock = System.Windows.Forms.DockStyle.Left;
            mainMenuSelectPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            mainMenuSelectPanel.Location = new System.Drawing.Point(0, 0);
            mainMenuSelectPanel.Name = "mainMenuSelectPanel";
            mainMenuSelectPanel.Size = new System.Drawing.Size(150, 561);
            mainMenuSelectPanel.TabIndex = 0;
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainMenuSelectPanel;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button proxyBtn;
        private System.Windows.Forms.Button vpnBtn;
        private System.Windows.Forms.Button rdpBtn;
        private System.Windows.Forms.Button ipBtn;
        private System.Windows.Forms.Button macBtn;
        private System.Windows.Forms.Button syslangBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Panel viewPanel;
    }
}