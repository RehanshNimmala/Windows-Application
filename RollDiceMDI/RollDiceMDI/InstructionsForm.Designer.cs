namespace RollDiceMDI
{
    partial class InstructionsForm
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.closeButtonInstructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(516, 344);
            this.instructionsLabel.TabIndex = 0;
            // 
            // closeButtonInstructions
            // 
            this.closeButtonInstructions.Location = new System.Drawing.Point(453, 356);
            this.closeButtonInstructions.Name = "closeButtonInstructions";
            this.closeButtonInstructions.Size = new System.Drawing.Size(75, 23);
            this.closeButtonInstructions.TabIndex = 1;
            this.closeButtonInstructions.Text = "Close";
            this.closeButtonInstructions.UseVisualStyleBackColor = true;
            this.closeButtonInstructions.Click += new System.EventHandler(this.closeButtonInstructions_Click);
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 388);
            this.Controls.Add(this.closeButtonInstructions);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "InstructionsForm";
            this.Text = "Instructions Form";
            this.Load += new System.EventHandler(this.InstructionsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Button closeButtonInstructions;
    }
}