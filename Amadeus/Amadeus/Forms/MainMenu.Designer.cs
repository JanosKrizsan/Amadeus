using Amadeus.CustomControls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.Forms
{
    partial class MainMenu
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
            var defBtnSize = new Size(150, 30);
            var defBtnMargin = new Padding(0, 25, 0, 0);

            mainMenuBtn = new BaseButton(_res, "mainMenuBtn", 0, point: new Point(0, 25), size: defBtnSize, text: "Main Menu", visStyleBackColor: true, margin: defBtnMargin, anchor: AnchorStyles.Top, flat: FlatStyle.Flat);
            settingsBtn = new BaseButton(_res, "settingsBtn", 1, point: new Point(0, 80), size: defBtnSize, text: "Settings", visStyleBackColor: true, margin: defBtnMargin, anchor: AnchorStyles.Top, flat: FlatStyle.Flat);
            proxyBtn = new BaseButton(_res, "proxyBtn", 2, point: new Point(0, 135), size: defBtnSize, text: "Proxy", visStyleBackColor: true, margin: defBtnMargin, anchor: AnchorStyles.Top, flat: FlatStyle.Flat);
            vpnBtn = new BaseButton(_res, "vpnBtn", 3, point: new Point(0, 190), size: defBtnSize, text: "VPN", visStyleBackColor: true, margin: defBtnMargin, anchor: AnchorStyles.Top, flat: FlatStyle.Flat);
            rdpBtn = new BaseButton(_res, "rdpBtn", 4, point: new Point(0, 245), size: defBtnSize, text: "RDP", visStyleBackColor: true, margin: defBtnMargin, anchor: AnchorStyles.Top, flat: FlatStyle.Flat);
            ipBtn = new BaseButton(_res, "ipBtn", 5, point: new Point(0, 300), size: defBtnSize, text: "IP Address", visStyleBackColor: true, margin: defBtnMargin, anchor: AnchorStyles.Top, flat: FlatStyle.Flat);
            macBtn = new BaseButton(_res, "macBtn", 6, point: new Point(0, 355), size: defBtnSize, text: "MAC Address", visStyleBackColor: true, margin: defBtnMargin, anchor: AnchorStyles.Top, flat: FlatStyle.Flat);
            sysLangBtn = new BaseButton(_res, "sysLangBtn", 7, point: new Point(0, 410), size: defBtnSize, text: "System Language", visStyleBackColor: true, margin: defBtnMargin, anchor: AnchorStyles.Top, flat: FlatStyle.Flat);
            logoutBtn = new BaseButton(_res, "logoutBtn", 8, point: new Point(0, 500), size: defBtnSize, text: "Log Out", visStyleBackColor: true, margin: new Padding(0, 60, 0, 0), anchor: AnchorStyles.Top, flat: FlatStyle.Flat);
            quitBtn = new BaseButton(_res, "quitBtn", 9, point: new Point(0, 530), size: defBtnSize, text: "Quit", visStyleBackColor: true, anchor: AnchorStyles.Top, flat: FlatStyle.Flat);
            #endregion

            #region Panels
            viewPanel = new BasePanel(_res, "viewPanel", 1, point: new Point(153, 0), size: new Size(632, 561), backColor: Color.Gainsboro);
            mainMenuSelectPnl = new BaseFlowPanel(_res, "mainMenuSelectPnl", 0, new Control[] { mainMenuBtn, settingsBtn, proxyBtn, vpnBtn, rdpBtn, ipBtn, macBtn, sysLangBtn, logoutBtn, quitBtn },
                new Point(0, 0), new Size(150, 561), dock: DockStyle.Left, flow: FlowDirection.TopDown);
            #endregion

            SuspendLayout();
            InitSelectionScreen();

        }

        private void InitSelectionScreen()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 561);
            ControlBox = false;
            Controls.Add(viewPanel);
            Controls.Add(mainMenuSelectPnl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "SelectionScreen";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SelectionScreen";
            mainMenuSelectPnl.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainMenuSelectPnl;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button proxyBtn;
        private System.Windows.Forms.Button vpnBtn;
        private System.Windows.Forms.Button rdpBtn;
        private System.Windows.Forms.Button ipBtn;
        private System.Windows.Forms.Button macBtn;
        private System.Windows.Forms.Button sysLangBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Panel viewPanel;
    }
}