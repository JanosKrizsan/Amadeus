namespace Amadeus.Forms
{
    partial class SysLanguage
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
            langTagListBox = new System.Windows.Forms.ListBox();
            currLangOpPanel = new System.Windows.Forms.FlowLayoutPanel();
            currentInstLangsLbl = new System.Windows.Forms.Label();
            currentLangsCmboBox = new System.Windows.Forms.ComboBox();
            removeCurrBtn = new System.Windows.Forms.Button();
            setSelectedBtn = new System.Windows.Forms.Button();
            setAsDefBtn = new System.Windows.Forms.Button();
            setToDefBtn = new System.Windows.Forms.Button();
            checkGeoDataBtn = new System.Windows.Forms.Button();
            customInpLbl = new System.Windows.Forms.Label();
            customTagInpBox = new System.Windows.Forms.TextBox();
            addCustomBtn = new System.Windows.Forms.Button();
            addNSetCustBtn = new System.Windows.Forms.Button();
            removeSimilarBtn = new System.Windows.Forms.Button();
            currHelpBtn = new System.Windows.Forms.Button();
            newLangListPanel = new System.Windows.Forms.FlowLayoutPanel();
            addNewBtn = new System.Windows.Forms.Button();
            addnSetNewBtn = new System.Windows.Forms.Button();
            helpNewBtn = new System.Windows.Forms.Button();
            currLangOpPanel.SuspendLayout();
            newLangListPanel.SuspendLayout();
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

        private void InithelpNewBtn()
        {
            helpNewBtn.Dock = System.Windows.Forms.DockStyle.Right;
            helpNewBtn.Location = new System.Drawing.Point(183, 107);
            helpNewBtn.Margin = new System.Windows.Forms.Padding(183, 25, 15, 3);
            helpNewBtn.Name = "helpNewBtn";
            helpNewBtn.Size = new System.Drawing.Size(80, 23);
            helpNewBtn.TabIndex = 2;
            helpNewBtn.Text = "Help!";
            helpNewBtn.UseVisualStyleBackColor = true;
        }

        private void InitaddnSetNewBtn()
        {
            addnSetNewBtn.Location = new System.Drawing.Point(84, 56);
            addnSetNewBtn.Margin = new System.Windows.Forms.Padding(84, 15, 3, 3);
            addnSetNewBtn.Name = "addnSetNewBtn";
            addnSetNewBtn.Size = new System.Drawing.Size(120, 23);
            addnSetNewBtn.TabIndex = 1;
            addnSetNewBtn.Text = "Add and Set New";
            addnSetNewBtn.UseVisualStyleBackColor = true;
        }

        private void InitaddNewBtn()
        {
            addNewBtn.Location = new System.Drawing.Point(84, 15);
            addNewBtn.Margin = new System.Windows.Forms.Padding(84, 15, 3, 3);
            addNewBtn.Name = "addNewBtn";
            addNewBtn.Size = new System.Drawing.Size(120, 23);
            addNewBtn.TabIndex = 0;
            addNewBtn.Text = "Add New";
            addNewBtn.UseVisualStyleBackColor = true;
        }

        private void InitnewLangListPanel()
        {
            newLangListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            newLangListPanel.Controls.Add(addNewBtn);
            newLangListPanel.Controls.Add(addnSetNewBtn);
            newLangListPanel.Controls.Add(helpNewBtn);
            newLangListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            newLangListPanel.Location = new System.Drawing.Point(317, 364);
            newLangListPanel.Name = "newLangListPanel";
            newLangListPanel.Size = new System.Drawing.Size(288, 146);
            newLangListPanel.TabIndex = 2;
        }

        private void InitcurrHelpBtn()
        {
            currHelpBtn.Dock = System.Windows.Forms.DockStyle.Right;
            currHelpBtn.Location = new System.Drawing.Point(190, 461);
            currHelpBtn.Margin = new System.Windows.Forms.Padding(0, 20, 25, 5);
            currHelpBtn.Name = "currHelpBtn";
            currHelpBtn.Size = new System.Drawing.Size(75, 23);
            currHelpBtn.TabIndex = 4;
            currHelpBtn.Text = "Help!";
            currHelpBtn.UseVisualStyleBackColor = true;
        }

        private void InitremoveSimilarBtn()
        {
            removeSimilarBtn.Location = new System.Drawing.Point(85, 413);
            removeSimilarBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            removeSimilarBtn.Name = "removeSimilarBtn";
            removeSimilarBtn.Size = new System.Drawing.Size(120, 23);
            removeSimilarBtn.TabIndex = 10;
            removeSimilarBtn.Text = "Remove Similar";
            removeSimilarBtn.UseVisualStyleBackColor = true;
        }

        private void InitaddNSetCustBtn()
        {
            addNSetCustBtn.Location = new System.Drawing.Point(85, 375);
            addNSetCustBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            addNSetCustBtn.Name = "addNSetCustBtn";
            addNSetCustBtn.Size = new System.Drawing.Size(120, 23);
            addNSetCustBtn.TabIndex = 12;
            addNSetCustBtn.Text = "Add and Set Custom";
            addNSetCustBtn.UseVisualStyleBackColor = true;
        }

        private void InitaddCustomBtn()
        {
            addCustomBtn.Location = new System.Drawing.Point(85, 337);
            addCustomBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            addCustomBtn.Name = "addCustomBtn";
            addCustomBtn.Size = new System.Drawing.Size(120, 23);
            addCustomBtn.TabIndex = 9;
            addCustomBtn.Text = "Add Custom";
            addCustomBtn.UseVisualStyleBackColor = true;
        }

        private void InitcustomTagInpBox()
        {
            customTagInpBox.Location = new System.Drawing.Point(5, 302);
            customTagInpBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            customTagInpBox.Name = "customTagInpBox";
            customTagInpBox.Size = new System.Drawing.Size(270, 20);
            customTagInpBox.TabIndex = 8;
        }

        private void InitcustomInpLbl()
        {
            customInpLbl.AutoSize = true;
            customInpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customInpLbl.Location = new System.Drawing.Point(5, 269);
            customInpLbl.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            customInpLbl.Name = "customInpLbl";
            customInpLbl.Size = new System.Drawing.Size(96, 18);
            customInpLbl.TabIndex = 7;
            customInpLbl.Text = "Custom Input";
        }

        private void InitcheckGeoDataBtn()
        {
            checkGeoDataBtn.Location = new System.Drawing.Point(85, 231);
            checkGeoDataBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            checkGeoDataBtn.Name = "checkGeoDataBtn";
            checkGeoDataBtn.Size = new System.Drawing.Size(120, 23);
            checkGeoDataBtn.TabIndex = 5;
            checkGeoDataBtn.Text = "Check Geo-Data";
            checkGeoDataBtn.UseVisualStyleBackColor = true;
        }

        private void InitsetToDefBtn()
        {
            setToDefBtn.Location = new System.Drawing.Point(85, 193);
            setToDefBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            setToDefBtn.Name = "setToDefBtn";
            setToDefBtn.Size = new System.Drawing.Size(120, 23);
            setToDefBtn.TabIndex = 3;
            setToDefBtn.Text = "Set to Default";
            setToDefBtn.UseVisualStyleBackColor = true;
        }

        private void InitsetAsDefBtn()
        {
            setAsDefBtn.Location = new System.Drawing.Point(85, 155);
            setAsDefBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            setAsDefBtn.Name = "setAsDefBtn";
            setAsDefBtn.Size = new System.Drawing.Size(120, 23);
            setAsDefBtn.TabIndex = 6;
            setAsDefBtn.Text = "Set as Default";
            setAsDefBtn.UseVisualStyleBackColor = true;
        }

        private void InitsetSelectedBtn()
        {
            setSelectedBtn.Location = new System.Drawing.Point(85, 117);
            setSelectedBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            setSelectedBtn.Name = "setSelectedBtn";
            setSelectedBtn.Size = new System.Drawing.Size(120, 23);
            setSelectedBtn.TabIndex = 11;
            setSelectedBtn.Text = "Set Selected";
            setSelectedBtn.UseVisualStyleBackColor = true;
        }

        private void InitremoveCurrBtn()
        {
            removeCurrBtn.Location = new System.Drawing.Point(85, 79);
            removeCurrBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            removeCurrBtn.Name = "removeCurrBtn";
            removeCurrBtn.Size = new System.Drawing.Size(120, 23);
            removeCurrBtn.TabIndex = 2;
            removeCurrBtn.Text = "Remove Selected";
            removeCurrBtn.UseVisualStyleBackColor = true;
        }

        private void InitcurrentLangsCmboBox()
        {
            currentLangsCmboBox.FormattingEnabled = true;
            currentLangsCmboBox.Location = new System.Drawing.Point(5, 43);
            currentLangsCmboBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            currentLangsCmboBox.Name = "currentLangsCmboBox";
            currentLangsCmboBox.Size = new System.Drawing.Size(270, 21);
            currentLangsCmboBox.TabIndex = 0;
        }

        private void InitcurrentInstLangsLbl()
        {
            currentInstLangsLbl.AutoSize = true;
            currentInstLangsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentInstLangsLbl.Location = new System.Drawing.Point(5, 10);
            currentInstLangsLbl.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            currentInstLangsLbl.Name = "currentInstLangsLbl";
            currentInstLangsLbl.Size = new System.Drawing.Size(186, 18);
            currentInstLangsLbl.TabIndex = 1;
            currentInstLangsLbl.Text = "Current Intalled Languages:";
        }

        private void InitcurrLangOpPanel()
        {
            currLangOpPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            currLangOpPanel.Controls.Add(currentInstLangsLbl);
            currLangOpPanel.Controls.Add(currentLangsCmboBox);
            currLangOpPanel.Controls.Add(removeCurrBtn);
            currLangOpPanel.Controls.Add(setSelectedBtn);
            currLangOpPanel.Controls.Add(setAsDefBtn);
            currLangOpPanel.Controls.Add(setToDefBtn);
            currLangOpPanel.Controls.Add(checkGeoDataBtn);
            currLangOpPanel.Controls.Add(customInpLbl);
            currLangOpPanel.Controls.Add(customTagInpBox);
            currLangOpPanel.Controls.Add(addCustomBtn);
            currLangOpPanel.Controls.Add(addNSetCustBtn);
            currLangOpPanel.Controls.Add(removeSimilarBtn);
            currLangOpPanel.Controls.Add(currHelpBtn);
            currLangOpPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            currLangOpPanel.Location = new System.Drawing.Point(12, 12);
            currLangOpPanel.Name = "currLangOpPanel";
            currLangOpPanel.Size = new System.Drawing.Size(290, 498);
            currLangOpPanel.TabIndex = 1;
        }

        private void InitLangTagListBox()
        {
            langTagListBox.BackColor = System.Drawing.SystemColors.MenuText;
            langTagListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            langTagListBox.ForeColor = System.Drawing.Color.OliveDrab;
            langTagListBox.FormattingEnabled = true;
            langTagListBox.ItemHeight = 18;
            langTagListBox.Location = new System.Drawing.Point(317, 12);
            langTagListBox.Name = "langTagListBox";
            langTagListBox.ScrollAlwaysVisible = true;
            langTagListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            langTagListBox.Size = new System.Drawing.Size(288, 346);
            langTagListBox.TabIndex = 0;
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