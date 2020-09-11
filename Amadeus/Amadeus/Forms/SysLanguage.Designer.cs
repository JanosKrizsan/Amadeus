using Amadeus.CustomControls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.Forms
{
    partial class SysLanguage
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
            var defBigButtonSize = new Size(120, 23);
            var defButtonPadding = new Padding(85, 10, 85, 5);
            var defControlPadding = new Padding(5, 10, 5, 5);

            removeCurrBtn = new BaseButton(_res, "removeCurrBtn", 2, visStyleBackColor: true, point: new Point(85, 79), margin: defButtonPadding, size: defBigButtonSize, text: "Remove Selected");
            setSelectedBtn = new BaseButton(_res, "setSelectedBtn", 11, visStyleBackColor: true, point: new Point(85, 117), margin: defButtonPadding, size: defBigButtonSize, text: "Set Selected");
            setAsDefBtn = new BaseButton(_res, "setAsDefBtn", 6, visStyleBackColor: true, point: new Point(85, 155), margin: defButtonPadding, size: defBigButtonSize, text: "Set as Default");
            setToDefBtn = new BaseButton(_res, "setToDefBtn", 3, visStyleBackColor: true, point: new Point(85, 193), margin: defButtonPadding, size: defBigButtonSize, text: "Set to Default");
            checkGeoDataBtn = new BaseButton(_res, "checkGeoData", 5, visStyleBackColor: true, point: new Point(85, 231), margin: defButtonPadding, size: defBigButtonSize, text: "Check Geo-Data");
            addCustomBtn = new BaseButton(_res, "addCustomBtn", 9, visStyleBackColor: true, point: new Point(85, 337), margin: defButtonPadding, size: defBigButtonSize, text: "Add Custom");
            addNSetCustBtn = new BaseButton(_res, "addNSetCustBtn", 12, visStyleBackColor: true, point: new Point(85, 375), margin: defButtonPadding, size: defBigButtonSize, text: "Add and Set Custom");
            removeSimilarBtn = new BaseButton(_res, "removeSimilarBtn", 10, visStyleBackColor: true, point: new Point(85, 413), margin: defButtonPadding, size: defBigButtonSize, text: "Remove Similar");
            currHelpBtn = new BaseButton(_res, "currHelpBtn", 4, visStyleBackColor: true, point: new Point(190, 461), margin: new Padding(0, 20, 25, 5), size: new Size(75, 23), text: "Help!", dock: DockStyle.Right);
            addNewBtn = new BaseButton(_res, "addNewBtn", 0, visStyleBackColor: true, point: new Point(84, 15), margin: new Padding(84, 15, 3, 3), size: defBigButtonSize, text: "Add New");
            addnSetNewBtn = new BaseButton(_res, "addnSetNewBtn", 1, visStyleBackColor: true, point: new Point(84, 56), margin: new Padding(84, 15, 3, 3), size: defBigButtonSize, text: "Add and Set New");
            helpNewBtn = new BaseButton(_res, "helpNewBtn", 2, visStyleBackColor: true, point: new Point(183, 107), margin: new Padding(183, 25, 15, 3), size: new Size(80, 23), text: "Help!", dock: DockStyle.Right);
            customTagInpBox = new BaseTextBox(_res, "customTagInpBox", 8, new Point(5, 302), new Size(270, 20), padding: defControlPadding);
            langTagListBox = new BaseListBox(_res, "langTagListBox", 18, formatting: true, scrollAlwaysVisible: true, backColor: SystemColors.MenuText, foreColor: Color.OliveDrab, point: new Point(317, 12), size: new Size(288, 346), selMode: SelectionMode.MultiSimple);
            customInpLbl = new BaseLabel(_res, "customInpLbl", 7, new Point(5, 269), new Size(96, 18), "Custom Input", padding: defControlPadding, autoSize: true);
            currentInstLangsLbl = new BaseLabel(_res, "currentInstLangsLbl", 1, new Point(5, 10), new Size(186, 18), "Current Installed Languages:", autoSize: true, padding: defControlPadding);
            currentLangsCmboBox = new BaseComboBox(_res, "currentLangsCmboBox", point: new Point(5, 43), size: new Size(270, 21), padding: defControlPadding);
            #endregion

            #region Panels
            currLangOpPanel = new BaseFlowPanel(_res, "currLangOpPanel", 1, controls: new Control[] { currentInstLangsLbl, currentLangsCmboBox, removeCurrBtn, setSelectedBtn, setAsDefBtn, setToDefBtn, checkGeoDataBtn, customInpLbl, customTagInpBox, addCustomBtn, addNSetCustBtn, removeSimilarBtn, currHelpBtn
    },
                new Point(12, 12), new Size(290, 498), borderStyle: BorderStyle.Fixed3D, flow: FlowDirection.TopDown);
            newLangListPanel = new BaseFlowPanel(_res, "newLangListPanel", 2, controls: new Control[] { addNewBtn, addnSetNewBtn, helpNewBtn
}, new Point(317, 364), new Size(288, 146), borderStyle: BorderStyle.Fixed3D, flow: FlowDirection.TopDown);
            #endregion

            SuspendLayout();
            InitSysLanguage();

        }

        private void InitSysLanguage()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 522);
            ControlBox = false;
            Controls.Add(newLangListPanel);
            Controls.Add(currLangOpPanel);
            Controls.Add(langTagListBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "SysLanguage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "SysLanguage";
            currLangOpPanel.ResumeLayout(false);
            currLangOpPanel.PerformLayout();
            newLangListPanel.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private System.Windows.Forms.ListBox langTagListBox;
        private System.Windows.Forms.FlowLayoutPanel currLangOpPanel;
        private System.Windows.Forms.FlowLayoutPanel newLangListPanel;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button addnSetNewBtn;
        private System.Windows.Forms.Button helpNewBtn;
        private System.Windows.Forms.Label currentInstLangsLbl;
        private System.Windows.Forms.ComboBox currentLangsCmboBox;
        private System.Windows.Forms.Button removeCurrBtn;
        private System.Windows.Forms.Button setToDefBtn;
        private System.Windows.Forms.Button currHelpBtn;
        private System.Windows.Forms.Button setAsDefBtn;
        private System.Windows.Forms.Button checkGeoDataBtn;
        private System.Windows.Forms.Button setSelectedBtn;
        private System.Windows.Forms.Label customInpLbl;
        private System.Windows.Forms.TextBox customTagInpBox;
        private System.Windows.Forms.Button addCustomBtn;
        private System.Windows.Forms.Button addNSetCustBtn;
        private System.Windows.Forms.Button removeSimilarBtn;
    }
}