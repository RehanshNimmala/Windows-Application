namespace VehicleForm
{
    partial class VehicleForm
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
            this.sedanButton = new System.Windows.Forms.Button();
            this.raceCarButton = new System.Windows.Forms.Button();
            this.motorCycleButton = new System.Windows.Forms.Button();
            this.truckButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sedanButton
            // 
            this.sedanButton.Location = new System.Drawing.Point(41, 43);
            this.sedanButton.Name = "sedanButton";
            this.sedanButton.Size = new System.Drawing.Size(126, 53);
            this.sedanButton.TabIndex = 0;
            this.sedanButton.Text = "Sedan";
            this.sedanButton.UseVisualStyleBackColor = true;
            this.sedanButton.Click += new System.EventHandler(this.sedanButton_Click);
            // 
            // raceCarButton
            // 
            this.raceCarButton.Location = new System.Drawing.Point(41, 130);
            this.raceCarButton.Name = "raceCarButton";
            this.raceCarButton.Size = new System.Drawing.Size(126, 53);
            this.raceCarButton.TabIndex = 1;
            this.raceCarButton.Text = "Race Car";
            this.raceCarButton.UseVisualStyleBackColor = true;
            this.raceCarButton.Click += new System.EventHandler(this.raceCarButton_Click);
            // 
            // motorCycleButton
            // 
            this.motorCycleButton.Location = new System.Drawing.Point(41, 225);
            this.motorCycleButton.Name = "motorCycleButton";
            this.motorCycleButton.Size = new System.Drawing.Size(126, 53);
            this.motorCycleButton.TabIndex = 2;
            this.motorCycleButton.Text = "Motor Cycle";
            this.motorCycleButton.UseVisualStyleBackColor = true;
            this.motorCycleButton.Click += new System.EventHandler(this.motorCycleButton_Click);
            // 
            // truckButton
            // 
            this.truckButton.Location = new System.Drawing.Point(41, 310);
            this.truckButton.Name = "truckButton";
            this.truckButton.Size = new System.Drawing.Size(126, 53);
            this.truckButton.TabIndex = 3;
            this.truckButton.Text = "Truck";
            this.truckButton.UseVisualStyleBackColor = true;
            this.truckButton.Click += new System.EventHandler(this.truckButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(41, 406);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 53);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.resultTextBox.Location = new System.Drawing.Point(286, 43);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(845, 416);
            this.resultTextBox.TabIndex = 5;
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 494);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.truckButton);
            this.Controls.Add(this.motorCycleButton);
            this.Controls.Add(this.raceCarButton);
            this.Controls.Add(this.sedanButton);
            this.Name = "VehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Automobiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sedanButton;
        private System.Windows.Forms.Button raceCarButton;
        private System.Windows.Forms.Button motorCycleButton;
        private System.Windows.Forms.Button truckButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

