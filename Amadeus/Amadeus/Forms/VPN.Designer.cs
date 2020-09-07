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

            selectConnBtn = new BaseButton(_res, "selectConnBtn", visStyleBackColor: true, point: new Point(60, 20), margin: new Padding(60, 20, 0, 5), size: regularBtnSize, text: "Connect to Selected");
            selectEditBtn = new BaseButton(_res, "selectEditBtn", visStyleBackColor: true, point: new Point(60, 58), margin: defaultButtonPadding, size: regularBtnSize, text: "Edit");
            selectRmvBtn = new BaseButton(_res, "selectRmvBtn", visStyleBackColor: true, point: new Point(60, 96), margin: defaultButtonPadding, size: regularBtnSize, text: "Remove");
            vpnHelpBtn = new BaseButton(_res, "vpnHelpBtn", 3, visStyleBackColor: true, point: new Point(100, 139), margin: new Padding(100, 15, 0, 5), size: regularBtnSize, text: "Help!");
            clearValsBtn = new BaseButton(_res, "clearValsBtn", 5, visStyleBackColor: true, point: new Point(132, 96), size: new Size(120, 23), text: "Clear Values");
            saveConnBtn = new BaseButton(_res, "saveConnBtn", 3, visStyleBackColor: true, point: new Point(74, 136), size: largeBtnSize, text: "Save and Connect");
            saveVpnNewBtn = new BaseButton(_res, "saveVpnNewBtn", visStyleBackColor: true, point: new Point(6, 96), size: largeBtnSize, text: "Save New / Edited");
            vpnsTxtBox = new BaseTextBox(_res, "vpnsTxtBox", 1, defTxtBoxPoint, defTxtBoxSize);
            vpnNameTxtBox = new BaseTextBox(_res, "vpnNameTxtBox", 1, defTxtBoxPoint, defTxtBoxSize);
            selectedInfoTxtBox = new BaseRichTextBox(_res, "selectedInfoTxtBox", 1, SystemColors.MenuText, Color.YellowGreen, new Point(6, 31), new Size(212, 134));
            selectedsLbl = new BaseLabel(_res, "selectedsLbl", point: new Point(3, 10), size: new Size(108, 18), text: "Selected\'s Info:");
            currentVpnsLbl = new BaseLabel(_res, "currentVpnsLbl", point: defLblPoint, size: new Size(103, 18), text: "Current VPNs:");
            nameVpnLbl = new BaseLabel(_res, "nameVpnLbl", point: defLblPoint, size: new Size(52, 18), text: "Name:");
            addressVpnLbl = new BaseLabel(_res, "addressVpnLbl", point: defLblPoint, size: new Size(66, 18), text: "Address:");
            ttypeVpnLbl = new BaseLabel(_res, "tTypeVpnLbl", point: defLblPoint, size: new Size(92, 18), text: "Tunnel Type:");
            encryptLvlVpnLbl = new BaseLabel(_res, "encryptLvlVpnLbl", point: defLblPoint, size: new Size(120, 18), text: "Encryption LEvel:");
            authMetLbl = new BaseLabel(_res, "authMetLbl", point: defLblPoint, size: new Size(99, 18), text: "Auth. Method:");
            currentVpnsComBox = new BaseComboBox(_res, "currentVpnsCombox", 2, defComboPoint, defComboSize);
            tTypeSelectCombBox = new BaseComboBox(_res, "tTypeSelectComBox", 1, defComboPoint, defComboSize);
            encryLvlCombBox = new BaseComboBox(_res, "encrLvlComBox", 2, defComboPoint, defComboSize);
            authMetCombBox = new BaseComboBox(_res, "authMetComBox", 2, defComboPoint, defComboSize);
            availForAllCheckBox = new BaseCheckBox(_res, "availForAllCheckBox", visStyleBackColor: true, text: "Available for All Users", point: new Point(5, 67), size: new Size(169, 22));
            splitTunCheckBox = new BaseCheckBox(_res, "splitTunCheckBox", visStyleBackColor: true, text: "Split Tunnel:", point: new Point(6, 17), size: new Size(103, 22));
            #endregion

            #region Panels
            bottomInfosPnl = new BaseFlowPanel(_res, "bottomInfosPnl", 2, new Control[] { currOpersPnl, currInfoPnl, currPnl }, new Point(12, 335), new Size(590, 175), borderStyle: BorderStyle.Fixed3D);
            currOpersPnl = new BaseFlowPanel(_res, "currOpersPnl", 6, new Control[] { selectConnBtn, selectEditBtn, selectRmvBtn, vpnHelpBtn }, new Point(383, 3), new Size(200, 170), flow: FlowDirection.TopDown);
            vpnSettingsPnl = new BaseFlowPanel(_res, "vpnSettingsPnl", 3, new Control[] { namePnl, addressPnl, tunnelPnl, encryptionPnl, authPnl, btnsTopPnl }, new Point(12, 12), new Size(590, 306));
            currInfoPnl = new BasePanel(_res, "currInfoPnl", 5, new Control[] { selectedInfoTxtBox, selectedsLbl }, new Point(150, 3), new Size(231, 170));
            currPnl = new BasePanel(_res, "currPnl", 4, new Control[] { currentVpnsComBox, currentVpnsLbl }, new Point(3, 3), new Size(150, 170));
            namePnl = new BasePanel(_res, "namePnl", 2, new Control[] { vpnsTxtBox, nameVpnLbl }, new Point(3, 3), defPanelSize);
            addressPnl = new BasePanel(_res, "addressPnl", 0, new Control[] { vpnNameTxtBox, addressVpnLbl }, new Point(159, 3), defPanelSize);
            tunnelPnl = new BasePanel(_res, "tunnelPnl", 2, new Control[] { tTypeSelectCombBox, ttypeVpnLbl }, new Point(315, 3), defPanelSize);
            encryptionPnl = new BasePanel(_res, "encryptionPnl", 3, new Control[] { encryLvlCombBox, encryptLvlVpnLbl }, new Point(3, 109), defPanelSize);
            authPnl = new BasePanel(_res, "authPnl", 4, new Control[] { authMetCombBox, authMetLbl }, new Point(159, 109), defPanelSize);
            btnsTopPnl = new BasePanel(_res, "btnSopPnl", 5, new Control[] { clearValsBtn, saveConnBtn, saveVpnNewBtn, availForAllCheckBox, splitTunCheckBox }, new Point(315, 109), new Size(270, 197));
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