namespace NimmalaWeek6
{
    partial class GenericsClass
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
            this.integerButton = new System.Windows.Forms.Button();
            this.doubleButton = new System.Windows.Forms.Button();
            this.stringButton = new System.Windows.Forms.Button();
            this.charButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generics";
            // 
            // integerButton
            // 
            this.integerButton.Location = new System.Drawing.Point(39, 103);
            this.integerButton.Name = "integerButton";
            this.integerButton.Size = new System.Drawing.Size(91, 37);
            this.integerButton.TabIndex = 1;
            this.integerButton.Text = "&Integer";
            this.integerButton.UseVisualStyleBackColor = true;
            this.integerButton.Click += new System.EventHandler(this.integerButton_Click);
            // 
            // doubleButton
            // 
            this.doubleButton.Location = new System.Drawing.Point(191, 103);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(91, 37);
            this.doubleButton.TabIndex = 2;
            this.doubleButton.Text = "&Double";
            this.doubleButton.UseVisualStyleBackColor = true;
            this.doubleButton.Click += new System.EventHandler(this.doubleButton_Click);
            // 
            // stringButton
            // 
            this.stringButton.Location = new System.Drawing.Point(338, 103);
            this.stringButton.Name = "stringButton";
            this.stringButton.Size = new System.Drawing.Size(91, 37);
            this.stringButton.TabIndex = 3;
            this.stringButton.Text = "&String";
            this.stringButton.UseVisualStyleBackColor = true;
            this.stringButton.Click += new System.EventHandler(this.stringButton_Click);
            // 
            // charButton
            // 
            this.charButton.Location = new System.Drawing.Point(485, 103);
            this.charButton.Name = "charButton";
            this.charButton.Size = new System.Drawing.Size(91, 37);
            this.charButton.TabIndex = 4;
            this.charButton.Text = "&Char";
            this.charButton.UseVisualStyleBackColor = true;
            this.charButton.Click += new System.EventHandler(this.charButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(636, 103);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 37);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(63, 173);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(664, 268);
            this.outputLabel.TabIndex = 6;
            // 
            // GenericsClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.charButton);
            this.Controls.Add(this.stringButton);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.integerButton);
            this.Controls.Add(this.label1);
            this.Name = "GenericsClass";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button integerButton;
        private System.Windows.Forms.Button doubleButton;
        private System.Windows.Forms.Button stringButton;
        private System.Windows.Forms.Button charButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

