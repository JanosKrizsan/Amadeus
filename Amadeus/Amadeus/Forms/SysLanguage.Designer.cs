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
            this.langTagListBox = new System.Windows.Forms.ListBox();
            this.currLangOpPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.currentLangsLbl = new System.Windows.Forms.Label();
            this.currentLangsCmboBox = new System.Windows.Forms.ComboBox();
            this.removeCurrBtn = new System.Windows.Forms.Button();
            this.setSelectedBtn = new System.Windows.Forms.Button();
            this.setAsDefBtn = new System.Windows.Forms.Button();
            this.setToDefBtn = new System.Windows.Forms.Button();
            this.checkGeoDataBtn = new System.Windows.Forms.Button();
            this.customInpLbl = new System.Windows.Forms.Label();
            this.customTagInpBox = new System.Windows.Forms.TextBox();
            this.addCustomBtn = new System.Windows.Forms.Button();
            this.addNSetCustBtn = new System.Windows.Forms.Button();
            this.removeSimilarBtn = new System.Windows.Forms.Button();
            this.currHelpBtn = new System.Windows.Forms.Button();
            this.newLangListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.addnSetNewBtn = new System.Windows.Forms.Button();
            this.helpNewBtn = new System.Windows.Forms.Button();
            this.currLangOpPanel.SuspendLayout();
            this.newLangListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // langTagListBox
            // 
            this.langTagListBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.langTagListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langTagListBox.ForeColor = System.Drawing.Color.OliveDrab;
            this.langTagListBox.FormattingEnabled = true;
            this.langTagListBox.ItemHeight = 18;
            this.langTagListBox.Items.AddRange(new object[] {
            "Language | language tag | english name",
            "Language | language tag | english name",
            "Language | language tag | english name",
            "Language | language tag | english name",
            "Language | language tag | english name",
            "Language | language tag | english name",
            "Language | language tag | english name"});
            this.langTagListBox.Location = new System.Drawing.Point(317, 12);
            this.langTagListBox.Name = "langTagListBox";
            this.langTagListBox.ScrollAlwaysVisible = true;
            this.langTagListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.langTagListBox.Size = new System.Drawing.Size(288, 346);
            this.langTagListBox.TabIndex = 0;
            // 
            // currLangOpPanel
            // 
            this.currLangOpPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currLangOpPanel.Controls.Add(this.currentLangsLbl);
            this.currLangOpPanel.Controls.Add(this.currentLangsCmboBox);
            this.currLangOpPanel.Controls.Add(this.removeCurrBtn);
            this.currLangOpPanel.Controls.Add(this.setSelectedBtn);
            this.currLangOpPanel.Controls.Add(this.setAsDefBtn);
            this.currLangOpPanel.Controls.Add(this.setToDefBtn);
            this.currLangOpPanel.Controls.Add(this.checkGeoDataBtn);
            this.currLangOpPanel.Controls.Add(this.customInpLbl);
            this.currLangOpPanel.Controls.Add(this.customTagInpBox);
            this.currLangOpPanel.Controls.Add(this.addCustomBtn);
            this.currLangOpPanel.Controls.Add(this.addNSetCustBtn);
            this.currLangOpPanel.Controls.Add(this.removeSimilarBtn);
            this.currLangOpPanel.Controls.Add(this.currHelpBtn);
            this.currLangOpPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.currLangOpPanel.Location = new System.Drawing.Point(12, 12);
            this.currLangOpPanel.Name = "currLangOpPanel";
            this.currLangOpPanel.Size = new System.Drawing.Size(290, 498);
            this.currLangOpPanel.TabIndex = 1;
            // 
            // currentLangsLbl
            // 
            this.currentLangsLbl.AutoSize = true;
            this.currentLangsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLangsLbl.Location = new System.Drawing.Point(5, 10);
            this.currentLangsLbl.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.currentLangsLbl.Name = "currentLangsLbl";
            this.currentLangsLbl.Size = new System.Drawing.Size(137, 18);
            this.currentLangsLbl.TabIndex = 1;
            this.currentLangsLbl.Text = "Current Languages:";
            // 
            // currentLangsCmboBox
            // 
            this.currentLangsCmboBox.FormattingEnabled = true;
            this.currentLangsCmboBox.Location = new System.Drawing.Point(5, 43);
            this.currentLangsCmboBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.currentLangsCmboBox.Name = "currentLangsCmboBox";
            this.currentLangsCmboBox.Size = new System.Drawing.Size(270, 21);
            this.currentLangsCmboBox.TabIndex = 0;
            // 
            // removeCurrBtn
            // 
            this.removeCurrBtn.Location = new System.Drawing.Point(85, 79);
            this.removeCurrBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            this.removeCurrBtn.Name = "removeCurrBtn";
            this.removeCurrBtn.Size = new System.Drawing.Size(120, 23);
            this.removeCurrBtn.TabIndex = 2;
            this.removeCurrBtn.Text = "Remove Selected";
            this.removeCurrBtn.UseVisualStyleBackColor = true;
            // 
            // setSelectedBtn
            // 
            this.setSelectedBtn.Location = new System.Drawing.Point(85, 117);
            this.setSelectedBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            this.setSelectedBtn.Name = "setSelectedBtn";
            this.setSelectedBtn.Size = new System.Drawing.Size(120, 23);
            this.setSelectedBtn.TabIndex = 11;
            this.setSelectedBtn.Text = "Set Selected";
            this.setSelectedBtn.UseVisualStyleBackColor = true;
            // 
            // setAsDefBtn
            // 
            this.setAsDefBtn.Location = new System.Drawing.Point(85, 155);
            this.setAsDefBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            this.setAsDefBtn.Name = "setAsDefBtn";
            this.setAsDefBtn.Size = new System.Drawing.Size(120, 23);
            this.setAsDefBtn.TabIndex = 6;
            this.setAsDefBtn.Text = "Set as Default";
            this.setAsDefBtn.UseVisualStyleBackColor = true;
            // 
            // setToDefBtn
            // 
            this.setToDefBtn.Location = new System.Drawing.Point(85, 193);
            this.setToDefBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            this.setToDefBtn.Name = "setToDefBtn";
            this.setToDefBtn.Size = new System.Drawing.Size(120, 23);
            this.setToDefBtn.TabIndex = 3;
            this.setToDefBtn.Text = "Set to Default";
            this.setToDefBtn.UseVisualStyleBackColor = true;
            // 
            // checkGeoDataBtn
            // 
            this.checkGeoDataBtn.Location = new System.Drawing.Point(85, 231);
            this.checkGeoDataBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            this.checkGeoDataBtn.Name = "checkGeoDataBtn";
            this.checkGeoDataBtn.Size = new System.Drawing.Size(120, 23);
            this.checkGeoDataBtn.TabIndex = 5;
            this.checkGeoDataBtn.Text = "Check Geo-Data";
            this.checkGeoDataBtn.UseVisualStyleBackColor = true;
            // 
            // customInpLbl
            // 
            this.customInpLbl.AutoSize = true;
            this.customInpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customInpLbl.Location = new System.Drawing.Point(5, 269);
            this.customInpLbl.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.customInpLbl.Name = "customInpLbl";
            this.customInpLbl.Size = new System.Drawing.Size(96, 18);
            this.customInpLbl.TabIndex = 7;
            this.customInpLbl.Text = "Custom Input";
            // 
            // customTagInpBox
            // 
            this.customTagInpBox.Location = new System.Drawing.Point(5, 302);
            this.customTagInpBox.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.customTagInpBox.Name = "customTagInpBox";
            this.customTagInpBox.Size = new System.Drawing.Size(270, 20);
            this.customTagInpBox.TabIndex = 8;
            this.customTagInpBox.Text = "add language tag here...";
            // 
            // addCustomBtn
            // 
            this.addCustomBtn.Location = new System.Drawing.Point(85, 337);
            this.addCustomBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            this.addCustomBtn.Name = "addCustomBtn";
            this.addCustomBtn.Size = new System.Drawing.Size(120, 23);
            this.addCustomBtn.TabIndex = 9;
            this.addCustomBtn.Text = "Add Custom";
            this.addCustomBtn.UseVisualStyleBackColor = true;
            // 
            // addNSetCustBtn
            // 
            this.addNSetCustBtn.Location = new System.Drawing.Point(85, 375);
            this.addNSetCustBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            this.addNSetCustBtn.Name = "addNSetCustBtn";
            this.addNSetCustBtn.Size = new System.Drawing.Size(120, 23);
            this.addNSetCustBtn.TabIndex = 12;
            this.addNSetCustBtn.Text = "Add and Set Custom";
            this.addNSetCustBtn.UseVisualStyleBackColor = true;
            // 
            // removeSimilarBtn
            // 
            this.removeSimilarBtn.Location = new System.Drawing.Point(85, 413);
            this.removeSimilarBtn.Margin = new System.Windows.Forms.Padding(85, 10, 85, 5);
            this.removeSimilarBtn.Name = "removeSimilarBtn";
            this.removeSimilarBtn.Size = new System.Drawing.Size(120, 23);
            this.removeSimilarBtn.TabIndex = 10;
            this.removeSimilarBtn.Text = "Remove Similar";
            this.removeSimilarBtn.UseVisualStyleBackColor = true;
            // 
            // currHelpBtn
            // 
            this.currHelpBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.currHelpBtn.Location = new System.Drawing.Point(190, 461);
            this.currHelpBtn.Margin = new System.Windows.Forms.Padding(0, 20, 25, 5);
            this.currHelpBtn.Name = "currHelpBtn";
            this.currHelpBtn.Size = new System.Drawing.Size(75, 23);
            this.currHelpBtn.TabIndex = 4;
            this.currHelpBtn.Text = "Help!";
            this.currHelpBtn.UseVisualStyleBackColor = true;
            // 
            // newLangListPanel
            // 
            this.newLangListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newLangListPanel.Controls.Add(this.addNewBtn);
            this.newLangListPanel.Controls.Add(this.addnSetNewBtn);
            this.newLangListPanel.Controls.Add(this.helpNewBtn);
            this.newLangListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.newLangListPanel.Location = new System.Drawing.Point(317, 364);
            this.newLangListPanel.Name = "newLangListPanel";
            this.newLangListPanel.Size = new System.Drawing.Size(288, 146);
            this.newLangListPanel.TabIndex = 2;
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(84, 15);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(84, 15, 3, 3);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(120, 23);
            this.addNewBtn.TabIndex = 0;
            this.addNewBtn.Text = "Add New";
            this.addNewBtn.UseVisualStyleBackColor = true;
            // 
            // addnSetNewBtn
            // 
            this.addnSetNewBtn.Location = new System.Drawing.Point(84, 56);
            this.addnSetNewBtn.Margin = new System.Windows.Forms.Padding(84, 15, 3, 3);
            this.addnSetNewBtn.Name = "addnSetNewBtn";
            this.addnSetNewBtn.Size = new System.Drawing.Size(120, 23);
            this.addnSetNewBtn.TabIndex = 1;
            this.addnSetNewBtn.Text = "Add and Set New";
            this.addnSetNewBtn.UseVisualStyleBackColor = true;
            // 
            // helpNewBtn
            // 
            this.helpNewBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.helpNewBtn.Location = new System.Drawing.Point(183, 107);
            this.helpNewBtn.Margin = new System.Windows.Forms.Padding(183, 25, 15, 3);
            this.helpNewBtn.Name = "helpNewBtn";
            this.helpNewBtn.Size = new System.Drawing.Size(80, 23);
            this.helpNewBtn.TabIndex = 2;
            this.helpNewBtn.Text = "Help!";
            this.helpNewBtn.UseVisualStyleBackColor = true;
            // 
            // SysLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 522);
            this.ControlBox = false;
            this.Controls.Add(this.newLangListPanel);
            this.Controls.Add(this.currLangOpPanel);
            this.Controls.Add(this.langTagListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SysLanguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SysLanguage";
            this.currLangOpPanel.ResumeLayout(false);
            this.currLangOpPanel.PerformLayout();
            this.newLangListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox langTagListBox;
        private System.Windows.Forms.FlowLayoutPanel currLangOpPanel;
        private System.Windows.Forms.FlowLayoutPanel newLangListPanel;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.Button addnSetNewBtn;
        private System.Windows.Forms.Button helpNewBtn;
        private System.Windows.Forms.Label currentLangsLbl;
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