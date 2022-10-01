namespace SingletonPractise
{
    partial class SingletonForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.helloButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(265, 78);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // helloButton
            // 
            this.helloButton.Location = new System.Drawing.Point(74, 129);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(148, 54);
            this.helloButton.TabIndex = 2;
            this.helloButton.Text = "Say Hello";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(74, 218);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(431, 48);
            this.resultLabel.TabIndex = 3;
            // 
            // SingletonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.helloButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SingletonForm";
            this.Text = "Singleton Design Pattern";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingletonForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

