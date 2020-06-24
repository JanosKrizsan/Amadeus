namespace Amadeus.Views
{
    partial class IPAddress
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
            this.staticPnl = new System.Windows.Forms.Panel();
            this.dynamicPnl = new System.Windows.Forms.Panel();
            this.staticAddLbl = new System.Windows.Forms.Label();
            this.DynamicAddLbl = new System.Windows.Forms.Label();
            this.ipaddressLbl = new System.Windows.Forms.Label();
            this.maskLbl = new System.Windows.Forms.Label();
            this.gatewayLbl = new System.Windows.Forms.Label();
            this.dnsLbl = new System.Windows.Forms.Label();
            this.setStaticIPBtn = new System.Windows.Forms.Button();
            this.setDynamicIPBtn = new System.Windows.Forms.Button();
            this.dnsTxtBox = new System.Windows.Forms.TextBox();
            this.maskTxtBox = new System.Windows.Forms.TextBox();
            this.ipAddTxtBox = new System.Windows.Forms.TextBox();
            this.gatewayTxtBox = new System.Windows.Forms.TextBox();
            this.adapterIpsListBox = new System.Windows.Forms.ListBox();
            this.selectedAdapterData = new System.Windows.Forms.RichTextBox();
            this.currNetAdDataLbl = new System.Windows.Forms.Label();
            this.adapterListLbl = new System.Windows.Forms.Label();
            this.ipAddressesHlpBtn = new System.Windows.Forms.Button();
            this.staticPnl.SuspendLayout();
            this.dynamicPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // staticPnl
            // 
            this.staticPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.staticPnl.Controls.Add(this.gatewayTxtBox);
            this.staticPnl.Controls.Add(this.ipAddTxtBox);
            this.staticPnl.Controls.Add(this.maskTxtBox);
            this.staticPnl.Controls.Add(this.dnsTxtBox);
            this.staticPnl.Controls.Add(this.setStaticIPBtn);
            this.staticPnl.Controls.Add(this.dnsLbl);
            this.staticPnl.Controls.Add(this.gatewayLbl);
            this.staticPnl.Controls.Add(this.maskLbl);
            this.staticPnl.Controls.Add(this.ipaddressLbl);
            this.staticPnl.Controls.Add(this.staticAddLbl);
            this.staticPnl.Location = new System.Drawing.Point(13, 17);
            this.staticPnl.Name = "staticPnl";
            this.staticPnl.Size = new System.Drawing.Size(282, 289);
            this.staticPnl.TabIndex = 0;
            // 
            // dynamicPnl
            // 
            this.dynamicPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dynamicPnl.Controls.Add(this.currNetAdDataLbl);
            this.dynamicPnl.Controls.Add(this.selectedAdapterData);
            this.dynamicPnl.Controls.Add(this.setDynamicIPBtn);
            this.dynamicPnl.Controls.Add(this.DynamicAddLbl);
            this.dynamicPnl.Location = new System.Drawing.Point(322, 17);
            this.dynamicPnl.Name = "dynamicPnl";
            this.dynamicPnl.Size = new System.Drawing.Size(282, 289);
            this.dynamicPnl.TabIndex = 1;
            // 
            // staticAddLbl
            // 
            this.staticAddLbl.AutoSize = true;
            this.staticAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticAddLbl.Location = new System.Drawing.Point(3, 11);
            this.staticAddLbl.Name = "staticAddLbl";
            this.staticAddLbl.Size = new System.Drawing.Size(113, 20);
            this.staticAddLbl.TabIndex = 0;
            this.staticAddLbl.Text = "Static Address";
            // 
            // DynamicAddLbl
            // 
            this.DynamicAddLbl.AutoSize = true;
            this.DynamicAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DynamicAddLbl.Location = new System.Drawing.Point(3, 11);
            this.DynamicAddLbl.Name = "DynamicAddLbl";
            this.DynamicAddLbl.Size = new System.Drawing.Size(133, 20);
            this.DynamicAddLbl.TabIndex = 1;
            this.DynamicAddLbl.Text = "Dynamic Address";
            // 
            // ipaddressLbl
            // 
            this.ipaddressLbl.AutoSize = true;
            this.ipaddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipaddressLbl.Location = new System.Drawing.Point(4, 75);
            this.ipaddressLbl.Name = "ipaddressLbl";
            this.ipaddressLbl.Size = new System.Drawing.Size(80, 17);
            this.ipaddressLbl.TabIndex = 1;
            this.ipaddressLbl.Text = "IP Address:";
            // 
            // maskLbl
            // 
            this.maskLbl.AutoSize = true;
            this.maskLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskLbl.Location = new System.Drawing.Point(155, 75);
            this.maskLbl.Name = "maskLbl";
            this.maskLbl.Size = new System.Drawing.Size(45, 17);
            this.maskLbl.TabIndex = 2;
            this.maskLbl.Text = "Mask:";
            // 
            // gatewayLbl
            // 
            this.gatewayLbl.AutoSize = true;
            this.gatewayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gatewayLbl.Location = new System.Drawing.Point(4, 151);
            this.gatewayLbl.Name = "gatewayLbl";
            this.gatewayLbl.Size = new System.Drawing.Size(67, 17);
            this.gatewayLbl.TabIndex = 3;
            this.gatewayLbl.Text = "Gateway:";
            // 
            // dnsLbl
            // 
            this.dnsLbl.AutoSize = true;
            this.dnsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dnsLbl.Location = new System.Drawing.Point(155, 151);
            this.dnsLbl.Name = "dnsLbl";
            this.dnsLbl.Size = new System.Drawing.Size(41, 17);
            this.dnsLbl.TabIndex = 4;
            this.dnsLbl.Text = "DNS:";
            // 
            // setStaticIPBtn
            // 
            this.setStaticIPBtn.Location = new System.Drawing.Point(7, 244);
            this.setStaticIPBtn.Name = "setStaticIPBtn";
            this.setStaticIPBtn.Size = new System.Drawing.Size(75, 23);
            this.setStaticIPBtn.TabIndex = 5;
            this.setStaticIPBtn.Text = "Set Address";
            this.setStaticIPBtn.UseVisualStyleBackColor = true;
            // 
            // setDynamicIPBtn
            // 
            this.setDynamicIPBtn.Location = new System.Drawing.Point(7, 244);
            this.setDynamicIPBtn.Name = "setDynamicIPBtn";
            this.setDynamicIPBtn.Size = new System.Drawing.Size(75, 23);
            this.setDynamicIPBtn.TabIndex = 6;
            this.setDynamicIPBtn.Text = "Do Magic";
            this.setDynamicIPBtn.UseVisualStyleBackColor = true;
            // 
            // dnsTxtBox
            // 
            this.dnsTxtBox.Location = new System.Drawing.Point(158, 171);
            this.dnsTxtBox.Name = "dnsTxtBox";
            this.dnsTxtBox.Size = new System.Drawing.Size(100, 20);
            this.dnsTxtBox.TabIndex = 6;
            // 
            // maskTxtBox
            // 
            this.maskTxtBox.Location = new System.Drawing.Point(158, 95);
            this.maskTxtBox.Name = "maskTxtBox";
            this.maskTxtBox.Size = new System.Drawing.Size(100, 20);
            this.maskTxtBox.TabIndex = 7;
            // 
            // ipAddTxtBox
            // 
            this.ipAddTxtBox.Location = new System.Drawing.Point(7, 95);
            this.ipAddTxtBox.Name = "ipAddTxtBox";
            this.ipAddTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ipAddTxtBox.TabIndex = 8;
            // 
            // gatewayTxtBox
            // 
            this.gatewayTxtBox.Location = new System.Drawing.Point(7, 171);
            this.gatewayTxtBox.Name = "gatewayTxtBox";
            this.gatewayTxtBox.Size = new System.Drawing.Size(100, 20);
            this.gatewayTxtBox.TabIndex = 9;
            // 
            // adapterIpsListBox
            // 
            this.adapterIpsListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.adapterIpsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adapterIpsListBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.adapterIpsListBox.FormattingEnabled = true;
            this.adapterIpsListBox.ItemHeight = 16;
            this.adapterIpsListBox.Items.AddRange(new object[] {
            "adapter name | adapter id | ipv4 | ipv6",
            "adapter name | adapter id | ipv4 | ipv6",
            "adapter name | adapter id | ipv4 | ipv6",
            "adapter name | adapter id | ipv4 | ipv6"});
            this.adapterIpsListBox.Location = new System.Drawing.Point(13, 358);
            this.adapterIpsListBox.Name = "adapterIpsListBox";
            this.adapterIpsListBox.Size = new System.Drawing.Size(591, 148);
            this.adapterIpsListBox.TabIndex = 2;
            // 
            // selectedAdapterData
            // 
            this.selectedAdapterData.BackColor = System.Drawing.SystemColors.MenuText;
            this.selectedAdapterData.ForeColor = System.Drawing.Color.YellowGreen;
            this.selectedAdapterData.Location = new System.Drawing.Point(3, 95);
            this.selectedAdapterData.Name = "selectedAdapterData";
            this.selectedAdapterData.Size = new System.Drawing.Size(259, 131);
            this.selectedAdapterData.TabIndex = 7;
            this.selectedAdapterData.Text = "";
            // 
            // currNetAdDataLbl
            // 
            this.currNetAdDataLbl.AutoSize = true;
            this.currNetAdDataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currNetAdDataLbl.Location = new System.Drawing.Point(4, 75);
            this.currNetAdDataLbl.Name = "currNetAdDataLbl";
            this.currNetAdDataLbl.Size = new System.Drawing.Size(169, 17);
            this.currNetAdDataLbl.TabIndex = 8;
            this.currNetAdDataLbl.Text = "Current NetAdapter Data:";
            // 
            // adapterListLbl
            // 
            this.adapterListLbl.AutoSize = true;
            this.adapterListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adapterListLbl.Location = new System.Drawing.Point(12, 329);
            this.adapterListLbl.Name = "adapterListLbl";
            this.adapterListLbl.Size = new System.Drawing.Size(112, 17);
            this.adapterListLbl.TabIndex = 9;
            this.adapterListLbl.Text = "Apaters and IPs:";
            // 
            // ipAddressesHlpBtn
            // 
            this.ipAddressesHlpBtn.Location = new System.Drawing.Point(564, 329);
            this.ipAddressesHlpBtn.Name = "ipAddressesHlpBtn";
            this.ipAddressesHlpBtn.Size = new System.Drawing.Size(40, 23);
            this.ipAddressesHlpBtn.TabIndex = 10;
            this.ipAddressesHlpBtn.Text = "Help!";
            this.ipAddressesHlpBtn.UseVisualStyleBackColor = true;
            // 
            // IPAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 522);
            this.ControlBox = false;
            this.Controls.Add(this.ipAddressesHlpBtn);
            this.Controls.Add(this.adapterListLbl);
            this.Controls.Add(this.adapterIpsListBox);
            this.Controls.Add(this.dynamicPnl);
            this.Controls.Add(this.staticPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IPAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IPAddress";
            this.staticPnl.ResumeLayout(false);
            this.staticPnl.PerformLayout();
            this.dynamicPnl.ResumeLayout(false);
            this.dynamicPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel staticPnl;
        private System.Windows.Forms.Label staticAddLbl;
        private System.Windows.Forms.Panel dynamicPnl;
        private System.Windows.Forms.Label DynamicAddLbl;
        private System.Windows.Forms.TextBox gatewayTxtBox;
        private System.Windows.Forms.TextBox ipAddTxtBox;
        private System.Windows.Forms.TextBox maskTxtBox;
        private System.Windows.Forms.TextBox dnsTxtBox;
        private System.Windows.Forms.Button setStaticIPBtn;
        private System.Windows.Forms.Label dnsLbl;
        private System.Windows.Forms.Label gatewayLbl;
        private System.Windows.Forms.Label maskLbl;
        private System.Windows.Forms.Label ipaddressLbl;
        private System.Windows.Forms.Button setDynamicIPBtn;
        private System.Windows.Forms.Label currNetAdDataLbl;
        private System.Windows.Forms.RichTextBox selectedAdapterData;
        private System.Windows.Forms.ListBox adapterIpsListBox;
        private System.Windows.Forms.Label adapterListLbl;
        private System.Windows.Forms.Button ipAddressesHlpBtn;
    }
}