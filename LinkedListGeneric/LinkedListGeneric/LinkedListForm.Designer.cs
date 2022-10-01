namespace LinkedListGeneric
{
    partial class LinkedListForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.integerButton = new System.Windows.Forms.Button();
            this.stringButton = new System.Windows.Forms.Button();
            this.boolButton = new System.Windows.Forms.Button();
            this.mixedTypeButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(69, 373);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 43);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // integerButton
            // 
            this.integerButton.Location = new System.Drawing.Point(69, 40);
            this.integerButton.Name = "integerButton";
            this.integerButton.Size = new System.Drawing.Size(96, 43);
            this.integerButton.TabIndex = 1;
            this.integerButton.Text = "&Integer";
            this.integerButton.UseVisualStyleBackColor = true;
            this.integerButton.Click += new System.EventHandler(this.integerButton_Click);
            // 
            // stringButton
            // 
            this.stringButton.Location = new System.Drawing.Point(69, 118);
            this.stringButton.Name = "stringButton";
            this.stringButton.Size = new System.Drawing.Size(96, 43);
            this.stringButton.TabIndex = 2;
            this.stringButton.Text = "&String";
            this.stringButton.UseVisualStyleBackColor = true;
            this.stringButton.Click += new System.EventHandler(this.stringButton_Click);
            // 
            // boolButton
            // 
            this.boolButton.Location = new System.Drawing.Point(69, 201);
            this.boolButton.Name = "boolButton";
            this.boolButton.Size = new System.Drawing.Size(96, 43);
            this.boolButton.TabIndex = 3;
            this.boolButton.Text = "&Bool";
            this.boolButton.UseVisualStyleBackColor = true;
            this.boolButton.Click += new System.EventHandler(this.boolButton_Click);
            // 
            // mixedTypeButton
            // 
            this.mixedTypeButton.Location = new System.Drawing.Point(69, 280);
            this.mixedTypeButton.Name = "mixedTypeButton";
            this.mixedTypeButton.Size = new System.Drawing.Size(96, 43);
            this.mixedTypeButton.TabIndex = 4;
            this.mixedTypeButton.Text = "&Mixed Type";
            this.mixedTypeButton.UseVisualStyleBackColor = true;
            this.mixedTypeButton.Click += new System.EventHandler(this.mixedTypeButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(271, 107);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(440, 230);
            this.resultLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.mixedTypeButton);
            this.Controls.Add(this.boolButton);
            this.Controls.Add(this.stringButton);
            this.Controls.Add(this.integerButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button integerButton;
        private System.Windows.Forms.Button stringButton;
        private System.Windows.Forms.Button boolButton;
        private System.Windows.Forms.Button mixedTypeButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

