namespace Amadeus.Forms
{
    partial class Vpn
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
            this.bottomInfosPnl = new System.Windows.Forms.Panel();
            this.currOpersPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.selectConnBtn = new System.Windows.Forms.Button();
            this.selectEditBtn = new System.Windows.Forms.Button();
            this.selectRmvBtn = new System.Windows.Forms.Button();
            this.vpnHelpBtn = new System.Windows.Forms.Button();
            this.currInfoPnl = new System.Windows.Forms.Panel();
            this.selectedInfoTxtBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currPnl = new System.Windows.Forms.Panel();
            this.currentVpnsComBox = new System.Windows.Forms.ComboBox();
            this.currentVpnsLbl = new System.Windows.Forms.Label();
            this.vpnSettingsPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.namePnl = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.nameVpnLbl = new System.Windows.Forms.Label();
            this.addressPnl = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addressVpnLbl = new System.Windows.Forms.Label();
            this.tunnelPnl = new System.Windows.Forms.Panel();
            this.tTypeSelectCombBox = new System.Windows.Forms.ComboBox();
            this.ttypeVpnLbl = new System.Windows.Forms.Label();
            this.encryptionPnl = new System.Windows.Forms.Panel();
            this.encrLvlCombBox = new System.Windows.Forms.ComboBox();
            this.encryptLvlVpnLbl = new System.Windows.Forms.Label();
            this.authPnl = new System.Windows.Forms.Panel();
            this.authMetCombBox = new System.Windows.Forms.ComboBox();
            this.authMetLbl = new System.Windows.Forms.Label();
            this.btnsTopPnl = new System.Windows.Forms.Panel();
            this.clearValsBtn = new System.Windows.Forms.Button();
            this.saveConnBtn = new System.Windows.Forms.Button();
            this.saveVpnNewBtn = new System.Windows.Forms.Button();
            this.availForAllCheckBox = new System.Windows.Forms.CheckBox();
            this.splitTunCheckBox = new System.Windows.Forms.CheckBox();
            this.bottomInfosPnl.SuspendLayout();
            this.currOpersPnl.SuspendLayout();
            this.currInfoPnl.SuspendLayout();
            this.currPnl.SuspendLayout();
            this.vpnSettingsPnl.SuspendLayout();
            this.namePnl.SuspendLayout();
            this.addressPnl.SuspendLayout();
            this.tunnelPnl.SuspendLayout();
            this.encryptionPnl.SuspendLayout();
            this.authPnl.SuspendLayout();
            this.btnsTopPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomInfosPnl
            // 
            this.bottomInfosPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bottomInfosPnl.Controls.Add(this.currOpersPnl);
            this.bottomInfosPnl.Controls.Add(this.currInfoPnl);
            this.bottomInfosPnl.Controls.Add(this.currPnl);
            this.bottomInfosPnl.Location = new System.Drawing.Point(12, 335);
            this.bottomInfosPnl.Name = "bottomInfosPnl";
            this.bottomInfosPnl.Size = new System.Drawing.Size(590, 175);
            this.bottomInfosPnl.TabIndex = 2;
            // 
            // currOpersPnl
            // 
            this.currOpersPnl.Controls.Add(this.selectConnBtn);
            this.currOpersPnl.Controls.Add(this.selectEditBtn);
            this.currOpersPnl.Controls.Add(this.selectRmvBtn);
            this.currOpersPnl.Controls.Add(this.vpnHelpBtn);
            this.currOpersPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.currOpersPnl.Location = new System.Drawing.Point(383, 3);
            this.currOpersPnl.Name = "currOpersPnl";
            this.currOpersPnl.Size = new System.Drawing.Size(200, 170);
            this.currOpersPnl.TabIndex = 6;
            // 
            // selectConnBtn
            // 
            this.selectConnBtn.Location = new System.Drawing.Point(60, 20);
            this.selectConnBtn.Margin = new System.Windows.Forms.Padding(60, 20, 0, 5);
            this.selectConnBtn.Name = "selectConnBtn";
            this.selectConnBtn.Size = new System.Drawing.Size(80, 23);
            this.selectConnBtn.TabIndex = 0;
            this.selectConnBtn.Text = "Connect to Selected";
            this.selectConnBtn.UseVisualStyleBackColor = true;
            // 
            // selectEditBtn
            // 
            this.selectEditBtn.Location = new System.Drawing.Point(60, 58);
            this.selectEditBtn.Margin = new System.Windows.Forms.Padding(60, 10, 0, 5);
            this.selectEditBtn.Name = "selectEditBtn";
            this.selectEditBtn.Size = new System.Drawing.Size(80, 23);
            this.selectEditBtn.TabIndex = 1;
            this.selectEditBtn.Text = "Edit";
            this.selectEditBtn.UseVisualStyleBackColor = true;
            // 
            // selectRmvBtn
            // 
            this.selectRmvBtn.Location = new System.Drawing.Point(60, 96);
            this.selectRmvBtn.Margin = new System.Windows.Forms.Padding(60, 10, 0, 5);
            this.selectRmvBtn.Name = "selectRmvBtn";
            this.selectRmvBtn.Size = new System.Drawing.Size(80, 23);
            this.selectRmvBtn.TabIndex = 2;
            this.selectRmvBtn.Text = "Remove ";
            this.selectRmvBtn.UseVisualStyleBackColor = true;
            // 
            // vpnHelpBtn
            // 
            this.vpnHelpBtn.Location = new System.Drawing.Point(100, 139);
            this.vpnHelpBtn.Margin = new System.Windows.Forms.Padding(100, 15, 0, 5);
            this.vpnHelpBtn.Name = "vpnHelpBtn";
            this.vpnHelpBtn.Size = new System.Drawing.Size(80, 23);
            this.vpnHelpBtn.TabIndex = 3;
            this.vpnHelpBtn.Text = "Help!";
            this.vpnHelpBtn.UseVisualStyleBackColor = true;
            // 
            // currInfoPnl
            // 
            this.currInfoPnl.Controls.Add(this.selectedInfoTxtBox);
            this.currInfoPnl.Controls.Add(this.label2);
            this.currInfoPnl.Location = new System.Drawing.Point(150, 3);
            this.currInfoPnl.Name = "currInfoPnl";
            this.currInfoPnl.Size = new System.Drawing.Size(231, 170);
            this.currInfoPnl.TabIndex = 5;
            // 
            // selectedInfoTxtBox
            // 
            this.selectedInfoTxtBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.selectedInfoTxtBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.selectedInfoTxtBox.Location = new System.Drawing.Point(6, 31);
            this.selectedInfoTxtBox.Name = "selectedInfoTxtBox";
            this.selectedInfoTxtBox.Size = new System.Drawing.Size(212, 134);
            this.selectedInfoTxtBox.TabIndex = 1;
            this.selectedInfoTxtBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected\'s Info:";
            // 
            // currPnl
            // 
            this.currPnl.Controls.Add(this.currentVpnsComBox);
            this.currPnl.Controls.Add(this.currentVpnsLbl);
            this.currPnl.Location = new System.Drawing.Point(3, 3);
            this.currPnl.Name = "currPnl";
            this.currPnl.Size = new System.Drawing.Size(150, 170);
            this.currPnl.TabIndex = 4;
            // 
            // currentVpnsComBox
            // 
            this.currentVpnsComBox.FormattingEnabled = true;
            this.currentVpnsComBox.Items.AddRange(new object[] {
            "add t-type..."});
            this.currentVpnsComBox.Location = new System.Drawing.Point(6, 57);
            this.currentVpnsComBox.Name = "currentVpnsComBox";
            this.currentVpnsComBox.Size = new System.Drawing.Size(135, 21);
            this.currentVpnsComBox.TabIndex = 2;
            // 
            // currentVpnsLbl
            // 
            this.currentVpnsLbl.AutoSize = true;
            this.currentVpnsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentVpnsLbl.Location = new System.Drawing.Point(3, 29);
            this.currentVpnsLbl.Name = "currentVpnsLbl";
            this.currentVpnsLbl.Size = new System.Drawing.Size(103, 18);
            this.currentVpnsLbl.TabIndex = 0;
            this.currentVpnsLbl.Text = "Current VPNs:";
            // 
            // vpnSettingsPnl
            // 
            this.vpnSettingsPnl.Controls.Add(this.namePnl);
            this.vpnSettingsPnl.Controls.Add(this.addressPnl);
            this.vpnSettingsPnl.Controls.Add(this.tunnelPnl);
            this.vpnSettingsPnl.Controls.Add(this.encryptionPnl);
            this.vpnSettingsPnl.Controls.Add(this.authPnl);
            this.vpnSettingsPnl.Controls.Add(this.btnsTopPnl);
            this.vpnSettingsPnl.Location = new System.Drawing.Point(12, 12);
            this.vpnSettingsPnl.Name = "vpnSettingsPnl";
            this.vpnSettingsPnl.Size = new System.Drawing.Size(590, 306);
            this.vpnSettingsPnl.TabIndex = 3;
            // 
            // namePnl
            // 
            this.namePnl.Controls.Add(this.textBox4);
            this.namePnl.Controls.Add(this.nameVpnLbl);
            this.namePnl.Location = new System.Drawing.Point(3, 3);
            this.namePnl.Name = "namePnl";
            this.namePnl.Size = new System.Drawing.Size(150, 100);
            this.namePnl.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(6, 57);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 21);
            this.textBox4.TabIndex = 1;
            // 
            // nameVpnLbl
            // 
            this.nameVpnLbl.AutoSize = true;
            this.nameVpnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameVpnLbl.Location = new System.Drawing.Point(3, 29);
            this.nameVpnLbl.Name = "nameVpnLbl";
            this.nameVpnLbl.Size = new System.Drawing.Size(52, 18);
            this.nameVpnLbl.TabIndex = 0;
            this.nameVpnLbl.Text = "Name:";
            // 
            // addressPnl
            // 
            this.addressPnl.Controls.Add(this.textBox1);
            this.addressPnl.Controls.Add(this.addressVpnLbl);
            this.addressPnl.Location = new System.Drawing.Point(159, 3);
            this.addressPnl.Name = "addressPnl";
            this.addressPnl.Size = new System.Drawing.Size(150, 100);
            this.addressPnl.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 21);
            this.textBox1.TabIndex = 1;
            // 
            // addressVpnLbl
            // 
            this.addressVpnLbl.AutoSize = true;
            this.addressVpnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressVpnLbl.Location = new System.Drawing.Point(3, 29);
            this.addressVpnLbl.Name = "addressVpnLbl";
            this.addressVpnLbl.Size = new System.Drawing.Size(66, 18);
            this.addressVpnLbl.TabIndex = 0;
            this.addressVpnLbl.Text = "Address:";
            // 
            // tunnelPnl
            // 
            this.tunnelPnl.Controls.Add(this.tTypeSelectCombBox);
            this.tunnelPnl.Controls.Add(this.ttypeVpnLbl);
            this.tunnelPnl.Location = new System.Drawing.Point(315, 3);
            this.tunnelPnl.Name = "tunnelPnl";
            this.tunnelPnl.Size = new System.Drawing.Size(150, 100);
            this.tunnelPnl.TabIndex = 2;
            // 
            // tTypeSelectCombBox
            // 
            this.tTypeSelectCombBox.FormattingEnabled = true;
            this.tTypeSelectCombBox.Items.AddRange(new object[] {
            "add t-type..."});
            this.tTypeSelectCombBox.Location = new System.Drawing.Point(6, 57);
            this.tTypeSelectCombBox.Name = "tTypeSelectCombBox";
            this.tTypeSelectCombBox.Size = new System.Drawing.Size(135, 21);
            this.tTypeSelectCombBox.TabIndex = 1;
            // 
            // ttypeVpnLbl
            // 
            this.ttypeVpnLbl.AutoSize = true;
            this.ttypeVpnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttypeVpnLbl.Location = new System.Drawing.Point(3, 29);
            this.ttypeVpnLbl.Name = "ttypeVpnLbl";
            this.ttypeVpnLbl.Size = new System.Drawing.Size(92, 18);
            this.ttypeVpnLbl.TabIndex = 0;
            this.ttypeVpnLbl.Text = "Tunnel Type:";
            // 
            // encryptionPnl
            // 
            this.encryptionPnl.Controls.Add(this.encrLvlCombBox);
            this.encryptionPnl.Controls.Add(this.encryptLvlVpnLbl);
            this.encryptionPnl.Location = new System.Drawing.Point(3, 109);
            this.encryptionPnl.Name = "encryptionPnl";
            this.encryptionPnl.Size = new System.Drawing.Size(150, 100);
            this.encryptionPnl.TabIndex = 3;
            // 
            // encrLvlCombBox
            // 
            this.encrLvlCombBox.FormattingEnabled = true;
            this.encrLvlCombBox.Items.AddRange(new object[] {
            "add t-type..."});
            this.encrLvlCombBox.Location = new System.Drawing.Point(6, 57);
            this.encrLvlCombBox.Name = "encrLvlCombBox";
            this.encrLvlCombBox.Size = new System.Drawing.Size(135, 21);
            this.encrLvlCombBox.TabIndex = 2;
            // 
            // encryptLvlVpnLbl
            // 
            this.encryptLvlVpnLbl.AutoSize = true;
            this.encryptLvlVpnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptLvlVpnLbl.Location = new System.Drawing.Point(3, 29);
            this.encryptLvlVpnLbl.Name = "encryptLvlVpnLbl";
            this.encryptLvlVpnLbl.Size = new System.Drawing.Size(120, 18);
            this.encryptLvlVpnLbl.TabIndex = 0;
            this.encryptLvlVpnLbl.Text = "Encryption Level:";
            // 
            // authPnl
            // 
            this.authPnl.Controls.Add(this.authMetCombBox);
            this.authPnl.Controls.Add(this.authMetLbl);
            this.authPnl.Location = new System.Drawing.Point(159, 109);
            this.authPnl.Name = "authPnl";
            this.authPnl.Size = new System.Drawing.Size(150, 100);
            this.authPnl.TabIndex = 4;
            // 
            // authMetCombBox
            // 
            this.authMetCombBox.FormattingEnabled = true;
            this.authMetCombBox.Items.AddRange(new object[] {
            "add t-type..."});
            this.authMetCombBox.Location = new System.Drawing.Point(6, 57);
            this.authMetCombBox.Name = "authMetCombBox";
            this.authMetCombBox.Size = new System.Drawing.Size(135, 21);
            this.authMetCombBox.TabIndex = 2;
            // 
            // authMetLbl
            // 
            this.authMetLbl.AutoSize = true;
            this.authMetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authMetLbl.Location = new System.Drawing.Point(3, 29);
            this.authMetLbl.Name = "authMetLbl";
            this.authMetLbl.Size = new System.Drawing.Size(99, 18);
            this.authMetLbl.TabIndex = 0;
            this.authMetLbl.Text = "Auth. Method:";
            // 
            // btnsTopPnl
            // 
            this.btnsTopPnl.Controls.Add(this.clearValsBtn);
            this.btnsTopPnl.Controls.Add(this.saveConnBtn);
            this.btnsTopPnl.Controls.Add(this.saveVpnNewBtn);
            this.btnsTopPnl.Controls.Add(this.availForAllCheckBox);
            this.btnsTopPnl.Controls.Add(this.splitTunCheckBox);
            this.btnsTopPnl.Location = new System.Drawing.Point(315, 109);
            this.btnsTopPnl.Name = "btnsTopPnl";
            this.btnsTopPnl.Size = new System.Drawing.Size(270, 197);
            this.btnsTopPnl.TabIndex = 5;
            // 
            // clearValsBtn
            // 
            this.clearValsBtn.Location = new System.Drawing.Point(132, 96);
            this.clearValsBtn.Name = "clearValsBtn";
            this.clearValsBtn.Size = new System.Drawing.Size(120, 23);
            this.clearValsBtn.TabIndex = 5;
            this.clearValsBtn.Text = "Clear Values";
            this.clearValsBtn.UseVisualStyleBackColor = true;
            // 
            // saveConnBtn
            // 
            this.saveConnBtn.Location = new System.Drawing.Point(74, 136);
            this.saveConnBtn.Name = "saveConnBtn";
            this.saveConnBtn.Size = new System.Drawing.Size(120, 23);
            this.saveConnBtn.TabIndex = 3;
            this.saveConnBtn.Text = "Save and Connect";
            this.saveConnBtn.UseVisualStyleBackColor = true;
            // 
            // saveVpnNewBtn
            // 
            this.saveVpnNewBtn.Location = new System.Drawing.Point(6, 96);
            this.saveVpnNewBtn.Name = "saveVpnNewBtn";
            this.saveVpnNewBtn.Size = new System.Drawing.Size(120, 23);
            this.saveVpnNewBtn.TabIndex = 2;
            this.saveVpnNewBtn.Text = "Save New / Edited";
            this.saveVpnNewBtn.UseVisualStyleBackColor = true;
            // 
            // availForAllCheckBox
            // 
            this.availForAllCheckBox.AutoSize = true;
            this.availForAllCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availForAllCheckBox.Location = new System.Drawing.Point(6, 57);
            this.availForAllCheckBox.Name = "availForAllCheckBox";
            this.availForAllCheckBox.Size = new System.Drawing.Size(169, 22);
            this.availForAllCheckBox.TabIndex = 1;
            this.availForAllCheckBox.Text = "Available for All Users";
            this.availForAllCheckBox.UseVisualStyleBackColor = true;
            // 
            // splitTunCheckBox
            // 
            this.splitTunCheckBox.AutoSize = true;
            this.splitTunCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitTunCheckBox.Location = new System.Drawing.Point(6, 17);
            this.splitTunCheckBox.Name = "splitTunCheckBox";
            this.splitTunCheckBox.Size = new System.Drawing.Size(103, 22);
            this.splitTunCheckBox.TabIndex = 0;
            this.splitTunCheckBox.Text = "Split Tunnel";
            this.splitTunCheckBox.UseVisualStyleBackColor = true;
            // 
            // Vpn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(616, 522);
            this.ControlBox = false;
            this.Controls.Add(this.vpnSettingsPnl);
            this.Controls.Add(this.bottomInfosPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vpn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VPN";
            this.bottomInfosPnl.ResumeLayout(false);
            this.currOpersPnl.ResumeLayout(false);
            this.currInfoPnl.ResumeLayout(false);
            this.currInfoPnl.PerformLayout();
            this.currPnl.ResumeLayout(false);
            this.currPnl.PerformLayout();
            this.vpnSettingsPnl.ResumeLayout(false);
            this.namePnl.ResumeLayout(false);
            this.namePnl.PerformLayout();
            this.addressPnl.ResumeLayout(false);
            this.addressPnl.PerformLayout();
            this.tunnelPnl.ResumeLayout(false);
            this.tunnelPnl.PerformLayout();
            this.encryptionPnl.ResumeLayout(false);
            this.encryptionPnl.PerformLayout();
            this.authPnl.ResumeLayout(false);
            this.authPnl.PerformLayout();
            this.btnsTopPnl.ResumeLayout(false);
            this.btnsTopPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel bottomInfosPnl;
        private System.Windows.Forms.FlowLayoutPanel vpnSettingsPnl;
        private System.Windows.Forms.Panel namePnl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label nameVpnLbl;
        private System.Windows.Forms.Panel addressPnl;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel currPnl;
        private System.Windows.Forms.ComboBox currentVpnsComBox;
        private System.Windows.Forms.Label currentVpnsLbl;
    }
}