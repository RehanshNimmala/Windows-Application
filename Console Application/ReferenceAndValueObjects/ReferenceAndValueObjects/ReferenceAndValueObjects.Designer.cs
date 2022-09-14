namespace ReferenceAndValueObjects
{
    partial class ReferenceAndValueObjects
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
            this.originalValueButton = new System.Windows.Forms.Button();
            this.callClassButton = new System.Windows.Forms.Button();
            this.valuesAfterCallButton = new System.Windows.Forms.Button();
            this.originalLabel = new System.Windows.Forms.Label();
            this.valuesAfterCallLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passing Variables by Values and Objects by Reference";
            // 
            // originalValueButton
            // 
            this.originalValueButton.Location = new System.Drawing.Point(29, 127);
            this.originalValueButton.Name = "originalValueButton";
            this.originalValueButton.Size = new System.Drawing.Size(156, 75);
            this.originalValueButton.TabIndex = 1;
            this.originalValueButton.Text = "Original Value";
            this.originalValueButton.UseVisualStyleBackColor = true;
            this.originalValueButton.Click += new System.EventHandler(this.originalValueButton_Click);
            // 
            // callClassButton
            // 
            this.callClassButton.Location = new System.Drawing.Point(320, 127);
            this.callClassButton.Name = "callClassButton";
            this.callClassButton.Size = new System.Drawing.Size(164, 75);
            this.callClassButton.TabIndex = 2;
            this.callClassButton.Text = "Call Class";
            this.callClassButton.UseVisualStyleBackColor = true;
            this.callClassButton.Click += new System.EventHandler(this.callClassButton_Click);
            // 
            // valuesAfterCallButton
            // 
            this.valuesAfterCallButton.Location = new System.Drawing.Point(545, 127);
            this.valuesAfterCallButton.Name = "valuesAfterCallButton";
            this.valuesAfterCallButton.Size = new System.Drawing.Size(173, 75);
            this.valuesAfterCallButton.TabIndex = 3;
            this.valuesAfterCallButton.Text = "Values after Class call";
            this.valuesAfterCallButton.UseVisualStyleBackColor = true;
            this.valuesAfterCallButton.Click += new System.EventHandler(this.valuesAfterCallButton_Click);
            // 
            // originalLabel
            // 
            this.originalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalLabel.Location = new System.Drawing.Point(29, 245);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(252, 174);
            this.originalLabel.TabIndex = 4;
            // 
            // valuesAfterCallLabel
            // 
            this.valuesAfterCallLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valuesAfterCallLabel.Location = new System.Drawing.Point(417, 245);
            this.valuesAfterCallLabel.Name = "valuesAfterCallLabel";
            this.valuesAfterCallLabel.Size = new System.Drawing.Size(301, 174);
            this.valuesAfterCallLabel.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(29, 455);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 61);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ReferenceAndValueObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.valuesAfterCallLabel);
            this.Controls.Add(this.originalLabel);
            this.Controls.Add(this.valuesAfterCallButton);
            this.Controls.Add(this.callClassButton);
            this.Controls.Add(this.originalValueButton);
            this.Controls.Add(this.label1);
            this.Name = "ReferenceAndValueObjects";
            this.Text = "Reference And Value Objects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button originalValueButton;
        private System.Windows.Forms.Button callClassButton;
        private System.Windows.Forms.Button valuesAfterCallButton;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label valuesAfterCallLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

