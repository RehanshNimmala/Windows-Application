
namespace NimmalaAssign7
{
    partial class ApplicationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cboFlooringType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantityRequired = new System.Windows.Forms.TextBox();
            this.btnGenerateEstimate = new System.Windows.Forms.Button();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(176, 34);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(121, 22);
            this.txtCustomerName.TabIndex = 1;
            // 
            // cboFlooringType
            // 
            this.cboFlooringType.FormattingEnabled = true;
            this.cboFlooringType.Location = new System.Drawing.Point(176, 96);
            this.cboFlooringType.Name = "cboFlooringType";
            this.cboFlooringType.Size = new System.Drawing.Size(121, 24);
            this.cboFlooringType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Flooring Ttype";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Required Quantity(sq.ft)";
            // 
            // txtQuantityRequired
            // 
            this.txtQuantityRequired.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantityRequired.Location = new System.Drawing.Point(196, 158);
            this.txtQuantityRequired.Name = "txtQuantityRequired";
            this.txtQuantityRequired.Size = new System.Drawing.Size(100, 22);
            this.txtQuantityRequired.TabIndex = 5;
            // 
            // btnGenerateEstimate
            // 
            this.btnGenerateEstimate.Location = new System.Drawing.Point(37, 214);
            this.btnGenerateEstimate.Name = "btnGenerateEstimate";
            this.btnGenerateEstimate.Size = new System.Drawing.Size(259, 60);
            this.btnGenerateEstimate.TabIndex = 6;
            this.btnGenerateEstimate.Text = "Generate Estimate";
            this.btnGenerateEstimate.UseVisualStyleBackColor = true;
            this.btnGenerateEstimate.Click += new System.EventHandler(this.btnGenerateEstimate_Click);
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.Location = new System.Drawing.Point(37, 299);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(259, 50);
            this.btnDisplayReport.TabIndex = 7;
            this.btnDisplayReport.Text = "Display Customer Report";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(37, 379);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(259, 59);
            this.btnFindCustomer.TabIndex = 8;
            this.btnFindCustomer.Text = "Find Customer";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 16;
            this.lstOutput.Location = new System.Drawing.Point(373, 34);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(382, 308);
            this.lstOutput.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(386, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 59);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(609, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 58);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.btnGenerateEstimate);
            this.Controls.Add(this.txtQuantityRequired);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboFlooringType);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "ApplicationForm";
            this.Text = "Midwest Carpet and Flooring";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cboFlooringType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantityRequired;
        private System.Windows.Forms.Button btnGenerateEstimate;
        private System.Windows.Forms.Button btnDisplayReport;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

