namespace Amadeus.Views
{
    partial class RDP
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentRdpsPnl = new System.Windows.Forms.Panel();
            this.onlyRdpFilesRdio = new System.Windows.Forms.RadioButton();
            this.savedRdpsLbl = new System.Windows.Forms.Label();
            this.savedRdpsResults = new System.Windows.Forms.ComboBox();
            this.refreshRdpsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.isMstcRunningImgBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentRdpsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isMstcRunningImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(243, 498);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(276, 282);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(328, 228);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // currentRdpsPnl
            // 
            this.currentRdpsPnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentRdpsPnl.Controls.Add(this.label1);
            this.currentRdpsPnl.Controls.Add(this.isMstcRunningImgBox);
            this.currentRdpsPnl.Controls.Add(this.button3);
            this.currentRdpsPnl.Controls.Add(this.button2);
            this.currentRdpsPnl.Controls.Add(this.button1);
            this.currentRdpsPnl.Controls.Add(this.refreshRdpsBtn);
            this.currentRdpsPnl.Controls.Add(this.savedRdpsResults);
            this.currentRdpsPnl.Controls.Add(this.savedRdpsLbl);
            this.currentRdpsPnl.Controls.Add(this.onlyRdpFilesRdio);
            this.currentRdpsPnl.Location = new System.Drawing.Point(276, 12);
            this.currentRdpsPnl.Name = "currentRdpsPnl";
            this.currentRdpsPnl.Size = new System.Drawing.Size(327, 264);
            this.currentRdpsPnl.TabIndex = 3;
            // 
            // onlyRdpFilesRdio
            // 
            this.onlyRdpFilesRdio.AutoSize = true;
            this.onlyRdpFilesRdio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyRdpFilesRdio.Location = new System.Drawing.Point(163, 28);
            this.onlyRdpFilesRdio.Name = "onlyRdpFilesRdio";
            this.onlyRdpFilesRdio.Size = new System.Drawing.Size(125, 21);
            this.onlyRdpFilesRdio.TabIndex = 0;
            this.onlyRdpFilesRdio.TabStop = true;
            this.onlyRdpFilesRdio.Text = "Only .RDP Files";
            this.onlyRdpFilesRdio.UseVisualStyleBackColor = true;
            // 
            // savedRdpsLbl
            // 
            this.savedRdpsLbl.AutoSize = true;
            this.savedRdpsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedRdpsLbl.Location = new System.Drawing.Point(49, 28);
            this.savedRdpsLbl.Name = "savedRdpsLbl";
            this.savedRdpsLbl.Size = new System.Drawing.Size(97, 18);
            this.savedRdpsLbl.TabIndex = 1;
            this.savedRdpsLbl.Text = "Saved RDPs:";
            // 
            // savedRdpsResults
            // 
            this.savedRdpsResults.FormattingEnabled = true;
            this.savedRdpsResults.Location = new System.Drawing.Point(52, 55);
            this.savedRdpsResults.Name = "savedRdpsResults";
            this.savedRdpsResults.Size = new System.Drawing.Size(200, 21);
            this.savedRdpsResults.TabIndex = 2;
            // 
            // refreshRdpsBtn
            // 
            this.refreshRdpsBtn.Location = new System.Drawing.Point(258, 55);
            this.refreshRdpsBtn.Name = "refreshRdpsBtn";
            this.refreshRdpsBtn.Size = new System.Drawing.Size(60, 23);
            this.refreshRdpsBtn.TabIndex = 3;
            this.refreshRdpsBtn.Text = "Refresh";
            this.refreshRdpsBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect To";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // isMstcRunningImgBox
            // 
            this.isMstcRunningImgBox.Location = new System.Drawing.Point(201, 161);
            this.isMstcRunningImgBox.Name = "isMstcRunningImgBox";
            this.isMstcRunningImgBox.Size = new System.Drawing.Size(106, 90);
            this.isMstcRunningImgBox.TabIndex = 7;
            this.isMstcRunningImgBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Currently Connected:";
            // 
            // RDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 522);
            this.ControlBox = false;
            this.Controls.Add(this.currentRdpsPnl);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RDP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Proxy";
            this.currentRdpsPnl.ResumeLayout(false);
            this.currentRdpsPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isMstcRunningImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel currentRdpsPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox isMstcRunningImgBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refreshRdpsBtn;
        private System.Windows.Forms.ComboBox savedRdpsResults;
        private System.Windows.Forms.Label savedRdpsLbl;
        private System.Windows.Forms.RadioButton onlyRdpFilesRdio;
    }
}