using Amadeus.CustomControls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Amadeus.Forms
{
    partial class MainMenuSub
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
            var defButtonSize = new Size(83, 23);

            menuSubHelpBtn = new BaseButton(_res, "menuSubHelpBtn", true, 11, new object[] { default, new Point(502, 172), default, defButtonSize, "Help!" });
            removeSelectedBtn = new BaseButton(_res, "removeSelectedBtn", true, 10, new object[] { default, new Point(98, 142), default, new Size(104, 23), "Remove Selected" });
            stopCurrentBtn = new BaseButton(_res, "stopCurrentBtn", true, 9, new object[] { default, new Point(297, 142), default, defButtonSize, "Stop Current" });
            runCustomBtn = new BaseButton(_res, "runCustomBtn", true, 8, new object[] { default, new Point(208, 142), default, defButtonSize, "Run Custom" });
            createNewBtn = new BaseButton(_res, "createNewBtn", true, 7, new object[] { default, new Point(6, 142), default, defButtonSize, "Add New" });
            saveAsCsvBtn = new BaseButton(_res, "saveAsCsvBtn", true, 5, new object[] { default, new Point(187, 41), default, defButtonSize, "Save as CSV" });
            saveAsXmlBtn = new BaseButton(_res, "saveAsXmlBtn", true, 4, new object[] { default, new Point(98, 41), default, defButtonSize, "Save as XML" });
            resetCrntBtn = new BaseButton(_res, "resetCrntBtn", true, 3, new object[] { default, new Point(357, 41), default, defButtonSize, "Reset Current" });
            openFileBtn = new BaseButton(_res, "openFileBtn", true, 2, new object[] { default, new Point(276, 41), default, new Size(75, 23), "Open File" });
            saveAsTxtBtn = new BaseButton(_res, "saveAsTxtBtn", true, args: new object[] { default, new Point(3, 41), default, new Size(86, 23), "Save as Text" });
            scriptLbl = new BaseLabel(_res, "scriptLbl", 6, new Point(3, 101), new Size(107, 17), "Script / Process", autoSize: true);
            procStatusLbl = new BaseLabel(_res, "procStatusLbl", 3, new Point(336, 270), new Size(37, 23), "Idle", autoSize: true, borderStyle: BorderStyle.Fixed3D);
            reportingLbl = new BaseLabel(_res, "reportingLbl", 1, new Point(3, 0), new Size(70, 17), "Reporting", autoSize: false);
            currentStatusBar = new BaseProgressBar(_res, "currentStatusBar", new Point(12, 270), new Size(318, 23), 1);
            infoTextBox = new BaseRichTextBox(_res, "infoTextBox", 2, Color.Black, Color.LimeGreen, new Point(12, 12), new Size(592, 241));
            #endregion

            #region Panels
            reportingOpersPnl = new BasePanel(_res, "reportingOpersPnl", new Control[] { menuSubHelpBtn, removeSelectedBtn, stopCurrentBtn, runCustomBtn, createNewBtn, scriptLbl, saveAsCsvBtn, saveAsXmlBtn, resetCrntBtn, openFileBtn, reportingLbl, saveAsTxtBtn },
                new Point(12, 308), new Size(592, 202));
            #endregion

            SuspendLayout();
            InitMainMenuSub();

        }

        private void InitMainMenuSub()
        {
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(616, 522);
            ControlBox = false;
            Controls.Add(procStatusLbl);
            Controls.Add(infoTextBox);
            Controls.Add(currentStatusBar);
            Controls.Add(reportingOpersPnl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MainMenuSub";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "MainMenuSub";
            reportingOpersPnl.ResumeLayout(false);
            reportingOpersPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel reportingOpersPnl;
        private System.Windows.Forms.Label reportingLbl;
        private System.Windows.Forms.Button saveAsTxtBtn;
        private System.Windows.Forms.ProgressBar currentStatusBar;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.Label procStatusLbl;
        private System.Windows.Forms.Button saveAsXmlBtn;
        private System.Windows.Forms.Button resetCrntBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button saveAsCsvBtn;
        private System.Windows.Forms.Label scriptLbl;
        private System.Windows.Forms.Button removeSelectedBtn;
        private System.Windows.Forms.Button stopCurrentBtn;
        private System.Windows.Forms.Button runCustomBtn;
        private System.Windows.Forms.Button createNewBtn;
        private System.Windows.Forms.Button menuSubHelpBtn;
    }
}