using Amadeus.CustomControls;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Amadeus.Forms
{
    partial class Vpn
    {
        private readonly ComponentResourceManager _res = new ComponentResourceManager(typeof(Vpn));

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

        private void InitializeComponent()
        {
            #region Controls
            var regularBtnSize = new Size(80, 23);
            var largeBtnSize = new Size(120, 23);
            var defaultButtonPadding = new Padding(60, 10, 0, 5);
            var defTxtBoxPoint = new Point(6, 57);
            var defTxtBoxSize = new Size(135, 21);
            var defLblPoint = new Point(3, 29);
            var defComboPoint = new Point(6, 57);
            var defComboSize = new Size(135, 21);
            var defPanelSize = new Size(150, 100);

            selectConnBtn = new BaseButton(_res, "selectConnBtn", true, args: new object[] { default, new Point(60, 20), new Padding(60, 20, 0, 5), regularBtnSize, "Connect to Selected" });
            selectEditBtn = new BaseButton(_res, "selectEditBtn", true, args: new object[] { default, new Point(60, 58), defaultButtonPadding, regularBtnSize, "Edit" });
            selectRmvBtn = new BaseButton(_res, "selectRmvBtn", true, args: new object[] { default, new Point(60, 96), defaultButtonPadding, regularBtnSize, "Remove" });
            vpnHelpBtn = new BaseButton(_res, "vpnHelpBtn", true, 3, new object[] { default, new Point(100, 139), new Padding(100, 15, 0, 5), regularBtnSize, "Help!" });
            clearValsBtn = new BaseButton(_res, "clearValsBtn", true, 5, new object[] { default, new Point(132, 96), default, new Size(120, 23), "Clear Values" });
            saveConnBtn = new BaseButton(_res, "saveConnBtn", true, 3, new object[] { default, new Point(74, 136), default, largeBtnSize, "Save and Connect" });
            saveVpnNewBtn = new BaseButton(_res, "saveVpnNewBtn", true, 2, new object[] { default, new Point(), default, largeBtnSize, "Save New / Edited" });
            vpnsTxtBox = new BaseTextBox(_res, "vpnsTxtBox", 1, defTxtBoxPoint, defTxtBoxSize);
            vpnNameTxtBox = new BaseTextBox(_res, "vpnNameTxtBox", 1, defTxtBoxPoint, defTxtBoxSize);
            selectedInfoTxtBox = new BaseRichTextBox(_res, "selectedInfoTxtBox", 1, SystemColors.MenuText, Color.YellowGreen, new Point(6, 31), new Size(212, 134));
            selectedsLbl = new BaseLabel(_res, "selectedsLbl", 0, new Point(3, 10), new Size(108, 18), "Selected\'s Info:");
            currentVpnsLbl = new BaseLabel(_res, "currentVpnsLbl", 0, defLblPoint, new Size(103, 18), "Current VPNs:");
            nameVpnLbl = new BaseLabel(_res, "nameVpnLbl", 0, defLblPoint, new Size(52, 18), "Name:");
            addressVpnLbl = new BaseLabel(_res, "addressVpnLbl", 0, defLblPoint, new Size(66, 18), "Address:");
            ttypeVpnLbl = new BaseLabel(_res, "tTypeVpnLbl", 0, defLblPoint, new Size(92, 18), "Tunnel Type:");
            encryptLvlVpnLbl = new BaseLabel(_res, "encryptLvlVpnLbl", 0, defLblPoint, new Size(120, 18), "Encryption LEvel:");
            authMetLbl = new BaseLabel(_res, "authMetLbl", 0, defLblPoint, new Size(99, 18), "Auth. Method:");
            currentVpnsComBox = new BaseComboBox(_res, "currentVpnsCombox", 2, defComboPoint, defComboSize);
            tTypeSelectCombBox = new BaseComboBox(_res, "tTypeSelectComBox", 1, defComboPoint, defComboSize);
            encryLvlCombBox = new BaseComboBox(_res, "encrLvlComBox", 2, defComboPoint, defComboSize);
            authMetCombBox = new BaseComboBox(_res, "authMetComBox", 2, defComboPoint, defComboSize);
            availForAllCheckBox = new BaseCheckBox(_res, "availForAllCheckBox", true, "Available for All Users", new Point(5, 67), new Size(169, 22));
            splitTunCheckBox = new BaseCheckBox(_res, "splitTunCheckBox", true, "Split Tunnel:", new Point(6, 17), new Size(103, 22));
            #endregion

            #region Panels
            bottomInfosPnl = new BaseFlowPanel(_res, new Control[] { currOpersPnl, currInfoPnl, currPnl }, new Point(12, 335), new Size(590, 175), "bottomInfosPnl", 2, BorderStyle.Fixed3D);
            currOpersPnl = new BaseFlowPanel(_res, new Control[] { selectConnBtn, selectEditBtn, selectRmvBtn, vpnHelpBtn }, new Point(383, 3), new Size(200, 170), "currOpersPnl", 6, new object[] { default, FlowDirection.TopDown });
            vpnSettingsPnl = new BaseFlowPanel(_res, new Control[] { namePnl, addressPnl, tunnelPnl, encryptionPnl, authPnl, btnsTopPnl }, new Point(12, 12), new Size(590, 306), "vpnSettingsPnl", 3);
            currInfoPnl = new BasePanel(_res, "currInfoPnl", new Control[] { selectedInfoTxtBox, selectedsLbl }, new Point(150, 3), new Size(231, 170), 5);
            currPnl = new BasePanel(_res, "currPnl", new Control[] { currentVpnsComBox, currentVpnsLbl }, new Point(3, 3), new Size(150, 170), 4);
            namePnl = new BasePanel(_res, "namePnl", new Control[] { vpnsTxtBox, nameVpnLbl }, new Point(3, 3), defPanelSize, 2);
            addressPnl = new BasePanel(_res, "addressPnl", new Control[] { vpnNameTxtBox, addressVpnLbl }, new Point(159, 3), defPanelSize, 0);
            tunnelPnl = new BasePanel(_res, "tunnelPnl", new Control[] { tTypeSelectCombBox, ttypeVpnLbl }, new Point(315, 3), defPanelSize, 2);
            encryptionPnl = new BasePanel(_res, "encryptionPnl", new Control[] { encryLvlCombBox, encryptLvlVpnLbl }, new Point(3, 109), defPanelSize, 3);
            authPnl = new BasePanel(_res, "authPnl", new Control[] { authMetCombBox, authMetLbl }, new Point(159, 109), defPanelSize, 4);
            btnsTopPnl = new BasePanel(_res, "btnSopPnl", new Control[] { clearValsBtn, saveConnBtn, saveVpnNewBtn, availForAllCheckBox, splitTunCheckBox }, new Point(315, 109), new Size(270, 197), 5);
            #endregion

            SuspendLayout();
            InitVpnElements();

        }

        private void InitVpnElements()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new System.Drawing.Size(616, 522);
            ControlBox = false;
            Controls.Add(vpnSettingsPnl);
            Controls.Add(bottomInfosPnl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Vpn";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "VPN";
            bottomInfosPnl.ResumeLayout(false);
            currOpersPnl.ResumeLayout(false);
            currInfoPnl.ResumeLayout(false);
            currInfoPnl.PerformLayout();
            currPnl.ResumeLayout(false);
            currPnl.PerformLayout();
            vpnSettingsPnl.ResumeLayout(false);
            namePnl.ResumeLayout(false);
            namePnl.PerformLayout();
            addressPnl.ResumeLayout(false);
            addressPnl.PerformLayout();
            tunnelPnl.ResumeLayout(false);
            tunnelPnl.PerformLayout();
            encryptionPnl.ResumeLayout(false);
            encryptionPnl.PerformLayout();
            authPnl.ResumeLayout(false);
            authPnl.PerformLayout();
            btnsTopPnl.ResumeLayout(false);
            btnsTopPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel bottomInfosPnl;
        private System.Windows.Forms.FlowLayoutPanel vpnSettingsPnl;
        private System.Windows.Forms.Panel namePnl;
        private System.Windows.Forms.TextBox vpnsTxtBox;
        private System.Windows.Forms.Label nameVpnLbl;
        private System.Windows.Forms.Panel addressPnl;
        private System.Windows.Forms.TextBox vpnNameTxtBox;
        private System.Windows.Forms.Label addressVpnLbl;
        private System.Windows.Forms.Panel tunnelPnl;
        private System.Windows.Forms.Label ttypeVpnLbl;
        private System.Windows.Forms.Panel encryptionPnl;
        private System.Windows.Forms.Label encryptLvlVpnLbl;
        private System.Windows.Forms.Panel authPnl;
        private System.Windows.Forms.Label authMetLbl;
        private System.Windows.Forms.Panel btnsTopPnl;
        private System.Windows.Forms.CheckBox availForAllCheckBox;
        private System.Windows.Forms.CheckBox splitTunCheckBox;
        private System.Windows.Forms.Button clearValsBtn;
        private System.Windows.Forms.Button saveConnBtn;
        private System.Windows.Forms.Button saveVpnNewBtn;
        private System.Windows.Forms.ComboBox tTypeSelectCombBox;
        private System.Windows.Forms.ComboBox encryLvlCombBox;
        private System.Windows.Forms.ComboBox authMetCombBox;
        private System.Windows.Forms.FlowLayoutPanel currOpersPnl;
        private System.Windows.Forms.Button selectConnBtn;
        private System.Windows.Forms.Button selectEditBtn;
        private System.Windows.Forms.Button selectRmvBtn;
        private System.Windows.Forms.Button vpnHelpBtn;
        private System.Windows.Forms.Panel currInfoPnl;
        private System.Windows.Forms.RichTextBox selectedInfoTxtBox;
        private System.Windows.Forms.Label selectedsLbl;
        private System.Windows.Forms.Panel currPnl;
        private System.Windows.Forms.ComboBox currentVpnsComBox;
        private System.Windows.Forms.Label currentVpnsLbl;
    }
}