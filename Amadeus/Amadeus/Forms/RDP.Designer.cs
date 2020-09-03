using Amadeus.CustomControls;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.Forms
{
    partial class Rdp
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
            connTxtBox = new BaseTextBox();
            addressTxtBox = new BaseTextBox();
            portTxtBox = new BaseTextBox();
            gatewTxtBox = new BaseTextBox();
            screenWidthTxtBox = new BaseTextBox();
            screenHeightTxtBox = new BaseTextBox();
            connLbl = new BaseLabel();
            addressLbl = new BaseLabel();
            portLbl = new BaseLabel();
            gatewayLbl = new BaseLabel();
            connStatusLbl = new BaseLabel();
            savedRdpsLbl = new BaseLabel();
            screenWidthLbl = new BaseLabel();
            screenHeightLbl = new BaseLabel();
            useGatewayChckBox = new BaseCheckBox();
            asAdminChckBox = new BaseCheckBox();
            remGuardChckBox = new BaseCheckBox();
            restrictedAdminChckBox = new BaseCheckBox();
            fullScreenChckBox = new BaseCheckBox();
            multiMonitorChckBox = new BaseCheckBox();
            spanMonitorsChckBox = new BaseCheckBox();
            rdpCredsHelpBtn = new BaseButton();
            recheckConnBtn = new BaseButton();
            editCrntBtn = new BaseButton();
            delCrntBtn = new BaseButton();
            connectCrntBtn = new BaseButton();
            refreshRdpsBtn = new BaseButton();
            saveNUpdtBtn = new BaseButton();
            saveToRdpFileBtn = new BaseButton();
            saveToXmlBtn = new BaseButton();
            connGivenBtn = new BaseButton();
            resetBtn = new BaseButton();
            screenSettingsHelpBtn = new BaseButton();
            isMstcRunningImgBox = new BasePicBox();
            savedRdpsResults = new BaseComboBox();
            onlyRdpFilesRdio = new BaseRadioButton();

            currentRdpsPnl = new BasePanel();
            screenSettingsHolderPnl = new BasePanel();
            connectionSettingsPnl = new BaseFlowPanel();
            rdpButtonsPnl = new BaseFlowPanel();
            screenSettingsPnl = new BaseFlowPanel();

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
            new BaseTextBox(_res, "screenHeightTxtBox", 25, new Point(20, 184), new Size(105, 20), padding: new Padding(20, 5, 3, 3));
        }

        private void InitscreenHeightLbl()
        {
            new BaseLabel(_res, "screenHeightLbl", 24, new Point(20, 162), new Size(102, 17), "Screen Height:", autoSize: true, padding: new Padding(20, 15, 3, 0));
        }

        private void InitscreenWidthTxtBox()
        {
            new BaseTextBox(_res, "screenWidthTxtBox", 23, new Point(20, 124), new Size(105, 20), padding: new Padding(20, 5, 3, 3));
        }

        private void InitscreenWidthLbl()
        {
            new BaseLabel(_res, "screenWidthLbl", 22, new Point(20, 102), new Size(97, 17), "Screen Width:", autoSize: true, padding: new Padding(20, 15, 3, 0));
        }

        private void InitspanMonitorsChckBox()
        {
            new BaseCheckBox(_res, "spanMonitorsChckBox", true, "Span Monitors Mode", new Point(10, 65), new Size(141, 19), margin: new Padding(10, 3, 3, 3), tabIndex: 21);
        }

        private void InitmultiMonitorChckBox()
        {
            new BaseCheckBox(_res, "multiMonitorChckBox", true, "Multi Monitor Mode", new Point(10, 40), new Size(133, 19), margin: new Padding(10, 3, 3, 3), tabIndex: 20);
        }

        private void InitfullscreenChckBox()
        {
            new BaseCheckBox(_res, "fullScreenChckBox", true, "Start Fullscreen", new Point(10, 15), new Size(111, 19), margin: new Padding(10, 15, 3, 3), tabIndex: 19);
        }

        private void InitscreenSettingsPnl()
        {
            new BaseFlowPanel(_res, new Control[] { fullScreenChckBox, multiMonitorChckBox, spanMonitorsChckBox, screenWidthLbl, screenWidthTxtBox, screenHeightLbl, screenHeightTxtBox }, new Point(3, 3), new Size(164, 215), "screenSettingsPnl", 0);
        }

        private void InitscreenSettingsHelpBtn()
        {
            new BaseButton(_res, "screenSettingsHelpBtn", true, 3, new object[] { null, new Point(88, 185), new Padding(88, 5, 3, 3), new Size(40, 23), "Help!" });
        }

        private void InitresetBtn()
        {
            new BaseButton(_res, "resetBtn", true, 1, new object[] { null, new Point(19, 154), new Padding(19, 10, 3, 3), new Size(110, 23), "Reset To Defaults" });
        }

        private void InitconnGivenBtn()
        {
            new BaseButton(_res, "connGivenBtn", true, 2, new object[] { null, new Point(19, 118), new Padding(19, 10, 3, 3), new Size(110, 23), "Quick Connect" });
        }

        private void InitsaveToXmlBtn()
        {
            new BaseButton(_res, "saveToXmlBtn", true, 4, new object[] { null, new Point(19, 82), new Padding(19, 10, 3, 3), new Size(110, 23), "Save as .XML" });
        }

        private void InitsaveToRdpFileBtn()
        {
            new BaseButton(_res, "saveToRdpFileBtn", true, 5, new object[] { null, new Point(19, 46), new Padding(19, 10, 3, 3), new Size(110, 23), "Save as .RDP" });
        }

        private void InitsaveNUpdtBtn()
        {
            new BaseButton(_res, "saveNUpdtBtn", true, args: new object[] { null, new Point(19, 10), new Padding(19, 10, 3, 3), new Size(110, 23), "Save / Update" });
        }

        private void InitrdpButtonsPnl()
        {
            new BaseFlowPanel(_res, new Control[] { saveNUpdtBtn, saveToRdpFileBtn, saveToXmlBtn, connGivenBtn, resetBtn, screenSettingsHelpBtn }, new Point(173, 3), new Size(148, 215), "rdpButtonsPnl", 1);
        }

        private void InitscreenSettingsHolderPnl()
        {
            new BaseFlowPanel(_res, new Control[] { rdpButtonsPnl, screenSettingsPnl }, new Point(276, 285), new Size(328, 225), "screenSettingsHolderPnl", 4, new object[] { BorderStyle.Fixed3D });
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
            new BaseTextBox(_res, "portTxtBox", 5, new Point(30, 172), new Size(120, 20), padding: new Padding(30, 5, 3, 3));
        }

        private void InitportLbl()
        {
            new BaseLabel(_res, "portLbl", 4, new Point(30, 150), new Size(84, 17), "Server Port:", autoSize: true, padding: new Padding(30, 15, 3, 0));
        }

        private void InitaddressTxtBox()
        {
            new BaseTextBox(_res, "addressTxtBox", 3, new Point(30, 112), new Size(120, 20), padding: new Padding(30, 5, 3, 3));
        }

        private void InitaddressLbl()
        {
            new BaseLabel(_res, "addressLbl", 2, new Point(30, 90), new Size(110, 17), "Server Address:", autoSize: true, padding: new Padding(30, 15, 3, 0));
        }

        private void InitconnTxtBox()
        {
            new BaseTextBox(_res, "connTxtBox", 1, new Point(30, 52), new Size(120, 20), padding: new Padding(30, 5, 3, 3));
        }

        private void InitconnLbl()
        {
            new BaseLabel(_res, "connLbl", 0, new Point(30, 30), new Size(124, 17), "Connection Name:", autoSize: true, padding: new Padding(30, 30, 3, 0));
        }

        private void InitconnectionSettingsPnl()
        {
            new BaseFlowPanel(_res, new Control[] { connLbl, connTxtBox, addressLbl, addressTxtBox, portLbl, portTxtBox, gatewayLbl, gatewTxtBox, useGatewayChckBox, asAdminChckBox, remGuardChckBox, restrictedAdminChckBox, rdpCredsHelpBtn },
                new Point(), new Size(), "connectionSettingsPnl", 0, new object[] { BorderStyle.Fixed3D, FlowDirection.TopDown });
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
        private System.Windows.Forms.CheckBox fullScreenChckBox;
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