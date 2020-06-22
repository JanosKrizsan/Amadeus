namespace Amadeus.Views
{
    partial class RDP
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentRdpsPnl = new System.Windows.Forms.Panel();
            this.onlyRdpFilesRdio = new System.Windows.Forms.RadioButton();
            this.savedRdpsLbl = new System.Windows.Forms.Label();
            this.savedRdpsResults = new System.Windows.Forms.ComboBox();
            this.refreshRdpsBtn = new System.Windows.Forms.Button();
            this.connectCrntBtn = new System.Windows.Forms.Button();
            this.delCrntBtn = new System.Windows.Forms.Button();
            this.editCrntBtn = new System.Windows.Forms.Button();
            this.isMstcRunningImgBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connLbl = new System.Windows.Forms.Label();
            this.connTxtBox = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.portTxtBox = new System.Windows.Forms.TextBox();
            this.gatewayLbl = new System.Windows.Forms.Label();
            this.gatewTxtBox = new System.Windows.Forms.TextBox();
            this.useGatewayChckBox = new System.Windows.Forms.CheckBox();
            this.asAdminChckBox = new System.Windows.Forms.CheckBox();
            this.remGuardChckBox = new System.Windows.Forms.CheckBox();
            this.restrictedAdminChckBox = new System.Windows.Forms.CheckBox();
            this.screenSettingsHolderPnl = new System.Windows.Forms.Panel();
            this.screenSettingsPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.fullscreenChckBox = new System.Windows.Forms.CheckBox();
            this.multiMonitorChckBox = new System.Windows.Forms.CheckBox();
            this.spanMonitorsChckBox = new System.Windows.Forms.CheckBox();
            this.screenWidthLbl = new System.Windows.Forms.Label();
            this.screenWidthTxtBox = new System.Windows.Forms.TextBox();
            this.screenHeightLbl = new System.Windows.Forms.Label();
            this.screenHeightTxtBox = new System.Windows.Forms.TextBox();
            this.saveNUpdtBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.connGivenBtn = new System.Windows.Forms.Button();
            this.screenSettingsHelpBtn = new System.Windows.Forms.Button();
            this.saveToXmlBtn = new System.Windows.Forms.Button();
            this.rdpCredsHelpBtn = new System.Windows.Forms.Button();
            this.recheckConnBtn = new System.Windows.Forms.Button();
            this.saveToRdpFileBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.currentRdpsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isMstcRunningImgBox)).BeginInit();
            this.screenSettingsHolderPnl.SuspendLayout();
            this.screenSettingsPnl.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.connLbl);
            this.flowLayoutPanel1.Controls.Add(this.connTxtBox);
            this.flowLayoutPanel1.Controls.Add(this.addressLbl);
            this.flowLayoutPanel1.Controls.Add(this.addressTxtBox);
            this.flowLayoutPanel1.Controls.Add(this.portLbl);
            this.flowLayoutPanel1.Controls.Add(this.portTxtBox);
            this.flowLayoutPanel1.Controls.Add(this.gatewayLbl);
            this.flowLayoutPanel1.Controls.Add(this.gatewTxtBox);
            this.flowLayoutPanel1.Controls.Add(this.useGatewayChckBox);
            this.flowLayoutPanel1.Controls.Add(this.asAdminChckBox);
            this.flowLayoutPanel1.Controls.Add(this.remGuardChckBox);
            this.flowLayoutPanel1.Controls.Add(this.restrictedAdminChckBox);
            this.flowLayoutPanel1.Controls.Add(this.rdpCredsHelpBtn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 498);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // currentRdpsPnl
            // 
            this.currentRdpsPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentRdpsPnl.Controls.Add(this.recheckConnBtn);
            this.currentRdpsPnl.Controls.Add(this.label1);
            this.currentRdpsPnl.Controls.Add(this.isMstcRunningImgBox);
            this.currentRdpsPnl.Controls.Add(this.editCrntBtn);
            this.currentRdpsPnl.Controls.Add(this.delCrntBtn);
            this.currentRdpsPnl.Controls.Add(this.connectCrntBtn);
            this.currentRdpsPnl.Controls.Add(this.refreshRdpsBtn);
            this.currentRdpsPnl.Controls.Add(this.savedRdpsResults);
            this.currentRdpsPnl.Controls.Add(this.savedRdpsLbl);
            this.currentRdpsPnl.Controls.Add(this.onlyRdpFilesRdio);
            this.currentRdpsPnl.Location = new System.Drawing.Point(276, 12);
            this.currentRdpsPnl.Name = "currentRdpsPnl";
            this.currentRdpsPnl.Size = new System.Drawing.Size(327, 264);
            this.currentRdpsPnl.TabIndex = 3;
            // 
            // onlyRdpFilesRdio
            // 
            this.onlyRdpFilesRdio.AutoSize = true;
            this.onlyRdpFilesRdio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyRdpFilesRdio.Location = new System.Drawing.Point(173, 25);
            this.onlyRdpFilesRdio.Name = "onlyRdpFilesRdio";
            this.onlyRdpFilesRdio.Size = new System.Drawing.Size(125, 21);
            this.onlyRdpFilesRdio.TabIndex = 0;
            this.onlyRdpFilesRdio.TabStop = true;
            this.onlyRdpFilesRdio.Text = "Only .RDP Files";
            this.onlyRdpFilesRdio.UseVisualStyleBackColor = true;
            // 
            // savedRdpsLbl
            // 
            this.savedRdpsLbl.AutoSize = true;
            this.savedRdpsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedRdpsLbl.Location = new System.Drawing.Point(31, 28);
            this.savedRdpsLbl.Name = "savedRdpsLbl";
            this.savedRdpsLbl.Size = new System.Drawing.Size(97, 18);
            this.savedRdpsLbl.TabIndex = 1;
            this.savedRdpsLbl.Text = "Saved RDPs:";
            // 
            // savedRdpsResults
            // 
            this.savedRdpsResults.FormattingEnabled = true;
            this.savedRdpsResults.Location = new System.Drawing.Point(33, 59);
            this.savedRdpsResults.Name = "savedRdpsResults";
            this.savedRdpsResults.Size = new System.Drawing.Size(181, 21);
            this.savedRdpsResults.TabIndex = 2;
            // 
            // refreshRdpsBtn
            // 
            this.refreshRdpsBtn.Location = new System.Drawing.Point(237, 57);
            this.refreshRdpsBtn.Name = "refreshRdpsBtn";
            this.refreshRdpsBtn.Size = new System.Drawing.Size(60, 23);
            this.refreshRdpsBtn.TabIndex = 3;
            this.refreshRdpsBtn.Text = "Refresh";
            this.refreshRdpsBtn.UseVisualStyleBackColor = true;
            // 
            // connectCrntBtn
            // 
            this.connectCrntBtn.Location = new System.Drawing.Point(33, 129);
            this.connectCrntBtn.Name = "connectCrntBtn";
            this.connectCrntBtn.Size = new System.Drawing.Size(75, 23);
            this.connectCrntBtn.TabIndex = 4;
            this.connectCrntBtn.Text = "Connect To";
            this.connectCrntBtn.UseVisualStyleBackColor = true;
            // 
            // delCrntBtn
            // 
            this.delCrntBtn.Location = new System.Drawing.Point(33, 161);
            this.delCrntBtn.Name = "delCrntBtn";
            this.delCrntBtn.Size = new System.Drawing.Size(75, 23);
            this.delCrntBtn.TabIndex = 5;
            this.delCrntBtn.Text = "Delete";
            this.delCrntBtn.UseVisualStyleBackColor = true;
            // 
            // editCrntBtn
            // 
            this.editCrntBtn.Location = new System.Drawing.Point(33, 190);
            this.editCrntBtn.Name = "editCrntBtn";
            this.editCrntBtn.Size = new System.Drawing.Size(75, 23);
            this.editCrntBtn.TabIndex = 6;
            this.editCrntBtn.Text = "Edit";
            this.editCrntBtn.UseVisualStyleBackColor = true;
            // 
            // isMstcRunningImgBox
            // 
            this.isMstcRunningImgBox.Location = new System.Drawing.Point(191, 161);
            this.isMstcRunningImgBox.Name = "isMstcRunningImgBox";
            this.isMstcRunningImgBox.Size = new System.Drawing.Size(106, 90);
            this.isMstcRunningImgBox.TabIndex = 7;
            this.isMstcRunningImgBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Connection Status:";
            // 
            // connLbl
            // 
            this.connLbl.AutoSize = true;
            this.connLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connLbl.Location = new System.Drawing.Point(30, 30);
            this.connLbl.Margin = new System.Windows.Forms.Padding(30, 30, 3, 0);
            this.connLbl.Name = "connLbl";
            this.connLbl.Size = new System.Drawing.Size(124, 17);
            this.connLbl.TabIndex = 0;
            this.connLbl.Text = "Connection Name:";
            // 
            // connTxtBox
            // 
            this.connTxtBox.Location = new System.Drawing.Point(30, 52);
            this.connTxtBox.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            this.connTxtBox.Name = "connTxtBox";
            this.connTxtBox.Size = new System.Drawing.Size(120, 20);
            this.connTxtBox.TabIndex = 1;
            this.connTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(30, 90);
            this.addressLbl.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(110, 17);
            this.addressLbl.TabIndex = 2;
            this.addressLbl.Text = "Server Address:";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(30, 112);
            this.addressTxtBox.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(120, 20);
            this.addressTxtBox.TabIndex = 3;
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLbl.Location = new System.Drawing.Point(30, 150);
            this.portLbl.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(84, 17);
            this.portLbl.TabIndex = 4;
            this.portLbl.Text = "Server Port:";
            // 
            // portTxtBox
            // 
            this.portTxtBox.Location = new System.Drawing.Point(30, 172);
            this.portTxtBox.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            this.portTxtBox.Name = "portTxtBox";
            this.portTxtBox.Size = new System.Drawing.Size(120, 20);
            this.portTxtBox.TabIndex = 5;
            // 
            // gatewayLbl
            // 
            this.gatewayLbl.AutoSize = true;
            this.gatewayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gatewayLbl.Location = new System.Drawing.Point(30, 210);
            this.gatewayLbl.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            this.gatewayLbl.Name = "gatewayLbl";
            this.gatewayLbl.Size = new System.Drawing.Size(67, 17);
            this.gatewayLbl.TabIndex = 6;
            this.gatewayLbl.Text = "Gateway:";
            // 
            // gatewTxtBox
            // 
            this.gatewTxtBox.Location = new System.Drawing.Point(30, 232);
            this.gatewTxtBox.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            this.gatewTxtBox.Name = "gatewTxtBox";
            this.gatewTxtBox.Size = new System.Drawing.Size(120, 20);
            this.gatewTxtBox.TabIndex = 7;
            // 
            // useGatewayChckBox
            // 
            this.useGatewayChckBox.AutoSize = true;
            this.useGatewayChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useGatewayChckBox.Location = new System.Drawing.Point(30, 285);
            this.useGatewayChckBox.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            this.useGatewayChckBox.Name = "useGatewayChckBox";
            this.useGatewayChckBox.Size = new System.Drawing.Size(98, 19);
            this.useGatewayChckBox.TabIndex = 8;
            this.useGatewayChckBox.Text = "Use Gateway";
            this.useGatewayChckBox.UseVisualStyleBackColor = true;
            // 
            // asAdminChckBox
            // 
            this.asAdminChckBox.AutoSize = true;
            this.asAdminChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asAdminChckBox.Location = new System.Drawing.Point(30, 317);
            this.asAdminChckBox.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.asAdminChckBox.Name = "asAdminChckBox";
            this.asAdminChckBox.Size = new System.Drawing.Size(77, 19);
            this.asAdminChckBox.TabIndex = 9;
            this.asAdminChckBox.Text = "As Admin";
            this.asAdminChckBox.UseVisualStyleBackColor = true;
            // 
            // remGuardChckBox
            // 
            this.remGuardChckBox.AutoSize = true;
            this.remGuardChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remGuardChckBox.Location = new System.Drawing.Point(30, 349);
            this.remGuardChckBox.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.remGuardChckBox.Name = "remGuardChckBox";
            this.remGuardChckBox.Size = new System.Drawing.Size(107, 19);
            this.remGuardChckBox.TabIndex = 10;
            this.remGuardChckBox.Text = "Remote Guard";
            this.remGuardChckBox.UseVisualStyleBackColor = true;
            // 
            // restrictedAdminChckBox
            // 
            this.restrictedAdminChckBox.AutoSize = true;
            this.restrictedAdminChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restrictedAdminChckBox.Location = new System.Drawing.Point(30, 381);
            this.restrictedAdminChckBox.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.restrictedAdminChckBox.Name = "restrictedAdminChckBox";
            this.restrictedAdminChckBox.Size = new System.Drawing.Size(135, 19);
            this.restrictedAdminChckBox.TabIndex = 15;
            this.restrictedAdminChckBox.Text = "As Restricted Admin";
            this.restrictedAdminChckBox.UseVisualStyleBackColor = true;
            // 
            // screenSettingsHolderPnl
            // 
            this.screenSettingsHolderPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenSettingsHolderPnl.Controls.Add(this.flowLayoutPanel3);
            this.screenSettingsHolderPnl.Controls.Add(this.screenSettingsPnl);
            this.screenSettingsHolderPnl.Location = new System.Drawing.Point(276, 285);
            this.screenSettingsHolderPnl.Name = "screenSettingsHolderPnl";
            this.screenSettingsHolderPnl.Size = new System.Drawing.Size(328, 225);
            this.screenSettingsHolderPnl.TabIndex = 4;
            // 
            // screenSettingsPnl
            // 
            this.screenSettingsPnl.Controls.Add(this.fullscreenChckBox);
            this.screenSettingsPnl.Controls.Add(this.multiMonitorChckBox);
            this.screenSettingsPnl.Controls.Add(this.spanMonitorsChckBox);
            this.screenSettingsPnl.Controls.Add(this.screenWidthLbl);
            this.screenSettingsPnl.Controls.Add(this.screenWidthTxtBox);
            this.screenSettingsPnl.Controls.Add(this.screenHeightLbl);
            this.screenSettingsPnl.Controls.Add(this.screenHeightTxtBox);
            this.screenSettingsPnl.Location = new System.Drawing.Point(3, 3);
            this.screenSettingsPnl.Name = "screenSettingsPnl";
            this.screenSettingsPnl.Size = new System.Drawing.Size(164, 215);
            this.screenSettingsPnl.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.saveNUpdtBtn);
            this.flowLayoutPanel3.Controls.Add(this.saveToRdpFileBtn);
            this.flowLayoutPanel3.Controls.Add(this.saveToXmlBtn);
            this.flowLayoutPanel3.Controls.Add(this.connGivenBtn);
            this.flowLayoutPanel3.Controls.Add(this.resetBtn);
            this.flowLayoutPanel3.Controls.Add(this.screenSettingsHelpBtn);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(173, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(148, 215);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // fullscreenChckBox
            // 
            this.fullscreenChckBox.AutoSize = true;
            this.fullscreenChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullscreenChckBox.Location = new System.Drawing.Point(10, 15);
            this.fullscreenChckBox.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.fullscreenChckBox.Name = "fullscreenChckBox";
            this.fullscreenChckBox.Size = new System.Drawing.Size(111, 19);
            this.fullscreenChckBox.TabIndex = 19;
            this.fullscreenChckBox.Text = "Start Fullscreen";
            this.fullscreenChckBox.UseVisualStyleBackColor = true;
            // 
            // multiMonitorChckBox
            // 
            this.multiMonitorChckBox.AutoSize = true;
            this.multiMonitorChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiMonitorChckBox.Location = new System.Drawing.Point(10, 40);
            this.multiMonitorChckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.multiMonitorChckBox.Name = "multiMonitorChckBox";
            this.multiMonitorChckBox.Size = new System.Drawing.Size(133, 19);
            this.multiMonitorChckBox.TabIndex = 20;
            this.multiMonitorChckBox.Text = "Multi Monitor Mode";
            this.multiMonitorChckBox.UseVisualStyleBackColor = true;
            // 
            // spanMonitorsChckBox
            // 
            this.spanMonitorsChckBox.AutoSize = true;
            this.spanMonitorsChckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spanMonitorsChckBox.Location = new System.Drawing.Point(10, 65);
            this.spanMonitorsChckBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.spanMonitorsChckBox.Name = "spanMonitorsChckBox";
            this.spanMonitorsChckBox.Size = new System.Drawing.Size(141, 19);
            this.spanMonitorsChckBox.TabIndex = 21;
            this.spanMonitorsChckBox.Text = "Span Monitors Mode";
            this.spanMonitorsChckBox.UseVisualStyleBackColor = true;
            // 
            // screenWidthLbl
            // 
            this.screenWidthLbl.AutoSize = true;
            this.screenWidthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenWidthLbl.Location = new System.Drawing.Point(20, 102);
            this.screenWidthLbl.Margin = new System.Windows.Forms.Padding(20, 15, 3, 0);
            this.screenWidthLbl.Name = "screenWidthLbl";
            this.screenWidthLbl.Size = new System.Drawing.Size(97, 17);
            this.screenWidthLbl.TabIndex = 22;
            this.screenWidthLbl.Text = "Screen Width:";
            // 
            // screenWidthTxtBox
            // 
            this.screenWidthTxtBox.Location = new System.Drawing.Point(20, 124);
            this.screenWidthTxtBox.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.screenWidthTxtBox.Name = "screenWidthTxtBox";
            this.screenWidthTxtBox.Size = new System.Drawing.Size(105, 20);
            this.screenWidthTxtBox.TabIndex = 23;
            // 
            // screenHeightLbl
            // 
            this.screenHeightLbl.AutoSize = true;
            this.screenHeightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenHeightLbl.Location = new System.Drawing.Point(20, 162);
            this.screenHeightLbl.Margin = new System.Windows.Forms.Padding(20, 15, 3, 0);
            this.screenHeightLbl.Name = "screenHeightLbl";
            this.screenHeightLbl.Size = new System.Drawing.Size(102, 17);
            this.screenHeightLbl.TabIndex = 24;
            this.screenHeightLbl.Text = "Screen Height:";
            // 
            // screenHeightTxtBox
            // 
            this.screenHeightTxtBox.Location = new System.Drawing.Point(20, 184);
            this.screenHeightTxtBox.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.screenHeightTxtBox.Name = "screenHeightTxtBox";
            this.screenHeightTxtBox.Size = new System.Drawing.Size(105, 20);
            this.screenHeightTxtBox.TabIndex = 25;
            // 
            // saveNUpdtBtn
            // 
            this.saveNUpdtBtn.Location = new System.Drawing.Point(19, 10);
            this.saveNUpdtBtn.Margin = new System.Windows.Forms.Padding(19, 10, 3, 3);
            this.saveNUpdtBtn.Name = "saveNUpdtBtn";
            this.saveNUpdtBtn.Size = new System.Drawing.Size(110, 23);
            this.saveNUpdtBtn.TabIndex = 0;
            this.saveNUpdtBtn.Text = "Save / Update";
            this.saveNUpdtBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(19, 154);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(19, 10, 3, 3);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(110, 23);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset To Defaults";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // connGivenBtn
            // 
            this.connGivenBtn.Location = new System.Drawing.Point(19, 118);
            this.connGivenBtn.Margin = new System.Windows.Forms.Padding(19, 10, 3, 3);
            this.connGivenBtn.Name = "connGivenBtn";
            this.connGivenBtn.Size = new System.Drawing.Size(110, 23);
            this.connGivenBtn.TabIndex = 2;
            this.connGivenBtn.Text = "Quick Connect";
            this.connGivenBtn.UseVisualStyleBackColor = true;
            // 
            // screenSettingsHelpBtn
            // 
            this.screenSettingsHelpBtn.Location = new System.Drawing.Point(88, 185);
            this.screenSettingsHelpBtn.Margin = new System.Windows.Forms.Padding(88, 5, 3, 3);
            this.screenSettingsHelpBtn.Name = "screenSettingsHelpBtn";
            this.screenSettingsHelpBtn.Size = new System.Drawing.Size(40, 23);
            this.screenSettingsHelpBtn.TabIndex = 3;
            this.screenSettingsHelpBtn.Text = "Help!";
            this.screenSettingsHelpBtn.UseVisualStyleBackColor = true;
            // 
            // saveToXmlBtn
            // 
            this.saveToXmlBtn.Location = new System.Drawing.Point(19, 82);
            this.saveToXmlBtn.Margin = new System.Windows.Forms.Padding(19, 10, 3, 3);
            this.saveToXmlBtn.Name = "saveToXmlBtn";
            this.saveToXmlBtn.Size = new System.Drawing.Size(110, 23);
            this.saveToXmlBtn.TabIndex = 4;
            this.saveToXmlBtn.Text = "Save as .XML";
            this.saveToXmlBtn.UseVisualStyleBackColor = true;
            // 
            // rdpCredsHelpBtn
            // 
            this.rdpCredsHelpBtn.Location = new System.Drawing.Point(174, 458);
            this.rdpCredsHelpBtn.Margin = new System.Windows.Forms.Padding(174, 55, 3, 3);
            this.rdpCredsHelpBtn.Name = "rdpCredsHelpBtn";
            this.rdpCredsHelpBtn.Size = new System.Drawing.Size(40, 23);
            this.rdpCredsHelpBtn.TabIndex = 16;
            this.rdpCredsHelpBtn.Text = "Help!";
            this.rdpCredsHelpBtn.UseVisualStyleBackColor = true;
            // 
            // recheckConnBtn
            // 
            this.recheckConnBtn.Location = new System.Drawing.Point(33, 228);
            this.recheckConnBtn.Name = "recheckConnBtn";
            this.recheckConnBtn.Size = new System.Drawing.Size(120, 23);
            this.recheckConnBtn.TabIndex = 9;
            this.recheckConnBtn.Text = "Recheck Connection";
            this.recheckConnBtn.UseVisualStyleBackColor = true;
            // 
            // saveToRdpFileBtn
            // 
            this.saveToRdpFileBtn.Location = new System.Drawing.Point(19, 46);
            this.saveToRdpFileBtn.Margin = new System.Windows.Forms.Padding(19, 10, 3, 3);
            this.saveToRdpFileBtn.Name = "saveToRdpFileBtn";
            this.saveToRdpFileBtn.Size = new System.Drawing.Size(110, 23);
            this.saveToRdpFileBtn.TabIndex = 5;
            this.saveToRdpFileBtn.Text = "Save as .RDP";
            this.saveToRdpFileBtn.UseVisualStyleBackColor = true;
            // 
            // RDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 522);
            this.ControlBox = false;
            this.Controls.Add(this.screenSettingsHolderPnl);
            this.Controls.Add(this.currentRdpsPnl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RDP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proxy";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.currentRdpsPnl.ResumeLayout(false);
            this.currentRdpsPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isMstcRunningImgBox)).EndInit();
            this.screenSettingsHolderPnl.ResumeLayout(false);
            this.screenSettingsPnl.ResumeLayout(false);
            this.screenSettingsPnl.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel currentRdpsPnl;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
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