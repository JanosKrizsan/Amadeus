namespace Amadeus.Forms
{
    partial class MacAddress
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
            macDetailsPnl = new System.Windows.Forms.Panel();
            generateRndmBtn = new System.Windows.Forms.Button();
            applyFullAddBtn = new System.Windows.Forms.Button();
            saveToFileBtn = new System.Windows.Forms.Button();
            fullMacTxtBox = new System.Windows.Forms.TextBox();
            constFullLbl = new System.Windows.Forms.Label();
            generateAddrBtn = new System.Windows.Forms.Button();
            addVendorBtn = new System.Windows.Forms.Button();
            genAddLbl = new System.Windows.Forms.Label();
            generatedTxtBox = new System.Windows.Forms.TextBox();
            macVendorsLbl = new System.Windows.Forms.Label();
            macVendorsLstBox = new System.Windows.Forms.ListBox();
            savedAddrsPnl = new System.Windows.Forms.FlowLayoutPanel();
            savedAddysLbl = new System.Windows.Forms.Label();
            savedMacsCmboBox = new System.Windows.Forms.ComboBox();
            applySelectBtn = new System.Windows.Forms.Button();
            removeSelectBtn = new System.Windows.Forms.Button();
            macAddHelpBtn = new System.Windows.Forms.Button();
            macDetailsPnl.SuspendLayout();
            savedAddrsPnl.SuspendLayout();
            SuspendLayout();

            InitmacDetailsPnl();
            InitgenerateRndmBtn();
            InitapplyFullAddBtn();
            InitsaveToFileBtn();
            InitfullMacTxtBox();
            InitconstFullLbl();
            InitgenerateAddrBtn();
            InitaddVendorBtn();
            InitgenAddLbl();
            InitgeneratedTxtBox();
            InitmacVendorsLbl();
            InitmacVendorsLstBox();
            InitsavedAddrsPnl();
            InitsavedAddysLbl();
            InitsavedMacsCmboBox();
            InitapplySelectBtn();
            InitremoveSelectBtn();
            InitmacAddHelpBtn();
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

        private void InitmacAddHelpBtn()
        {
            macAddHelpBtn.Location = new System.Drawing.Point(80, 233);
            macAddHelpBtn.Margin = new System.Windows.Forms.Padding(80, 15, 3, 3);
            macAddHelpBtn.Name = "macAddHelpBtn";
            macAddHelpBtn.Size = new System.Drawing.Size(40, 23);
            macAddHelpBtn.TabIndex = 5;
            macAddHelpBtn.Text = "Help!";
            macAddHelpBtn.UseVisualStyleBackColor = true;
        }

        private void InitremoveSelectBtn()
        {
            removeSelectBtn.Location = new System.Drawing.Point(35, 192);
            removeSelectBtn.Margin = new System.Windows.Forms.Padding(35, 15, 3, 3);
            removeSelectBtn.Name = "removeSelectBtn";
            removeSelectBtn.Size = new System.Drawing.Size(70, 23);
            removeSelectBtn.TabIndex = 2;
            removeSelectBtn.Text = "Remove";
            removeSelectBtn.UseVisualStyleBackColor = true;
        }

        private void InitapplySelectBtn()
        {
            applySelectBtn.Location = new System.Drawing.Point(35, 151);
            applySelectBtn.Margin = new System.Windows.Forms.Padding(35, 60, 3, 3);
            applySelectBtn.Name = "applySelectBtn";
            applySelectBtn.Size = new System.Drawing.Size(70, 23);
            applySelectBtn.TabIndex = 1;
            applySelectBtn.Text = "Apply";
            applySelectBtn.UseVisualStyleBackColor = true;
        }

        private void InitsavedMacsCmboBox()
        {
            savedMacsCmboBox.FormattingEnabled = true;
            savedMacsCmboBox.Location = new System.Drawing.Point(5, 67);
            savedMacsCmboBox.Margin = new System.Windows.Forms.Padding(5, 10, 3, 3);
            savedMacsCmboBox.Name = "savedMacsCmboBox";
            savedMacsCmboBox.Size = new System.Drawing.Size(121, 21);
            savedMacsCmboBox.TabIndex = 3;
        }

        private void InitsavedAddysLbl()
        {
            savedAddysLbl.AutoSize = true;
            savedAddysLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            savedAddysLbl.Location = new System.Drawing.Point(5, 40);
            savedAddysLbl.Margin = new System.Windows.Forms.Padding(5, 40, 3, 0);
            savedAddysLbl.Name = "savedAddysLbl";
            savedAddysLbl.Size = new System.Drawing.Size(123, 17);
            savedAddysLbl.TabIndex = 4;
            savedAddysLbl.Text = "Saved Addresses:";
        }

        private void InitsavedAddrsPnl()
        {
            savedAddrsPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            savedAddrsPnl.Controls.Add(savedAddysLbl);
            savedAddrsPnl.Controls.Add(savedMacsCmboBox);
            savedAddrsPnl.Controls.Add(applySelectBtn);
            savedAddrsPnl.Controls.Add(removeSelectBtn);
            savedAddrsPnl.Controls.Add(macAddHelpBtn);
            savedAddrsPnl.Location = new System.Drawing.Point(461, 12);
            savedAddrsPnl.Name = "savedAddrsPnl";
            savedAddrsPnl.Size = new System.Drawing.Size(140, 490);
            savedAddrsPnl.TabIndex = 1;
        }

        private void InitmacVendorsLstBox()
        {
            macVendorsLstBox.FormattingEnabled = true;
            macVendorsLstBox.Location = new System.Drawing.Point(6, 67);
            macVendorsLstBox.Name = "macVendorsLstBox";
            macVendorsLstBox.Size = new System.Drawing.Size(350, 147);
            macVendorsLstBox.TabIndex = 0;
        }

        private void InitmacVendorsLbl()
        {
            macVendorsLbl.AutoSize = true;
            macVendorsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            macVendorsLbl.Location = new System.Drawing.Point(3, 40);
            macVendorsLbl.Name = "macVendorsLbl";
            macVendorsLbl.Size = new System.Drawing.Size(100, 18);
            macVendorsLbl.TabIndex = 1;
            macVendorsLbl.Text = "Mac Vendors:";
        }

        private void InitgeneratedTxtBox()
        {
            generatedTxtBox.Location = new System.Drawing.Point(6, 349);
            generatedTxtBox.Name = "generatedTxtBox";
            generatedTxtBox.Size = new System.Drawing.Size(120, 20);
            generatedTxtBox.TabIndex = 2;
        }

        private void InitgenAddLbl()
        {
            genAddLbl.AutoSize = true;
            genAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genAddLbl.Location = new System.Drawing.Point(3, 315);
            genAddLbl.Name = "genAddLbl";
            genAddLbl.Size = new System.Drawing.Size(131, 18);
            genAddLbl.TabIndex = 3;
            genAddLbl.Text = "Generate Address:";
        }

        private void InitaddVendorBtn()
        {
            addVendorBtn.Location = new System.Drawing.Point(6, 237);
            addVendorBtn.Name = "addVendorBtn";
            addVendorBtn.Size = new System.Drawing.Size(100, 23);
            addVendorBtn.TabIndex = 4;
            addVendorBtn.Text = "Add Selected";
            addVendorBtn.UseVisualStyleBackColor = true;
        }

        private void InitgenerateAddrBtn()
        {
            generateAddrBtn.Location = new System.Drawing.Point(6, 387);
            generateAddrBtn.Name = "generateAddrBtn";
            generateAddrBtn.Size = new System.Drawing.Size(100, 23);
            generateAddrBtn.TabIndex = 5;
            generateAddrBtn.Text = "Generate New";
            generateAddrBtn.UseVisualStyleBackColor = true;
        }

        private void InitconstFullLbl()
        {
            constFullLbl.AutoSize = true;
            constFullLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            constFullLbl.Location = new System.Drawing.Point(233, 315);
            constFullLbl.Name = "constFullLbl";
            constFullLbl.Size = new System.Drawing.Size(178, 18);
            constFullLbl.TabIndex = 6;
            constFullLbl.Text = "Constructed Full Address:";
        }

        private void InitfullMacTxtBox()
        {
            fullMacTxtBox.Location = new System.Drawing.Point(236, 349);
            fullMacTxtBox.Name = "fullMacTxtBox";
            fullMacTxtBox.Size = new System.Drawing.Size(160, 20);
            fullMacTxtBox.TabIndex = 7;
        }

        private void InitsaveToFileBtn()
        {
            saveToFileBtn.Location = new System.Drawing.Point(236, 433);
            saveToFileBtn.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            saveToFileBtn.Name = "saveToFileBtn";
            saveToFileBtn.Size = new System.Drawing.Size(70, 23);
            saveToFileBtn.TabIndex = 0;
            saveToFileBtn.Text = "Save";
            saveToFileBtn.UseVisualStyleBackColor = true;
        }

        private void InitapplyFullAddBtn()
        {
            applyFullAddBtn.Location = new System.Drawing.Point(236, 387);
            applyFullAddBtn.Name = "applyFullAddBtn";
            applyFullAddBtn.Size = new System.Drawing.Size(120, 23);
            applyFullAddBtn.TabIndex = 8;
            applyFullAddBtn.Text = "Apply Full Address";
            applyFullAddBtn.UseVisualStyleBackColor = true;
        }

        private void InitgenerateRndmBtn()
        {
            generateRndmBtn.Location = new System.Drawing.Point(236, 237);
            generateRndmBtn.Name = "generateRndmBtn";
            generateRndmBtn.Size = new System.Drawing.Size(120, 23);
            generateRndmBtn.TabIndex = 9;
            generateRndmBtn.Text = "Generate Random";
            generateRndmBtn.UseVisualStyleBackColor = true;
        }

        private void InitmacDetailsPnl()
        {
            macDetailsPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            macDetailsPnl.Controls.Add(generateRndmBtn);
            macDetailsPnl.Controls.Add(applyFullAddBtn);
            macDetailsPnl.Controls.Add(saveToFileBtn);
            macDetailsPnl.Controls.Add(fullMacTxtBox);
            macDetailsPnl.Controls.Add(constFullLbl);
            macDetailsPnl.Controls.Add(generateAddrBtn);
            macDetailsPnl.Controls.Add(addVendorBtn);
            macDetailsPnl.Controls.Add(genAddLbl);
            macDetailsPnl.Controls.Add(generatedTxtBox);
            macDetailsPnl.Controls.Add(macVendorsLbl);
            macDetailsPnl.Controls.Add(macVendorsLstBox);
            macDetailsPnl.Location = new System.Drawing.Point(12, 12);
            macDetailsPnl.Name = "macDetailsPnl";
            macDetailsPnl.Size = new System.Drawing.Size(434, 491);
            macDetailsPnl.TabIndex = 0;
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