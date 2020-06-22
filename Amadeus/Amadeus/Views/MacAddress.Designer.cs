namespace Amadeus.Views
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
            this.macDetailsPnl = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.macVendorsLstBox = new System.Windows.Forms.ListBox();
            this.macVendorsLbl = new System.Windows.Forms.Label();
            this.generatedTxtBox = new System.Windows.Forms.TextBox();
            this.genAddLbl = new System.Windows.Forms.Label();
            this.addVendorBtn = new System.Windows.Forms.Button();
            this.generateAddrBtn = new System.Windows.Forms.Button();
            this.constFullLbl = new System.Windows.Forms.Label();
            this.fullMacTxtBox = new System.Windows.Forms.TextBox();
            this.applyFullAddBtn = new System.Windows.Forms.Button();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.applySelectBtn = new System.Windows.Forms.Button();
            this.removeSelectBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.savedAddysLbl = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.macAddHelpBtn = new System.Windows.Forms.Button();
            this.macDetailsPnl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // macDetailsPnl
            // 
            this.macDetailsPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.macDetailsPnl.Controls.Add(this.button4);
            this.macDetailsPnl.Controls.Add(this.applyFullAddBtn);
            this.macDetailsPnl.Controls.Add(this.saveToFileBtn);
            this.macDetailsPnl.Controls.Add(this.fullMacTxtBox);
            this.macDetailsPnl.Controls.Add(this.constFullLbl);
            this.macDetailsPnl.Controls.Add(this.generateAddrBtn);
            this.macDetailsPnl.Controls.Add(this.addVendorBtn);
            this.macDetailsPnl.Controls.Add(this.genAddLbl);
            this.macDetailsPnl.Controls.Add(this.generatedTxtBox);
            this.macDetailsPnl.Controls.Add(this.macVendorsLbl);
            this.macDetailsPnl.Controls.Add(this.macVendorsLstBox);
            this.macDetailsPnl.Location = new System.Drawing.Point(12, 12);
            this.macDetailsPnl.Name = "macDetailsPnl";
            this.macDetailsPnl.Size = new System.Drawing.Size(434, 491);
            this.macDetailsPnl.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.savedAddysLbl);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.applySelectBtn);
            this.flowLayoutPanel1.Controls.Add(this.removeSelectBtn);
            this.flowLayoutPanel1.Controls.Add(this.macAddHelpBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(461, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(140, 490);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // macVendorsLstBox
            // 
            this.macVendorsLstBox.FormattingEnabled = true;
            this.macVendorsLstBox.Items.AddRange(new object[] {
            "Mac Vendor | Mac Vendor Addy",
            "Mac Vendor | Mac Vendor Addy",
            "Mac Vendor | Mac Vendor Addy",
            "Mac Vendor | Mac Vendor Addy",
            "Mac Vendor | Mac Vendor Addy"});
            this.macVendorsLstBox.Location = new System.Drawing.Point(6, 67);
            this.macVendorsLstBox.Name = "macVendorsLstBox";
            this.macVendorsLstBox.Size = new System.Drawing.Size(350, 147);
            this.macVendorsLstBox.TabIndex = 0;
            // 
            // macVendorsLbl
            // 
            this.macVendorsLbl.AutoSize = true;
            this.macVendorsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macVendorsLbl.Location = new System.Drawing.Point(3, 40);
            this.macVendorsLbl.Name = "macVendorsLbl";
            this.macVendorsLbl.Size = new System.Drawing.Size(100, 18);
            this.macVendorsLbl.TabIndex = 1;
            this.macVendorsLbl.Text = "Mac Vendors:";
            // 
            // generatedTxtBox
            // 
            this.generatedTxtBox.Location = new System.Drawing.Point(6, 349);
            this.generatedTxtBox.Name = "generatedTxtBox";
            this.generatedTxtBox.Size = new System.Drawing.Size(120, 20);
            this.generatedTxtBox.TabIndex = 2;
            // 
            // genAddLbl
            // 
            this.genAddLbl.AutoSize = true;
            this.genAddLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genAddLbl.Location = new System.Drawing.Point(3, 315);
            this.genAddLbl.Name = "genAddLbl";
            this.genAddLbl.Size = new System.Drawing.Size(131, 18);
            this.genAddLbl.TabIndex = 3;
            this.genAddLbl.Text = "Generate Address:";
            // 
            // addVendorBtn
            // 
            this.addVendorBtn.Location = new System.Drawing.Point(6, 237);
            this.addVendorBtn.Name = "addVendorBtn";
            this.addVendorBtn.Size = new System.Drawing.Size(100, 23);
            this.addVendorBtn.TabIndex = 4;
            this.addVendorBtn.Text = "Add Selected";
            this.addVendorBtn.UseVisualStyleBackColor = true;
            // 
            // generateAddrBtn
            // 
            this.generateAddrBtn.Location = new System.Drawing.Point(6, 387);
            this.generateAddrBtn.Name = "generateAddrBtn";
            this.generateAddrBtn.Size = new System.Drawing.Size(100, 23);
            this.generateAddrBtn.TabIndex = 5;
            this.generateAddrBtn.Text = "Generate New";
            this.generateAddrBtn.UseVisualStyleBackColor = true;
            // 
            // constFullLbl
            // 
            this.constFullLbl.AutoSize = true;
            this.constFullLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.constFullLbl.Location = new System.Drawing.Point(233, 315);
            this.constFullLbl.Name = "constFullLbl";
            this.constFullLbl.Size = new System.Drawing.Size(178, 18);
            this.constFullLbl.TabIndex = 6;
            this.constFullLbl.Text = "Constructed Full Address:";
            // 
            // fullMacTxtBox
            // 
            this.fullMacTxtBox.Location = new System.Drawing.Point(236, 349);
            this.fullMacTxtBox.Name = "fullMacTxtBox";
            this.fullMacTxtBox.Size = new System.Drawing.Size(160, 20);
            this.fullMacTxtBox.TabIndex = 7;
            // 
            // applyFullAddBtn
            // 
            this.applyFullAddBtn.Location = new System.Drawing.Point(236, 387);
            this.applyFullAddBtn.Name = "applyFullAddBtn";
            this.applyFullAddBtn.Size = new System.Drawing.Size(120, 23);
            this.applyFullAddBtn.TabIndex = 8;
            this.applyFullAddBtn.Text = "Apply Full Address";
            this.applyFullAddBtn.UseVisualStyleBackColor = true;
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.Location = new System.Drawing.Point(236, 433);
            this.saveToFileBtn.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(70, 23);
            this.saveToFileBtn.TabIndex = 0;
            this.saveToFileBtn.Text = "Save";
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            // 
            // applySelectBtn
            // 
            this.applySelectBtn.Location = new System.Drawing.Point(35, 151);
            this.applySelectBtn.Margin = new System.Windows.Forms.Padding(35, 60, 3, 3);
            this.applySelectBtn.Name = "applySelectBtn";
            this.applySelectBtn.Size = new System.Drawing.Size(70, 23);
            this.applySelectBtn.TabIndex = 1;
            this.applySelectBtn.Text = "Apply";
            this.applySelectBtn.UseVisualStyleBackColor = true;
            // 
            // removeSelectBtn
            // 
            this.removeSelectBtn.Location = new System.Drawing.Point(35, 192);
            this.removeSelectBtn.Margin = new System.Windows.Forms.Padding(35, 15, 3, 3);
            this.removeSelectBtn.Name = "removeSelectBtn";
            this.removeSelectBtn.Size = new System.Drawing.Size(70, 23);
            this.removeSelectBtn.TabIndex = 2;
            this.removeSelectBtn.Text = "Remove";
            this.removeSelectBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 67);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 10, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // savedAddysLbl
            // 
            this.savedAddysLbl.AutoSize = true;
            this.savedAddysLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedAddysLbl.Location = new System.Drawing.Point(5, 40);
            this.savedAddysLbl.Margin = new System.Windows.Forms.Padding(5, 40, 3, 0);
            this.savedAddysLbl.Name = "savedAddysLbl";
            this.savedAddysLbl.Size = new System.Drawing.Size(123, 17);
            this.savedAddysLbl.TabIndex = 4;
            this.savedAddysLbl.Text = "Saved Addresses:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(236, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Generate Random";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // macAddHelpBtn
            // 
            this.macAddHelpBtn.Location = new System.Drawing.Point(80, 233);
            this.macAddHelpBtn.Margin = new System.Windows.Forms.Padding(80, 15, 3, 3);
            this.macAddHelpBtn.Name = "macAddHelpBtn";
            this.macAddHelpBtn.Size = new System.Drawing.Size(40, 23);
            this.macAddHelpBtn.TabIndex = 5;
            this.macAddHelpBtn.Text = "Help!";
            this.macAddHelpBtn.UseVisualStyleBackColor = true;
            // 
            // MacAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 522);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.macDetailsPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MacAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MacAddress";
            this.macDetailsPnl.ResumeLayout(false);
            this.macDetailsPnl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel macDetailsPnl;
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label savedAddysLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button applySelectBtn;
        private System.Windows.Forms.Button removeSelectBtn;
        private System.Windows.Forms.Button macAddHelpBtn;
    }
}