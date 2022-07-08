
namespace NimmalaAssign2
{
    partial class RoomReservation
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblNumberOfHours = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtNumberOfHours = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lstConfirmation = new System.Windows.Forms.ListBox();
            this.btnCompleteReservation = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayReservationReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(102, 80);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 17);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblNumberOfHours
            // 
            this.lblNumberOfHours.AutoSize = true;
            this.lblNumberOfHours.Location = new System.Drawing.Point(102, 129);
            this.lblNumberOfHours.Name = "lblNumberOfHours";
            this.lblNumberOfHours.Size = new System.Drawing.Size(114, 17);
            this.lblNumberOfHours.TabIndex = 1;
            this.lblNumberOfHours.Text = "Number of hours";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.Location = new System.Drawing.Point(101, 174);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(100, 23);
            this.lblRoomNumber.TabIndex = 2;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(263, 80);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(150, 22);
            this.txtCustomerName.TabIndex = 3;
            // 
            // txtNumberOfHours
            // 
            this.txtNumberOfHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfHours.Location = new System.Drawing.Point(263, 130);
            this.txtNumberOfHours.Name = "txtNumberOfHours";
            this.txtNumberOfHours.Size = new System.Drawing.Size(150, 22);
            this.txtNumberOfHours.TabIndex = 4;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomNumber.Location = new System.Drawing.Point(263, 174);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(150, 22);
            this.txtRoomNumber.TabIndex = 5;
            // 
            // lstConfirmation
            // 
            this.lstConfirmation.FormattingEnabled = true;
            this.lstConfirmation.ItemHeight = 16;
            this.lstConfirmation.Location = new System.Drawing.Point(144, 237);
            this.lstConfirmation.Name = "lstConfirmation";
            this.lstConfirmation.Size = new System.Drawing.Size(299, 148);
            this.lstConfirmation.TabIndex = 6;
            // 
            // btnCompleteReservation
            // 
            this.btnCompleteReservation.Location = new System.Drawing.Point(509, 77);
            this.btnCompleteReservation.Name = "btnCompleteReservation";
            this.btnCompleteReservation.Size = new System.Drawing.Size(195, 25);
            this.btnCompleteReservation.TabIndex = 7;
            this.btnCompleteReservation.Text = "Complete Reservation";
            this.btnCompleteReservation.UseVisualStyleBackColor = true;
            this.btnCompleteReservation.Click += new System.EventHandler(this.btnCompleteReservation_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(509, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(195, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(509, 173);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayReservationReport
            // 
            this.btnDisplayReservationReport.Location = new System.Drawing.Point(509, 221);
            this.btnDisplayReservationReport.Name = "btnDisplayReservationReport";
            this.btnDisplayReservationReport.Size = new System.Drawing.Size(220, 52);
            this.btnDisplayReservationReport.TabIndex = 10;
            this.btnDisplayReservationReport.Text = "Display Reservations Report";
            this.btnDisplayReservationReport.UseVisualStyleBackColor = true;
            this.btnDisplayReservationReport.Click += new System.EventHandler(this.btnDisplayReservationReport_Click);
            // 
            // RoomReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayReservationReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCompleteReservation);
            this.Controls.Add(this.lstConfirmation);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.txtNumberOfHours);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblNumberOfHours);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "RoomReservation";
            this.Text = "Community center Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblNumberOfHours;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtNumberOfHours;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.ListBox lstConfirmation;
        private System.Windows.Forms.Button btnCompleteReservation;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayReservationReport;
    }
}

