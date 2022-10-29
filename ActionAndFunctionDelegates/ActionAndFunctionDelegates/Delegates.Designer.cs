namespace ActionAndFunctionDelegates
{
    partial class Delegates
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.functionDelegateButton = new System.Windows.Forms.Button();
            this.actionDelegateWithLambdaButton = new System.Windows.Forms.Button();
            this.multicastDelegateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a string";
            // 
            // stringTextBox
            // 
            this.stringTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stringTextBox.Location = new System.Drawing.Point(150, 63);
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(474, 22);
            this.stringTextBox.TabIndex = 2;
            this.stringTextBox.Text = "Enter a text here";
            this.stringTextBox.Enter += new System.EventHandler(this.stringTextBox_Enter);
            this.stringTextBox.Leave += new System.EventHandler(this.stringTextBox_Leave);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(42, 115);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(582, 139);
            this.resultLabel.TabIndex = 3;
            // 
            // functionDelegateButton
            // 
            this.functionDelegateButton.Location = new System.Drawing.Point(42, 292);
            this.functionDelegateButton.Name = "functionDelegateButton";
            this.functionDelegateButton.Size = new System.Drawing.Size(113, 54);
            this.functionDelegateButton.TabIndex = 4;
            this.functionDelegateButton.Text = "Function Delegate";
            this.functionDelegateButton.UseVisualStyleBackColor = true;
            this.functionDelegateButton.Click += new System.EventHandler(this.functionDelegateButton_Click);
            // 
            // actionDelegateWithLambdaButton
            // 
            this.actionDelegateWithLambdaButton.Location = new System.Drawing.Point(205, 292);
            this.actionDelegateWithLambdaButton.Name = "actionDelegateWithLambdaButton";
            this.actionDelegateWithLambdaButton.Size = new System.Drawing.Size(113, 54);
            this.actionDelegateWithLambdaButton.TabIndex = 5;
            this.actionDelegateWithLambdaButton.Text = "Action Delegate with Lambda";
            this.actionDelegateWithLambdaButton.UseVisualStyleBackColor = true;
            this.actionDelegateWithLambdaButton.Click += new System.EventHandler(this.actionDelegateWithLambdaButton_Click);
            // 
            // multicastDelegateButton
            // 
            this.multicastDelegateButton.Location = new System.Drawing.Point(367, 292);
            this.multicastDelegateButton.Name = "multicastDelegateButton";
            this.multicastDelegateButton.Size = new System.Drawing.Size(113, 54);
            this.multicastDelegateButton.TabIndex = 6;
            this.multicastDelegateButton.Text = "Multicast Delegate";
            this.multicastDelegateButton.UseVisualStyleBackColor = true;
            this.multicastDelegateButton.Click += new System.EventHandler(this.multicastDelegateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(511, 292);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 54);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Delegates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.multicastDelegateButton);
            this.Controls.Add(this.actionDelegateWithLambdaButton);
            this.Controls.Add(this.functionDelegateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.stringTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Delegates";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button functionDelegateButton;
        private System.Windows.Forms.Button actionDelegateWithLambdaButton;
        private System.Windows.Forms.Button multicastDelegateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

