
namespace NimmalaAssign5
{
    partial class DepreciationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstStraightLineDisplay = new System.Windows.Forms.ListBox();
            this.btnCalculateDepreciation = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtYearOfPurchase = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDecliningBalanceDisplay = new System.Windows.Forms.ListBox();
            this.btnResetDecliningBalance = new System.Windows.Forms.Button();
            this.btnCalculateDepreciationDecliningBalance = new System.Windows.Forms.Button();
            this.txtDepreciationRate = new System.Windows.Forms.TextBox();
            this.txtPurchasePriceDecliningBalance = new System.Windows.Forms.TextBox();
            this.txtYearOfPurchaseDecliningBalance = new System.Windows.Forms.TextBox();
            this.txtDescriptionDecliningBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstStraightLineDisplay);
            this.groupBox1.Controls.Add(this.btnCalculateDepreciation);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.txtNumberOfYears);
            this.groupBox1.Controls.Add(this.txtPurchasePrice);
            this.groupBox1.Controls.Add(this.txtYearOfPurchase);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Straight Line";
            // 
            // lstStraightLineDisplay
            // 
            this.lstStraightLineDisplay.FormattingEnabled = true;
            this.lstStraightLineDisplay.ItemHeight = 16;
            this.lstStraightLineDisplay.Location = new System.Drawing.Point(357, 41);
            this.lstStraightLineDisplay.Name = "lstStraightLineDisplay";
            this.lstStraightLineDisplay.Size = new System.Drawing.Size(265, 340);
            this.lstStraightLineDisplay.TabIndex = 10;
            // 
            // btnCalculateDepreciation
            // 
            this.btnCalculateDepreciation.Location = new System.Drawing.Point(27, 244);
            this.btnCalculateDepreciation.Name = "btnCalculateDepreciation";
            this.btnCalculateDepreciation.Size = new System.Drawing.Size(257, 57);
            this.btnCalculateDepreciation.TabIndex = 9;
            this.btnCalculateDepreciation.Text = "Calculate Depreciation";
            this.btnCalculateDepreciation.UseVisualStyleBackColor = true;
            this.btnCalculateDepreciation.Click += new System.EventHandler(this.btnCalculateDepreciation_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(27, 323);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(257, 57);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfYears.Location = new System.Drawing.Point(184, 198);
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfYears.TabIndex = 7;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchasePrice.Location = new System.Drawing.Point(184, 144);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(100, 22);
            this.txtPurchasePrice.TabIndex = 6;
            // 
            // txtYearOfPurchase
            // 
            this.txtYearOfPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearOfPurchase.Location = new System.Drawing.Point(184, 100);
            this.txtYearOfPurchase.Name = "txtYearOfPurchase";
            this.txtYearOfPurchase.Size = new System.Drawing.Size(100, 22);
            this.txtYearOfPurchase.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(184, 51);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Number of Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Purchase Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Year of Purchase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description of Item";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDecliningBalanceDisplay);
            this.groupBox2.Controls.Add(this.btnResetDecliningBalance);
            this.groupBox2.Controls.Add(this.btnCalculateDepreciationDecliningBalance);
            this.groupBox2.Controls.Add(this.txtDepreciationRate);
            this.groupBox2.Controls.Add(this.txtPurchasePriceDecliningBalance);
            this.groupBox2.Controls.Add(this.txtYearOfPurchaseDecliningBalance);
            this.groupBox2.Controls.Add(this.txtDescriptionDecliningBalance);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(698, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 397);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Declining Balance";
            // 
            // lstDecliningBalanceDisplay
            // 
            this.lstDecliningBalanceDisplay.FormattingEnabled = true;
            this.lstDecliningBalanceDisplay.ItemHeight = 16;
            this.lstDecliningBalanceDisplay.Location = new System.Drawing.Point(344, 56);
            this.lstDecliningBalanceDisplay.Name = "lstDecliningBalanceDisplay";
            this.lstDecliningBalanceDisplay.Size = new System.Drawing.Size(234, 324);
            this.lstDecliningBalanceDisplay.TabIndex = 11;
            // 
            // btnResetDecliningBalance
            // 
            this.btnResetDecliningBalance.Location = new System.Drawing.Point(39, 323);
            this.btnResetDecliningBalance.Name = "btnResetDecliningBalance";
            this.btnResetDecliningBalance.Size = new System.Drawing.Size(270, 58);
            this.btnResetDecliningBalance.TabIndex = 10;
            this.btnResetDecliningBalance.Text = "Reset";
            this.btnResetDecliningBalance.UseVisualStyleBackColor = true;
            this.btnResetDecliningBalance.Click += new System.EventHandler(this.btnResetDecliningBalance_Click);
            // 
            // btnCalculateDepreciationDecliningBalance
            // 
            this.btnCalculateDepreciationDecliningBalance.Location = new System.Drawing.Point(39, 244);
            this.btnCalculateDepreciationDecliningBalance.Name = "btnCalculateDepreciationDecliningBalance";
            this.btnCalculateDepreciationDecliningBalance.Size = new System.Drawing.Size(270, 57);
            this.btnCalculateDepreciationDecliningBalance.TabIndex = 9;
            this.btnCalculateDepreciationDecliningBalance.Text = "Calculate Depreciation";
            this.btnCalculateDepreciationDecliningBalance.UseVisualStyleBackColor = true;
            this.btnCalculateDepreciationDecliningBalance.Click += new System.EventHandler(this.btnCalculateDepreciationDecliningBalance_Click);
            // 
            // txtDepreciationRate
            // 
            this.txtDepreciationRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepreciationRate.Location = new System.Drawing.Point(196, 198);
            this.txtDepreciationRate.Name = "txtDepreciationRate";
            this.txtDepreciationRate.Size = new System.Drawing.Size(113, 22);
            this.txtDepreciationRate.TabIndex = 8;
            // 
            // txtPurchasePriceDecliningBalance
            // 
            this.txtPurchasePriceDecliningBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurchasePriceDecliningBalance.Location = new System.Drawing.Point(196, 147);
            this.txtPurchasePriceDecliningBalance.Name = "txtPurchasePriceDecliningBalance";
            this.txtPurchasePriceDecliningBalance.Size = new System.Drawing.Size(113, 22);
            this.txtPurchasePriceDecliningBalance.TabIndex = 7;
            // 
            // txtYearOfPurchaseDecliningBalance
            // 
            this.txtYearOfPurchaseDecliningBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearOfPurchaseDecliningBalance.Location = new System.Drawing.Point(196, 104);
            this.txtYearOfPurchaseDecliningBalance.Name = "txtYearOfPurchaseDecliningBalance";
            this.txtYearOfPurchaseDecliningBalance.Size = new System.Drawing.Size(113, 22);
            this.txtYearOfPurchaseDecliningBalance.TabIndex = 6;
            // 
            // txtDescriptionDecliningBalance
            // 
            this.txtDescriptionDecliningBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescriptionDecliningBalance.Location = new System.Drawing.Point(196, 56);
            this.txtDescriptionDecliningBalance.Name = "txtDescriptionDecliningBalance";
            this.txtDescriptionDecliningBalance.Size = new System.Drawing.Size(113, 22);
            this.txtDescriptionDecliningBalance.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Depreciation Rate(%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Purchase Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Year of Purchase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description of Item";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(517, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(332, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DepreciationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 518);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepreciationForm";
            this.Text = "Depreciation Calculation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCalculateDepreciation;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtYearOfPurchase;
        private System.Windows.Forms.ListBox lstStraightLineDisplay;
        private System.Windows.Forms.TextBox txtPurchasePriceDecliningBalance;
        private System.Windows.Forms.TextBox txtYearOfPurchaseDecliningBalance;
        private System.Windows.Forms.TextBox txtDescriptionDecliningBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepreciationRate;
        private System.Windows.Forms.ListBox lstDecliningBalanceDisplay;
        private System.Windows.Forms.Button btnResetDecliningBalance;
        private System.Windows.Forms.Button btnCalculateDepreciationDecliningBalance;
        private System.Windows.Forms.Button btnClose;
    }
}

