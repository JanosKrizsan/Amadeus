using Amadeus.CustomControls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.Forms
{
    partial class IPAddress
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
            var defTxtBoxSize = new Size(100, 20);

            adapterIpsListBox = new BaseListBox(_res, "adaptersIpsListBox", 2, true, backColor: SystemColors.MenuText, foreColor: Color.YellowGreen, point: new Point(13, 358), size: new Size(591, 148), itemHeight: 16);
            selectedAdapterDataRchTxtBx = new BaseRichTextBox(_res, "selectedAdapterDataRchTxtBx", 7, SystemColors.MenuText, Color.YellowGreen, new Point(3, 95), new Size(259, 131));
            gatewayTxtBox = new BaseTextBox(_res, "gatewayTxtBox", 9, new Point(7, 171), defTxtBoxSize);
            ipAddTxtBox = new BaseTextBox(_res, "ipAddTxtBox", 8, new Point(7, 95), defTxtBoxSize);
            maskTxtBox = new BaseTextBox(_res, "maskTxtBox", 7, new Point(158, 95), defTxtBoxSize);
            dnsTxtBox = new BaseTextBox(_res, "dnsTxtBox", 6, new Point(158, 171), defTxtBoxSize);
            dnsLbl = new BaseLabel(_res, "dnsLbl", 4, new Point(155, 151), new Size(41, 17), "DNS:", autoSize: true);
            gatewayLbl = new BaseLabel(_res, "gatewayLbl", 3, new Point(4, 151), new Size(67, 17), "Gateway:", autoSize: true);
            maskLbl = new BaseLabel(_res, "maskLbl", 2, new Point(155, 75), new Size(4, 17), "Mask", autoSize: true);
            ipaddressLbl = new BaseLabel(_res, "ipAddressLbl", 1, new Point(4, 75), new Size(80, 17), "IP Address:", autoSize: true);
            staticAddLbl = new BaseLabel(_res, "staticAddLbl", point: new Point(3, 11), size: new Size(113, 20), text: "Static Address", autoSize: true);
            currNetAdDataLbl = new BaseLabel(_res, "currNetAdDataLbl", 8, new Point(4, 75), new Size(169, 17), "Current NetAdapter Data:", autoSize: true);
            dynamicAddLbl = new BaseLabel(_res, "dynamicAddLbl", 1, new Point(3, 11), new Size(133, 20), "Dynamic Address", autoSize: true);
            adaptersListLbl = new BaseLabel(_res, "adaptersListLbl", 9, point: new Point(12, 329), new Size(112, 17), autoSize: true, text: "Adapters and IPs:");
            ipAddressesHlpBtn = new BaseButton(_res, "ipAddressesHlpBtn", 10, visStyleBackColor: true, point: new Point(564, 329), size: new Size(40, 23), text: "Help!");
            setDynamicIPBtn = new BaseButton(_res, "setDynamicIPBtn", 6, point: new Point(7, 244), size: new Size(75, 23), visStyleBackColor: true, text: "Do Magic");
            setStaticIPBtn = new BaseButton(_res, "setStaticIPBtn", 5, point: new Point(7, 244), size: new Size(75, 23), text: "Set Address:", visStyleBackColor: true);
            #endregion

            #region Panels
            staticPnl = new BaseFlowPanel(_res, "staticPnl", controls: new Control[] { gatewayTxtBox, ipAddTxtBox, maskTxtBox, dnsTxtBox, setStaticIPBtn, dnsLbl, gatewayLbl, maskLbl, ipaddressLbl, staticAddLbl },
                point: new Point(13, 17), size: new Size(282, 289), borderStyle: BorderStyle.Fixed3D);
            dynamicPnl = new BaseFlowPanel(_res, "dynamicPnl", 1, new Control[] { currNetAdDataLbl, selectedAdapterDataRchTxtBx, setDynamicIPBtn, dynamicAddLbl }, new Point(322, 17), new Size(282, 289), BorderStyle.Fixed3D);
            #endregion


            SuspendLayout();
            InitIPAddress();

        }

        private void InitIPAddress()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 522);
            ControlBox = false;
            Controls.Add(ipAddressesHlpBtn);
            Controls.Add(adaptersListLbl);
            Controls.Add(adapterIpsListBox);
            Controls.Add(dynamicPnl);
            Controls.Add(staticPnl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "IPAddress";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "IPAddress";
            staticPnl.ResumeLayout(false);
            staticPnl.PerformLayout();
            dynamicPnl.ResumeLayout(false);
            dynamicPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Panel staticPnl;
        private System.Windows.Forms.Label staticAddLbl;
        private System.Windows.Forms.Panel dynamicPnl;
        private System.Windows.Forms.Label dynamicAddLbl;
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
        private System.Windows.Forms.RichTextBox selectedAdapterDataRchTxtBx;
        private System.Windows.Forms.ListBox adapterIpsListBox;
        private System.Windows.Forms.Label adaptersListLbl;
        private System.Windows.Forms.Button ipAddressesHlpBtn;
    }
}