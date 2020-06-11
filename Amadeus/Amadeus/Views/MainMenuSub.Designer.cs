﻿namespace Amadeus.Views
{
    partial class MainMenuSub
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentStatusBar = new System.Windows.Forms.ProgressBar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveAsTxtBtn = new System.Windows.Forms.Button();
            this.procStatusLbl = new System.Windows.Forms.Label();
            this.reportingLbl = new System.Windows.Forms.Label();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.resetCrntBtn = new System.Windows.Forms.Button();
            this.saveAsXmlBtn = new System.Windows.Forms.Button();
            this.saveAsCsvBtn = new System.Windows.Forms.Button();
            this.scriptLbl = new System.Windows.Forms.Label();
            this.createNewBtn = new System.Windows.Forms.Button();
            this.runCustomBtn = new System.Windows.Forms.Button();
            this.stopCurrentBtn = new System.Windows.Forms.Button();
            this.removeSelectedBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.removeSelectedBtn);
            this.panel1.Controls.Add(this.stopCurrentBtn);
            this.panel1.Controls.Add(this.runCustomBtn);
            this.panel1.Controls.Add(this.createNewBtn);
            this.panel1.Controls.Add(this.scriptLbl);
            this.panel1.Controls.Add(this.saveAsCsvBtn);
            this.panel1.Controls.Add(this.saveAsXmlBtn);
            this.panel1.Controls.Add(this.resetCrntBtn);
            this.panel1.Controls.Add(this.openFileBtn);
            this.panel1.Controls.Add(this.reportingLbl);
            this.panel1.Controls.Add(this.saveAsTxtBtn);
            this.panel1.Location = new System.Drawing.Point(12, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 202);
            this.panel1.TabIndex = 0;
            // 
            // currentStatusBar
            // 
            this.currentStatusBar.Location = new System.Drawing.Point(12, 270);
            this.currentStatusBar.Name = "currentStatusBar";
            this.currentStatusBar.Size = new System.Drawing.Size(318, 23);
            this.currentStatusBar.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(592, 241);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // saveAsTxtBtn
            // 
            this.saveAsTxtBtn.Location = new System.Drawing.Point(6, 51);
            this.saveAsTxtBtn.Name = "saveAsTxtBtn";
            this.saveAsTxtBtn.Size = new System.Drawing.Size(86, 23);
            this.saveAsTxtBtn.TabIndex = 0;
            this.saveAsTxtBtn.Text = "Save as Text";
            this.saveAsTxtBtn.UseVisualStyleBackColor = true;
            this.saveAsTxtBtn.Click += new System.EventHandler(this.saveToFileBtn_Click);
            // 
            // procStatusLbl
            // 
            this.procStatusLbl.AutoSize = true;
            this.procStatusLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.procStatusLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procStatusLbl.Location = new System.Drawing.Point(336, 270);
            this.procStatusLbl.Name = "procStatusLbl";
            this.procStatusLbl.Size = new System.Drawing.Size(37, 23);
            this.procStatusLbl.TabIndex = 3;
            this.procStatusLbl.Text = "Idle";
            // 
            // reportingLbl
            // 
            this.reportingLbl.AutoSize = true;
            this.reportingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportingLbl.Location = new System.Drawing.Point(3, 0);
            this.reportingLbl.Name = "reportingLbl";
            this.reportingLbl.Size = new System.Drawing.Size(70, 17);
            this.reportingLbl.TabIndex = 1;
            this.reportingLbl.Text = "Reporting";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(276, 51);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 2;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            // 
            // resetCrntBtn
            // 
            this.resetCrntBtn.Location = new System.Drawing.Point(357, 51);
            this.resetCrntBtn.Name = "resetCrntBtn";
            this.resetCrntBtn.Size = new System.Drawing.Size(83, 23);
            this.resetCrntBtn.TabIndex = 3;
            this.resetCrntBtn.Text = "Reset Current";
            this.resetCrntBtn.UseVisualStyleBackColor = true;
            // 
            // saveAsXmlBtn
            // 
            this.saveAsXmlBtn.Location = new System.Drawing.Point(98, 51);
            this.saveAsXmlBtn.Name = "saveAsXmlBtn";
            this.saveAsXmlBtn.Size = new System.Drawing.Size(83, 23);
            this.saveAsXmlBtn.TabIndex = 4;
            this.saveAsXmlBtn.Text = "Save As XML";
            this.saveAsXmlBtn.UseVisualStyleBackColor = true;
            // 
            // saveAsCsvBtn
            // 
            this.saveAsCsvBtn.Location = new System.Drawing.Point(187, 51);
            this.saveAsCsvBtn.Name = "saveAsCsvBtn";
            this.saveAsCsvBtn.Size = new System.Drawing.Size(83, 23);
            this.saveAsCsvBtn.TabIndex = 5;
            this.saveAsCsvBtn.Text = "Save As CSV";
            this.saveAsCsvBtn.UseVisualStyleBackColor = true;
            // 
            // scriptLbl
            // 
            this.scriptLbl.AutoSize = true;
            this.scriptLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptLbl.Location = new System.Drawing.Point(3, 101);
            this.scriptLbl.Name = "scriptLbl";
            this.scriptLbl.Size = new System.Drawing.Size(107, 17);
            this.scriptLbl.TabIndex = 6;
            this.scriptLbl.Text = "Script / Process";
            // 
            // createNewBtn
            // 
            this.createNewBtn.Location = new System.Drawing.Point(6, 142);
            this.createNewBtn.Name = "createNewBtn";
            this.createNewBtn.Size = new System.Drawing.Size(83, 23);
            this.createNewBtn.TabIndex = 7;
            this.createNewBtn.Text = "Add New";
            this.createNewBtn.UseVisualStyleBackColor = true;
            // 
            // runCustomBtn
            // 
            this.runCustomBtn.Location = new System.Drawing.Point(208, 142);
            this.runCustomBtn.Name = "runCustomBtn";
            this.runCustomBtn.Size = new System.Drawing.Size(83, 23);
            this.runCustomBtn.TabIndex = 8;
            this.runCustomBtn.Text = "Run Custom";
            this.runCustomBtn.UseVisualStyleBackColor = true;
            // 
            // stopCurrentBtn
            // 
            this.stopCurrentBtn.Location = new System.Drawing.Point(297, 142);
            this.stopCurrentBtn.Name = "stopCurrentBtn";
            this.stopCurrentBtn.Size = new System.Drawing.Size(83, 23);
            this.stopCurrentBtn.TabIndex = 9;
            this.stopCurrentBtn.Text = "Stop Current";
            this.stopCurrentBtn.UseVisualStyleBackColor = true;
            // 
            // removeSelectedBtn
            // 
            this.removeSelectedBtn.Location = new System.Drawing.Point(98, 142);
            this.removeSelectedBtn.Name = "removeSelectedBtn";
            this.removeSelectedBtn.Size = new System.Drawing.Size(104, 23);
            this.removeSelectedBtn.TabIndex = 10;
            this.removeSelectedBtn.Text = "Remove Selected";
            this.removeSelectedBtn.UseVisualStyleBackColor = true;
            // 
            // MainMenuSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 522);
            this.ControlBox = false;
            this.Controls.Add(this.procStatusLbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.currentStatusBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainMenuSub";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label reportingLbl;
        private System.Windows.Forms.Button saveAsTxtBtn;
        private System.Windows.Forms.ProgressBar currentStatusBar;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
    }
}