namespace TempConverterPractise
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.farenhietRadioButton = new System.Windows.Forms.RadioButton();
            this.celciusRadioButton = new System.Windows.Forms.RadioButton();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(45, 55);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(93, 20);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "Temperature";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperatureTextBox.Location = new System.Drawing.Point(195, 48);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(125, 27);
            this.temperatureTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.farenhietRadioButton);
            this.groupBox1.Controls.Add(this.celciusRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(45, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature";
            // 
            // farenhietRadioButton
            // 
            this.farenhietRadioButton.AutoSize = true;
            this.farenhietRadioButton.Location = new System.Drawing.Point(21, 83);
            this.farenhietRadioButton.Name = "farenhietRadioButton";
            this.farenhietRadioButton.Size = new System.Drawing.Size(90, 24);
            this.farenhietRadioButton.TabIndex = 1;
            this.farenhietRadioButton.TabStop = true;
            this.farenhietRadioButton.Text = "Farenhiet";
            this.farenhietRadioButton.UseVisualStyleBackColor = true;
            // 
            // celciusRadioButton
            // 
            this.celciusRadioButton.AutoSize = true;
            this.celciusRadioButton.Location = new System.Drawing.Point(21, 26);
            this.celciusRadioButton.Name = "celciusRadioButton";
            this.celciusRadioButton.Size = new System.Drawing.Size(76, 24);
            this.celciusRadioButton.TabIndex = 0;
            this.celciusRadioButton.TabStop = true;
            this.celciusRadioButton.Text = "Celcius";
            this.celciusRadioButton.UseVisualStyleBackColor = true;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(45, 266);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(250, 57);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(45, 347);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(243, 55);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(362, 139);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(372, 263);
            this.resultLabel.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(45, 429);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(243, 62);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.temperatureLabel);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label temperatureLabel;
        private TextBox temperatureTextBox;
        private GroupBox groupBox1;
        private RadioButton farenhietRadioButton;
        private RadioButton celciusRadioButton;
        private Button convertButton;
        private Button exitButton;
        private Label resultLabel;
        private Button resetButton;
    }
}