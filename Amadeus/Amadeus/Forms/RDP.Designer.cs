namespace Amadeus.Forms
{
    partial class Rdp
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
            connectionSettingsPnl = new System.Windows.Forms.FlowLayoutPanel();
            connLbl = new System.Windows.Forms.Label();
            connTxtBox = new System.Windows.Forms.TextBox();
            addressLbl = new System.Windows.Forms.Label();
            addressTxtBox = new System.Windows.Forms.TextBox();
            portLbl = new System.Windows.Forms.Label();
            portTxtBox = new System.Windows.Forms.TextBox();
            gatewayLbl = new System.Windows.Forms.Label();
            gatewTxtBox = new System.Windows.Forms.TextBox();
            useGatewayChckBox = new System.Windows.Forms.CheckBox();
            asAdminChckBox = new System.Windows.Forms.CheckBox();
            remGuardChckBox = new System.Windows.Forms.CheckBox();
            restrictedAdminChckBox = new System.Windows.Forms.CheckBox();
            rdpCredsHelpBtn = new System.Windows.Forms.Button();
            currentRdpsPnl = new System.Windows.Forms.Panel();
            recheckConnBtn = new System.Windows.Forms.Button();
            connStatusLbl = new System.Windows.Forms.Label();
            isMstcRunningImgBox = new System.Windows.Forms.PictureBox();
            editCrntBtn = new System.Windows.Forms.Button();
            delCrntBtn = new System.Windows.Forms.Button();
            connectCrntBtn = new System.Windows.Forms.Button();
            refreshRdpsBtn = new System.Windows.Forms.Button();
            savedRdpsResults = new System.Windows.Forms.ComboBox();
            savedRdpsLbl = new System.Windows.Forms.Label();
            onlyRdpFilesRdio = new System.Windows.Forms.RadioButton();
            screenSettingsHolderPnl = new System.Windows.Forms.Panel();
            rdpButtonsPnl = new System.Windows.Forms.FlowLayoutPanel();
            saveNUpdtBtn = new System.Windows.Forms.Button();
            saveToRdpFileBtn = new System.Windows.Forms.Button();
            saveToXmlBtn = new System.Windows.Forms.Button();
            connGivenBtn = new System.Windows.Forms.Button();
            resetBtn = new System.Windows.Forms.Button();
            screenSettingsHelpBtn = new System.Windows.Forms.Button();
            screenSettingsPnl = new System.Windows.Forms.FlowLayoutPanel();
            fullscreenChckBox = new System.Windows.Forms.CheckBox();
            multiMonitorChckBox = new System.Windows.Forms.CheckBox();
            spanMonitorsChckBox = new System.Windows.Forms.CheckBox();
            screenWidthLbl = new System.Windows.Forms.Label();
            screenWidthTxtBox = new System.Windows.Forms.TextBox();
            screenHeightLbl = new System.Windows.Forms.Label();
            screenHeightTxtBox = new System.Windows.Forms.TextBox();
            connectionSettingsPnl.SuspendLayout();
            currentRdpsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(isMstcRunningImgBox)).BeginInit();

            SuspendLayout();
            InitRdp();

        }

        private void InitRdp()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 522);
            ControlBox = false;
            Controls.Add(screenSettingsHolderPnl);
            Controls.Add(currentRdpsPnl);
            Controls.Add(connectionSettingsPnl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Rdp";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Proxy";
            connectionSettingsPnl.ResumeLayout(false);
            connectionSettingsPnl.PerformLayout();
            currentRdpsPnl.ResumeLayout(false);
            currentRdpsPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(isMstcRunningImgBox)).EndInit();
            screenSettingsHolderPnl.ResumeLayout(false);
            rdpButtonsPnl.ResumeLayout(false);
            screenSettingsPnl.ResumeLayout(false);
            screenSettingsPnl.PerformLayout();
            ResumeLayout(false);
        }

        private void InitscreenHeightTxtBox()
        {
            screenHeightTxtBox.Location = new System.Drawing.Point(20, 184);
            screenHeightTxtBox.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            screenHeightTxtBox.Name = "screenHeightTxtBox";
            screenHeightTxtBox.Size = new System.Drawing.Size(105, 20);
            screenHeightTxtBox.TabIndex = 25;
        }

        private void InitscreenHeightLbl()
        {
            screenHeightLbl.AutoSize = true;
            screenHeightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            screenHeightLbl.Location = new System.Drawing.Point(20, 162);
            screenHeightLbl.Margin = new System.Windows.Forms.Padding(20, 15, 3, 0);
            screenHeightLbl.Name = "screenHeightLbl";
            screenHeightLbl.Size = new System.Drawing.Size(102, 17);
            screenHeightLbl.TabIndex = 24;
            screenHeightLbl.Text = "Screen Height:";
        }

        private void InitscreenWidthTxtBox()
        {
            screenWidthTxtBox.Location = new System.Drawing.Point(20, 124);
            screenWidthTxtBox.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            screenWidthTxtBox.Name = "screenWidthTxtBox";
            screenWidthTxtBox.Size = new System.Drawing.Size(105, 20);
            screenWidthTxtBox.TabIndex = 23;
        }

        private void InitscreenWidthLbl()
        {
            screenWidthLbl.AutoSize = true;
            screenWidthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            screenWidthLbl.Location = new System.Drawing.Point(20, 102);
            screenWidthLbl.Margin = new System.Windows.Forms.Padding(20, 15, 3, 0);
            screenWidthLbl.Name = "screenWidthLbl";
            screenWidthLbl.Size = new System.Drawing.Size(97, 17);
            screenWidthLbl.TabIndex = 22;
            screenWidthLbl.Text = "Screen Width:";
        }

        private void InitspanMonitorsChckBox()
        {
            spanMonitorsChckBox.AutoSize = true;
            spanMonitorsChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            spanMonitorsChckBox.Location = new System.Drawing.Point(10, 65);
            spanMonitorsChckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            spanMonitorsChckBox.Name = "spanMonitorsChckBox";
            spanMonitorsChckBox.Size = new System.Drawing.Size(141, 19);
            spanMonitorsChckBox.TabIndex = 21;
            spanMonitorsChckBox.Text = "Span Monitors Mode";
            spanMonitorsChckBox.UseVisualStyleBackColor = true;
        }

        private void InitmultiMonitorChckBox()
        {
            multiMonitorChckBox.AutoSize = true;
            multiMonitorChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            multiMonitorChckBox.Location = new System.Drawing.Point(10, 40);
            multiMonitorChckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            multiMonitorChckBox.Name = "multiMonitorChckBox";
            multiMonitorChckBox.Size = new System.Drawing.Size(133, 19);
            multiMonitorChckBox.TabIndex = 20;
            multiMonitorChckBox.Text = "Multi Monitor Mode";
            multiMonitorChckBox.UseVisualStyleBackColor = true;
        }

        private void InitfullscreenChckBox()
        {
            fullscreenChckBox.AutoSize = true;
            fullscreenChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fullscreenChckBox.Location = new System.Drawing.Point(10, 15);
            fullscreenChckBox.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            fullscreenChckBox.Name = "fullscreenChckBox";
            fullscreenChckBox.Size = new System.Drawing.Size(111, 19);
            fullscreenChckBox.TabIndex = 19;
            fullscreenChckBox.Text = "Start Fullscreen";
            fullscreenChckBox.UseVisualStyleBackColor = true;
        }

        private void InitscreenSettingsPnl()
        {
            screenSettingsPnl.Controls.Add(fullscreenChckBox);
            screenSettingsPnl.Controls.Add(multiMonitorChckBox);
            screenSettingsPnl.Controls.Add(spanMonitorsChckBox);
            screenSettingsPnl.Controls.Add(screenWidthLbl);
            screenSettingsPnl.Controls.Add(screenWidthTxtBox);
            screenSettingsPnl.Controls.Add(screenHeightLbl);
            screenSettingsPnl.Controls.Add(screenHeightTxtBox);
            screenSettingsPnl.Location = new System.Drawing.Point(3, 3);
            screenSettingsPnl.Name = "screenSettingsPnl";
            screenSettingsPnl.Size = new System.Drawing.Size(164, 215);
            screenSettingsPnl.TabIndex = 0;
        }

        private void InitscreenSettingsHelpBtn()
        {
            screenSettingsHelpBtn.Location = new System.Drawing.Point(88, 185);
            screenSettingsHelpBtn.Margin = new System.Windows.Forms.Padding(88, 5, 3, 3);
            screenSettingsHelpBtn.Name = "screenSettingsHelpBtn";
            screenSettingsHelpBtn.Size = new System.Drawing.Size(40, 23);
            screenSettingsHelpBtn.TabIndex = 3;
            screenSettingsHelpBtn.Text = "Help!";
            screenSettingsHelpBtn.UseVisualStyleBackColor = true;
        }

        private void InitresetBtn()
        {
            resetBtn.Location = new System.Drawing.Point(19, 154);
            resetBtn.Margin = new System.Windows.Forms.Padding(19, 10, 3, 3);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new System.Drawing.Size(110, 23);
            resetBtn.TabIndex = 1;
            resetBtn.Text = "Reset To Defaults";
            resetBtn.UseVisualStyleBackColor = true;
        }

        private void InitconnGivenBtn()
        {
            connGivenBtn.Location = new System.Drawing.Point(19, 118);
            connGivenBtn.Margin = new System.Windows.Forms.Padding(19, 10, 3, 3);
            connGivenBtn.Name = "connGivenBtn";
            connGivenBtn.Size = new System.Drawing.Size(110, 23);
            connGivenBtn.TabIndex = 2;
            connGivenBtn.Text = "Quick Connect";
            connGivenBtn.UseVisualStyleBackColor = true;
        }

        private void InitsaveToXmlBtn()
        {
            saveToXmlBtn.Location = new System.Drawing.Point(19, 82);
            saveToXmlBtn.Margin = new System.Windows.Forms.Padding(19, 10, 3, 3);
            saveToXmlBtn.Name = "saveToXmlBtn";
            saveToXmlBtn.Size = new System.Drawing.Size(110, 23);
            saveToXmlBtn.TabIndex = 4;
            saveToXmlBtn.Text = "Save as .XML";
            saveToXmlBtn.UseVisualStyleBackColor = true;
        }

        private void InitsaveToRdpFileBtn()
        {
            saveToRdpFileBtn.Location = new System.Drawing.Point(19, 46);
            saveToRdpFileBtn.Margin = new System.Windows.Forms.Padding(19, 10, 3, 3);
            saveToRdpFileBtn.Name = "saveToRdpFileBtn";
            saveToRdpFileBtn.Size = new System.Drawing.Size(110, 23);
            saveToRdpFileBtn.TabIndex = 5;
            saveToRdpFileBtn.Text = "Save as .RDP";
            saveToRdpFileBtn.UseVisualStyleBackColor = true;
        }

        private void InitsaveNUpdtBtn()
        {
            saveNUpdtBtn.Location = new System.Drawing.Point(19, 10);
            saveNUpdtBtn.Margin = new System.Windows.Forms.Padding(19, 10, 3, 3);
            saveNUpdtBtn.Name = "saveNUpdtBtn";
            saveNUpdtBtn.Size = new System.Drawing.Size(110, 23);
            saveNUpdtBtn.TabIndex = 0;
            saveNUpdtBtn.Text = "Save / Update";
            saveNUpdtBtn.UseVisualStyleBackColor = true;
        }

        private void InitrdpButtonsPnl()
        {
            rdpButtonsPnl.Controls.Add(saveNUpdtBtn);
            rdpButtonsPnl.Controls.Add(saveToRdpFileBtn);
            rdpButtonsPnl.Controls.Add(saveToXmlBtn);
            rdpButtonsPnl.Controls.Add(connGivenBtn);
            rdpButtonsPnl.Controls.Add(resetBtn);
            rdpButtonsPnl.Controls.Add(screenSettingsHelpBtn);
            rdpButtonsPnl.Location = new System.Drawing.Point(173, 3);
            rdpButtonsPnl.Name = "rdpButtonsPnl";
            rdpButtonsPnl.Size = new System.Drawing.Size(148, 215);
            rdpButtonsPnl.TabIndex = 1;
        }

        private void InitscreenSettingsHolderPnl()
        {
            screenSettingsHolderPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            screenSettingsHolderPnl.Controls.Add(rdpButtonsPnl);
            screenSettingsHolderPnl.Controls.Add(screenSettingsPnl);
            screenSettingsHolderPnl.Location = new System.Drawing.Point(276, 285);
            screenSettingsHolderPnl.Name = "screenSettingsHolderPnl";
            screenSettingsHolderPnl.Size = new System.Drawing.Size(328, 225);
            screenSettingsHolderPnl.TabIndex = 4;
        }

        private void InitonlyRdpFilesRdio()
        {
            onlyRdpFilesRdio.AutoSize = true;
            onlyRdpFilesRdio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            onlyRdpFilesRdio.Location = new System.Drawing.Point(173, 25);
            onlyRdpFilesRdio.Name = "onlyRdpFilesRdio";
            onlyRdpFilesRdio.Size = new System.Drawing.Size(125, 21);
            onlyRdpFilesRdio.TabIndex = 0;
            onlyRdpFilesRdio.TabStop = true;
            onlyRdpFilesRdio.Text = "Only .RDP Files";
            onlyRdpFilesRdio.UseVisualStyleBackColor = true;
        }

        private void InitsavedRdpsLbl()
        {
            savedRdpsLbl.AutoSize = true;
            savedRdpsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            savedRdpsLbl.Location = new System.Drawing.Point(31, 28);
            savedRdpsLbl.Name = "savedRdpsLbl";
            savedRdpsLbl.Size = new System.Drawing.Size(97, 18);
            savedRdpsLbl.TabIndex = 1;
            savedRdpsLbl.Text = "Saved RDPs:";
        }

        private void InitsavedRdpsResults()
        {
            savedRdpsResults.FormattingEnabled = true;
            savedRdpsResults.Location = new System.Drawing.Point(33, 59);
            savedRdpsResults.Name = "savedRdpsResults";
            savedRdpsResults.Size = new System.Drawing.Size(181, 21);
            savedRdpsResults.TabIndex = 2;
        }

        private void InitrefreshRdpsBtn()
        {
            refreshRdpsBtn.Location = new System.Drawing.Point(237, 57);
            refreshRdpsBtn.Name = "refreshRdpsBtn";
            refreshRdpsBtn.Size = new System.Drawing.Size(60, 23);
            refreshRdpsBtn.TabIndex = 3;
            refreshRdpsBtn.Text = "Refresh";
            refreshRdpsBtn.UseVisualStyleBackColor = true;
        }

        private void InitconnectCrntBtn()
        {
            connectCrntBtn.Location = new System.Drawing.Point(33, 129);
            connectCrntBtn.Name = "connectCrntBtn";
            connectCrntBtn.Size = new System.Drawing.Size(75, 23);
            connectCrntBtn.TabIndex = 4;
            connectCrntBtn.Text = "Connect To";
            connectCrntBtn.UseVisualStyleBackColor = true;
        }

        private void InitdelCrntBtn()
        {
            delCrntBtn.Location = new System.Drawing.Point(33, 161);
            delCrntBtn.Name = "delCrntBtn";
            delCrntBtn.Size = new System.Drawing.Size(75, 23);
            delCrntBtn.TabIndex = 5;
            delCrntBtn.Text = "Delete";
            delCrntBtn.UseVisualStyleBackColor = true;
        }

        private void IniteditCrntBtn()
        {
            editCrntBtn.Location = new System.Drawing.Point(33, 190);
            editCrntBtn.Name = "editCrntBtn";
            editCrntBtn.Size = new System.Drawing.Size(75, 23);
            editCrntBtn.TabIndex = 6;
            editCrntBtn.Text = "Edit";
            editCrntBtn.UseVisualStyleBackColor = true;
        }

        private void InitisMstcRunningImgBox()
        {
            isMstcRunningImgBox.Location = new System.Drawing.Point(191, 161);
            isMstcRunningImgBox.Name = "isMstcRunningImgBox";
            isMstcRunningImgBox.Size = new System.Drawing.Size(106, 90);
            isMstcRunningImgBox.TabIndex = 7;
            isMstcRunningImgBox.TabStop = false;
        }

        private void InitconnStatusLbl()
        {
            connStatusLbl.AutoSize = true;
            connStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            connStatusLbl.Location = new System.Drawing.Point(175, 129);
            connStatusLbl.Name = "connStatusLbl";
            connStatusLbl.Size = new System.Drawing.Size(127, 17);
            connStatusLbl.TabIndex = 8;
            connStatusLbl.Text = "Connection Status:";
        }

        private void InitrecheckConnBtn()
        {
            recheckConnBtn.Location = new System.Drawing.Point(33, 228);
            recheckConnBtn.Name = "recheckConnBtn";
            recheckConnBtn.Size = new System.Drawing.Size(120, 23);
            recheckConnBtn.TabIndex = 9;
            recheckConnBtn.Text = "Recheck Connection";
            recheckConnBtn.UseVisualStyleBackColor = true;
        }

        private void InitcurrentRdpsPnl()
        {
            currentRdpsPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            currentRdpsPnl.Controls.Add(recheckConnBtn);
            currentRdpsPnl.Controls.Add(connStatusLbl);
            currentRdpsPnl.Controls.Add(isMstcRunningImgBox);
            currentRdpsPnl.Controls.Add(editCrntBtn);
            currentRdpsPnl.Controls.Add(delCrntBtn);
            currentRdpsPnl.Controls.Add(connectCrntBtn);
            currentRdpsPnl.Controls.Add(refreshRdpsBtn);
            currentRdpsPnl.Controls.Add(savedRdpsResults);
            currentRdpsPnl.Controls.Add(savedRdpsLbl);
            currentRdpsPnl.Controls.Add(onlyRdpFilesRdio);
            currentRdpsPnl.Location = new System.Drawing.Point(276, 12);
            currentRdpsPnl.Name = "currentRdpsPnl";
            currentRdpsPnl.Size = new System.Drawing.Size(327, 264);
            currentRdpsPnl.TabIndex = 3;
        }

        private void InitrdpCredsHelpBtn()
        {
            rdpCredsHelpBtn.Location = new System.Drawing.Point(174, 458);
            rdpCredsHelpBtn.Margin = new System.Windows.Forms.Padding(174, 55, 3, 3);
            rdpCredsHelpBtn.Name = "rdpCredsHelpBtn";
            rdpCredsHelpBtn.Size = new System.Drawing.Size(40, 23);
            rdpCredsHelpBtn.TabIndex = 16;
            rdpCredsHelpBtn.Text = "Help!";
            rdpCredsHelpBtn.UseVisualStyleBackColor = true;
        }

        private void InitrestrictedAdminChckBox()
        {
            restrictedAdminChckBox.AutoSize = true;
            restrictedAdminChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            restrictedAdminChckBox.Location = new System.Drawing.Point(30, 381);
            restrictedAdminChckBox.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            restrictedAdminChckBox.Name = "restrictedAdminChckBox";
            restrictedAdminChckBox.Size = new System.Drawing.Size(135, 19);
            restrictedAdminChckBox.TabIndex = 15;
            restrictedAdminChckBox.Text = "As Restricted Admin";
            restrictedAdminChckBox.UseVisualStyleBackColor = true;
        }

        private void InitremGuardChckBox()
        {
            remGuardChckBox.AutoSize = true;
            remGuardChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remGuardChckBox.Location = new System.Drawing.Point(30, 349);
            remGuardChckBox.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            remGuardChckBox.Name = "remGuardChckBox";
            remGuardChckBox.Size = new System.Drawing.Size(107, 19);
            remGuardChckBox.TabIndex = 10;
            remGuardChckBox.Text = "Remote Guard";
            remGuardChckBox.UseVisualStyleBackColor = true;
        }

        private void InitasAdminChckBox()
        {
            asAdminChckBox.AutoSize = true;
            asAdminChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            asAdminChckBox.Location = new System.Drawing.Point(30, 317);
            asAdminChckBox.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            asAdminChckBox.Name = "asAdminChckBox";
            asAdminChckBox.Size = new System.Drawing.Size(77, 19);
            asAdminChckBox.TabIndex = 9;
            asAdminChckBox.Text = "As Admin";
            asAdminChckBox.UseVisualStyleBackColor = true;
        }

        private void InituseGatewayChckBox()
        {
            useGatewayChckBox.AutoSize = true;
            useGatewayChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            useGatewayChckBox.Location = new System.Drawing.Point(30, 285);
            useGatewayChckBox.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            useGatewayChckBox.Name = "useGatewayChckBox";
            useGatewayChckBox.Size = new System.Drawing.Size(98, 19);
            useGatewayChckBox.TabIndex = 8;
            useGatewayChckBox.Text = "Use Gateway";
            useGatewayChckBox.UseVisualStyleBackColor = true;
        }

        private void InitgatewTxtBox()
        {
            gatewTxtBox.Location = new System.Drawing.Point(30, 232);
            gatewTxtBox.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            gatewTxtBox.Name = "gatewTxtBox";
            gatewTxtBox.Size = new System.Drawing.Size(120, 20);
            gatewTxtBox.TabIndex = 7;
        }

        private void InitgatewayLbl()
        {
            gatewayLbl.AutoSize = true;
            gatewayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gatewayLbl.Location = new System.Drawing.Point(30, 210);
            gatewayLbl.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            gatewayLbl.Name = "gatewayLbl";
            gatewayLbl.Size = new System.Drawing.Size(67, 17);
            gatewayLbl.TabIndex = 6;
            gatewayLbl.Text = "Gateway:";
        }

        private void InitportTxtBox()
        {
            portTxtBox.Location = new System.Drawing.Point(30, 172);
            portTxtBox.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            portTxtBox.Name = "portTxtBox";
            portTxtBox.Size = new System.Drawing.Size(120, 20);
            portTxtBox.TabIndex = 5;
        }

        private void InitportLbl()
        {
            portLbl.AutoSize = true;
            portLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            portLbl.Location = new System.Drawing.Point(30, 150);
            portLbl.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            portLbl.Name = "portLbl";
            portLbl.Size = new System.Drawing.Size(84, 17);
            portLbl.TabIndex = 4;
            portLbl.Text = "Server Port:";
        }

        private void InitaddressTxtBox()
        {
            addressTxtBox.Location = new System.Drawing.Point(30, 112);
            addressTxtBox.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new System.Drawing.Size(120, 20);
            addressTxtBox.TabIndex = 3;
        }

        private void InitaddressLbl()
        {
            addressLbl.AutoSize = true;
            addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLbl.Location = new System.Drawing.Point(30, 90);
            addressLbl.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new System.Drawing.Size(110, 17);
            addressLbl.TabIndex = 2;
            addressLbl.Text = "Server Address:";
        }

        private void InitconnTxtBox()
        {
            connTxtBox.Location = new System.Drawing.Point(30, 52);
            connTxtBox.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            connTxtBox.Name = "connTxtBox";
            connTxtBox.Size = new System.Drawing.Size(120, 20);
            connTxtBox.TabIndex = 1;
        }

        private void InitconnLbl()
        {
            connLbl.AutoSize = true;
            connLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            connLbl.Location = new System.Drawing.Point(30, 30);
            connLbl.Margin = new System.Windows.Forms.Padding(30, 30, 3, 0);
            connLbl.Name = "connLbl";
            connLbl.Size = new System.Drawing.Size(124, 17);
            connLbl.TabIndex = 0;
            connLbl.Text = "Connection Name:";
        }

        private void InitconnectionSettingsPnl()
        {
            connectionSettingsPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            connectionSettingsPnl.Controls.Add(connLbl);
            connectionSettingsPnl.Controls.Add(connTxtBox);
            connectionSettingsPnl.Controls.Add(addressLbl);
            connectionSettingsPnl.Controls.Add(addressTxtBox);
            connectionSettingsPnl.Controls.Add(portLbl);
            connectionSettingsPnl.Controls.Add(portTxtBox);
            connectionSettingsPnl.Controls.Add(gatewayLbl);
            connectionSettingsPnl.Controls.Add(gatewTxtBox);
            connectionSettingsPnl.Controls.Add(useGatewayChckBox);
            connectionSettingsPnl.Controls.Add(asAdminChckBox);
            connectionSettingsPnl.Controls.Add(remGuardChckBox);
            connectionSettingsPnl.Controls.Add(restrictedAdminChckBox);
            connectionSettingsPnl.Controls.Add(rdpCredsHelpBtn);
            connectionSettingsPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            connectionSettingsPnl.Location = new System.Drawing.Point(12, 12);
            connectionSettingsPnl.Name = "connectionSettingsPnl";
            connectionSettingsPnl.Size = new System.Drawing.Size(244, 498);
            connectionSettingsPnl.TabIndex = 0;
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel connectionSettingsPnl;
        private System.Windows.Forms.Panel currentRdpsPnl;
        private System.Windows.Forms.Label connStatusLbl;
        private System.Windows.Forms.PictureBox isMstcRunningImgBox;
        private System.Windows.Forms.Button editCrntBtn;
        private System.Windows.Forms.Button delCrntBtn;
        private System.Windows.Forms.Button connectCrntBtn;
        private System.Windows.Forms.Button refreshRdpsBtn;
        private System.Windows.Forms.ComboBox savedRdpsResults;
        private System.Windows.Forms.Label savedRdpsLbl;
        private System.Windows.Forms.RadioButton onlyRdpFilesRdio;
        private System.Windows.Forms.Label connLbl;
        private System.Windows.Forms.TextBox connTxtBox;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.TextBox portTxtBox;
        private System.Windows.Forms.Label gatewayLbl;
        private System.Windows.Forms.TextBox gatewTxtBox;
        private System.Windows.Forms.CheckBox useGatewayChckBox;
        private System.Windows.Forms.CheckBox asAdminChckBox;
        private System.Windows.Forms.CheckBox remGuardChckBox;
        private System.Windows.Forms.CheckBox restrictedAdminChckBox;
        private System.Windows.Forms.Panel screenSettingsHolderPnl;
        private System.Windows.Forms.FlowLayoutPanel rdpButtonsPnl;
        private System.Windows.Forms.Button saveNUpdtBtn;
        private System.Windows.Forms.Button saveToXmlBtn;
        private System.Windows.Forms.Button connGivenBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button screenSettingsHelpBtn;
        private System.Windows.Forms.FlowLayoutPanel screenSettingsPnl;
        private System.Windows.Forms.CheckBox fullscreenChckBox;
        private System.Windows.Forms.CheckBox multiMonitorChckBox;
        private System.Windows.Forms.CheckBox spanMonitorsChckBox;
        private System.Windows.Forms.Label screenWidthLbl;
        private System.Windows.Forms.TextBox screenWidthTxtBox;
        private System.Windows.Forms.Label screenHeightLbl;
        private System.Windows.Forms.TextBox screenHeightTxtBox;
        private System.Windows.Forms.Button rdpCredsHelpBtn;
        private System.Windows.Forms.Button recheckConnBtn;
        private System.Windows.Forms.Button saveToRdpFileBtn;
    }
}