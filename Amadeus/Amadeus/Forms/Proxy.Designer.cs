using Amadeus.CustomControls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.Forms
{
    partial class Proxy
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
            var defButtonSize = new Size(80, 23);
            var defTextBoxSize = new Size(140, 20);
            var defTextBoxPadding = new Padding(40, 5, 3, 3);
            var defLabelPadding = new Padding(40, 20, 3, 0);

            saveProxyBtn = new BaseButton(_res, "saveProxyBtn", true, 8, new object[] { default, new Point(50, 336), new Padding(50, 30, 3, 3), new Size(120, 23), "Save to File" });
            saveNConnectProxyBtn = new BaseButton(_res, "saveNConnectProxyBtn", true, 9, new object[] { default, new Point(50, 382), new Padding(50, 20, 3, 3), new Size(120, 23), "Save and Connect" });
            proxyHelpBtn = new BaseButton(_res, "proxyHelpBtn", true, 13, new object[] { default, new Point(140, 458), new Padding(140, 50, 3, 3), new Size(60, 23), "Help!" });
            connectToSavedBtn = new BaseButton(_res, "connectToSavedBtn", true, 2, new object[] { default, new Point(70, 320), new Padding(70, 20, 70, 3), new Size(80, 23), "Connect To" });
            editSavedBtn = new BaseButton(_res, "editSavedBtn", true, 3, new object[] { default, new Point(70, 361), new Padding(70, 15, 70, 3), new Size(80, 23), "Edit" });
            deleteSavedBtn = new BaseButton(_res, "deleteSavedBtn", true, 4, new object[] { default, new Point(70, 402), new Padding(70, 15, 70, 3), new Size(80, 23), "Delete" });
            selectTextFileBtn = new BaseButton(_res, "selectTextFileBtn", true, args: new object[] { default, new Point(20, 78), new Padding(20, 40, 20, 3), new Size(100, 23), "Select Text File" });
            helpImportBtn = new BaseButton(_res, "helpImportBtn", true, 2, new object[] { default, new Point(30, 119), new Padding(30, 15, 30, 3), new Size(80, 23), "Help!" });
            ipAddyLbl = new BaseLabel(_res, "ipAddyLbl", 0, new Point(40, 20), new Size(83, 18), "IP Address:", autoSize: true, padding: defLabelPadding);
            portLbl = new BaseLabel(_res, "portLbl", 11, new Point(40, 86), new Size(40, 18), "Port:", autoSize: true, padding: defLabelPadding);
            passLbl = new BaseLabel(_res, "passLbl", 4, new Point(40, 218), new Size(79, 18), "Password:", autoSize: true, padding: defLabelPadding);
            uNameLbl = new BaseLabel(_res, "uNameLbl", 2, new Point(40, 152), new Size(81, 18), "Username:", autoSize: true, padding: defLabelPadding);
            proxyInfoLbl = new BaseLabel(_res, "proxyInfoLbl", 6, new Point(10, 92), new Size(114, 18), "Info of Selected:", autoSize: true, padding: new Padding(10, 20, 10, 0));
            savedProxiesLbl = new BaseLabel(_res, "savedProxiesLbl", 5, new Point(10, 20), new Size(107, 18), "Saved Proxies:", autoSize: true, padding: new Padding(10, 20, 3, 0));
            importProxiesLbl = new BaseLabel(_res, "importProxiesLbl", 1, new Point(18, 20), new Size(104, 18), "Import Proxies", autoSize: true, padding: new Padding(18, 20, 0, 0));
            ipAddyTxtBox = new BaseTextBox(_res, "ipAddyTxtBox", 1, new Point(40, 43), defTextBoxSize, padding: defTextBoxPadding);
            portTxtBox = new BaseTextBox(_res, "portTxtBox", 12, new Point(40, 109), defTextBoxSize, padding: defTextBoxPadding);
            uNameTxtBox = new BaseTextBox(_res, "uNameTxtBox", 3, new Point(40, 175), defTextBoxSize, padding: defTextBoxPadding);
            passTextBox = new BaseTextBox(_res, "passTextBox", 5, new Point(40, 241), defTextBoxSize, padding: defTextBoxPadding);
            authReqChckBox = new BaseCheckBox(_res, "authReqChckBox", true, "Authorization Required", new Point(40, 284), new Size(151, 19), margin: new Padding(40, 20, 3, 3), tabIndex: 10);
            savedProxiesCombBox = new BaseComboBox(_res, "savedProxiesCombBox", 1, new Point(10, 48), new Size(180, 21), new Padding(10, 10, 3, 3));
            proxyInfoTxtBox = new BaseRichTextBox(_res, "proxyInfoTxtBox", 0, SystemColors.MenuText, Color.GreenYellow, new Point(10, 120), new Size(200, 177), margin: new Padding(10, 10, 10, 3));
            #endregion

            #region Panels
            importProxiesPnl = new BaseFlowPanel(_res, new Control[] { importProxiesLbl, selectTextFileBtn, helpImportBtn }, new Point(12, 12), new Size(140, 498), "importProxiesPnl", 1, new object[] { BorderStyle.Fixed3D, FlowDirection.TopDown });
            savedProxiesPnl = new BaseFlowPanel(_res, new Control[] { savedProxiesLbl, savedProxiesCombBox, proxyInfoLbl, proxyInfoTxtBox, connectToSavedBtn, editSavedBtn, deleteSavedBtn }, new Point(158, 12), new Size(220, 498), "savedProxiesPnl", 1, new object[] { BorderStyle.Fixed3D, FlowDirection.TopDown });
            addNewProxyPnl = new BaseFlowPanel(_res, new Control[] { ipAddyLbl, ipAddyTxtBox, portLbl, portTxtBox, uNameLbl, uNameTxtBox, passLbl, passTextBox, authReqChckBox, saveProxyBtn, saveNConnectProxyBtn, proxyHelpBtn },
                new Point(384, 12), new Size(220, 498), "addNewProxyPnl", 0, new object[] { BorderStyle.Fixed3D, FlowDirection.TopDown });
            #endregion

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