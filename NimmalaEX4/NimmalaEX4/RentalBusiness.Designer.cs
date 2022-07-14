
namespace NimmalaEX4
{
    partial class RentalBusiness
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInitialReading = new System.Windows.Forms.TextBox();
            this.txtFinalReading = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnGenerateRentalReceipt = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstReceipt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Reading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of days";
            // 
            // txtInitialReading
            // 
            this.txtInitialReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInitialReading.Location = new System.Drawing.Point(205, 58);
            this.txtInitialReading.Name = "txtInitialReading";
            this.txtInitialReading.Size = new System.Drawing.Size(100, 22);
            this.txtInitialReading.TabIndex = 3;
            // 
            // txtFinalReading
            // 
            this.txtFinalReading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalReading.Location = new System.Drawing.Point(205, 131);
            this.txtFinalReading.Name = "txtFinalReading";
            this.txtFinalReading.Size = new System.Drawing.Size(100, 22);
            this.txtFinalReading.TabIndex = 4;
            // 
            // txtDays
            // 
            this.txtDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDays.Location = new System.Drawing.Point(205, 207);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 22);
            this.txtDays.TabIndex = 5;
            // 
            // btnGenerateRentalReceipt
            // 
            this.btnGenerateRentalReceipt.Location = new System.Drawing.Point(449, 58);
            this.btnGenerateRentalReceipt.Name = "btnGenerateRentalReceipt";
            this.btnGenerateRentalReceipt.Size = new System.Drawing.Size(214, 52);
            this.btnGenerateRentalReceipt.TabIndex = 6;
            this.btnGenerateRentalReceipt.Text = "Generate Rental Receipt";
            this.btnGenerateRentalReceipt.UseVisualStyleBackColor = true;
            this.btnGenerateRentalReceipt.Click += new System.EventHandler(this.btnGenerateRentalReceipt_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(449, 148);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(214, 50);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(449, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(214, 52);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstReceipt
            // 
            this.lstReceipt.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReceipt.FormattingEnabled = true;
            this.lstReceipt.ItemHeight = 16;
            this.lstReceipt.Location = new System.Drawing.Point(116, 266);
            this.lstReceipt.Name = "lstReceipt";
            this.lstReceipt.Size = new System.Drawing.Size(253, 164);
            this.lstReceipt.TabIndex = 9;
            // 
            // RentalBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lstReceipt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerateRentalReceipt);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtFinalReading);
            this.Controls.Add(this.txtInitialReading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentalBusiness";
            this.Text = "Reliable Rentals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInitialReading;
        private System.Windows.Forms.TextBox txtFinalReading;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnGenerateRentalReceipt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstReceipt;
    }
}

