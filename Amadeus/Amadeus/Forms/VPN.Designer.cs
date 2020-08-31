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

            selectConnBtn = new BaseButton(_res, "selectConnBtn", true, args: new object[] { null, new Point(60, 20), new Padding(60, 20, 0, 5), regularBtnSize, "Connect to Selected" });
            selectEditBtn = new BaseButton(_res, "selectEditBtn", true, args: new object[] { null, new Point(60, 58), defaultButtonPadding, regularBtnSize, "Edit" });
            selectRmvBtn = new BaseButton(_res, "selectRmvBtn", true, args: new object[] { null, new Point(60, 96), defaultButtonPadding, regularBtnSize, "Remove" });
            vpnHelpBtn = new BaseButton(_res, "vpnHelpBtn", true, 3, new object[] { null, new Point(100, 139), new Padding(100, 15, 0, 5), regularBtnSize, "Help!" });
            clearValsBtn = new BaseButton(_res, "clearValsBtn", true, 5, new object[] { null, new Point(132, 96), null, new Size(120, 23), "Clear Values" });
            saveConnBtn = new BaseButton(_res, "saveConnBtn", true, 3, new object[] { null, new Point(74, 136), null, largeBtnSize, "Save and Connect" });
            saveVpnNewBtn = new BaseButton(_res, "saveVpnNewBtn", true, 2, new object[] { null, new Point(), null, largeBtnSize, "Save New / Edited" });
            vpnsTxtBox = new BaseTextBox(_res, "vpnsTxtBox", 1, new Point(6, 57), new Size(135, 21));
            vpnNameTxtBox = new BaseTextBox(_res, "vpnNameTxtBox", 1, new Point(6, 57), new Size(135, 21));
            selectedInfoTxtBox = new BaseRichTextBox(_res, "selectedInfoTxtBox", 1, SystemColors.MenuText, Color.YellowGreen, new Point(6, 31), new Size(212, 134));
            selectedsLbl = new BaseLabel(_res, );
            currentVpnsLbl = new BaseLabel(_res, );
            nameVpnLbl = new BaseLabel(_res, );
            addressVpnLbl = new BaseLabel(_res, );
            ttypeVpnLbl = new BaseLabel(_res, );
            encryptLvlVpnLbl = new BaseLabel(_res, );
            authMetLbl = new BaseLabel(_res, );
            currentVpnsComBox = new BaseComboBox();
            tTypeSelectCombBox = new BaseComboBox(_res, );
            encrLvlCombBox = new BaseComboBox(_res, );
            authMetCombBox = new BaseComboBox(_res, );
            availForAllCheckBox = new BaseCheckBox(_res, );
            splitTunCheckBox = new BaseCheckBox(_res, );
            #endregion

            #region Panels
            bottomInfosPnl = new BaseFlowPanel(_res, new Control[] { currOpersPnl, currInfoPnl, currPnl }, new Point(12, 335), new Size(590, 175), "bottomInfosPnl", 2, BorderStyle.Fixed3D);
            currOpersPnl = new BaseFlowPanel(_res, new Control[] { selectConnBtn, selectEditBtn, selectRmvBtn, vpnHelpBtn }, new Point(383, 3), new Size(200, 170), "currOpersPnl", 6, new object[] { null, FlowDirection.TopDown });
            vpnSettingsPnl = new BaseFlowPanel(_res, );
            currInfoPnl = new Panel(_res, );
            currPnl = new Panel(_res, );
            namePnl = new Panel(_res, );
            addressPnl = new Panel(_res, );
            tunnelPnl = new Panel(_res, );
            encryptionPnl = new Panel(_res, );
            authPnl = new Panel(_res, );
            btnsTopPnl = new Panel(_res, );
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

        private void InitsplitTunCheckBox()
        {
            splitTunCheckBox.AutoSize = true;
            splitTunCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            splitTunCheckBox.Location = new System.Drawing.Point(6, 17);
            splitTunCheckBox.Name = "splitTunCheckBox";
            splitTunCheckBox.Size = new System.Drawing.Size(103, 22);
            splitTunCheckBox.TabIndex = 0;
            splitTunCheckBox.Text = "Split Tunnel";
            splitTunCheckBox.UseVisualStyleBackColor = true;
        }

        private void InitavailForAllCheckBox()
        {
            availForAllCheckBox.AutoSize = true;
            availForAllCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            availForAllCheckBox.Location = new System.Drawing.Point(6, 57);
            availForAllCheckBox.Name = "availForAllCheckBox";
            availForAllCheckBox.Size = new System.Drawing.Size(169, 22);
            availForAllCheckBox.TabIndex = 1;
            availForAllCheckBox.Text = "Available for All Users";
            availForAllCheckBox.UseVisualStyleBackColor = true;
        }







        private void InitbtnsTopPnl()
        {
            btnsTopPnl.Controls.Add(clearValsBtn);
            btnsTopPnl.Controls.Add(saveConnBtn);
            btnsTopPnl.Controls.Add(saveVpnNewBtn);
            btnsTopPnl.Controls.Add(availForAllCheckBox);
            btnsTopPnl.Controls.Add(splitTunCheckBox);
            btnsTopPnl.Location = new System.Drawing.Point(315, 109);
            btnsTopPnl.Name = "btnsTopPnl";
            btnsTopPnl.Size = new System.Drawing.Size(270, 197);
            btnsTopPnl.TabIndex = 5;
        }

        private void InitauthMetLbl()
        {
            authMetLbl.AutoSize = true;
            authMetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            authMetLbl.Location = new System.Drawing.Point(3, 29);
            authMetLbl.Name = "authMetLbl";
            authMetLbl.Size = new System.Drawing.Size(99, 18);
            authMetLbl.TabIndex = 0;
            authMetLbl.Text = "Auth. Method:";
        }

        private void InitauthMetCombBox()
        {
            authMetCombBox.FormattingEnabled = true;
            authMetCombBox.Items.AddRange(new object[] {
            "add t-type..."});
            authMetCombBox.Location = new System.Drawing.Point(6, 57);
            authMetCombBox.Name = "authMetCombBox";
            authMetCombBox.Size = new System.Drawing.Size(135, 21);
            authMetCombBox.TabIndex = 2;
        }

        private void InitauthPnl()
        {
            authPnl.Controls.Add(authMetCombBox);
            authPnl.Controls.Add(authMetLbl);
            authPnl.Location = new System.Drawing.Point(159, 109);
            authPnl.Name = "authPnl";
            authPnl.Size = new System.Drawing.Size(150, 100);
            authPnl.TabIndex = 4;
        }

        private void InitencryptLvlVpnLbl()
        {
            encryptLvlVpnLbl.AutoSize = true;
            encryptLvlVpnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            encryptLvlVpnLbl.Location = new System.Drawing.Point(3, 29);
            encryptLvlVpnLbl.Name = "encryptLvlVpnLbl";
            encryptLvlVpnLbl.Size = new System.Drawing.Size(120, 18);
            encryptLvlVpnLbl.TabIndex = 0;
            encryptLvlVpnLbl.Text = "Encryption Level:";
        }

        private void InitencrLvlCombBox()
        {
            encrLvlCombBox.FormattingEnabled = true;
            encrLvlCombBox.Items.AddRange(new object[] {
            "add t-type..."});
            encrLvlCombBox.Location = new System.Drawing.Point(6, 57);
            encrLvlCombBox.Name = "encrLvlCombBox";
            encrLvlCombBox.Size = new System.Drawing.Size(135, 21);
            encrLvlCombBox.TabIndex = 2;
        }

        private void InitencryptionPnl()
        {
            encryptionPnl.Controls.Add(encrLvlCombBox);
            encryptionPnl.Controls.Add(encryptLvlVpnLbl);
            encryptionPnl.Location = new System.Drawing.Point(3, 109);
            encryptionPnl.Name = "encryptionPnl";
            encryptionPnl.Size = new System.Drawing.Size(150, 100);
            encryptionPnl.TabIndex = 3;
        }

        private void InitttypeVpnLbl()
        {
            ttypeVpnLbl.AutoSize = true;
            ttypeVpnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ttypeVpnLbl.Location = new System.Drawing.Point(3, 29);
            ttypeVpnLbl.Name = "ttypeVpnLbl";
            ttypeVpnLbl.Size = new System.Drawing.Size(92, 18);
            ttypeVpnLbl.TabIndex = 0;
            ttypeVpnLbl.Text = "Tunnel Type:";
        }

        private void InittTypeSelectCombBox()
        {
            tTypeSelectCombBox.FormattingEnabled = true;
            tTypeSelectCombBox.Items.AddRange(new object[] {
            "add t-type..."});
            tTypeSelectCombBox.Location = new System.Drawing.Point(6, 57);
            tTypeSelectCombBox.Name = "tTypeSelectCombBox";
            tTypeSelectCombBox.Size = new System.Drawing.Size(135, 21);
            tTypeSelectCombBox.TabIndex = 1;
        }

        private void InittunnelPnl()
        {
            tunnelPnl.Controls.Add(tTypeSelectCombBox);
            tunnelPnl.Controls.Add(ttypeVpnLbl);
            tunnelPnl.Location = new System.Drawing.Point(315, 3);
            tunnelPnl.Name = "tunnelPnl";
            tunnelPnl.Size = new System.Drawing.Size(150, 100);
            tunnelPnl.TabIndex = 2;
        }

        private void InitaddressVpnLbl()
        {
            addressVpnLbl.AutoSize = true;
            addressVpnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressVpnLbl.Location = new System.Drawing.Point(3, 29);
            addressVpnLbl.Name = "addressVpnLbl";
            addressVpnLbl.Size = new System.Drawing.Size(66, 18);
            addressVpnLbl.TabIndex = 0;
            addressVpnLbl.Text = "Address:";
        }



        private void InitaddressPnl()
        {
            addressPnl.Controls.Add(vpnNameTxtBox);
            addressPnl.Controls.Add(addressVpnLbl);
            addressPnl.Location = new System.Drawing.Point(159, 3);
            addressPnl.Name = "addressPnl";
            addressPnl.Size = new System.Drawing.Size(150, 100);
            addressPnl.TabIndex = 0;
        }

        private void InitnameVpnLbl()
        {
            nameVpnLbl.AutoSize = true;
            nameVpnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameVpnLbl.Location = new System.Drawing.Point(3, 29);
            nameVpnLbl.Name = "nameVpnLbl";
            nameVpnLbl.Size = new System.Drawing.Size(52, 18);
            nameVpnLbl.TabIndex = 0;
            nameVpnLbl.Text = "Name:";
        }



        private void InitnamePnl()
        {
            namePnl.Controls.Add(vpnsTxtBox);
            namePnl.Controls.Add(nameVpnLbl);
            namePnl.Location = new System.Drawing.Point(3, 3);
            namePnl.Name = "namePnl";
            namePnl.Size = new System.Drawing.Size(150, 100);
            namePnl.TabIndex = 2;
        }

        private void InitvpnSettingsPnl()
        {
            vpnSettingsPnl.Controls.Add(namePnl);
            vpnSettingsPnl.Controls.Add(addressPnl);
            vpnSettingsPnl.Controls.Add(tunnelPnl);
            vpnSettingsPnl.Controls.Add(encryptionPnl);
            vpnSettingsPnl.Controls.Add(authPnl);
            vpnSettingsPnl.Controls.Add(btnsTopPnl);
            vpnSettingsPnl.Location = new System.Drawing.Point(12, 12);
            vpnSettingsPnl.Name = "vpnSettingsPnl";
            vpnSettingsPnl.Size = new System.Drawing.Size(590, 306);
            vpnSettingsPnl.TabIndex = 3;
        }

        private void InitcurrentVpnsLbl()
        {
            currentVpnsLbl.AutoSize = true;
            currentVpnsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentVpnsLbl.Location = new System.Drawing.Point(3, 29);
            currentVpnsLbl.Name = "currentVpnsLbl";
            currentVpnsLbl.Size = new System.Drawing.Size(103, 18);
            currentVpnsLbl.TabIndex = 0;
            currentVpnsLbl.Text = "Current VPNs:";
        }

        private void InitcurrentVpnsComBox()
        {
            currentVpnsComBox.FormattingEnabled = true;
            currentVpnsComBox.Items.AddRange(new object[] {
            "add t-type..."});
            currentVpnsComBox.Location = new System.Drawing.Point(6, 57);
            currentVpnsComBox.Name = "currentVpnsComBox";
            currentVpnsComBox.Size = new System.Drawing.Size(135, 21);
            currentVpnsComBox.TabIndex = 2;
        }

        private void InitcurrPnl()
        {
            currPnl.Controls.Add(currentVpnsComBox);
            currPnl.Controls.Add(currentVpnsLbl);
            currPnl.Location = new System.Drawing.Point(3, 3);
            currPnl.Name = "currPnl";
            currPnl.Size = new System.Drawing.Size(150, 170);
            currPnl.TabIndex = 4;
        }

        private void InitselectedsLbl()
        {
            selectedsLbl.AutoSize = true;
            selectedsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            selectedsLbl.Location = new System.Drawing.Point(3, 10);
            selectedsLbl.Name = "label2";
            selectedsLbl.Size = new System.Drawing.Size(108, 18);
            selectedsLbl.TabIndex = 0;
            selectedsLbl.Text = "Selected\'s Info:";
        }



        private void InitcurrInfoPnl()
        {
            currInfoPnl.Controls.Add(selectedInfoTxtBox);
            currInfoPnl.Controls.Add(selectedsLbl);
            currInfoPnl.Location = new System.Drawing.Point(150, 3);
            currInfoPnl.Name = "currInfoPnl";
            currInfoPnl.Size = new System.Drawing.Size(231, 170);
            currInfoPnl.TabIndex = 5;
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
        private System.Windows.Forms.ComboBox encrLvlCombBox;
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