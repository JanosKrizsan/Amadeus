using Amadeus.CustomControls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.Forms
{
    partial class MacAddress
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
            var defBtnSizeBig = new Size(100, 23);
            var defBtnSize = new Size(70, 23);

            constFullLbl = new BaseLabel(_res, "constFullLbl", 6, new Point(233, 315), new Size(178, 18), "Constructed Full Address:", autoSize: true);
            genAddLbl = new BaseLabel(_res, "genAddLbl", 3, new Point(3, 315), new Size(131, 18), "Generate Address:", autoSize: true);
            macVendorsLbl = new BaseLabel(_res, "macVendorsLbl", 1, new Point(3, 40), new Size(100, 18), "Mac Vendors:", autoSize: true);
            savedAddysLbl = new BaseLabel(_res, "savedAddysLbl", 3, new Point(5, 40), new Size(123, 17), "Saved Addresses:", padding: new Padding(5, 40, 3, 0), autoSize: true);
            generateRndmBtn = new BaseButton(_res, "generateRndmBtn", 9, point: new Point(236, 237), size: new Size(120, 23), text: "Generate Random", visStyleBackColor: true);
            applyFullAddBtn = new BaseButton(_res, "applyFullAddBtn", 8, point: new Point(236, 387), size: defBtnSizeBig, text: "Apply Full Address", visStyleBackColor: true);
            saveToFileBtn = new BaseButton(_res, "saveToFileBtn", 0, point: new Point(236, 433), size: new Size(70, 23), margin: new Padding(20, 20, 3, 3), text: "Save", visStyleBackColor: true);
            generateAddrBtn = new BaseButton(_res, "generateAddrBtn", 5, point: new Point(6, 387), size: defBtnSizeBig, text: "Generate New", visStyleBackColor: true);
            addVendorBtn = new BaseButton(_res, "addVendorBtn", 4, point: new Point(6, 237), size: new Size(100, 23), text: "Add Selected", visStyleBackColor: true);
            applySelectBtn = new BaseButton(_res, "applySelectBtn", 1, point: new Point(35, 151), size: defBtnSize, margin: new Padding(35, 60, 3, 3), text: "Apply", visStyleBackColor: true);
            removeSelectBtn = new BaseButton(_res, "removeSelectBtn", 2, point: new Point(35, 192), size: defBtnSize, margin: new Padding(35, 15, 3, 3), text: "Remove", visStyleBackColor: true);
            macAddHelpBtn = new BaseButton(_res, "macAddHelpBtn", 5, point: new Point(80, 233), size: new Size(40, 23), margin: new Padding(80, 15, 3, 3), text: "Help!", visStyleBackColor: true);
            fullMacTxtBox = new BaseTextBox(_res, "fullMacTxtBox", 7, new Point(236, 349), new Size(160, 20));
            generatedTxtBox = new BaseTextBox(_res, "generatedTxtBox", 2, new Point(6, 349), new Size(120, 20));
            macVendorsLstBox = new BaseListBox(_res, "macVendorsLstBox", 0, true, point: new Point(6, 67), size: new Size(350, 147));
            savedMacsCmboBox = new BaseComboBox(_res, "savedMacsCmboBox", 3, new Point(5, 67), new Size(121, 21), new Padding(5, 10, 3, 3));

            #endregion

            #region Panels
            macDetailsPnl = new BaseFlowPanel(_res, "macDetailsPnl", 0, new Control[] { generateRndmBtn, applyFullAddBtn, saveToFileBtn, fullMacTxtBox, constFullLbl, generateAddrBtn, addVendorBtn, genAddLbl, generatedTxtBox, macVendorsLbl, macVendorsLstBox },
                new Point(12, 12), new Size(434, 491));
            savedAddrsPnl = new BaseFlowPanel(_res, "svedAddrsPnl", 1, new Control[] { savedAddysLbl, savedMacsCmboBox, applySelectBtn, removeSelectBtn, macAddHelpBtn },
                new Point(461, 12), new Size(140, 490), borderStyle: BorderStyle.Fixed3D);
            #endregion

            SuspendLayout();
            InitMacAddress();

        }

        private void InitMacAddress()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 522);
            ControlBox = false;
            Controls.Add(savedAddrsPnl);
            Controls.Add(macDetailsPnl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MacAddress";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "MacAddress";
            macDetailsPnl.ResumeLayout(false);
            macDetailsPnl.PerformLayout();
            savedAddrsPnl.ResumeLayout(false);
            savedAddrsPnl.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel macDetailsPnl;
        private System.Windows.Forms.Button generateRndmBtn;
        private System.Windows.Forms.Button applyFullAddBtn;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.TextBox fullMacTxtBox;
        private System.Windows.Forms.Label constFullLbl;
        private System.Windows.Forms.Button generateAddrBtn;
        private System.Windows.Forms.Button addVendorBtn;
        private System.Windows.Forms.Label genAddLbl;
        private System.Windows.Forms.TextBox generatedTxtBox;
        private System.Windows.Forms.Label macVendorsLbl;
        private System.Windows.Forms.ListBox macVendorsLstBox;
        private System.Windows.Forms.FlowLayoutPanel savedAddrsPnl;
        private System.Windows.Forms.Label savedAddysLbl;
        private System.Windows.Forms.ComboBox savedMacsCmboBox;
        private System.Windows.Forms.Button applySelectBtn;
        private System.Windows.Forms.Button removeSelectBtn;
        private System.Windows.Forms.Button macAddHelpBtn;
    }
}