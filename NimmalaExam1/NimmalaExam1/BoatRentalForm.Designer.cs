
namespace NimmalaExam1
{
    partial class BoatRentalForm
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
            this.txtCustomerDrivingLicense = new System.Windows.Forms.TextBox();
            this.txtBoatName = new System.Windows.Forms.TextBox();
            this.dtpRentStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnDisplayRentalReceipt = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstReceipt = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Driving License";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boat Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rent Start Date";
            // 
            // txtCustomerDrivingLicense
            // 
            this.txtCustomerDrivingLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerDrivingLicense.Location = new System.Drawing.Point(275, 47);
            this.txtCustomerDrivingLicense.Name = "txtCustomerDrivingLicense";
            this.txtCustomerDrivingLicense.Size = new System.Drawing.Size(136, 22);
            this.txtCustomerDrivingLicense.TabIndex = 3;
            // 
            // txtBoatName
            // 
            this.txtBoatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoatName.Location = new System.Drawing.Point(275, 89);
            this.txtBoatName.Name = "txtBoatName";
            this.txtBoatName.Size = new System.Drawing.Size(136, 22);
            this.txtBoatName.TabIndex = 4;
            // 
            // dtpRentStartDate
            // 
            this.dtpRentStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRentStartDate.Location = new System.Drawing.Point(211, 125);
            this.dtpRentStartDate.Name = "dtpRentStartDate";
            this.dtpRentStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpRentStartDate.TabIndex = 5;
            this.dtpRentStartDate.Value = new System.DateTime(2022, 2, 27, 0, 0, 0, 0);
            // 
            // btnDisplayRentalReceipt
            // 
            this.btnDisplayRentalReceipt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisplayRentalReceipt.Location = new System.Drawing.Point(545, 45);
            this.btnDisplayRentalReceipt.Name = "btnDisplayRentalReceipt";
            this.btnDisplayRentalReceipt.Size = new System.Drawing.Size(192, 78);
            this.btnDisplayRentalReceipt.TabIndex = 6;
            this.btnDisplayRentalReceipt.Text = "Display Rental Receipt";
            this.btnDisplayRentalReceipt.UseVisualStyleBackColor = true;
            this.btnDisplayRentalReceipt.Click += new System.EventHandler(this.btnDisplayRentalReceipt_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(545, 163);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(192, 72);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(545, 279);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 63);
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
            this.lstReceipt.Location = new System.Drawing.Point(65, 204);
            this.lstReceipt.Name = "lstReceipt";
            this.lstReceipt.Size = new System.Drawing.Size(346, 196);
            this.lstReceipt.TabIndex = 9;
            // 
            // BoatRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstReceipt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDisplayRentalReceipt);
            this.Controls.Add(this.dtpRentStartDate);
            this.Controls.Add(this.txtBoatName);
            this.Controls.Add(this.txtCustomerDrivingLicense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BoatRentalForm";
            this.Text = "Adventure Boat Rentals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerDrivingLicense;
        private System.Windows.Forms.TextBox txtBoatName;
        private System.Windows.Forms.DateTimePicker dtpRentStartDate;
        private System.Windows.Forms.Button btnDisplayRentalReceipt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstReceipt;
    }
}

