
namespace NimmalaAssign6
{
    partial class CloudSoftwareForm
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
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.cboApplicationType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumberOfUsers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStorageUsed = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbStoredOnpremise = new System.Windows.Forms.RadioButton();
            this.rdbStoredCloud = new System.Windows.Forms.RadioButton();
            this.chkNonForProfit = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnDisplayInvoice = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Name";
            // 
            // txtClientName
            // 
            this.txtClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientName.Location = new System.Drawing.Point(124, 38);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(167, 22);
            this.txtClientName.TabIndex = 1;
            // 
            // cboApplicationType
            // 
            this.cboApplicationType.FormattingEnabled = true;
            this.cboApplicationType.Items.AddRange(new object[] {
            "Sales Management",
            "Cloud Project",
            "Payroll Solutions",
            "Easy Meeting"});
            this.cboApplicationType.Location = new System.Drawing.Point(42, 95);
            this.cboApplicationType.Name = "cboApplicationType";
            this.cboApplicationType.Size = new System.Drawing.Size(242, 24);
            this.cboApplicationType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose the desired type of Application";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Users";
            // 
            // txtNumberOfUsers
            // 
            this.txtNumberOfUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberOfUsers.Location = new System.Drawing.Point(157, 147);
            this.txtNumberOfUsers.Name = "txtNumberOfUsers";
            this.txtNumberOfUsers.Size = new System.Drawing.Size(134, 22);
            this.txtNumberOfUsers.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount of Storage used(GB)";
            // 
            // txtStorageUsed
            // 
            this.txtStorageUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStorageUsed.Location = new System.Drawing.Point(226, 191);
            this.txtStorageUsed.Name = "txtStorageUsed";
            this.txtStorageUsed.Size = new System.Drawing.Size(65, 22);
            this.txtStorageUsed.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbStoredOnpremise);
            this.groupBox1.Controls.Add(this.rdbStoredCloud);
            this.groupBox1.Location = new System.Drawing.Point(42, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data storage location";
            // 
            // rdbStoredOnpremise
            // 
            this.rdbStoredOnpremise.AutoSize = true;
            this.rdbStoredOnpremise.Location = new System.Drawing.Point(32, 73);
            this.rdbStoredOnpremise.Name = "rdbStoredOnpremise";
            this.rdbStoredOnpremise.Size = new System.Drawing.Size(178, 21);
            this.rdbStoredOnpremise.TabIndex = 1;
            this.rdbStoredOnpremise.TabStop = true;
            this.rdbStoredOnpremise.Text = "Data stored on-premise";
            this.rdbStoredOnpremise.UseVisualStyleBackColor = true;
            // 
            // rdbStoredCloud
            // 
            this.rdbStoredCloud.AutoSize = true;
            this.rdbStoredCloud.Location = new System.Drawing.Point(32, 31);
            this.rdbStoredCloud.Name = "rdbStoredCloud";
            this.rdbStoredCloud.Size = new System.Drawing.Size(158, 21);
            this.rdbStoredCloud.TabIndex = 0;
            this.rdbStoredCloud.TabStop = true;
            this.rdbStoredCloud.Text = "Data stored in Cloud";
            this.rdbStoredCloud.UseVisualStyleBackColor = true;
            // 
            // chkNonForProfit
            // 
            this.chkNonForProfit.AutoSize = true;
            this.chkNonForProfit.Location = new System.Drawing.Point(84, 390);
            this.chkNonForProfit.Name = "chkNonForProfit";
            this.chkNonForProfit.Size = new System.Drawing.Size(207, 21);
            this.chkNonForProfit.TabIndex = 9;
            this.chkNonForProfit.Text = "Non-for-profit Organizations";
            this.chkNonForProfit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status of the Organization";
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 16;
            this.lstDisplay.Location = new System.Drawing.Point(343, 38);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(428, 292);
            this.lstDisplay.TabIndex = 11;
            // 
            // btnDisplayInvoice
            // 
            this.btnDisplayInvoice.Location = new System.Drawing.Point(343, 370);
            this.btnDisplayInvoice.Name = "btnDisplayInvoice";
            this.btnDisplayInvoice.Size = new System.Drawing.Size(136, 68);
            this.btnDisplayInvoice.TabIndex = 12;
            this.btnDisplayInvoice.Text = "Display Invoice";
            this.btnDisplayInvoice.UseVisualStyleBackColor = true;
            this.btnDisplayInvoice.Click += new System.EventHandler(this.btnDisplayInvoice_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(507, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 68);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(644, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 69);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CloudSoftwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplayInvoice);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkNonForProfit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStorageUsed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumberOfUsers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboApplicationType);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.label1);
            this.Name = "CloudSoftwareForm";
            this.Text = "Cloud Software";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.ComboBox cboApplicationType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumberOfUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStorageUsed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbStoredOnpremise;
        private System.Windows.Forms.RadioButton rdbStoredCloud;
        private System.Windows.Forms.CheckBox chkNonForProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnDisplayInvoice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

