namespace Amadeus.Views
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
            this.menuItemsPanel = new System.Windows.Forms.Panel();
            this.vpnWinBtn = new System.Windows.Forms.Button();
            this.ipWinBtn = new System.Windows.Forms.Button();
            this.rdpWinBtn = new System.Windows.Forms.Button();
            this.proxyWinBtn = new System.Windows.Forms.Button();
            this.optionsWinBtn = new System.Windows.Forms.Button();
            this.logoutWinBtn = new System.Windows.Forms.Button();
            this.macWinBtn = new System.Windows.Forms.Button();
            this.statusInfo = new System.Windows.Forms.RichTextBox();
            this.menuItemsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItemsPanel
            // 
            this.menuItemsPanel.Controls.Add(this.macWinBtn);
            this.menuItemsPanel.Controls.Add(this.logoutWinBtn);
            this.menuItemsPanel.Controls.Add(this.optionsWinBtn);
            this.menuItemsPanel.Controls.Add(this.proxyWinBtn);
            this.menuItemsPanel.Controls.Add(this.rdpWinBtn);
            this.menuItemsPanel.Controls.Add(this.ipWinBtn);
            this.menuItemsPanel.Controls.Add(this.vpnWinBtn);
            this.menuItemsPanel.Location = new System.Drawing.Point(12, 180);
            this.menuItemsPanel.Name = "menuItemsPanel";
            this.menuItemsPanel.Size = new System.Drawing.Size(226, 158);
            this.menuItemsPanel.TabIndex = 0;
            // 
            // vpnWinBtn
            // 
            this.vpnWinBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.vpnWinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vpnWinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vpnWinBtn.Location = new System.Drawing.Point(0, 0);
            this.vpnWinBtn.Name = "vpnWinBtn";
            this.vpnWinBtn.Size = new System.Drawing.Size(75, 23);
            this.vpnWinBtn.TabIndex = 0;
            this.vpnWinBtn.Text = "VPN";
            this.vpnWinBtn.UseVisualStyleBackColor = false;
            // 
            // ipWinBtn
            // 
            this.ipWinBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ipWinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ipWinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipWinBtn.Location = new System.Drawing.Point(151, 3);
            this.ipWinBtn.Name = "ipWinBtn";
            this.ipWinBtn.Size = new System.Drawing.Size(75, 23);
            this.ipWinBtn.TabIndex = 1;
            this.ipWinBtn.Text = "IP";
            this.ipWinBtn.UseVisualStyleBackColor = false;
            // 
            // rdpWinBtn
            // 
            this.rdpWinBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rdpWinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdpWinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdpWinBtn.Location = new System.Drawing.Point(0, 32);
            this.rdpWinBtn.Name = "rdpWinBtn";
            this.rdpWinBtn.Size = new System.Drawing.Size(75, 23);
            this.rdpWinBtn.TabIndex = 2;
            this.rdpWinBtn.Text = "RDP";
            this.rdpWinBtn.UseVisualStyleBackColor = false;
            // 
            // proxyWinBtn
            // 
            this.proxyWinBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.proxyWinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.proxyWinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyWinBtn.Location = new System.Drawing.Point(0, 61);
            this.proxyWinBtn.Name = "proxyWinBtn";
            this.proxyWinBtn.Size = new System.Drawing.Size(75, 23);
            this.proxyWinBtn.TabIndex = 3;
            this.proxyWinBtn.Text = "PROXY";
            this.proxyWinBtn.UseVisualStyleBackColor = false;
            // 
            // optionsWinBtn
            // 
            this.optionsWinBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.optionsWinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.optionsWinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsWinBtn.Location = new System.Drawing.Point(0, 135);
            this.optionsWinBtn.Name = "optionsWinBtn";
            this.optionsWinBtn.Size = new System.Drawing.Size(75, 23);
            this.optionsWinBtn.TabIndex = 4;
            this.optionsWinBtn.Text = "Options";
            this.optionsWinBtn.UseVisualStyleBackColor = false;
            // 
            // logoutWinBtn
            // 
            this.logoutWinBtn.BackColor = System.Drawing.Color.Violet;
            this.logoutWinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutWinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutWinBtn.Location = new System.Drawing.Point(151, 135);
            this.logoutWinBtn.Name = "logoutWinBtn";
            this.logoutWinBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutWinBtn.TabIndex = 5;
            this.logoutWinBtn.Text = "LogOut";
            this.logoutWinBtn.UseVisualStyleBackColor = false;
            // 
            // macWinBtn
            // 
            this.macWinBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.macWinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.macWinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macWinBtn.Location = new System.Drawing.Point(151, 32);
            this.macWinBtn.Name = "macWinBtn";
            this.macWinBtn.Size = new System.Drawing.Size(75, 23);
            this.macWinBtn.TabIndex = 6;
            this.macWinBtn.Text = "MAC";
            this.macWinBtn.UseVisualStyleBackColor = false;
            // 
            // statusInfo
            // 
            this.statusInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusInfo.ForeColor = System.Drawing.Color.GreenYellow;
            this.statusInfo.Location = new System.Drawing.Point(12, 12);
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.statusInfo.Size = new System.Drawing.Size(226, 150);
            this.statusInfo.TabIndex = 1;
            this.statusInfo.Text = "";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.ControlBox = false;
            this.Controls.Add(this.statusInfo);
            this.Controls.Add(this.menuItemsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuItemsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuItemsPanel;
        private System.Windows.Forms.Button logoutWinBtn;
        private System.Windows.Forms.Button optionsWinBtn;
        private System.Windows.Forms.Button proxyWinBtn;
        private System.Windows.Forms.Button rdpWinBtn;
        private System.Windows.Forms.Button ipWinBtn;
        private System.Windows.Forms.Button vpnWinBtn;
        private System.Windows.Forms.Button macWinBtn;
        private System.Windows.Forms.RichTextBox statusInfo;
    }
}