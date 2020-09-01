namespace Amadeus.Forms
{
    partial class Proxy
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
            addNewProxyPnl = new System.Windows.Forms.FlowLayoutPanel();
            ipAddyLbl = new System.Windows.Forms.Label();
            ipAddyTxtBox = new System.Windows.Forms.TextBox();
            portLbl = new System.Windows.Forms.Label();
            portTxtBox = new System.Windows.Forms.TextBox();
            uNameLbl = new System.Windows.Forms.Label();
            uNameTxtBox = new System.Windows.Forms.TextBox();
            passLbl = new System.Windows.Forms.Label();
            passTextBox = new System.Windows.Forms.TextBox();
            authReqChckBox = new System.Windows.Forms.CheckBox();
            saveProxyBtn = new System.Windows.Forms.Button();
            saveNConnectProxyBtn = new System.Windows.Forms.Button();
            proxyHelpBtn = new System.Windows.Forms.Button();
            savedProxiesPnl = new System.Windows.Forms.FlowLayoutPanel();
            savedProxiesLbl = new System.Windows.Forms.Label();
            savedProxiesCombBox = new System.Windows.Forms.ComboBox();
            proxyInfoLbl = new System.Windows.Forms.Label();
            proxyInfoTxtBox = new System.Windows.Forms.RichTextBox();
            connectToSavedBtn = new System.Windows.Forms.Button();
            editSavedBtn = new System.Windows.Forms.Button();
            deleteSavedBtn = new System.Windows.Forms.Button();
            importProxiesPnl = new System.Windows.Forms.FlowLayoutPanel();
            importProxiesLbl = new System.Windows.Forms.Label();
            selectTextFileBtn = new System.Windows.Forms.Button();
            helpImportBtn = new System.Windows.Forms.Button();

            SuspendLayout();
            InitProxy();

        }

        private void InitProxy()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 522);
            ControlBox = false;
            Controls.Add(importProxiesPnl);
            Controls.Add(savedProxiesPnl);
            Controls.Add(addNewProxyPnl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Proxy";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "RDP";
            addNewProxyPnl.ResumeLayout(false);
            addNewProxyPnl.PerformLayout();
            savedProxiesPnl.ResumeLayout(false);
            savedProxiesPnl.PerformLayout();
            importProxiesPnl.ResumeLayout(false);
            importProxiesPnl.PerformLayout();
            ResumeLayout(false);
        }

        private void InithelpImportBtn()
        {
            helpImportBtn.Location = new System.Drawing.Point(30, 119);
            helpImportBtn.Margin = new System.Windows.Forms.Padding(30, 15, 30, 3);
            helpImportBtn.Name = "helpImportBtn";
            helpImportBtn.Size = new System.Drawing.Size(80, 23);
            helpImportBtn.TabIndex = 2;
            helpImportBtn.Text = "Help!";
            helpImportBtn.UseVisualStyleBackColor = true;
        }

        private void InitselectTextFileBtn()
        {
            selectTextFileBtn.Location = new System.Drawing.Point(20, 78);
            selectTextFileBtn.Margin = new System.Windows.Forms.Padding(20, 40, 20, 3);
            selectTextFileBtn.Name = "selectTextFileBtn";
            selectTextFileBtn.Size = new System.Drawing.Size(100, 23);
            selectTextFileBtn.TabIndex = 0;
            selectTextFileBtn.Text = "Select Text File";
            selectTextFileBtn.UseVisualStyleBackColor = true;
        }

        private void InitimportProxiesLbl()
        {
            importProxiesLbl.AutoSize = true;
            importProxiesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            importProxiesLbl.Location = new System.Drawing.Point(18, 20);
            importProxiesLbl.Margin = new System.Windows.Forms.Padding(18, 20, 0, 0);
            importProxiesLbl.Name = "importProxiesLbl";
            importProxiesLbl.Size = new System.Drawing.Size(104, 18);
            importProxiesLbl.TabIndex = 1;
            importProxiesLbl.Text = "Import Proxies";
        }

        private void InitimportProxiesPnl()
        {
            importProxiesPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            importProxiesPnl.Controls.Add(importProxiesLbl);
            importProxiesPnl.Controls.Add(selectTextFileBtn);
            importProxiesPnl.Controls.Add(helpImportBtn);
            importProxiesPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            importProxiesPnl.Location = new System.Drawing.Point(12, 12);
            importProxiesPnl.Name = "importProxiesPnl";
            importProxiesPnl.Size = new System.Drawing.Size(140, 498);
            importProxiesPnl.TabIndex = 1;
        }

        private void InitdeleteSavedBtn()
        {
            deleteSavedBtn.Location = new System.Drawing.Point(70, 402);
            deleteSavedBtn.Margin = new System.Windows.Forms.Padding(70, 15, 70, 3);
            deleteSavedBtn.Name = "deleteSavedBtn";
            deleteSavedBtn.Size = new System.Drawing.Size(80, 23);
            deleteSavedBtn.TabIndex = 4;
            deleteSavedBtn.Text = "Delete";
            deleteSavedBtn.UseVisualStyleBackColor = true;
        }

        private void IniteditSavedBtn()
        {
            editSavedBtn.Location = new System.Drawing.Point(70, 361);
            editSavedBtn.Margin = new System.Windows.Forms.Padding(70, 15, 70, 3);
            editSavedBtn.Name = "editSavedBtn";
            editSavedBtn.Size = new System.Drawing.Size(80, 23);
            editSavedBtn.TabIndex = 3;
            editSavedBtn.Text = "Edit";
            editSavedBtn.UseVisualStyleBackColor = true;
        }

        private void InitconnectToSavedBtn()
        {
            connectToSavedBtn.Location = new System.Drawing.Point(70, 320);
            connectToSavedBtn.Margin = new System.Windows.Forms.Padding(70, 20, 70, 3);
            connectToSavedBtn.Name = "connectToSavedBtn";
            connectToSavedBtn.Size = new System.Drawing.Size(80, 23);
            connectToSavedBtn.TabIndex = 2;
            connectToSavedBtn.Text = "Connect to";
            connectToSavedBtn.UseVisualStyleBackColor = true;
        }

        private void InitproxyInfoTxtBox()
        {
            proxyInfoTxtBox.BackColor = System.Drawing.SystemColors.MenuText;
            proxyInfoTxtBox.ForeColor = System.Drawing.Color.GreenYellow;
            proxyInfoTxtBox.Location = new System.Drawing.Point(10, 120);
            proxyInfoTxtBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            proxyInfoTxtBox.Name = "proxyInfoTxtBox";
            proxyInfoTxtBox.Size = new System.Drawing.Size(200, 177);
            proxyInfoTxtBox.TabIndex = 0;
            proxyInfoTxtBox.Text = "";
        }

        private void InitproxyInfoLbl()
        {
            proxyInfoLbl.AutoSize = true;
            proxyInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            proxyInfoLbl.Location = new System.Drawing.Point(10, 92);
            proxyInfoLbl.Margin = new System.Windows.Forms.Padding(10, 20, 10, 0);
            proxyInfoLbl.Name = "proxyInfoLbl";
            proxyInfoLbl.Size = new System.Drawing.Size(114, 18);
            proxyInfoLbl.TabIndex = 6;
            proxyInfoLbl.Text = "Info of Selected:";
        }

        private void InitsavedProxiesCombBox()
        {
            savedProxiesCombBox.FormattingEnabled = true;
            savedProxiesCombBox.Location = new System.Drawing.Point(10, 48);
            savedProxiesCombBox.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            savedProxiesCombBox.Name = "savedProxiesCombBox";
            savedProxiesCombBox.Size = new System.Drawing.Size(180, 21);
            savedProxiesCombBox.TabIndex = 1;
        }

        private void InitsavedProxiesLbl()
        {
            savedProxiesLbl.AutoSize = true;
            savedProxiesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            savedProxiesLbl.Location = new System.Drawing.Point(10, 20);
            savedProxiesLbl.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            savedProxiesLbl.Name = "savedProxiesLbl";
            savedProxiesLbl.Size = new System.Drawing.Size(107, 18);
            savedProxiesLbl.TabIndex = 5;
            savedProxiesLbl.Text = "Saved Proxies:";
        }

        private void InitsavedProxiesPnl()
        {
            savedProxiesPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            savedProxiesPnl.Controls.Add(savedProxiesLbl);
            savedProxiesPnl.Controls.Add(savedProxiesCombBox);
            savedProxiesPnl.Controls.Add(proxyInfoLbl);
            savedProxiesPnl.Controls.Add(proxyInfoTxtBox);
            savedProxiesPnl.Controls.Add(connectToSavedBtn);
            savedProxiesPnl.Controls.Add(editSavedBtn);
            savedProxiesPnl.Controls.Add(deleteSavedBtn);
            savedProxiesPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            savedProxiesPnl.Location = new System.Drawing.Point(158, 12);
            savedProxiesPnl.Name = "savedProxiesPnl";
            savedProxiesPnl.Size = new System.Drawing.Size(220, 498);
            savedProxiesPnl.TabIndex = 1;
        }

        private void InitproxyHelpBtn()
        {
            proxyHelpBtn.Location = new System.Drawing.Point(140, 458);
            proxyHelpBtn.Margin = new System.Windows.Forms.Padding(140, 50, 3, 3);
            proxyHelpBtn.Name = "proxyHelpBtn";
            proxyHelpBtn.Size = new System.Drawing.Size(60, 23);
            proxyHelpBtn.TabIndex = 13;
            proxyHelpBtn.Text = "Help!";
            proxyHelpBtn.UseVisualStyleBackColor = true;
        }

        private void InitsaveNConnectProxyBtn()
        {
            saveNConnectProxyBtn.Location = new System.Drawing.Point(50, 382);
            saveNConnectProxyBtn.Margin = new System.Windows.Forms.Padding(50, 20, 3, 3);
            saveNConnectProxyBtn.Name = "saveNConnectProxyBtn";
            saveNConnectProxyBtn.Size = new System.Drawing.Size(120, 23);
            saveNConnectProxyBtn.TabIndex = 9;
            saveNConnectProxyBtn.Text = "Save and Connect";
            saveNConnectProxyBtn.UseVisualStyleBackColor = true;
        }

        private void InitsaveProxyBtn()
        {
            saveProxyBtn.Location = new System.Drawing.Point(50, 336);
            saveProxyBtn.Margin = new System.Windows.Forms.Padding(50, 30, 3, 3);
            saveProxyBtn.Name = "saveProxyBtn";
            saveProxyBtn.Size = new System.Drawing.Size(120, 23);
            saveProxyBtn.TabIndex = 8;
            saveProxyBtn.Text = "Save to File";
            saveProxyBtn.UseVisualStyleBackColor = true;
        }

        private void InitauthReqChckBox()
        {
            authReqChckBox.AutoSize = true;
            authReqChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            authReqChckBox.Location = new System.Drawing.Point(40, 284);
            authReqChckBox.Margin = new System.Windows.Forms.Padding(40, 20, 3, 3);
            authReqChckBox.Name = "authReqChckBox";
            authReqChckBox.Size = new System.Drawing.Size(151, 19);
            authReqChckBox.TabIndex = 10;
            authReqChckBox.Text = "Authorization Required";
            authReqChckBox.UseVisualStyleBackColor = true;
        }

        private void InitpassTextBox()
        {
            passTextBox.Location = new System.Drawing.Point(40, 241);
            passTextBox.Margin = new System.Windows.Forms.Padding(40, 5, 3, 3);
            passTextBox.Name = "passTextBox";
            passTextBox.Size = new System.Drawing.Size(140, 20);
            passTextBox.TabIndex = 5;
        }

        private void InitpassLbl()
        {
            passLbl.AutoSize = true;
            passLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passLbl.Location = new System.Drawing.Point(40, 218);
            passLbl.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            passLbl.Name = "passLbl";
            passLbl.Size = new System.Drawing.Size(79, 18);
            passLbl.TabIndex = 4;
            passLbl.Text = "Password:";
        }

        private void InituNameTxtBox()
        {
            uNameTxtBox.Location = new System.Drawing.Point(40, 175);
            uNameTxtBox.Margin = new System.Windows.Forms.Padding(40, 5, 3, 3);
            uNameTxtBox.Name = "uNameTxtBox";
            uNameTxtBox.Size = new System.Drawing.Size(140, 20);
            uNameTxtBox.TabIndex = 3;
        }

        private void InituNameLbl()
        {
            uNameLbl.AutoSize = true;
            uNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            uNameLbl.Location = new System.Drawing.Point(40, 152);
            uNameLbl.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            uNameLbl.Name = "uNameLbl";
            uNameLbl.Size = new System.Drawing.Size(81, 18);
            uNameLbl.TabIndex = 2;
            uNameLbl.Text = "Username:";
        }

        private void InitportTxtBox()
        {
            portTxtBox.Location = new System.Drawing.Point(40, 109);
            portTxtBox.Margin = new System.Windows.Forms.Padding(40, 5, 3, 3);
            portTxtBox.Name = "portTxtBox";
            portTxtBox.Size = new System.Drawing.Size(140, 20);
            portTxtBox.TabIndex = 12;
        }

        private void InitportLbl()
        {
            portLbl.AutoSize = true;
            portLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            portLbl.Location = new System.Drawing.Point(40, 86);
            portLbl.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            portLbl.Name = "portLbl";
            portLbl.Size = new System.Drawing.Size(40, 18);
            portLbl.TabIndex = 11;
            portLbl.Text = "Port:";
        }

        private void InitipAddyTxtBox()
        {
            ipAddyTxtBox.Location = new System.Drawing.Point(40, 43);
            ipAddyTxtBox.Margin = new System.Windows.Forms.Padding(40, 5, 3, 3);
            ipAddyTxtBox.Name = "ipAddyTxtBox";
            ipAddyTxtBox.Size = new System.Drawing.Size(140, 20);
            ipAddyTxtBox.TabIndex = 1;
        }

        private void InitipAddyLbl()
        {
            ipAddyLbl.AutoSize = true;
            ipAddyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ipAddyLbl.Location = new System.Drawing.Point(40, 20);
            ipAddyLbl.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            ipAddyLbl.Name = "ipAddyLbl";
            ipAddyLbl.Size = new System.Drawing.Size(83, 18);
            ipAddyLbl.TabIndex = 0;
            ipAddyLbl.Text = "IP Address:";
        }

        private void InitaddNewProxyPnl()
        {
            addNewProxyPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            addNewProxyPnl.Controls.Add(ipAddyLbl);
            addNewProxyPnl.Controls.Add(ipAddyTxtBox);
            addNewProxyPnl.Controls.Add(portLbl);
            addNewProxyPnl.Controls.Add(portTxtBox);
            addNewProxyPnl.Controls.Add(uNameLbl);
            addNewProxyPnl.Controls.Add(uNameTxtBox);
            addNewProxyPnl.Controls.Add(passLbl);
            addNewProxyPnl.Controls.Add(passTextBox);
            addNewProxyPnl.Controls.Add(authReqChckBox);
            addNewProxyPnl.Controls.Add(saveProxyBtn);
            addNewProxyPnl.Controls.Add(saveNConnectProxyBtn);
            addNewProxyPnl.Controls.Add(proxyHelpBtn);
            addNewProxyPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            addNewProxyPnl.Location = new System.Drawing.Point(384, 12);
            addNewProxyPnl.Name = "addNewProxyPnl";
            addNewProxyPnl.Size = new System.Drawing.Size(220, 498);
            addNewProxyPnl.TabIndex = 0;
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel addNewProxyPnl;
        private System.Windows.Forms.FlowLayoutPanel savedProxiesPnl;
        private System.Windows.Forms.FlowLayoutPanel importProxiesPnl;
        private System.Windows.Forms.Label ipAddyLbl;
        private System.Windows.Forms.TextBox ipAddyTxtBox;
        private System.Windows.Forms.Label uNameLbl;
        private System.Windows.Forms.TextBox uNameTxtBox;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button saveProxyBtn;
        private System.Windows.Forms.Button saveNConnectProxyBtn;
        private System.Windows.Forms.CheckBox authReqChckBox;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.TextBox portTxtBox;
        private System.Windows.Forms.Button proxyHelpBtn;
        private System.Windows.Forms.Label savedProxiesLbl;
        private System.Windows.Forms.ComboBox savedProxiesCombBox;
        private System.Windows.Forms.Label proxyInfoLbl;
        private System.Windows.Forms.RichTextBox proxyInfoTxtBox;
        private System.Windows.Forms.Button connectToSavedBtn;
        private System.Windows.Forms.Button editSavedBtn;
        private System.Windows.Forms.Button deleteSavedBtn;
        private System.Windows.Forms.Label importProxiesLbl;
        private System.Windows.Forms.Button selectTextFileBtn;
        private System.Windows.Forms.Button helpImportBtn;
    }
}