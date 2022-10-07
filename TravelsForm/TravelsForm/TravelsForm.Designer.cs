namespace TravelsForm
{
    partial class TravelsForm
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
            this.components = new System.ComponentModel.Container();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classGroupBox = new System.Windows.Forms.GroupBox();
            this.firstClassRadioButton = new System.Windows.Forms.RadioButton();
            this.economyRadioButton = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.travelersTextBox = new System.Windows.Forms.TextBox();
            this.getFareButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.fareLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.classGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Items.AddRange(new object[] {
            "Carribbean Cruise",
            "Alaskan Cruise"});
            this.destinationComboBox.Location = new System.Drawing.Point(341, 69);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(217, 28);
            this.destinationComboBox.TabIndex = 0;
            this.destinationComboBox.SelectedIndexChanged += new System.EventHandler(this.DestinationComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Destination:";
            // 
            // classGroupBox
            // 
            this.classGroupBox.Controls.Add(this.economyRadioButton);
            this.classGroupBox.Controls.Add(this.firstClassRadioButton);
            this.classGroupBox.Location = new System.Drawing.Point(341, 150);
            this.classGroupBox.Name = "classGroupBox";
            this.classGroupBox.Size = new System.Drawing.Size(210, 100);
            this.classGroupBox.TabIndex = 2;
            this.classGroupBox.TabStop = false;
            this.classGroupBox.Text = "Select Class";
            // 
            // firstClassRadioButton
            // 
            this.firstClassRadioButton.AutoSize = true;
            this.firstClassRadioButton.Location = new System.Drawing.Point(38, 26);
            this.firstClassRadioButton.Name = "firstClassRadioButton";
            this.firstClassRadioButton.Size = new System.Drawing.Size(108, 24);
            this.firstClassRadioButton.TabIndex = 0;
            this.firstClassRadioButton.TabStop = true;
            this.firstClassRadioButton.Text = "First Class";
            this.firstClassRadioButton.UseVisualStyleBackColor = true;
            this.firstClassRadioButton.CheckedChanged += new System.EventHandler(this.FirstClassRadioButton_CheckedChanged);
            // 
            // economyRadioButton
            // 
            this.economyRadioButton.AutoSize = true;
            this.economyRadioButton.Location = new System.Drawing.Point(38, 70);
            this.economyRadioButton.Name = "economyRadioButton";
            this.economyRadioButton.Size = new System.Drawing.Size(100, 24);
            this.economyRadioButton.TabIndex = 1;
            this.economyRadioButton.TabStop = true;
            this.economyRadioButton.Text = "Economy";
            this.economyRadioButton.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(179, 277);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 20);
            this.label.TabIndex = 1;
            this.label.Text = "No of Travelers";
            // 
            // travelersTextBox
            // 
            this.travelersTextBox.Location = new System.Drawing.Point(341, 277);
            this.travelersTextBox.Name = "travelersTextBox";
            this.travelersTextBox.Size = new System.Drawing.Size(193, 26);
            this.travelersTextBox.TabIndex = 3;
            // 
            // getFareButton
            // 
            this.getFareButton.Location = new System.Drawing.Point(274, 330);
            this.getFareButton.Name = "getFareButton";
            this.getFareButton.Size = new System.Drawing.Size(87, 35);
            this.getFareButton.TabIndex = 4;
            this.getFareButton.Text = "Get Fare";
            this.getFareButton.UseVisualStyleBackColor = true;
            this.getFareButton.Click += new System.EventHandler(this.getFareButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(418, 330);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 35);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fareLabel
            // 
            this.fareLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fareLabel.Location = new System.Drawing.Point(45, 381);
            this.fareLabel.Name = "fareLabel";
            this.fareLabel.Size = new System.Drawing.Size(724, 99);
            this.fareLabel.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TravelsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.fareLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getFareButton);
            this.Controls.Add(this.travelersTextBox);
            this.Controls.Add(this.classGroupBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinationComboBox);
            this.Name = "TravelsForm";
            this.Text = "Learn to Enjoy Vacationing!!!!";
            this.classGroupBox.ResumeLayout(false);
            this.classGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox classGroupBox;
        private System.Windows.Forms.RadioButton economyRadioButton;
        private System.Windows.Forms.RadioButton firstClassRadioButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox travelersTextBox;
        private System.Windows.Forms.Button getFareButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label fareLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

