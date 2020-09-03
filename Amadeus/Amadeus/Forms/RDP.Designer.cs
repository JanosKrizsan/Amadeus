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
            #region Controls
            connTxtBox = new BaseTextBox(_res, "connTxtBox", 1, new Point(30, 52), new Size(120, 20), padding: new Padding(30, 5, 3, 3));
            addressTxtBox = new BaseTextBox(_res, "addressTxtBox", 3, new Point(30, 112), new Size(120, 20), padding: new Padding(30, 5, 3, 3));
            portTxtBox = new BaseTextBox(_res, "portTxtBox", 5, new Point(30, 172), new Size(120, 20), padding: new Padding(30, 5, 3, 3));
            gatewayTxtBox = new BaseTextBox(_res, "gatewayTxtBox", 7, new Point(30, 232), new Size(120, 20), padding: new Padding(30, 5, 3, 3));
            screenWidthTxtBox = new BaseTextBox(_res, "screenWidthTxtBox", 23, new Point(20, 124), new Size(105, 20), padding: new Padding(20, 5, 3, 3));
            screenHeightTxtBox = new BaseTextBox(_res, "screenHeightTxtBox", 25, new Point(20, 184), new Size(105, 20), padding: new Padding(20, 5, 3, 3));
            connLbl = new BaseLabel(_res, "connLbl", 0, new Point(30, 30), new Size(124, 17), "Connection Name:", autoSize: true, padding: new Padding(30, 30, 3, 0));
            addressLbl = new BaseLabel(_res, "addressLbl", 2, new Point(30, 90), new Size(110, 17), "Server Address:", autoSize: true, padding: new Padding(30, 15, 3, 0));
            portLbl = new BaseLabel(_res, "portLbl", 4, new Point(30, 150), new Size(84, 17), "Server Port:", autoSize: true, padding: new Padding(30, 15, 3, 0));
            gatewayLbl = new BaseLabel(_res, "gatewayLbl", 6, new Point(30, 120), new Size(67, 17), "Gateway:", autoSize: true, padding: new Padding(30, 15, 3, 0));
            connStatusLbl = new BaseLabel(_res, "connStatusLbl", 8, new Point(175, 129), new Size(127, 17), "Connection Status", autoSize: true);
            savedRdpsLbl = new BaseLabel(_res, "savedRdpsLbl", 1, new Point(31, 28), new Size(97, 18), "Saved RDPs:", autoSize: true);
            screenWidthLbl = new BaseLabel(_res, "screenWidthLbl", 22, new Point(20, 102), new Size(97, 17), "Screen Width:", autoSize: true, padding: new Padding(20, 15, 3, 0));
            screenHeightLbl = new BaseLabel(_res, "screenHeightLbl", 24, new Point(20, 162), new Size(102, 17), "Screen Height:", autoSize: true, padding: new Padding(20, 15, 3, 0));
            useGatewayChckBox = new BaseCheckBox(_res, "useGatewayChckBox", true, "Use Gateway", new Point(30, 285), new Size(98, 19), margin: new Padding(30, 30, 3, 3), tabIndex: 8);
            asAdminChckBox = new BaseCheckBox(_res, "asAdminChckBox", true, "As Admin", new Point(30, 317), new Size(77, 19), margin: new Padding(30, 10, 3, 3), tabIndex: 9);
            remGuardChckBox = new BaseCheckBox(_res, "remGuardChckBox", true, "Remote Guard", new Point(30, 349), new Size(107, 19), margin: new Padding(30, 10, 3, 3), tabIndex: 10);
            restrictedAdminChckBox = new BaseCheckBox(_res, "restrictedAdminChckBox", true, "As Restricted Admin", new Point(30, 381), new Size(135, 19), margin: new Padding(30, 10, 3, 3), tabIndex: 15);
            fullScreenChckBox = new BaseCheckBox(_res, "fullScreenChckBox", true, "Start Fullscreen", new Point(10, 15), new Size(111, 19), margin: new Padding(10, 15, 3, 3), tabIndex: 19);
            multiMonitorChckBox = new BaseCheckBox(_res, "multiMonitorChckBox", true, "Multi Monitor Mode", new Point(10, 40), new Size(133, 19), margin: new Padding(10, 3, 3, 3), tabIndex: 20);
            spanMonitorsChckBox = new BaseCheckBox(_res, "spanMonitorsChckBox", true, "Span Monitors Mode", new Point(10, 65), new Size(141, 19), margin: new Padding(10, 3, 3, 3), tabIndex: 21);
            rdpCredsHelpBtn = new BaseButton(_res, "rdpCredsHelpBtn", true, 16, new object[] { null, new Point(174, 458), new Padding(174, 55, 3, 3), new Size(40, 23) });
            recheckConnBtn = new BaseButton(_res, "recheckConnBtn", true, 9, new object[] { null, new Point(33, 228), null, new Size(120, 23), "Recheck Connection" });
            editCrntBtn = new BaseButton(_res, "editCrntBtn", true, 6, new object[] { null, new Point(33, 190), new Size(75, 23), "Edit" });
            delCrntBtn = new BaseButton(_res, "delCrntBtn", true, 5, new object[] { null, new Point(33, 161), new Size(75, 23), "Delete" });
            connectCrntBtn = new BaseButton(_res, "connectCrntBtn", true, 4, new object[] { null, new Point(33, 129), new Size(75, 23), "Connect To" });
            refreshRdpsBtn = new BaseButton(_res, "refreshRdpBtn", true, 3, new object[] { null, new Point(237, 57), new Size(60, 23), "Refresh" });
            saveNUpdtBtn = new BaseButton(_res, "saveNUpdtBtn", true, args: new object[] { null, new Point(19, 10), new Padding(19, 10, 3, 3), new Size(110, 23), "Save / Update" });
            saveToRdpFileBtn = new BaseButton(_res, "saveToRdpFileBtn", true, 5, new object[] { null, new Point(19, 46), new Padding(19, 10, 3, 3), new Size(110, 23), "Save as .RDP" });
            saveToXmlBtn = new BaseButton(_res, "saveToXmlBtn", true, 4, new object[] { null, new Point(19, 82), new Padding(19, 10, 3, 3), new Size(110, 23), "Save as .XML" });
            connGivenBtn = new BaseButton(_res, "connGivenBtn", true, 2, new object[] { null, new Point(19, 118), new Padding(19, 10, 3, 3), new Size(110, 23), "Quick Connect" });
            resetBtn = new BaseButton(_res, "resetBtn", true, 1, new object[] { null, new Point(19, 154), new Padding(19, 10, 3, 3), new Size(110, 23), "Reset To Defaults" });
            screenSettingsHelpBtn = new BaseButton(_res, "screenSettingsHelpBtn", true, 3, new object[] { null, new Point(88, 185), new Padding(88, 5, 3, 3), new Size(40, 23), "Help!" });
            isMstcRunningImgBox = new BasePicBox(_res, "isMstcRunningImgBox", new Point(191, 161), new Size(106, 90), 7, false);
            savedRdpsResults = new BaseComboBox(_res, "savedRdpsResults", 2, new Point(33, 59), new Size(181, 21));
            onlyRdpFilesRdio = new BaseRadioButton(_res, "onlyRdpFilesRdio", "Only .RDP Files", 0, true, new Point(173, 25), new Size(125, 21), true, true);
            #endregion

            #region Panels
            currentRdpsPnl = new BaseFlowPanel(_res, new Control[] { recheckConnBtn, connStatusLbl, isMstcRunningImgBox, editCrntBtn, delCrntBtn, connectCrntBtn, refreshRdpsBtn, savedRdpsResults, savedRdpsLbl, saveToRdpFileBtn, onlyRdpFilesRdio },
                new Point(276, 12), new Size(327, 264), "currentRdpsPnl", 3, new object[] { BorderStyle.Fixed3D });
            screenSettingsHolderPnl = new BaseFlowPanel(_res, new Control[] { rdpButtonsPnl, screenSettingsPnl }, new Point(276, 285), new Size(328, 225), "screenSettingsHolderPnl", 4, new object[] { BorderStyle.Fixed3D });
            connectionSettingsPnl = new BaseFlowPanel(_res, new Control[] { connLbl, connTxtBox, addressLbl, addressTxtBox, portLbl, portTxtBox, gatewayLbl, gatewayTxtBox, useGatewayChckBox, asAdminChckBox, remGuardChckBox, restrictedAdminChckBox, rdpCredsHelpBtn },
                new Point(), new Size(), "connectionSettingsPnl", 0, new object[] { BorderStyle.Fixed3D, FlowDirection.TopDown });
            rdpButtonsPnl = new BaseFlowPanel(_res, new Control[] { saveNUpdtBtn, saveToRdpFileBtn, saveToXmlBtn, connGivenBtn, resetBtn, screenSettingsHelpBtn }, new Point(173, 3), new Size(148, 215), "rdpButtonsPnl", 1);
            screenSettingsPnl = new BaseFlowPanel(_res, new Control[] { fullScreenChckBox, multiMonitorChckBox, spanMonitorsChckBox, screenWidthLbl, screenWidthTxtBox, screenHeightLbl, screenHeightTxtBox }, new Point(3, 3), new Size(164, 215), "screenSettingsPnl", 0);
            #endregion

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
        private System.Windows.Forms.TextBox gatewayTxtBox;
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