
namespace NimmalaAssign1
{
    partial class CompanyContactDetails
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
            this.btnCustomerRelations = new System.Windows.Forms.Button();
            this.btnMarketing = new System.Windows.Forms.Button();
            this.btnOrderProcessing = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerRelations
            // 
            this.btnCustomerRelations.Location = new System.Drawing.Point(28, 55);
            this.btnCustomerRelations.Name = "btnCustomerRelations";
            this.btnCustomerRelations.Size = new System.Drawing.Size(163, 35);
            this.btnCustomerRelations.TabIndex = 0;
            this.btnCustomerRelations.Text = "Customer Relations";
            this.btnCustomerRelations.UseVisualStyleBackColor = true;
            this.btnCustomerRelations.Click += new System.EventHandler(this.btnCustomerRelations_Click);
            // 
            // btnMarketing
            // 
            this.btnMarketing.Location = new System.Drawing.Point(228, 55);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Size = new System.Drawing.Size(131, 35);
            this.btnMarketing.TabIndex = 1;
            this.btnMarketing.Text = "Marketing";
            this.btnMarketing.UseVisualStyleBackColor = true;
            this.btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnOrderProcessing
            // 
            this.btnOrderProcessing.Location = new System.Drawing.Point(403, 55);
            this.btnOrderProcessing.Name = "btnOrderProcessing";
            this.btnOrderProcessing.Size = new System.Drawing.Size(174, 35);
            this.btnOrderProcessing.TabIndex = 2;
            this.btnOrderProcessing.Text = "Order Processing";
            this.btnOrderProcessing.UseVisualStyleBackColor = true;
            this.btnOrderProcessing.Click += new System.EventHandler(this.btnOrderProcessing_Click);
            // 
            // btnShipping
            // 
            this.btnShipping.Location = new System.Drawing.Point(633, 55);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(117, 35);
            this.btnShipping.TabIndex = 3;
            this.btnShipping.Text = "Shipping";
            this.btnShipping.UseVisualStyleBackColor = true;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phone Number";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(390, 131);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(150, 23);
            this.lblDisplay.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(337, 186);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 52);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CompanyContactDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 281);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.btnOrderProcessing);
            this.Controls.Add(this.btnMarketing);
            this.Controls.Add(this.btnCustomerRelations);
            this.Name = "CompanyContactDetails";
            this.Text = "Custom Sporting Goods";
            this.Load += new System.EventHandler(this.CompanyContactDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerRelations;
        private System.Windows.Forms.Button btnMarketing;
        private System.Windows.Forms.Button btnOrderProcessing;
        private System.Windows.Forms.Button btnShipping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnReset;
    }
}

